﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp1.Objetos;

namespace WinFormsApp1.Conexao
{
    public class sqlUsuarios
    {
        public int CadastrarUsuario(UsuarioCadastro recUsu)
        {
            UsuarioCadastro uCadas = new UsuarioCadastro();
            uCadas = recUsu;

            BancoSqlServer banco = new BancoSqlServer();

            // Exemplo: Inserir um novo usuário
            string queryInsert = $@"INSERT INTO usuario (Nome,rg,cpf,data_nascimento,email,Endereco,Telefone,loginUsuario,senha,perfil) 
            VALUES('{uCadas.Nome}','{uCadas.RG}','{uCadas.CPF}','{uCadas.DataNascimento}','{uCadas.Email}','{uCadas.Endereco}','{uCadas.Telefone}','{uCadas.Usuario}', '{uCadas.Senha}', '0') ";

            int linhasAfetadas = banco.ExecutarComando(queryInsert);
            //MessageBox.Show($"Linhas afetadas: {linhasAfetadas}");

            return linhasAfetadas;
        }
        public int CadastrarFuncionario(UsuarioCadastro recUsu)
        {
            UsuarioCadastro uCadas = new UsuarioCadastro();
            uCadas = recUsu;

            BancoSqlServer banco = new BancoSqlServer();

            // Exemplo: Inserir um novo usuário
            string queryInsert = $@"INSERT INTO usuario (Nome,rg,cpf,data_nascimento,email,Endereco,Telefone,loginUsuario,senha,perfil) 
            VALUES('{uCadas.Nome}','{uCadas.RG}','{uCadas.CPF}','{uCadas.DataNascimento}','{uCadas.Email}','{uCadas.Endereco}','{uCadas.Telefone}','{uCadas.Usuario}', '{uCadas.Senha}', '1') ";

            int linhasAfetadas = banco.ExecutarComando(queryInsert);
            //MessageBox.Show($"Linhas afetadas: {linhasAfetadas}");

            return linhasAfetadas;
        }
        public int AtualizarUsuario(UsuarioCadastro recUsu)
        {
            UsuarioCadastro uCadas = new UsuarioCadastro();
            uCadas = recUsu;

            BancoSqlServer banco = new BancoSqlServer();

            // Exemplo: Inserir um novo usuário
            string queryUpdate = $@"UPDATE usuario
            SET [Nome] = '{uCadas.Nome}',[RG] = '{uCadas.RG}',[CPF] = '{uCadas.CPF}',[DataNascimento] = '{uCadas.DataNascimento}',[Endereco] = '{uCadas.Endereco}',[Telefone] = '{uCadas.Telefone}'
            WHERE [Email] = '{uCadas.Email}'";

            int linhasAfetadas = banco.ExecutarComando(queryUpdate);
            //MessageBox.Show($"Linhas afetadas: {linhasAfetadas}");

            return linhasAfetadas;
        }



        public bool ValidarLogin(string email, string pass)
        {

            var banco = new BancoSqlServer();

            // Exemplo: Consultar usuários
            string querySelect = "select * from dbo.usuarios where Email = '" + email + "' and Senha = '" + pass + "'";
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