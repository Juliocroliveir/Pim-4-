using Microsoft.Data.SqlClient;
using System.Windows.Forms;

namespace WinFormsApp1.Conexao
{
    class BancoSqlServer
    {
        private SqlConnectionStringBuilder builder;
        public bool Conectado { get; private set; }

        public BancoSqlServer()
        {
            Conectado = false;

            builder = new SqlConnectionStringBuilder
            {
                DataSource = "DESKTOP-4KFQHVM\\SQLEXPRESS",
                InitialCatalog = "dbFazendaUrbana",
                TrustServerCertificate = true,
                IntegratedSecurity = true // Usando autenticação do Windows
            };


            try
            {
                using (var conexao = new SqlConnection(builder.ConnectionString))
                {
                    conexao.Open();
                    Conectado = true;
                }
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
    }
}
