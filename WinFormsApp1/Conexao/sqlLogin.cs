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

        //INSERT INTO[dbo].[usuario]
        //([nome]
        //   ,[rg]
        //   ,[cpf]
        //   ,[data_nascimento]
        //   ,[email]
        //   ,[endereco]
        //   ,[telefone]
        //   ,[loginUsuario]
        //   ,[senha]
        //   ,[perfil])


        public int? ValidarLogin(string loginUsuario, string pass) {

            var banco = new BancoSqlServer();

            // Exemplo: Consultar usuários
            string querySelect = $"select * from usuario where loginUsuario = '{loginUsuario}' and senha = '{pass}'";
            using (var leitor = banco.ExecutarConsulta(querySelect))
            {
                while (leitor != null && leitor.Read())
                {
                    MessageBox.Show($"Bem vindo! {leitor["nome"]}");
                    return (int)leitor["perfil"];
                }
                return null;
            }

        }
    }
}
