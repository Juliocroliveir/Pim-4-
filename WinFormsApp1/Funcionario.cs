using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Funcionario : Form
    {
        public Funcionario()
        {
            InitializeComponent();
        }

        private void btoListarFuncionario_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Funcionario listfornec = new Funcionario();
            listfornec.ShowDialog();
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

        private void btoListarFornecedor_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            ListarFornecedores listfornec = new ListarFornecedores();
            listfornec.ShowDialog();
            this.Visible = true;
        }



        private void btoListarSementes_Click_1(object sender, EventArgs e)
        {
            this.Visible = false;
            ListarSementes listfornec = new ListarSementes();
            listfornec.ShowDialog();
            this.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
