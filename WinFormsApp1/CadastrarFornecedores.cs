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
    public partial class CadastrarFornecedores : Form
    {
        public CadastrarFornecedores()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Deseja sair da tela atual")

            DialogResult resultado = MessageBox.Show(
            "Você deseja continuar?", // Texto da mensagem
            "Confirmação",            // Título da caixa de diálogo
            MessageBoxButtons.YesNo,  // Botões disponíveis (Sim e Não)
            MessageBoxIcon.Question   // Ícone (opcional, aqui é de interrogação)
            );

            if (resultado == DialogResult.Yes)
            {
                this.Visible = false;
                EditarCliente form4 = new EditarCliente();
                form4.ShowDialog();
                this.Visible = true;
            }
        }

        private void Form13_Load(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {


            bool erro = false;
            //validações dos campos
            //validar se confirmar senha e senha estão iguais

            if (string.IsNullOrWhiteSpace(txtNome.Text))
            {
                erroNome.Visible = true;
                erro = true;
            }

            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                erroEmail.Visible = true;
                erro = true;
            }

            if (string.IsNullOrWhiteSpace(txtTelefone.Text))
            {
                erroTelefone.Visible = true;
                erro = true;
            }

            if (string.IsNullOrWhiteSpace(txtCNPJ.Text))
            {
                erroCNPJ.Visible = true;
                erro = true;
            }

            if (string.IsNullOrWhiteSpace(txtEndereco.Text))
            {
                erroEndereco.Visible = true;
                erro = true;
            }
            if (erro)
            {
                erroMensagem.Text = "* Campos Obrigatórios";
                erroMensagem.Visible = true;
                return;
            }




            FornecedorCadastro fornecedorCadastro = new FornecedorCadastro();
            fornecedorCadastro.Nome = txtNome.Text;
            fornecedorCadastro.cnpj = txtCNPJ.Text;
            fornecedorCadastro.Telefone = txtTelefone.Text;
            fornecedorCadastro.Endereco = txtEndereco.Text;
            fornecedorCadastro.Email = txtEmail.Text;



            sqlFornecedor fornecedorC = new sqlFornecedor();

            int ret = fornecedorC.CadastrarFornecedor(fornecedorCadastro);
            if (ret == -1)
            {
                MessageBox.Show("Não foi possível cadastrar, contate o Administrador");
            }
            if (ret == 1)
            {
                MessageBox.Show("Produto cadastrado com sucesso!");
            }


        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Informacoes form14 = new Informacoes();
            form14.ShowDialog();
            this.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Deseja sair da tela atual")

            DialogResult resultado = MessageBox.Show(
            "Você deseja sair?", // Texto da mensagem
            "Confirmação",            // Título da caixa de diálogo
            MessageBoxButtons.YesNo,  // Botões disponíveis (Sim e Não)
            MessageBoxIcon.Question   // Ícone (opcional, aqui é de interrogação)
            );

            if (resultado == DialogResult.Yes)
            {
                this.Visible = false;
                Login form2 = new Login();
                form2.ShowDialog();
                Close();
                this.Visible = true;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            QuemSomos form15 = new QuemSomos();
            form15.ShowDialog();
            this.Visible = true;
        }
    }
}
