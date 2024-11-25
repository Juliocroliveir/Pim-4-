using System.Windows.Forms;
using WinFormsApp1.Conexao;

namespace WinFormsApp1.Conexao
{
    internal class TesteConexao
    {
        public void Testar()
        {
            var banco = new BancoSqlServer();

            if (banco.Conectado)
            {
                MessageBox.Show("Conexão bem-sucedida!", "Teste de Conexão", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Falha ao conectar ao banco de dados.\nVerifique a configuração da conexão.", "Teste de Conexão", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
