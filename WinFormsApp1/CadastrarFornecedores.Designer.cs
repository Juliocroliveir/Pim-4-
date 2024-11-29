namespace WinFormsApp1
{
    partial class CadastrarFornecedores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastrarFornecedores));
            txtTelefone = new TextBox();
            txtEndereco = new TextBox();
            txtNome = new TextBox();
            txtCNPJ = new TextBox();
            txtEmail = new TextBox();
            button3 = new Button();
            label7 = new Label();
            label6 = new Label();
            label4 = new Label();
            label2 = new Label();
            button1 = new Button();
            erroEmail = new Label();
            erroNome = new Label();
            erroCNPJ = new Label();
            erroTelefone = new Label();
            erroMensagem = new Label();
            erroEndereco = new Label();
            SuspendLayout();
            // 
            // txtTelefone
            // 
            txtTelefone.Location = new Point(285, 293);
            txtTelefone.Name = "txtTelefone";
            txtTelefone.PlaceholderText = "Telefone";
            txtTelefone.Size = new Size(210, 23);
            txtTelefone.TabIndex = 62;
            // 
            // txtEndereco
            // 
            txtEndereco.Location = new Point(285, 247);
            txtEndereco.Name = "txtEndereco";
            txtEndereco.PlaceholderText = "Endereço";
            txtEndereco.Size = new Size(210, 23);
            txtEndereco.TabIndex = 61;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(285, 157);
            txtNome.Name = "txtNome";
            txtNome.PlaceholderText = "Nome";
            txtNome.Size = new Size(210, 23);
            txtNome.TabIndex = 59;
            // 
            // txtCNPJ
            // 
            txtCNPJ.Location = new Point(285, 198);
            txtCNPJ.Name = "txtCNPJ";
            txtCNPJ.PlaceholderText = "CNPJ";
            txtCNPJ.Size = new Size(210, 23);
            txtCNPJ.TabIndex = 60;
            txtCNPJ.TextChanged += textBox6_TextChanged;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(285, 116);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "email@dominio.com";
            txtEmail.Size = new Size(210, 23);
            txtEmail.TabIndex = 58;
            // 
            // button3
            // 
            button3.BackColor = Color.Gold;
            button3.FlatStyle = FlatStyle.Popup;
            button3.Location = new Point(285, 344);
            button3.Name = "button3";
            button3.Size = new Size(210, 23);
            button3.TabIndex = 63;
            button3.Text = "Cadastra Fornecedor";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(285, 66);
            label7.Name = "label7";
            label7.Size = new Size(222, 30);
            label7.TabIndex = 57;
            label7.Text = "Cadastrar Fornecedor";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Gold;
            label6.Location = new Point(12, 9);
            label6.Name = "label6";
            label6.Size = new Size(181, 32);
            label6.TabIndex = 56;
            label6.Text = "Onion Farmers";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(453, 25);
            label4.Name = "label4";
            label4.Size = new Size(73, 15);
            label4.TabIndex = 54;
            label4.Text = "Informações";
            label4.Click += label4_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(532, 25);
            label2.Name = "label2";
            label2.Size = new Size(78, 15);
            label2.TabIndex = 52;
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
            button1.TabIndex = 51;
            button1.Text = "Logout";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // erroEmail
            // 
            erroEmail.AutoSize = true;
            erroEmail.ForeColor = Color.Red;
            erroEmail.Location = new Point(267, 116);
            erroEmail.Name = "erroEmail";
            erroEmail.Size = new Size(12, 15);
            erroEmail.TabIndex = 54;
            erroEmail.Text = "*";
            erroEmail.Visible = false;
            erroEmail.Click += label4_Click;
            // 
            // erroNome
            // 
            erroNome.AutoSize = true;
            erroNome.ForeColor = Color.Red;
            erroNome.Location = new Point(267, 160);
            erroNome.Name = "erroNome";
            erroNome.Size = new Size(12, 15);
            erroNome.TabIndex = 54;
            erroNome.Text = "*";
            erroNome.Visible = false;
            erroNome.Click += label4_Click;
            // 
            // erroCNPJ
            // 
            erroCNPJ.AutoSize = true;
            erroCNPJ.ForeColor = Color.Red;
            erroCNPJ.Location = new Point(267, 201);
            erroCNPJ.Name = "erroCNPJ";
            erroCNPJ.Size = new Size(12, 15);
            erroCNPJ.TabIndex = 54;
            erroCNPJ.Text = "*";
            erroCNPJ.Visible = false;
            erroCNPJ.Click += label4_Click;
            // 
            // erroTelefone
            // 
            erroTelefone.AutoSize = true;
            erroTelefone.ForeColor = Color.Red;
            erroTelefone.Location = new Point(267, 301);
            erroTelefone.Name = "erroTelefone";
            erroTelefone.Size = new Size(12, 15);
            erroTelefone.TabIndex = 54;
            erroTelefone.Text = "*";
            erroTelefone.Visible = false;
            erroTelefone.Click += label4_Click;
            // 
            // erroMensagem
            // 
            erroMensagem.AutoSize = true;
            erroMensagem.ForeColor = Color.Red;
            erroMensagem.Location = new Point(370, 393);
            erroMensagem.Name = "erroMensagem";
            erroMensagem.Size = new Size(12, 15);
            erroMensagem.TabIndex = 54;
            erroMensagem.Text = "*";
            erroMensagem.Visible = false;
            erroMensagem.Click += label4_Click;
            // 
            // erroEndereco
            // 
            erroEndereco.AutoSize = true;
            erroEndereco.ForeColor = Color.Red;
            erroEndereco.Location = new Point(267, 255);
            erroEndereco.Name = "erroEndereco";
            erroEndereco.Size = new Size(12, 15);
            erroEndereco.TabIndex = 54;
            erroEndereco.Text = "*";
            erroEndereco.Visible = false;
            erroEndereco.Click += label4_Click;
            // 
            // CadastrarFornecedores
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(800, 450);
            Controls.Add(txtTelefone);
            Controls.Add(txtEndereco);
            Controls.Add(txtNome);
            Controls.Add(txtCNPJ);
            Controls.Add(txtEmail);
            Controls.Add(button3);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(erroMensagem);
            Controls.Add(erroTelefone);
            Controls.Add(erroEndereco);
            Controls.Add(erroCNPJ);
            Controls.Add(erroNome);
            Controls.Add(erroEmail);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(button1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "CadastrarFornecedores";
            Text = "Onion Farmers";
            Load += Form13_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtTelefone;
        private TextBox txtEndereco;
        private TextBox txtNome;
        private TextBox txtCNPJ;
        private TextBox txtEmail;
        private Button button3;
        private Label label7;
        private Label label6;
        private Label label4;
        private Label label2;
        private Button button1;
        private Label erroEmail;
        private Label erroNome;
        private Label erroCNPJ;
        private Label erroTelefone;
        private Label erroMensagem;
        private Label erroEndereco;
    }
}