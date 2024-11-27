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
    public partial class EditarProduto : Form
    {
        private string id;
        public EditarProduto(string id)
        {
            this.id = id;
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
                Close();
                this.Visible = true;
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show(
            "Você deseja continuar?", // Texto da mensagem
            "Confirmação",            // Título da caixa de diálogo
            MessageBoxButtons.YesNo,  // Botões disponíveis (Sim e Não)
            MessageBoxIcon.Question   // Ícone (opcional, aqui é de interrogação)
            );

            if (resultado == DialogResult.Yes)
            {
                this.Visible = false;
                Produtos form5 = new Produtos();
                form5.ShowDialog();
                Close();
                this.Visible = true;
            }
        }

        private void EditarProduto_Load(object sender, EventArgs e)
        {
            sqlProdutos prod = new sqlProdutos();
            ProdutoCadastro produto = new ProdutoCadastro();

            produto = prod.BuscarProdutoPorId(int.Parse(this.id));

            txtNomeProduto.Text = produto.Nome;
            txtValidade.Text = produto.Validade.ToString();
            txtPreco.Text = produto.PrecoKg.ToString();
            txtQualidade.Text = produto.Qualidade.ToString();
            txtQuantidade.Text += produto.Quantidade.ToString();
            txtPureza.Text = produto.Pureza.ToString();
            txtTamanho.Text = produto.Tamanho.ToString();
            txtGerminacao.Text = produto.Germinacao.ToString();

        }


        private void limpaErro()
        {

            if (erroNomeProduto.Visible == false &&
                erroValidade.Visible == false &&
                erroPreco.Visible == false &&
                erroGerminacao.Visible == false &&
                erroPureza.Visible == false &&
                erroTamanho.Visible == false &&
                erroQualidade.Visible == false &&
                erroQuantidade.Visible == false)
                erroMensagem.Visible = false;

        }
        private void txtNomeProduto_KeyDown(object sender, KeyEventArgs e)
        {
            if (txtNomeProduto.Text != "")
                erroNomeProduto.Visible = false;

            limpaErro();
        }
        private void txtValidade_KeyDown(object sender, KeyEventArgs e)
        {
            if (txtValidade.Text != "")
                erroValidade.Visible = false;

            limpaErro();
        }
        private void txtGerminacao_KeyDown(object sender, KeyEventArgs e)
        {
            if (txtGerminacao.Text != "")
                erroGerminacao.Visible = false;

            limpaErro();
        }
        private void txtQualidade_KeyDown(object sender, KeyEventArgs e)
        {
            if (txtQualidade.Text != "")
                erroQualidade.Visible = false;

            limpaErro();
        }
        private void txtQuantidade_KeyDown(object sender, KeyEventArgs e)
        {
            if (txtQuantidade.Text != "")
                erroQuantidade.Visible = false;

            limpaErro();
        }
        private void txtTamanho_KeyDown(object sender, KeyEventArgs e)
        {
            if (txtTamanho.Text != "")
                erroTamanho.Visible = false;

            limpaErro();
        }
        private void txtPreco_KeyDown(object sender, KeyEventArgs e)
        {
            if (txtPreco.Text != "")
                erroPreco.Visible = false;

            limpaErro();
        }
        private void txtPureza_KeyDown(object sender, KeyEventArgs e)
        {
            if (txtPureza.Text != "")
                erroPureza.Visible = false;

            limpaErro();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Informacoes form14 = new Informacoes();
            form14.ShowDialog();
            this.Visible = true;
        }
    }
}
