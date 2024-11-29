namespace WinFormsApp1
{
    partial class ListarFornecedores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListarFornecedores));
            label6 = new Label();
            label4 = new Label();
            label2 = new Label();
            button1 = new Button();
            linkLabel1 = new LinkLabel();
            lbFornecedores = new ListBox();
            label16 = new Label();
            btoNovo = new Button();
            btoEditar = new Button();
            btoDeletar = new Button();
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
            label6.TabIndex = 132;
            label6.Text = "Onion Farmers";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(453, 25);
            label4.Name = "label4";
            label4.Size = new Size(73, 15);
            label4.TabIndex = 130;
            label4.Text = "Informações";
            label4.Click += label4_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(532, 25);
            label2.Name = "label2";
            label2.Size = new Size(78, 15);
            label2.TabIndex = 128;
            label2.Text = "Quem somos";
            // 
            // button1
            // 
            button1.BackColor = Color.Gold;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Location = new Point(702, 21);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 127;
            button1.Text = "Voltar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(654, 29);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(0, 15);
            linkLabel1.TabIndex = 126;
            // 
            // lbFornecedores
            // 
            lbFornecedores.FormattingEnabled = true;
            lbFornecedores.ItemHeight = 15;
            lbFornecedores.Location = new Point(34, 86);
            lbFornecedores.Name = "lbFornecedores";
            lbFornecedores.Size = new Size(743, 304);
            lbFornecedores.TabIndex = 81;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label16.Location = new Point(271, 59);
            label16.Name = "label16";
            label16.Size = new Size(209, 21);
            label16.TabIndex = 145;
            label16.Text = "Fornecedores Cadastrados";
            // 
            // btoNovo
            // 
            btoNovo.BackColor = Color.FromArgb(0, 192, 0);
            btoNovo.FlatStyle = FlatStyle.Popup;
            btoNovo.Location = new Point(540, 396);
            btoNovo.Name = "btoNovo";
            btoNovo.Size = new Size(75, 23);
            btoNovo.TabIndex = 148;
            btoNovo.Text = "Novo";
            btoNovo.UseVisualStyleBackColor = false;
            btoNovo.Click += btoNovoProduto_Click;
            // 
            // btoEditar
            // 
            btoEditar.BackColor = Color.Gold;
            btoEditar.Enabled = false;
            btoEditar.FlatStyle = FlatStyle.Popup;
            btoEditar.Location = new Point(621, 396);
            btoEditar.Name = "btoEditar";
            btoEditar.Size = new Size(75, 23);
            btoEditar.TabIndex = 147;
            btoEditar.Text = "Editar";
            btoEditar.UseVisualStyleBackColor = false;
            btoEditar.Click += btoEditar_Click;
            // 
            // btoDeletar
            // 
            btoDeletar.BackColor = Color.Red;
            btoDeletar.FlatStyle = FlatStyle.Popup;
            btoDeletar.Location = new Point(702, 396);
            btoDeletar.Name = "btoDeletar";
            btoDeletar.Size = new Size(75, 23);
            btoDeletar.TabIndex = 146;
            btoDeletar.Text = "Deletar";
            btoDeletar.UseVisualStyleBackColor = false;
            btoDeletar.Click += btoDeletar_Click;
            // 
            // ListarFornecedores
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(800, 450);
            Controls.Add(btoNovo);
            Controls.Add(btoEditar);
            Controls.Add(btoDeletar);
            Controls.Add(label16);
            Controls.Add(lbFornecedores);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(linkLabel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ListarFornecedores";
            Text = "Onion Farmers";
            Load += ListarFornecedores_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label6;
        private Label label4;
        private Label label2;
        private Button button1;
        private LinkLabel linkLabel1;
        private ListBox lbFornecedores;
        private Label label16;
        private Button btoNovo;
        private Button btoEditar;
        private Button btoDeletar;
    }
}