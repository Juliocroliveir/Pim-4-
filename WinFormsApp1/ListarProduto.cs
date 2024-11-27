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
    public partial class ListarProduto : Form
    {
        public ListarProduto()
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

        private void ListarProduto_Load(object sender, EventArgs e)
        {
            // Limpa o ListBox
            lbProdutos.Items.Clear();

            sqlProdutos listProd = new sqlProdutos();

            // Busca a lista de produtos
            List<ProdutoCadastro> listaProdutos = listProd.ListarProdutos();

            // Verifica se há produtos cadastrados
            if (listaProdutos == null || listaProdutos.Count == 0)
            {
                MessageBox.Show("Nenhum produto cadastrado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Adiciona o cabeçalho no ListBox
            lbProdutos.Items.Add("ID\tNome\tValidade\tPreço (Kg)\tGerminação\tQualidade\tPureza\tTamanho\tQuantidade");
            lbProdutos.Items.Add(new string('-', 80)); // Linha de separação

            // Adiciona cada produto no ListBox
            foreach (var produto in listaProdutos)
            {
                string linha = $"{produto.id}\t{produto.Nome}\t{produto.Validade:dd/MM/yyyy}\t{produto.PrecoKg}\t{produto.Germinacao}\t{produto.Qualidade}\t{produto.Pureza}\t{produto.Tamanho}\t{produto.Quantidade}";
                lbProdutos.Items.Add(linha);
            }
        }

        private void btoNovoProduto_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            CadastrarProduto produto = new CadastrarProduto();
            produto.ShowDialog();
            this.Visible = true;
        }

        private void btoEditarProduto_Click(object sender, EventArgs e)
        {
            if (lbProdutos.SelectedIndex == -1)
            {
                MessageBox.Show("Nenhum item selecionado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string itemSelecionado = lbProdutos.SelectedItem.ToString();


            string idString = itemSelecionado.Split('\t')[0]; // Separa pelo caractere de tabulação (\t)


            this.Visible = false;
            EditarProduto produto = new EditarProduto(idString);
            produto.ShowDialog();
            this.Visible = true;

        }

        private void btoDeletarProduto_Click(object sender, EventArgs e)
        {

            if (lbProdutos.SelectedIndex == -1)
            {
                MessageBox.Show("Nenhum item selecionado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string itemSelecionado = lbProdutos.SelectedItem.ToString();


            string idString = itemSelecionado.Split('\t')[0]; // Separa pelo caractere de tabulação (\t)


            sqlProdutos prod = new sqlProdutos();
            bool ret = prod.DeletarProdutoPorId(int.Parse(idString));

        }
    }
}
