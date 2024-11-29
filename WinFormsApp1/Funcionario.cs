﻿using System;
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

        private void label4_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Informacoes form14 = new Informacoes();
            form14.ShowDialog();
            this.Visible = true;
        }
    }
}