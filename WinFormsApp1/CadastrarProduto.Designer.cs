namespace WinFormsApp1
{
    partial class CadastrarProduto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastrarProduto));
            pictureBox1 = new PictureBox();
            label6 = new Label();
            label4 = new Label();
            label2 = new Label();
            button1 = new Button();
            linkLabel1 = new LinkLabel();
            txtNomeProduto = new TextBox();
            txtPreco = new TextBox();
            txtQualidade = new TextBox();
            txtTamanho = new TextBox();
            txtQuantidade = new TextBox();
            txtPureza = new TextBox();
            txtGerminacao = new TextBox();
            txtValidade = new TextBox();
            btoAdicionarProduto = new Button();
            label12 = new Label();
            label7 = new Label();
            label8 = new Label();
            label10 = new Label();
            label11 = new Label();
            label13 = new Label();
            label14 = new Label();
            label15 = new Label();
            label16 = new Label();
            erroNomeProduto = new Label();
            erroValidade = new Label();
            erroMensagem = new Label();
            erroGerminacao = new Label();
            erroPureza = new Label();
            erroQuantidade = new Label();
            erroPreco = new Label();
            erroQualidade = new Label();
            erroTamanho = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.pngtree_red_fresh_tomato_with_green_leaf_png_image_6561484;
            pictureBox1.Location = new Point(70, 104);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(203, 243);
            pictureBox1.TabIndex = 88;
            pictureBox1.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Gold;
            label6.Location = new Point(12, 9);
            label6.Name = "label6";
            label6.Size = new Size(188, 32);
            label6.TabIndex = 87;
            label6.Text = "Onion  Farmers";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(453, 25);
            label4.Name = "label4";
            label4.Size = new Size(73, 15);
            label4.TabIndex = 85;
            label4.Text = "Informações";
            label4.Click += label4_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(532, 25);
            label2.Name = "label2";
            label2.Size = new Size(78, 15);
            label2.TabIndex = 83;
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
            button1.TabIndex = 82;
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
            linkLabel1.TabIndex = 81;
            // 
            // txtNomeProduto
            // 
            txtNomeProduto.Location = new Point(297, 128);
            txtNomeProduto.Name = "txtNomeProduto";
            txtNomeProduto.Size = new Size(196, 23);
            txtNomeProduto.TabIndex = 99;
            txtNomeProduto.KeyDown += txtNomeProduto_KeyDown;
            // 
            // txtPreco
            // 
            txtPreco.Location = new Point(297, 181);
            txtPreco.Name = "txtPreco";
            txtPreco.Size = new Size(196, 23);
            txtPreco.TabIndex = 100;
            txtPreco.KeyDown += txtPreco_KeyDown;
            // 
            // txtQualidade
            // 
            txtQualidade.Location = new Point(297, 232);
            txtQualidade.Name = "txtQualidade";
            txtQualidade.Size = new Size(196, 23);
            txtQualidade.TabIndex = 101;
            txtQualidade.KeyDown += txtQualidade_KeyDown;
            // 
            // txtTamanho
            // 
            txtTamanho.Location = new Point(297, 284);
            txtTamanho.Name = "txtTamanho";
            txtTamanho.Size = new Size(196, 23);
            txtTamanho.TabIndex = 102;
            txtTamanho.KeyDown += txtTamanho_KeyDown;
            // 
            // txtQuantidade
            // 
            txtQuantidade.Location = new Point(532, 284);
            txtQuantidade.Name = "txtQuantidade";
            txtQuantidade.Size = new Size(196, 23);
            txtQuantidade.TabIndex = 106;
            txtQuantidade.KeyDown += txtQuantidade_KeyDown;
            // 
            // txtPureza
            // 
            txtPureza.Location = new Point(532, 232);
            txtPureza.Name = "txtPureza";
            txtPureza.Size = new Size(196, 23);
            txtPureza.TabIndex = 105;
            txtPureza.KeyDown += txtPureza_KeyDown;
            // 
            // txtGerminacao
            // 
            txtGerminacao.Location = new Point(532, 181);
            txtGerminacao.Name = "txtGerminacao";
            txtGerminacao.Size = new Size(196, 23);
            txtGerminacao.TabIndex = 104;
            txtGerminacao.KeyDown += txtGerminacao_KeyDown;
            // 
            // txtValidade
            // 
            txtValidade.Location = new Point(532, 128);
            txtValidade.Name = "txtValidade";
            txtValidade.Size = new Size(196, 23);
            txtValidade.TabIndex = 103;
            txtValidade.KeyDown += txtValidade_KeyDown;
            // 
            // btoAdicionarProduto
            // 
            btoAdicionarProduto.BackColor = Color.Gold;
            btoAdicionarProduto.FlatStyle = FlatStyle.Popup;
            btoAdicionarProduto.Location = new Point(297, 343);
            btoAdicionarProduto.Name = "btoAdicionarProduto";
            btoAdicionarProduto.Size = new Size(193, 23);
            btoAdicionarProduto.TabIndex = 107;
            btoAdicionarProduto.Text = "Adicionar";
            btoAdicionarProduto.UseVisualStyleBackColor = false;
            btoAdicionarProduto.Click += btoAdicionarProduto_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.Location = new Point(297, 104);
            label12.Name = "label12";
            label12.Size = new Size(57, 21);
            label12.TabIndex = 108;
            label12.Text = "Nome";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(297, 157);
            label7.Name = "label7";
            label7.Size = new Size(87, 21);
            label7.TabIndex = 109;
            label7.Text = "Preço / kg";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(297, 208);
            label8.Name = "label8";
            label8.Size = new Size(89, 21);
            label8.TabIndex = 110;
            label8.Text = "Qualidade";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(297, 260);
            label10.Name = "label10";
            label10.Size = new Size(81, 21);
            label10.TabIndex = 111;
            label10.Text = "Tamanho";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(532, 260);
            label11.Name = "label11";
            label11.Size = new Size(100, 21);
            label11.TabIndex = 115;
            label11.Text = "Quantidade";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.Location = new Point(532, 208);
            label13.Name = "label13";
            label13.Size = new Size(62, 21);
            label13.TabIndex = 114;
            label13.Text = "Pureza";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.Location = new Point(532, 157);
            label14.Name = "label14";
            label14.Size = new Size(102, 21);
            label14.TabIndex = 113;
            label14.Text = "Germinação";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label15.Location = new Point(532, 104);
            label15.Name = "label15";
            label15.Size = new Size(77, 21);
            label15.TabIndex = 112;
            label15.Text = "Validade";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label16.Location = new Point(98, 70);
            label16.Name = "label16";
            label16.Size = new Size(150, 21);
            label16.TabIndex = 145;
            label16.Text = "Adicionar Produto";
            // 
            // erroNomeProduto
            // 
            erroNomeProduto.AutoSize = true;
            erroNomeProduto.ForeColor = Color.Red;
            erroNomeProduto.Location = new Point(279, 136);
            erroNomeProduto.Name = "erroNomeProduto";
            erroNomeProduto.Size = new Size(12, 15);
            erroNomeProduto.TabIndex = 146;
            erroNomeProduto.Text = "*";
            erroNomeProduto.Visible = false;
            // 
            // erroValidade
            // 
            erroValidade.AutoSize = true;
            erroValidade.ForeColor = Color.Red;
            erroValidade.Location = new Point(514, 136);
            erroValidade.Name = "erroValidade";
            erroValidade.Size = new Size(12, 15);
            erroValidade.TabIndex = 147;
            erroValidade.Text = "*";
            erroValidade.Visible = false;
            // 
            // erroMensagem
            // 
            erroMensagem.AutoSize = true;
            erroMensagem.ForeColor = Color.Red;
            erroMensagem.Location = new Point(542, 343);
            erroMensagem.Name = "erroMensagem";
            erroMensagem.Size = new Size(12, 15);
            erroMensagem.TabIndex = 147;
            erroMensagem.Text = "*";
            erroMensagem.Visible = false;
            // 
            // erroGerminacao
            // 
            erroGerminacao.AutoSize = true;
            erroGerminacao.ForeColor = Color.Red;
            erroGerminacao.Location = new Point(514, 189);
            erroGerminacao.Name = "erroGerminacao";
            erroGerminacao.Size = new Size(12, 15);
            erroGerminacao.TabIndex = 147;
            erroGerminacao.Text = "*";
            erroGerminacao.Visible = false;
            // 
            // erroPureza
            // 
            erroPureza.AutoSize = true;
            erroPureza.ForeColor = Color.Red;
            erroPureza.Location = new Point(514, 240);
            erroPureza.Name = "erroPureza";
            erroPureza.Size = new Size(12, 15);
            erroPureza.TabIndex = 147;
            erroPureza.Text = "*";
            erroPureza.Visible = false;
            // 
            // erroQuantidade
            // 
            erroQuantidade.AutoSize = true;
            erroQuantidade.ForeColor = Color.Red;
            erroQuantidade.Location = new Point(514, 292);
            erroQuantidade.Name = "erroQuantidade";
            erroQuantidade.Size = new Size(12, 15);
            erroQuantidade.TabIndex = 147;
            erroQuantidade.Text = "*";
            erroQuantidade.Visible = false;
            // 
            // erroPreco
            // 
            erroPreco.AutoSize = true;
            erroPreco.ForeColor = Color.Red;
            erroPreco.Location = new Point(279, 181);
            erroPreco.Name = "erroPreco";
            erroPreco.Size = new Size(12, 15);
            erroPreco.TabIndex = 147;
            erroPreco.Text = "*";
            erroPreco.Visible = false;
            // 
            // erroQualidade
            // 
            erroQualidade.AutoSize = true;
            erroQualidade.ForeColor = Color.Red;
            erroQualidade.Location = new Point(279, 232);
            erroQualidade.Name = "erroQualidade";
            erroQualidade.Size = new Size(12, 15);
            erroQualidade.TabIndex = 147;
            erroQualidade.Text = "*";
            erroQualidade.Visible = false;
            // 
            // erroTamanho
            // 
            erroTamanho.AutoSize = true;
            erroTamanho.ForeColor = Color.Red;
            erroTamanho.Location = new Point(279, 284);
            erroTamanho.Name = "erroTamanho";
            erroTamanho.Size = new Size(12, 15);
            erroTamanho.TabIndex = 147;
            erroTamanho.Text = "*";
            erroTamanho.Visible = false;
            // 
            // CadastrarProduto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(erroMensagem);
            Controls.Add(erroTamanho);
            Controls.Add(erroQuantidade);
            Controls.Add(erroQualidade);
            Controls.Add(erroPreco);
            Controls.Add(erroPureza);
            Controls.Add(erroGerminacao);
            Controls.Add(erroValidade);
            Controls.Add(erroNomeProduto);
            Controls.Add(label16);
            Controls.Add(label11);
            Controls.Add(label13);
            Controls.Add(label14);
            Controls.Add(label15);
            Controls.Add(label10);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label12);
            Controls.Add(btoAdicionarProduto);
            Controls.Add(txtQuantidade);
            Controls.Add(txtPureza);
            Controls.Add(txtGerminacao);
            Controls.Add(txtValidade);
            Controls.Add(txtTamanho);
            Controls.Add(txtQualidade);
            Controls.Add(txtPreco);
            Controls.Add(txtNomeProduto);
            Controls.Add(pictureBox1);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(linkLabel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "CadastrarProduto";
            Text = "Onion Farmers";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label erroValidade;
        private PictureBox pictureBox1;
        private Label label6;
        private Label label4;
        private Label label2;
        private Button button1;
        private LinkLabel linkLabel1;
        private Label erroPureza;
        private TextBox txtNomeProduto;
        private TextBox txtPreco;
        private TextBox txtQualidade;
        private TextBox txtTamanho;
        private TextBox txtQuantidade;
        private TextBox txtPureza;
        private TextBox txtGerminacao;
        private TextBox txtValidade;
        private Button btoAdicionarProduto;
        private Label label12;
        private Label label7;
        private Label label8;
        private Label label10;
        private Label label11;
        private Label label13;
        private Label label14;
        private Label label15;
        private Label label16;
        private Label erroNomeProduto;
        private Label erroMensagem;
        private Label erroGerminacao;
        private Label erroQuantidade;
        private Label erroPreco;
        private Label erroQualidade;
        private Label erroTamanho;
    }
}