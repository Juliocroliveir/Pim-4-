namespace WinFormsApp1
{
    partial class ListarSementes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListarSementes));
            btoDeletarProduto = new Button();
            label6 = new Label();
            label4 = new Label();
            label2 = new Label();
            button1 = new Button();
            linkLabel1 = new LinkLabel();
            btoEditarProduto = new Button();
            lbProdutos = new ListBox();
            btoNovoProduto = new Button();
            label16 = new Label();
            SuspendLayout();
            // 
            // btoDeletarProduto
            // 
            btoDeletarProduto.BackColor = Color.Red;
            btoDeletarProduto.FlatStyle = FlatStyle.Popup;
            btoDeletarProduto.Location = new Point(702, 396);
            btoDeletarProduto.Name = "btoDeletarProduto";
            btoDeletarProduto.Size = new Size(75, 23);
            btoDeletarProduto.TabIndex = 74;
            btoDeletarProduto.Text = "Deletar";
            btoDeletarProduto.UseVisualStyleBackColor = false;
            btoDeletarProduto.Click += btoDeletarProduto_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Gold;
            label6.Location = new Point(12, 9);
            label6.Name = "label6";
            label6.Size = new Size(181, 32);
            label6.TabIndex = 64;
            label6.Text = "Onion Farmers";
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
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(532, 25);
            label2.Name = "label2";
            label2.Size = new Size(78, 15);
            label2.TabIndex = 60;
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
            // btoEditarProduto
            // 
            btoEditarProduto.BackColor = Color.Gold;
            btoEditarProduto.FlatStyle = FlatStyle.Popup;
            btoEditarProduto.Location = new Point(621, 396);
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
            lbProdutos.Location = new Point(34, 86);
            lbProdutos.Name = "lbProdutos";
            lbProdutos.Size = new Size(743, 304);
            lbProdutos.TabIndex = 81;
            // 
            // btoNovoProduto
            // 
            btoNovoProduto.BackColor = Color.FromArgb(0, 192, 0);
            btoNovoProduto.FlatStyle = FlatStyle.Popup;
            btoNovoProduto.Location = new Point(540, 396);
            btoNovoProduto.Name = "btoNovoProduto";
            btoNovoProduto.Size = new Size(75, 23);
            btoNovoProduto.TabIndex = 82;
            btoNovoProduto.Text = "Novo";
            btoNovoProduto.UseVisualStyleBackColor = false;
            btoNovoProduto.Click += btoNovoProduto_Click;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label16.Location = new Point(279, 62);
            label16.Name = "label16";
            label16.Size = new Size(180, 21);
            label16.TabIndex = 146;
            label16.Text = "Sementes Cadastradas";
            // 
            // ListarSementes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(800, 450);
            Controls.Add(label16);
            Controls.Add(btoNovoProduto);
            Controls.Add(lbProdutos);
            Controls.Add(btoEditarProduto);
            Controls.Add(btoDeletarProduto);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(linkLabel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ListarSementes";
            Text = "Onion Farmer";
            Load += ListarProduto_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btoDeletarProduto;
        private Label label6;
        private Label label4;
        private Label label2;
        private Button button1;
        private LinkLabel linkLabel1;
        private Button btoEditarProduto;
        private ListBox lbProdutos;
        private Button btoNovoProduto;
        private Label label16;
    }
}