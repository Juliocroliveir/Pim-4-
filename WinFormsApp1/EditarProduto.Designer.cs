namespace WinFormsApp1
{
    partial class EditarProduto
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
            label11 = new Label();
            label13 = new Label();
            label14 = new Label();
            label15 = new Label();
            label10 = new Label();
            label8 = new Label();
            label7 = new Label();
            label12 = new Label();
            btoSalvar = new Button();
            txtQuantidade = new TextBox();
            txtPureza = new TextBox();
            txtGerminacao = new TextBox();
            txtValidade = new TextBox();
            txtTamanho = new TextBox();
            txtQualidade = new TextBox();
            txtPreco = new TextBox();
            txtNomeProduto = new TextBox();
            button5 = new Button();
            pictureBox1 = new PictureBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            button1 = new Button();
            linkLabel1 = new LinkLabel();
            label16 = new Label();
            erroNomeProduto = new Label();
            erroValidade = new Label();
            erroPreco = new Label();
            erroGerminacao = new Label();
            erroQualidade = new Label();
            erroPureza = new Label();
            erroTamanho = new Label();
            erroQuantidade = new Label();
            erroMensagem = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(532, 260);
            label11.Name = "label11";
            label11.Size = new Size(100, 21);
            label11.TabIndex = 143;
            label11.Text = "Quantidade";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.Location = new Point(532, 208);
            label13.Name = "label13";
            label13.Size = new Size(62, 21);
            label13.TabIndex = 142;
            label13.Text = "Pureza";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.Location = new Point(532, 157);
            label14.Name = "label14";
            label14.Size = new Size(102, 21);
            label14.TabIndex = 141;
            label14.Text = "Germinação";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label15.Location = new Point(532, 104);
            label15.Name = "label15";
            label15.Size = new Size(77, 21);
            label15.TabIndex = 140;
            label15.Text = "Validade";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(297, 260);
            label10.Name = "label10";
            label10.Size = new Size(81, 21);
            label10.TabIndex = 139;
            label10.Text = "Tamanho";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(297, 208);
            label8.Name = "label8";
            label8.Size = new Size(89, 21);
            label8.TabIndex = 138;
            label8.Text = "Qualidade";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(297, 157);
            label7.Name = "label7";
            label7.Size = new Size(87, 21);
            label7.TabIndex = 137;
            label7.Text = "Preço / kg";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.Location = new Point(297, 104);
            label12.Name = "label12";
            label12.Size = new Size(57, 21);
            label12.TabIndex = 136;
            label12.Text = "Nome";
            // 
            // btoSalvar
            // 
            btoSalvar.BackColor = Color.Gold;
            btoSalvar.FlatStyle = FlatStyle.Popup;
            btoSalvar.Location = new Point(297, 343);
            btoSalvar.Name = "btoSalvar";
            btoSalvar.Size = new Size(193, 23);
            btoSalvar.TabIndex = 135;
            btoSalvar.Text = "Salvar";
            btoSalvar.UseVisualStyleBackColor = false;
            // 
            // txtQuantidade
            // 
            txtQuantidade.Location = new Point(532, 284);
            txtQuantidade.Name = "txtQuantidade";
            txtQuantidade.Size = new Size(196, 23);
            txtQuantidade.TabIndex = 134;
            txtQuantidade.KeyDown += txtQuantidade_KeyDown;
            // 
            // txtPureza
            // 
            txtPureza.Location = new Point(532, 232);
            txtPureza.Name = "txtPureza";
            txtPureza.Size = new Size(196, 23);
            txtPureza.TabIndex = 133;
            txtPureza.KeyDown += txtPureza_KeyDown;
            // 
            // txtGerminacao
            // 
            txtGerminacao.Location = new Point(532, 181);
            txtGerminacao.Name = "txtGerminacao";
            txtGerminacao.Size = new Size(196, 23);
            txtGerminacao.TabIndex = 132;
            txtGerminacao.KeyDown += txtGerminacao_KeyDown;
            // 
            // txtValidade
            // 
            txtValidade.Location = new Point(532, 128);
            txtValidade.Name = "txtValidade";
            txtValidade.Size = new Size(196, 23);
            txtValidade.TabIndex = 131;
            txtValidade.KeyDown += txtValidade_KeyDown;
            // 
            // txtTamanho
            // 
            txtTamanho.Location = new Point(297, 284);
            txtTamanho.Name = "txtTamanho";
            txtTamanho.Size = new Size(196, 23);
            txtTamanho.TabIndex = 130;
            txtTamanho.KeyDown += txtTamanho_KeyDown;
            // 
            // txtQualidade
            // 
            txtQualidade.Location = new Point(297, 232);
            txtQualidade.Name = "txtQualidade";
            txtQualidade.Size = new Size(196, 23);
            txtQualidade.TabIndex = 129;
            txtQualidade.KeyDown += txtQualidade_KeyDown;
            // 
            // txtPreco
            // 
            txtPreco.Location = new Point(297, 181);
            txtPreco.Name = "txtPreco";
            txtPreco.Size = new Size(196, 23);
            txtPreco.TabIndex = 128;
            txtPreco.KeyDown += txtPreco_KeyDown;
            // 
            // txtNomeProduto
            // 
            txtNomeProduto.Location = new Point(297, 128);
            txtNomeProduto.Name = "txtNomeProduto";
            txtNomeProduto.Size = new Size(196, 23);
            txtNomeProduto.TabIndex = 127;
            txtNomeProduto.KeyDown += txtNomeProduto_KeyDown;
            // 
            // button5
            // 
            button5.BackColor = Color.DodgerBlue;
            button5.FlatStyle = FlatStyle.Popup;
            button5.Location = new Point(287, 21);
            button5.Name = "button5";
            button5.Size = new Size(91, 23);
            button5.TabIndex = 125;
            button5.Text = "Fornecedores";
            button5.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.pngtree_red_fresh_tomato_with_green_leaf_png_image_6561484;
            pictureBox1.Location = new Point(70, 104);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(203, 243);
            pictureBox1.TabIndex = 123;
            pictureBox1.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Gold;
            label6.Location = new Point(12, 9);
            label6.Name = "label6";
            label6.Size = new Size(197, 32);
            label6.TabIndex = 122;
            label6.Text = "Onion's Farmers";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(392, 25);
            label5.Name = "label5";
            label5.Size = new Size(55, 15);
            label5.TabIndex = 121;
            label5.Text = "Produtos";
            label5.Click += label5_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(453, 25);
            label4.Name = "label4";
            label4.Size = new Size(73, 15);
            label4.TabIndex = 120;
            label4.Text = "Informações";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(616, 25);
            label3.Name = "label3";
            label3.Size = new Size(66, 15);
            label3.TabIndex = 119;
            label3.Text = "Seus dados";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(532, 25);
            label2.Name = "label2";
            label2.Size = new Size(78, 15);
            label2.TabIndex = 118;
            label2.Text = "Quem somos";
            // 
            // button1
            // 
            button1.BackColor = Color.Gold;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Location = new Point(702, 21);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 117;
            button1.Text = "Logout";
            button1.UseVisualStyleBackColor = false;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(654, 29);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(0, 15);
            linkLabel1.TabIndex = 116;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label16.Location = new Point(115, 70);
            label16.Name = "label16";
            label16.Size = new Size(121, 21);
            label16.TabIndex = 144;
            label16.Text = "Editar Produto";
            // 
            // erroNomeProduto
            // 
            erroNomeProduto.AutoSize = true;
            erroNomeProduto.ForeColor = Color.Red;
            erroNomeProduto.Location = new Point(287, 136);
            erroNomeProduto.Name = "erroNomeProduto";
            erroNomeProduto.Size = new Size(12, 15);
            erroNomeProduto.TabIndex = 121;
            erroNomeProduto.Text = "*";
            erroNomeProduto.Visible = false;
            erroNomeProduto.Click += label5_Click;
            // 
            // erroValidade
            // 
            erroValidade.AutoSize = true;
            erroValidade.ForeColor = Color.Red;
            erroValidade.Location = new Point(514, 136);
            erroValidade.Name = "erroValidade";
            erroValidade.Size = new Size(12, 15);
            erroValidade.TabIndex = 121;
            erroValidade.Text = "*";
            erroValidade.Visible = false;
            erroValidade.Click += label5_Click;
            // 
            // erroPreco
            // 
            erroPreco.AutoSize = true;
            erroPreco.ForeColor = Color.Red;
            erroPreco.Location = new Point(287, 189);
            erroPreco.Name = "erroPreco";
            erroPreco.Size = new Size(12, 15);
            erroPreco.TabIndex = 121;
            erroPreco.Text = "*";
            erroPreco.Visible = false;
            erroPreco.Click += label5_Click;
            // 
            // erroGerminacao
            // 
            erroGerminacao.AutoSize = true;
            erroGerminacao.ForeColor = Color.Red;
            erroGerminacao.Location = new Point(514, 189);
            erroGerminacao.Name = "erroGerminacao";
            erroGerminacao.Size = new Size(12, 15);
            erroGerminacao.TabIndex = 121;
            erroGerminacao.Text = "*";
            erroGerminacao.Visible = false;
            erroGerminacao.Click += label5_Click;
            // 
            // erroQualidade
            // 
            erroQualidade.AutoSize = true;
            erroQualidade.ForeColor = Color.Red;
            erroQualidade.Location = new Point(287, 240);
            erroQualidade.Name = "erroQualidade";
            erroQualidade.Size = new Size(12, 15);
            erroQualidade.TabIndex = 121;
            erroQualidade.Text = "*";
            erroQualidade.Visible = false;
            erroQualidade.Click += label5_Click;
            // 
            // erroPureza
            // 
            erroPureza.AutoSize = true;
            erroPureza.ForeColor = Color.Red;
            erroPureza.Location = new Point(514, 240);
            erroPureza.Name = "erroPureza";
            erroPureza.Size = new Size(12, 15);
            erroPureza.TabIndex = 121;
            erroPureza.Text = "*";
            erroPureza.Visible = false;
            erroPureza.Click += label5_Click;
            // 
            // erroTamanho
            // 
            erroTamanho.AutoSize = true;
            erroTamanho.ForeColor = Color.Red;
            erroTamanho.Location = new Point(287, 292);
            erroTamanho.Name = "erroTamanho";
            erroTamanho.Size = new Size(12, 15);
            erroTamanho.TabIndex = 121;
            erroTamanho.Text = "*";
            erroTamanho.Visible = false;
            erroTamanho.Click += label5_Click;
            // 
            // erroQuantidade
            // 
            erroQuantidade.AutoSize = true;
            erroQuantidade.ForeColor = Color.Red;
            erroQuantidade.Location = new Point(514, 292);
            erroQuantidade.Name = "erroQuantidade";
            erroQuantidade.Size = new Size(12, 15);
            erroQuantidade.TabIndex = 121;
            erroQuantidade.Text = "*";
            erroQuantidade.Visible = false;
            erroQuantidade.Click += label5_Click;
            // 
            // erroMensagem
            // 
            erroMensagem.AutoSize = true;
            erroMensagem.ForeColor = Color.Red;
            erroMensagem.Location = new Point(532, 351);
            erroMensagem.Name = "erroMensagem";
            erroMensagem.Size = new Size(12, 15);
            erroMensagem.TabIndex = 121;
            erroMensagem.Text = "*";
            erroMensagem.Visible = false;
            erroMensagem.Click += label5_Click;
            // 
            // EditarProduto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(800, 450);
            Controls.Add(label16);
            Controls.Add(label11);
            Controls.Add(label13);
            Controls.Add(label14);
            Controls.Add(label15);
            Controls.Add(label10);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label12);
            Controls.Add(btoSalvar);
            Controls.Add(txtQuantidade);
            Controls.Add(txtPureza);
            Controls.Add(txtGerminacao);
            Controls.Add(txtValidade);
            Controls.Add(txtTamanho);
            Controls.Add(txtQualidade);
            Controls.Add(txtPreco);
            Controls.Add(txtNomeProduto);
            Controls.Add(button5);
            Controls.Add(pictureBox1);
            Controls.Add(label6);
            Controls.Add(erroMensagem);
            Controls.Add(erroQuantidade);
            Controls.Add(erroTamanho);
            Controls.Add(erroPureza);
            Controls.Add(erroQualidade);
            Controls.Add(erroGerminacao);
            Controls.Add(erroPreco);
            Controls.Add(erroValidade);
            Controls.Add(erroNomeProduto);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(linkLabel1);
            Name = "EditarProduto";
            Text = "Form11";
            Load += EditarProduto_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label11;
        private Label label13;
        private Label label14;
        private Label label15;
        private Label label10;
        private Label label8;
        private Label label7;
        private Label label12;
        private Button btoSalvar;
        private TextBox txtQuantidade;
        private TextBox txtPureza;
        private TextBox txtGerminacao;
        private TextBox txtValidade;
        private TextBox txtTamanho;
        private TextBox txtQualidade;
        private TextBox txtPreco;
        private TextBox txtNomeProduto;
        private Button button5;
        private PictureBox pictureBox1;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button button1;
        private LinkLabel linkLabel1;
        private Label label16;
        private Label erroNomeProduto;
        private Label erroValidade;
        private Label erroPreco;
        private Label erroGerminacao;
        private Label erroQualidade;
        private Label erroPureza;
        private Label erroTamanho;
        private Label erroQuantidade;
        private Label erroMensagem;
    }
}