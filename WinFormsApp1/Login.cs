﻿using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp1.Conexao;

namespace WinFormsApp1
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            CadastroCliente form3 = new CadastroCliente();

            form3.ShowDialog();
            this.Visible = true;
        }



        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox2.Text.IsNullOrEmpty())
                erroEmail.Visible = true;

            if (textBox1.Text.IsNullOrEmpty())
                erroSenha.Visible = true;


            if (erroEmail.Visible || erroSenha.Visible)
                erroMensagem.Visible = true;

            if (!textBox2.Text.IsNullOrEmpty() && !textBox1.Text.IsNullOrEmpty())
            {
                string email = textBox2.Text;
                string pass = textBox1.Text;

                Conexao.Login login = new Conexao.Login();
                var ret = login.ValidarLogin(email, pass);

                if (ret)
                {
                    //chamar a tela principal
                    this.Visible = false;
                    Produtos form5 = new Produtos();

                    form5.ShowDialog();
                    this.Visible = true;
                }
                else
                {
                    MessageBox.Show("Usuário ou senha inválida");
                }

            }


        }
        private void TextBox2_KeyDown(object sender, KeyEventArgs e)
        {

            if (textBox2.Text != "")
                erroEmail.Visible = false;

            if (erroSenha.Visible == false)
                erroMensagem.Visible = false;

        }
        private void TextBox1_KeyDown(object sender, KeyEventArgs e)
        {

            if (textBox1.Text != "")
                erroSenha.Visible = false;

            if (erroEmail.Visible == false)
                erroMensagem.Visible = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}