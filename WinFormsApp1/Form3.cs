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
using WinFormsApp1.Objetos;

namespace WinFormsApp1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }


        private void btoCadastrarUsuario_Click(object sender, EventArgs e)
        {
            //validações dos campos
            //validar se confirmar senha e senha estão iguais





            UsuarioCadastro usuarioCadastro = new UsuarioCadastro();
            usuarioCadastro.Email = txtEmail.Text;
            usuarioCadastro.Senha = txtSenha.Text;
            usuarioCadastro.Nome = txtNome.Text;
            usuarioCadastro.RG = txtRG.Text;
            usuarioCadastro.CPF = txtCPF.Text;
            usuarioCadastro.DataNascimento = DateTime.Parse(txtDataNascimento.Text);
            usuarioCadastro.Endereco = txtEndereco.Text;
            usuarioCadastro.Telefone = txtTelefone.Text;

            Usuarios usuarios = new Usuarios();

            int ret = usuarios.CadastrarUsuario(usuarioCadastro);
            if (ret == -1)
            {
                MessageBox.Show("Não foi possível cadastrar, contate o Administrador");
            }
            if (ret == 1)
            {
                //mensagem de cadastro com sucesso
                //redirecionar para a tela 5
            }
            else
            {
                //tratar caso não cadastrou
            }





        }

        private void txtCPF_KeyDown(object sender, KeyEventArgs e)
        {
            // Permitir apenas teclas numéricas e algumas teclas adicionais (Backspace, Delete, etc.)
            if (!((e.KeyCode >= Keys.D0 && e.KeyCode <= Keys.D9) ||       // Teclas numéricas do teclado principal
                  (e.KeyCode >= Keys.NumPad0 && e.KeyCode <= Keys.NumPad9) || // Teclas numéricas do teclado numérico
                  e.KeyCode == Keys.Back ||                              // Backspace
                  e.KeyCode == Keys.Delete ||                            // Delete
                  e.KeyCode == Keys.Left ||                              // Seta para a esquerda
                  e.KeyCode == Keys.Right ||                             // Seta para a direita
                  e.KeyCode == Keys.Tab))                                // Tab
            {
                // Bloqueia a entrada de outros caracteres
                e.SuppressKeyPress = true;
            }
        }

        private void txtCPF_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtCPF.Text.Count() == 11)
            {
                var part1 = txtCPF.Text.Substring(0, 3);
                var part2 = txtCPF.Text.Substring(3, 3);
                var part3 = txtCPF.Text.Substring(6, 3);
                var part4 = txtCPF.Text.Substring(9, 2);

                txtCPF.Text = part1 + "." + part2 + "." + part3 + "-" + part4;

            }
        }


        private void txtDataNascimento_KeyDown(object sender, KeyEventArgs e)
        {
            // Permitir apenas teclas numéricas e algumas teclas adicionais (Backspace, Delete, etc.)
            if (!((e.KeyCode >= Keys.D0 && e.KeyCode <= Keys.D9) ||       // Teclas numéricas do teclado principal
                  (e.KeyCode >= Keys.NumPad0 && e.KeyCode <= Keys.NumPad9) || // Teclas numéricas do teclado numérico
                  e.KeyCode == Keys.Back ||                              // Backspace
                  e.KeyCode == Keys.Delete ||                            // Delete
                  e.KeyCode == Keys.Left ||                              // Seta para a esquerda
                  e.KeyCode == Keys.Right ||                             // Seta para a direita
                  e.KeyCode == Keys.Tab))                                // Tab
            {
                // Bloqueia a entrada de outros caracteres
                e.SuppressKeyPress = true;
            }
        }
        private void txtDataNascimento_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtDataNascimento.Text.Count() == 8)
            {
                var part1 = txtDataNascimento.Text.Substring(0, 2);
                var part2 = txtDataNascimento.Text.Substring(2, 2);
                var part3 = txtDataNascimento.Text.Substring(4, 4);

                txtDataNascimento.Text = part1 + "/" + part2 + "/" + part3;

            }
        }

        private void txtDataNascimento_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
