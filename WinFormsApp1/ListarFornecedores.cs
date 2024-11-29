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
    public partial class ListarFornecedores : Form
    {
        public ListarFornecedores()
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


        private void label4_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Informacoes form14 = new Informacoes();
            form14.ShowDialog();
            this.Visible = true;
        }

        private void btoNovoProduto_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            CadastrarFornecedores cadFornece = new CadastrarFornecedores();
            cadFornece.ShowDialog();
            this.Visible = true;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btoEditar_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            //EditarFornecedores editFornece = new EditarFornecedores();
            //editFornece.ShowDialog();
            this.Visible = true;

        }

        private void btoDeletar_Click(object sender, EventArgs e)
        {


            if (lbFornecedores.SelectedIndex == -1)
            {
                MessageBox.Show("Nenhum item selecionado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string itemSelecionado = lbFornecedores.SelectedItem.ToString();
            int indexSelecionado = lbFornecedores.SelectedIndex;


            string idString = itemSelecionado.Split('\t')[0]; // Separa pelo caractere de tabulação (\t)


            sqlFornecedor prod = new sqlFornecedor();
            bool ret = prod.DeletarFornecedorPorId(int.Parse(idString));

            // Remove o item selecionado
            if (indexSelecionado > 1)
            {
                lbFornecedores.Items.RemoveAt(indexSelecionado);
            }
        }

        private void ListarFornecedores_Load(object sender, EventArgs e)
        {

            // Limpa o ListBox
            lbFornecedores.Items.Clear();

            sqlFornecedor listProd = new sqlFornecedor();

            // Busca a lista de produtos
            List<FornecedorCadastro> listarFornecedores = listProd.ListarFornecedors();

            // Verifica se há produtos cadastrados
            if (listarFornecedores == null || listarFornecedores.Count == 0)
            {
                MessageBox.Show("Nenhum Fornecedor cadastrado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Adiciona o cabeçalho no ListBox
            lbFornecedores.Items.Add("ID\tNome\tCNPJ\tEmail\tEndereco\tTelefone");
            lbFornecedores.Items.Add(new string('-', 80)); // Linha de separação

            // Adiciona cada produto no ListBox
            foreach (var fornecedor in listarFornecedores)
            {
                string linha = $"{fornecedor.id}\t{fornecedor.Nome}\t{fornecedor.cnpj}\t{fornecedor.Email}\t{fornecedor.Endereco}\t{fornecedor.Telefone}";
                lbFornecedores.Items.Add(linha);
            }
        }
    }
}
