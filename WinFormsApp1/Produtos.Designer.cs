namespace WinFormsApp1
{
    partial class Produtos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Produtos));
            label6 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            button1 = new Button();
            linkLabel1 = new LinkLabel();
            lbProdutos = new ListBox();
            lblLista = new ListBox();
            btoAdicionar = new Button();
            txtQtd = new TextBox();
            label1 = new Label();
            btoRemover = new Button();
            label5 = new Label();
            lbSubTotal = new Label();
            label8 = new Label();
            label7 = new Label();
            label9 = new Label();
            lbTaxa = new Label();
            lbSomaTotal = new Label();
            lbFrete = new Label();
            btoIrPagamento = new Button();
            SuspendLayout();
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Gold;
            label6.Location = new Point(12, 9);
            label6.Name = "label6";
            label6.Size = new Size(181, 32);
            label6.TabIndex = 45;
            label6.Text = "Onion Farmers";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(453, 25);
            label4.Name = "label4";
            label4.Size = new Size(73, 15);
            label4.TabIndex = 43;
            label4.Text = "Informações";
            label4.Click += label4_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(616, 25);
            label3.Name = "label3";
            label3.Size = new Size(66, 15);
            label3.TabIndex = 42;
            label3.Text = "Seus dados";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(532, 25);
            label2.Name = "label2";
            label2.Size = new Size(78, 15);
            label2.TabIndex = 41;
            label2.Text = "Quem somos";
            label2.Click += label2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Gold;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Location = new Point(702, 21);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 40;
            button1.Text = "Logout";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(654, 29);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(0, 15);
            linkLabel1.TabIndex = 39;
            // 
            // lbProdutos
            // 
            lbProdutos.FormattingEnabled = true;
            lbProdutos.ItemHeight = 15;
            lbProdutos.Location = new Point(22, 95);
            lbProdutos.Name = "lbProdutos";
            lbProdutos.Size = new Size(265, 304);
            lbProdutos.TabIndex = 82;
            // 
            // lblLista
            // 
            lblLista.FormattingEnabled = true;
            lblLista.ItemHeight = 15;
            lblLista.Location = new Point(493, 95);
            lblLista.Name = "lblLista";
            lblLista.Size = new Size(265, 214);
            lblLista.TabIndex = 82;
            // 
            // btoAdicionar
            // 
            btoAdicionar.Location = new Point(320, 204);
            btoAdicionar.Name = "btoAdicionar";
            btoAdicionar.Size = new Size(70, 23);
            btoAdicionar.TabIndex = 83;
            btoAdicionar.Text = "Adicionar";
            btoAdicionar.UseVisualStyleBackColor = true;
            btoAdicionar.Click += btoAdicionar_Click;
            // 
            // txtQtd
            // 
            txtQtd.Location = new Point(320, 173);
            txtQtd.Name = "txtQtd";
            txtQtd.Size = new Size(71, 23);
            txtQtd.TabIndex = 84;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(320, 155);
            label1.Name = "label1";
            label1.Size = new Size(69, 15);
            label1.TabIndex = 43;
            label1.Text = "Quantidade";
            // 
            // btoRemover
            // 
            btoRemover.Location = new Point(407, 204);
            btoRemover.Name = "btoRemover";
            btoRemover.Size = new Size(70, 23);
            btoRemover.TabIndex = 83;
            btoRemover.Text = "Remover";
            btoRemover.UseVisualStyleBackColor = true;
            btoRemover.Click += btoRemover_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(493, 322);
            label5.Name = "label5";
            label5.Size = new Size(52, 15);
            label5.TabIndex = 43;
            label5.Text = "SubTotal";
            // 
            // lbSubTotal
            // 
            lbSubTotal.AutoSize = true;
            lbSubTotal.Location = new Point(662, 322);
            lbSubTotal.Name = "lbSubTotal";
            lbSubTotal.Size = new Size(28, 15);
            lbSubTotal.TabIndex = 43;
            lbSubTotal.Text = "0,00";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(493, 346);
            label8.Name = "label8";
            label8.Size = new Size(33, 15);
            label8.TabIndex = 43;
            label8.Text = "Frete";
            label8.Click += label8_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(493, 370);
            label7.Name = "label7";
            label7.Size = new Size(30, 15);
            label7.TabIndex = 43;
            label7.Text = "Taxa";
            label7.Click += label8_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(494, 397);
            label9.Name = "label9";
            label9.Size = new Size(32, 15);
            label9.TabIndex = 43;
            label9.Text = "Total";
            label9.Click += label8_Click;
            // 
            // lbTaxa
            // 
            lbTaxa.AutoSize = true;
            lbTaxa.Location = new Point(662, 370);
            lbTaxa.Name = "lbTaxa";
            lbTaxa.Size = new Size(28, 15);
            lbTaxa.TabIndex = 43;
            lbTaxa.Text = "0,00";
            // 
            // lbSomaTotal
            // 
            lbSomaTotal.AutoSize = true;
            lbSomaTotal.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lbSomaTotal.ForeColor = Color.Green;
            lbSomaTotal.Location = new Point(662, 397);
            lbSomaTotal.Name = "lbSomaTotal";
            lbSomaTotal.Size = new Size(31, 15);
            lbSomaTotal.TabIndex = 43;
            lbSomaTotal.Text = "0,00";
            // 
            // lbFrete
            // 
            lbFrete.AutoSize = true;
            lbFrete.Location = new Point(662, 346);
            lbFrete.Name = "lbFrete";
            lbFrete.Size = new Size(28, 15);
            lbFrete.TabIndex = 43;
            lbFrete.Text = "7,50";
            // 
            // btoIrPagamento
            // 
            btoIrPagamento.BackColor = Color.Gold;
            btoIrPagamento.FlatStyle = FlatStyle.Popup;
            btoIrPagamento.Location = new Point(320, 389);
            btoIrPagamento.Name = "btoIrPagamento";
            btoIrPagamento.Size = new Size(142, 23);
            btoIrPagamento.TabIndex = 40;
            btoIrPagamento.Text = "Ir para Pagamento";
            btoIrPagamento.UseVisualStyleBackColor = false;
            btoIrPagamento.Click += btoIrPagamento_Click;
            // 
            // Produtos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(800, 451);
            Controls.Add(txtQtd);
            Controls.Add(btoRemover);
            Controls.Add(btoAdicionar);
            Controls.Add(lblLista);
            Controls.Add(lbProdutos);
            Controls.Add(label6);
            Controls.Add(label1);
            Controls.Add(label9);
            Controls.Add(label7);
            Controls.Add(label8);
            Controls.Add(lbSomaTotal);
            Controls.Add(lbFrete);
            Controls.Add(lbTaxa);
            Controls.Add(lbSubTotal);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btoIrPagamento);
            Controls.Add(button1);
            Controls.Add(linkLabel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Produtos";
            Text = "Onion Farmers";
            Name = "Produtos";
            Text = "Form5";
            Load += Produtos_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label6;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button button1;
        private LinkLabel linkLabel1;
        private ListBox lbProdutos;
        private ListBox lblLista;
        private Button btoAdicionar;
        private TextBox txtQtd;
        private Label label1;
        private Button btoRemover;
        private Label label5;
        private Label lbSubTotal;
        private Label label8;
        private Label label7;
        private Label label9;
        private Label lbTaxa;
        private Label lbSomaTotal;
        private Label lbFrete;
        private Button btoIrPagamento;
    }
}