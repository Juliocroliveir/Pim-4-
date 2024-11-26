using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp1.Objetos;

namespace WinFormsApp1.Conexao
{
    public class Usuarios
    {
        public int CadastrarUsuario(UsuarioCadastro recUsu)
        {
            UsuarioCadastro uCadas = new UsuarioCadastro();
            uCadas = recUsu;

            BancoSqlServer banco = new BancoSqlServer();

            // Exemplo: Inserir um novo usuário
            string queryInsert = $@"INSERT INTO dbo.Usuarios (Email,Senha,Nome,RG,CPF,DataNascimento,Endereco,Telefone) 
            VALUES('{uCadas.Email}','{uCadas.Senha}','{uCadas.Nome }','{uCadas.RG}','{uCadas.CPF }','{uCadas.DataNascimento}','{uCadas.Endereco}','{uCadas.Telefone}') ";

            int linhasAfetadas = banco.ExecutarComando(queryInsert);
            //MessageBox.Show($"Linhas afetadas: {linhasAfetadas}");

            return linhasAfetadas;
        }



        public bool ValidarLogin(string email, string pass)
        {

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