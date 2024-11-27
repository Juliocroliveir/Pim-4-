using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.Conexao
{
    public class sqlLogin
    {

        public bool ValidarLogin(string email, string pass) {

            var banco = new BancoSqlServer();

            // Exemplo: Consultar usuários
            string querySelect = "select * from dbo.Usuarios where Email = '" + email + "' and Senha = '" + pass + "'";
            using (var leitor = banco.ExecutarConsulta(querySelect))
            {
                while (leitor != null && leitor.Read())
                {
                    MessageBox.Show($"Bem vindo! {leitor["Nome"]}");
                    return true;

                }
                return false;
            }

        }
    }
}
