using Microsoft.Data.SqlClient;
using System.Windows.Forms;

namespace WinFormsApp1.Conexao
{
    public class BancoSqlServer
    {
        private readonly SqlConnectionStringBuilder builder;
        private SqlConnection? conexao;

        public bool Conectado => conexao?.State == System.Data.ConnectionState.Open;

        public BancoSqlServer()
        {
            builder = new SqlConnectionStringBuilder
            {
                DataSource = "DESKTOP-4KFQHVM\\SQLEXPRESS", // Nome do servidor "DESKTOP-4KFQHVM\\SQLEXPRESS"
                InitialCatalog = "dbFazendaUrbana",        // Nome do banco de dados
                TrustServerCertificate = true,
                IntegratedSecurity = true                  // Usando autenticação do Windows
            };
        }

        /// <summary>
        /// Abre a conexão com o banco de dados.
        /// </summary>
        public void Conectar()
        {
            try
            {
                if (conexao == null)
                    conexao = new SqlConnection(builder.ConnectionString);

                if (conexao.State == System.Data.ConnectionState.Closed)
                    conexao.Open();
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Erro SQL: {ex.Message}", "Erro na Conexão", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro desconhecido: {ex.Message}", "Erro na Conexão", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Fecha a conexão com o banco de dados.
        /// </summary>
        public void Desconectar()
        {
            try
            {
                if (conexao != null && conexao.State == System.Data.ConnectionState.Open)
                    conexao.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao fechar a conexão: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Executa um comando SQL não query (INSERT, UPDATE, DELETE).
        /// </summary>
        /// <param name="query">Comando SQL</param>
        /// <returns>Número de linhas afetadas</returns>
        public int ExecutarComando(string query)
        {
            try
            {
                Conectar();

                using (var comando = new SqlCommand(query, conexao))
                {
                    return comando.ExecuteNonQuery();
                }
            }
            catch (SqlException ex)
            {
                //MessageBox.Show($"Erro SQL: {ex.Message}", "Erro no Comando", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1;
            }
            finally
            {
                Desconectar();
            }
        }

        /// <summary>
        /// Executa um comando SQL de consulta (SELECT).
        /// </summary>
        /// <param name="query">Comando SQL</param>
        /// <returns>SqlDataReader contendo os resultados</returns>
        public SqlDataReader? ExecutarConsulta(string query)
        {
            try
            {
                Conectar();

                var comando = new SqlCommand(query, conexao);
                return comando.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Erro SQL: {ex.Message}", "Erro na Consulta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
    }
}
