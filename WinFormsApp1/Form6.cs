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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form4 form4 = new Form4();
            form4.ShowDialog();
            Close();
            this.Visible = true;
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
                Form5 form5 = new Form5();
                form5.ShowDialog();
                Close();
                this.Visible = true;
            }
        }
    }
}
