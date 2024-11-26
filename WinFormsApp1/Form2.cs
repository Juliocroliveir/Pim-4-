using Microsoft.IdentityModel.Tokens;
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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form3 form3 = new Form3();

            form3.ShowDialog();
            this.Visible = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox2.Text.IsNullOrEmpty())
                erroEmail.Visible = true;

            if (textBox1.Text.IsNullOrEmpty())
                erroSenha.Visible = true;


            if (erroEmail.Visible || erroSenha.Visible)
                erroMensagem.Visible = true;




        }
        private void TextBox2_KeyDown(object sender, KeyEventArgs e)
        {

            if (textBox2.Text != "")
                erroEmail.Visible = false;

            if (erroSenha.Visible == false)
                erroMensagem.Visible = false;

        }
        private void TextBox1_KeyDown(object sender, KeyEventArgs e)
        {

            if (textBox1.Text != "")
                erroSenha.Visible = false;

            if (erroEmail.Visible == false)
                erroMensagem.Visible = false;

        }

       
    }
}
