using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp1.Conexao;
using WinFormsApp1.Objetos;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace WinFormsApp1
{
    public partial class Produtos : Form
    {

        double valorSub = 0;
        double SomaTotal = 0;
        double taxa = 0;
        public Produtos()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

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

        private void Produtos_Load(object sender, EventArgs e)
        {
            // Limpa o ListBox
            lbProdutos.Items.Clear();

            sqlSemente listProd = new sqlSemente();

            // Busca a lista de produtos
            List<SementeCadastro> listaSemente = listProd.ListarSementes();

            // Verifica se há produtos cadastrados
            if (listaSemente == null || listaSemente.Count == 0)
            {
                MessageBox.Show("Nenhum produto cadastrado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Adiciona o cabeçalho no ListBox
            lbProdutos.Items.Add("Nome\tValor (Kg)\tGerminação\tQualidade\tPureza\tTamanho\tQuantidade\tID\tValidade");
            lbProdutos.Items.Add(new string('-', 80)); // Linha de separação

            // Adiciona cada produto no ListBox
            foreach (var sement in listaSemente)
            {
                string linha = $"{sement.Nome}\t{sement.Valor}\t{sement.Germinacao}\t{sement.Qualidade}\t{sement.Pureza}\t{sement.Tamanho}\t{sement.Quantidade}\t{sement.id}\t{sement.Validade:dd/MM/yyyy}";
                lbProdutos.Items.Add(linha);
            }
        }


        private void btoAdicionar_Click(object sender, EventArgs e)
        {
            if (lbProdutos.SelectedIndex == -1)
            {
                MessageBox.Show("Nenhum item selecionado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrEmpty(txtQtd.Text))
            {
                MessageBox.Show("Quantidade Obrigatória", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string itemSelecionado = lbProdutos.SelectedItem.ToString();

            if (lblLista.Items.Count == 0)
            {
                // Adiciona o cabeçalho no ListBox
                lblLista.Items.Add("Nome\tValor (Kg)\tQuantidade\tID");
                lblLista.Items.Add(new string('-', 80)); // Linha de separação
            }


            string idString = itemSelecionado.Split('\t')[7]; // Separa pelo caractere de tabulação (\t)
            string nomeString = itemSelecionado.Split('\t')[0]; // Separa pelo caractere de tabulação (\t)
            string ValorString = itemSelecionado.Split('\t')[1]; // Separa pelo caractere de tabulação (\t)
            double valorQtd = int.Parse(txtQtd.Text) * double.Parse(ValorString);
            valorSub = valorSub + valorQtd;
            taxa = valorSub * 0.12;

            SomaTotal = valorSub + double.Parse(lbFrete.Text) + taxa;

            lbSubTotal.Text = valorSub.ToString();
            lbTaxa.Text = taxa.ToString("C", new CultureInfo("pt-BR"));
            lbSomaTotal.Text = valorSub.ToString() + double.Parse(lbFrete.Text) + taxa;

            lbProdutos.SelectedIndex = -1;
            txtQtd.Text = "";


            lbSubTotal.Text = valorSub.ToString("C", new CultureInfo("pt-BR"));
            lbSomaTotal.Text = SomaTotal.ToString("C", new CultureInfo("pt-BR"));

            string linha = $"{nomeString}\t{ValorString}\t{txtQtd.Text}\t{valorQtd.ToString()}\t{idString}";
            lblLista.Items.Add(linha);
        }

        private void btoRemover_Click(object sender, EventArgs e)
        {
            if (lblLista.SelectedIndex == -1)
            {
                MessageBox.Show("Nenhum item selecionado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Remove o item selecionado
            int indexSelecionado = lblLista.SelectedIndex;

            string itemSelecionado = lblLista.SelectedItem.ToString();

            string ValorString = itemSelecionado.Split('\t')[3]; // Separa pelo caractere de tabulação (\t)
            double valorQtd = double.Parse(ValorString);
            valorSub = valorSub - valorQtd;
            taxa = valorSub * 0.12;

            lbTaxa.Text = taxa.ToString("C", new CultureInfo("pt-BR"));
            SomaTotal = valorSub + double.Parse(lbFrete.Text) + taxa;

            lbSubTotal.Text = valorSub.ToString("C", new CultureInfo("pt-BR")).Replace('-', ' ');
            lbSomaTotal.Text = SomaTotal.ToString("C", new CultureInfo("pt-BR")).Replace('-', ' ');


            if (indexSelecionado > 1)
            {
                lblLista.Items.RemoveAt(indexSelecionado);
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void btoIrPagamento_Click(object sender, EventArgs e)
        {
            //chamar a tela principal
            this.Visible = false;
            FormaPagamento forPagamento = new FormaPagamento();
            forPagamento.ShowDialog();
            this.Visible = true;
        }


        private void label2_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            QuemSomos form15 = new QuemSomos();
            form15.ShowDialog();
            this.Visible = true;
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
