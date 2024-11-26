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
    }
}
