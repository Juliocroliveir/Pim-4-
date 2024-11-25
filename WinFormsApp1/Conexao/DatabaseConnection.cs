using System;
using System.Data;
using System.Data.SqlClient;

namespace WinFormsApp1.Conexao
{
    public class DatabaseConnection
    {
        // String de conexão com o banco de dados
        private string connectionString;

        // Construtor para inicializar a string de conexão
        public DatabaseConnection()
        {
            // Altere os parâmetros conforme necessário
            connectionString = "Server=SEU_SERVIDOR;Database=SEU_BANCO;User Id=SEU_USUARIO;Password=SUA_SENHA;";
        }

        // Método para abrir uma conexão
        public SqlConnection OpenConnection()
        {
            SqlConnection connection = new SqlConnection(connectionString);
            try
            {
                connection.Open();
                return connection;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao abrir conexão: {ex.Message}");
                throw;
            }
        }

        // Método para fechar uma conexão
        public void CloseConnection(SqlConnection connection)
        {
            if (connection != null && connection.State == ConnectionState.Open)
            {
                connection.Close();
            }
        }

        // Método para executar comandos no banco de dados
        public int ExecuteCommand(string query, SqlParameter[] parameters = null)
        {
            using (SqlConnection connection = OpenConnection())
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    if (parameters != null)
                    {
                        command.Parameters.AddRange(parameters);
                    }
                    try
                    {
                        return command.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Erro ao executar comando: {ex.Message}");
                        throw;
                    }
                }
            }
        }

        // Método para obter dados do banco
        public DataTable GetDataTable(string query, SqlParameter[] parameters = null)
        {
            using (SqlConnection connection = OpenConnection())
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    if (parameters != null)
                    {
                        command.Parameters.AddRange(parameters);
                    }
                    try
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        return dataTable;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Erro ao obter dados: {ex.Message}");
                        throw;
                    }
                }
            }
        }
    }
}
