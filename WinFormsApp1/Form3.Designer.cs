namespace WinFormsApp1
{
    partial class Form3
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
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            button1 = new Button();
            linkLabel1 = new LinkLabel();
            label7 = new Label();
            txtEmail = new TextBox();
            txtSenha = new TextBox();
            btoCadastrarUsuario = new Button();
            txtConfirmaSenha = new TextBox();
            txtCPF = new TextBox();
            txtNome = new TextBox();
            txtRG = new TextBox();
            txtTelefone = new TextBox();
            txtDataNascimento = new TextBox();
            txtEndereco = new TextBox();
            SuspendLayout();
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Gold;
            label6.Location = new Point(12, 9);
            label6.Name = "label6";
            label6.Size = new Size(197, 32);
            label6.TabIndex = 14;
            label6.Text = "Onion's Farmers";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(392, 25);
            label5.Name = "label5";
            label5.Size = new Size(55, 15);
            label5.TabIndex = 13;
            label5.Text = "Produtos";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(453, 25);
            label4.Name = "label4";
            label4.Size = new Size(73, 15);
            label4.TabIndex = 12;
            label4.Text = "Informações";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(616, 25);
            label3.Name = "label3";
            label3.Size = new Size(66, 15);
            label3.TabIndex = 11;
            label3.Text = "Seus dados";
            label3.Visible = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(532, 25);
            label2.Name = "label2";
            label2.Size = new Size(78, 15);
            label2.TabIndex = 10;
            label2.Text = "Quem somos";
            // 
            // button1
            // 
            button1.BackColor = Color.Gold;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Location = new Point(702, 21);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 9;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = false;
            button1.Visible = false;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(654, 29);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(0, 15);
            linkLabel1.TabIndex = 8;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(305, 66);
            label7.Name = "label7";
            label7.Size = new Size(168, 30);
            label7.TabIndex = 21;
            label7.Text = "Crie a sua conta";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(124, 121);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "email@dominio.com";
            txtEmail.Size = new Size(210, 23);
            txtEmail.TabIndex = 24;
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(124, 162);
            txtSenha.Name = "txtSenha";
            txtSenha.PlaceholderText = "Senha de no minimo 6 digitos";
            txtSenha.Size = new Size(210, 23);
            txtSenha.TabIndex = 23;
            // 
            // btoCadastrarUsuario
            // 
            btoCadastrarUsuario.BackColor = Color.Gold;
            btoCadastrarUsuario.FlatStyle = FlatStyle.Popup;
            btoCadastrarUsuario.Location = new Point(285, 344);
            btoCadastrarUsuario.Name = "btoCadastrarUsuario";
            btoCadastrarUsuario.Size = new Size(210, 23);
            btoCadastrarUsuario.TabIndex = 22;
            btoCadastrarUsuario.Text = "Cadastrar usando esse email";
            btoCadastrarUsuario.UseVisualStyleBackColor = false;
            btoCadastrarUsuario.Click += btoCadastrarUsuario_Click;
            // 
            // txtConfirmaSenha
            // 
            txtConfirmaSenha.Location = new Point(124, 204);
            txtConfirmaSenha.Name = "txtConfirmaSenha";
            txtConfirmaSenha.PlaceholderText = "Repita a senha";
            txtConfirmaSenha.Size = new Size(210, 23);
            txtConfirmaSenha.TabIndex = 25;
            // 
            // txtCPF
            // 
            txtCPF.Location = new Point(453, 121);
            txtCPF.MaxLength = 11;
            txtCPF.Name = "txtCPF";
            txtCPF.PlaceholderText = "CPF";
            txtCPF.Size = new Size(210, 23);
            txtCPF.TabIndex = 28;
            txtCPF.KeyDown += txtCPF_KeyDown;
            txtCPF.KeyUp += txtCPF_KeyUp;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(124, 245);
            txtNome.Name = "txtNome";
            txtNome.PlaceholderText = "Nome";
            txtNome.Size = new Size(210, 23);
            txtNome.TabIndex = 27;
            // 
            // txtRG
            // 
            txtRG.Location = new Point(124, 286);
            txtRG.Name = "txtRG";
            txtRG.PlaceholderText = "RG";
            txtRG.Size = new Size(210, 23);
            txtRG.TabIndex = 26;
            // 
            // txtTelefone
            // 
            txtTelefone.Location = new Point(453, 245);
            txtTelefone.Name = "txtTelefone";
            txtTelefone.PlaceholderText = "Telefone";
            txtTelefone.Size = new Size(210, 23);
            txtTelefone.TabIndex = 31;
            // 
            // txtDataNascimento
            // 
            txtDataNascimento.Location = new Point(453, 162);
            txtDataNascimento.MaxLength = 8;
            txtDataNascimento.Name = "txtDataNascimento";
            txtDataNascimento.PlaceholderText = "Data de nascimento";
            txtDataNascimento.Size = new Size(210, 23);
            txtDataNascimento.TabIndex = 30;
            txtDataNascimento.TextChanged += txtDataNascimento_TextChanged;
            txtDataNascimento.KeyDown += txtDataNascimento_KeyDown;
            txtDataNascimento.KeyUp += txtDataNascimento_KeyUp;
            // 
            // txtEndereco
            // 
            txtEndereco.Location = new Point(453, 203);
            txtEndereco.Name = "txtEndereco";
            txtEndereco.PlaceholderText = "Endereço";
            txtEndereco.Size = new Size(210, 23);
            txtEndereco.TabIndex = 29;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(800, 450);
            Controls.Add(txtTelefone);
            Controls.Add(txtDataNascimento);
            Controls.Add(txtEndereco);
            Controls.Add(txtCPF);
            Controls.Add(txtNome);
            Controls.Add(txtRG);
            Controls.Add(txtConfirmaSenha);
            Controls.Add(txtEmail);
            Controls.Add(txtSenha);
            Controls.Add(btoCadastrarUsuario);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(linkLabel1);
            Name = "Form3";
            Text = "Form3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button button1;
        private LinkLabel linkLabel1;
        private Label label7;
        private TextBox txtEmail;
        private TextBox txtSenha;
        private Button btoCadastrarUsuario;
        private TextBox txtConfirmaSenha;
        private TextBox txtCPF;
        private TextBox txtNome;
        private TextBox txtRG;
        private TextBox txtTelefone;
        private TextBox txtDataNascimento;
        private TextBox txtEndereco;
    }
}