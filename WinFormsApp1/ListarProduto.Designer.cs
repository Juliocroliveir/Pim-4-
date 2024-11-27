namespace WinFormsApp1
{
    partial class ListarProduto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListarProduto));
            btoDeletarProduto = new Button();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            button1 = new Button();
            linkLabel1 = new LinkLabel();
            button5 = new Button();
            btoEditarProduto = new Button();
            lbProdutos = new ListBox();
            btoNovoProduto = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btoDeletarProduto
            // 
            btoDeletarProduto.BackColor = Color.Red;
            btoDeletarProduto.FlatStyle = FlatStyle.Popup;
            btoDeletarProduto.Location = new Point(648, 396);
            btoDeletarProduto.Name = "btoDeletarProduto";
            btoDeletarProduto.Size = new Size(75, 23);
            btoDeletarProduto.TabIndex = 74;
            btoDeletarProduto.Text = "Deletar";
            btoDeletarProduto.UseVisualStyleBackColor = false;
            btoDeletarProduto.Click += btoDeletarProduto_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.BackgroundImage = Properties.Resources.OIP__1_;
            pictureBox3.Location = new Point(12, 289);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(88, 102);
            pictureBox3.TabIndex = 67;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = Properties.Resources.semente_800x445;
            pictureBox2.Location = new Point(12, 182);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(88, 101);
            pictureBox2.TabIndex = 66;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.pngtree_red_fresh_tomato_with_green_leaf_png_image_6561484;
            pictureBox1.Location = new Point(12, 82);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(88, 94);
            pictureBox1.TabIndex = 65;
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
            label6.TabIndex = 64;
            label6.Text = "Onion's Farmers";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(392, 25);
            label5.Name = "label5";
            label5.Size = new Size(55, 15);
            label5.TabIndex = 63;
            label5.Text = "Produtos";
            label5.Click += label5_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(453, 25);
            label4.Name = "label4";
            label4.Size = new Size(73, 15);
            label4.TabIndex = 62;
            label4.Text = "Informações";
            label4.Click += label4_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(616, 25);
            label3.Name = "label3";
            label3.Size = new Size(66, 15);
            label3.TabIndex = 61;
            label3.Text = "Seus dados";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(532, 25);
            label2.Name = "label2";
            label2.Size = new Size(78, 15);
            label2.TabIndex = 60;
            label2.Text = "Quem somos";
            // 
            // button1
            // 
            button1.BackColor = Color.Gold;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Location = new Point(702, 21);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 59;
            button1.Text = "Logout";
            button1.UseVisualStyleBackColor = false;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(654, 29);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(0, 15);
            linkLabel1.TabIndex = 58;
            // 
            // button5
            // 
            button5.BackColor = Color.DodgerBlue;
            button5.FlatStyle = FlatStyle.Popup;
            button5.Location = new Point(287, 21);
            button5.Name = "button5";
            button5.Size = new Size(91, 23);
            button5.TabIndex = 77;
            button5.Text = "Fornecedores";
            button5.UseVisualStyleBackColor = false;
            // 
            // btoEditarProduto
            // 
            btoEditarProduto.BackColor = Color.Gold;
            btoEditarProduto.FlatStyle = FlatStyle.Popup;
            btoEditarProduto.Location = new Point(567, 396);
            btoEditarProduto.Name = "btoEditarProduto";
            btoEditarProduto.Size = new Size(75, 23);
            btoEditarProduto.TabIndex = 78;
            btoEditarProduto.Text = "Editar";
            btoEditarProduto.UseVisualStyleBackColor = false;
            btoEditarProduto.Click += btoEditarProduto_Click;
            // 
            // lbProdutos
            // 
            lbProdutos.FormattingEnabled = true;
            lbProdutos.ItemHeight = 15;
            lbProdutos.Location = new Point(106, 86);
            lbProdutos.Name = "lbProdutos";
            lbProdutos.Size = new Size(682, 304);
            lbProdutos.TabIndex = 81;
            // 
            // btoNovoProduto
            // 
            btoNovoProduto.BackColor = Color.FromArgb(0, 192, 0);
            btoNovoProduto.FlatStyle = FlatStyle.Popup;
            btoNovoProduto.Location = new Point(486, 396);
            btoNovoProduto.Name = "btoNovoProduto";
            btoNovoProduto.Size = new Size(75, 23);
            btoNovoProduto.TabIndex = 82;
            btoNovoProduto.Text = "Novo";
            btoNovoProduto.UseVisualStyleBackColor = false;
            btoNovoProduto.Click += btoNovoProduto_Click;
            // 
            // ListarProduto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(800, 450);
            Controls.Add(btoNovoProduto);
            Controls.Add(lbProdutos);
            Controls.Add(btoEditarProduto);
            Controls.Add(button5);
            Controls.Add(btoDeletarProduto);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(linkLabel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ListarProduto";
            Text = "Onion's Farmer";
            Load += ListarProduto_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btoDeletarProduto;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button button1;
        private LinkLabel linkLabel1;
        private Button button5;
        private Button btoEditarProduto;
        private ListBox lbProdutos;
        private Button btoNovoProduto;
    }
}