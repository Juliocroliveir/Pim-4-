using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using WinFormsApp1.Conexao;
using WinFormsApp1.Objetos;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsApp1
{
    public partial class CadastrarProduto : Form
    {
        public CadastrarProduto()
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

        private void btoAdicionarProduto_Click(object sender, EventArgs e)
        {

            bool erro = false;
            //validações dos campos
            //validar se confirmar senha e senha estão iguais

            if (string.IsNullOrWhiteSpace(txtNomeProduto.Text))
            {
                erroNomeProduto.Visible = true;
                erro = true;
            }

            if (string.IsNullOrWhiteSpace(txtValidade.Text))
            {
                erroValidade.Visible = true;
                erro = true;
            }

            if (string.IsNullOrWhiteSpace(txtPreco.Text))
            {
                erroPreco.Visible = true;
                erro = true;
            }

            if (string.IsNullOrWhiteSpace(txtGerminacao.Text))
            {
                erroGerminacao.Visible = true;
                erro = true;
            }

            if (string.IsNullOrWhiteSpace(txtQualidade.Text))
            {
                erroQualidade.Visible = true;
                erro = true;
            }

            if (string.IsNullOrWhiteSpace(txtPureza.Text))
            {
                erroPureza.Visible = true;
                erro = true;
            }

            if (string.IsNullOrWhiteSpace(txtTamanho.Text))
            {
                erroTamanho.Visible = true;
                erro = true;
            }

            if (string.IsNullOrWhiteSpace(txtQuantidade.Text))
            {
                erroQuantidade.Visible = true;
                erro = true;
            }

            if (erro)
            {
                erroMensagem.Text = "* Campos Obrigatórios";
                erroMensagem.Visible = true;
                return;
            }


            if (!DateTime.TryParse(txtValidade.Text, out DateTime dataConvertida))
            {
                erroValidade.Visible = true;
                erro = true;
            }

            if (erro)
            {
                erroMensagem.Text = "* Informação inválida";
                erroMensagem.Visible = true;
                return;
            }



            SementeCadastro sementeCadastro = new SementeCadastro();
            sementeCadastro.Nome = txtNomeProduto.Text;
            sementeCadastro.Validade = DateTime.Parse(txtValidade.Text);
            sementeCadastro.Valor = txtPreco.Text;
            sementeCadastro.Germinacao = txtGerminacao.Text;
            sementeCadastro.Qualidade = txtQualidade.Text;
            sementeCadastro.Pureza = txtPureza.Text;
            sementeCadastro.Tamanho = txtTamanho.Text;
            sementeCadastro.Quantidade = txtQuantidade.Text;


            sqlSemente sementeC = new sqlSemente();

            int ret = sementeC.CadastrarSemente(sementeCadastro);
            if (ret == -1)
            {
                MessageBox.Show("Não foi possível cadastrar, contate o Administrador");
            }
            if (ret == 1)
            {
                MessageBox.Show("Produto cadastrado com sucesso!");
            }



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
    }
}
