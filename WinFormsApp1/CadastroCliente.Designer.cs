namespace WinFormsApp1
{
    partial class CadastroCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastroCliente));
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
            erroEmail = new Label();
            erroSenha = new Label();
            erroConfirmarSenha = new Label();
            erroNome = new Label();
            erroRg = new Label();
            erroCpf = new Label();
            erroDataNascimento = new Label();
            erroEndereco = new Label();
            erroTelefone = new Label();
            erroMensagem = new Label();
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
            label5.Visible = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(453, 25);
            label4.Name = "label4";
            label4.Size = new Size(73, 15);
            label4.TabIndex = 12;
            label4.Text = "Informações";
            label4.Click += label4_Click;
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
            txtEmail.MaxLength = 20;
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "email@dominio.com";
            txtEmail.Size = new Size(210, 23);
            txtEmail.TabIndex = 24;
            txtEmail.TextChanged += txtEmail_TextChanged;
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(124, 162);
            txtSenha.MaxLength = 15;
            txtSenha.Name = "txtSenha";
            txtSenha.PlaceholderText = "Senha de no minimo 6 digitos";
            txtSenha.Size = new Size(210, 23);
            txtSenha.TabIndex = 25;
            txtSenha.TextChanged += txtSenha_TextChanged;
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
            txtConfirmaSenha.MaxLength = 15;
            txtConfirmaSenha.Name = "txtConfirmaSenha";
            txtConfirmaSenha.PlaceholderText = "Repita a senha";
            txtConfirmaSenha.Size = new Size(210, 23);
            txtConfirmaSenha.TabIndex = 26;
            txtConfirmaSenha.TextChanged += txtConfirmaSenha_TextChanged;
            // 
            // txtCPF
            // 
            txtCPF.Location = new Point(453, 121);
            txtCPF.MaxLength = 11;
            txtCPF.Name = "txtCPF";
            txtCPF.PlaceholderText = "CPF";
            txtCPF.Size = new Size(210, 23);
            txtCPF.TabIndex = 29;
            txtCPF.TextChanged += txtCPF_TextChanged;
            txtCPF.KeyDown += txtCPF_KeyDown;
            txtCPF.KeyUp += txtCPF_KeyUp;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(124, 245);
            txtNome.MaxLength = 40;
            txtNome.Name = "txtNome";
            txtNome.PlaceholderText = "Nome";
            txtNome.Size = new Size(210, 23);
            txtNome.TabIndex = 27;
            txtNome.TextChanged += txtNome_TextChanged;
            // 
            // txtRG
            // 
            txtRG.Location = new Point(124, 286);
            txtRG.MaxLength = 12;
            txtRG.Name = "txtRG";
            txtRG.PlaceholderText = "RG";
            txtRG.Size = new Size(210, 23);
            txtRG.TabIndex = 28;
            txtRG.TextChanged += txtRG_TextChanged;
            // 
            // txtTelefone
            // 
            txtTelefone.Location = new Point(453, 245);
            txtTelefone.MaxLength = 15;
            txtTelefone.Name = "txtTelefone";
            txtTelefone.PlaceholderText = "Telefone";
            txtTelefone.Size = new Size(210, 23);
            txtTelefone.TabIndex = 32;
            txtTelefone.TextChanged += txtTelefone_TextChanged;
            // 
            // txtDataNascimento
            // 
            txtDataNascimento.Location = new Point(453, 162);
            txtDataNascimento.MaxLength = 8;
            txtDataNascimento.Name = "txtDataNascimento";
            txtDataNascimento.PlaceholderText = "Data de nascimento";
            txtDataNascimento.Size = new Size(210, 23);
            txtDataNascimento.TabIndex = 30;
            txtDataNascimento.TextChanged += txtDataNascimento_TextChanged_1;
            txtDataNascimento.KeyDown += txtDataNascimento_KeyDown;
            txtDataNascimento.KeyUp += txtDataNascimento_KeyUp;
            // 
            // txtEndereco
            // 
            txtEndereco.Location = new Point(453, 203);
            txtEndereco.MaxLength = 100;
            txtEndereco.Name = "txtEndereco";
            txtEndereco.PlaceholderText = "Endereço";
            txtEndereco.Size = new Size(210, 23);
            txtEndereco.TabIndex = 31;
            txtEndereco.TextChanged += txtEndereco_TextChanged;
            // 
            // erroEmail
            // 
            erroEmail.AutoSize = true;
            erroEmail.ForeColor = Color.Red;
            erroEmail.Location = new Point(106, 124);
            erroEmail.Name = "erroEmail";
            erroEmail.Size = new Size(12, 15);
            erroEmail.TabIndex = 33;
            erroEmail.Text = "*";
            erroEmail.Visible = false;
            erroEmail.Click += label1_Click;
            // 
            // erroSenha
            // 
            erroSenha.AutoSize = true;
            erroSenha.ForeColor = Color.Red;
            erroSenha.Location = new Point(106, 165);
            erroSenha.Name = "erroSenha";
            erroSenha.Size = new Size(12, 15);
            erroSenha.TabIndex = 34;
            erroSenha.Text = "*";
            erroSenha.Visible = false;
            // 
            // erroConfirmarSenha
            // 
            erroConfirmarSenha.AutoSize = true;
            erroConfirmarSenha.ForeColor = Color.Red;
            erroConfirmarSenha.Location = new Point(106, 207);
            erroConfirmarSenha.Name = "erroConfirmarSenha";
            erroConfirmarSenha.Size = new Size(12, 15);
            erroConfirmarSenha.TabIndex = 35;
            erroConfirmarSenha.Text = "*";
            erroConfirmarSenha.Visible = false;
            // 
            // erroNome
            // 
            erroNome.AutoSize = true;
            erroNome.ForeColor = Color.Red;
            erroNome.Location = new Point(106, 248);
            erroNome.Name = "erroNome";
            erroNome.Size = new Size(12, 15);
            erroNome.TabIndex = 36;
            erroNome.Text = "*";
            erroNome.Visible = false;
            // 
            // erroRg
            // 
            erroRg.AutoSize = true;
            erroRg.ForeColor = Color.Red;
            erroRg.Location = new Point(106, 289);
            erroRg.Name = "erroRg";
            erroRg.Size = new Size(12, 15);
            erroRg.TabIndex = 37;
            erroRg.Text = "*";
            erroRg.Visible = false;
            // 
            // erroCpf
            // 
            erroCpf.AutoSize = true;
            erroCpf.ForeColor = Color.Red;
            erroCpf.Location = new Point(435, 124);
            erroCpf.Name = "erroCpf";
            erroCpf.Size = new Size(12, 15);
            erroCpf.TabIndex = 38;
            erroCpf.Text = "*";
            erroCpf.Visible = false;
            // 
            // erroDataNascimento
            // 
            erroDataNascimento.AutoSize = true;
            erroDataNascimento.ForeColor = Color.Red;
            erroDataNascimento.Location = new Point(435, 165);
            erroDataNascimento.Name = "erroDataNascimento";
            erroDataNascimento.Size = new Size(12, 15);
            erroDataNascimento.TabIndex = 39;
            erroDataNascimento.Text = "*";
            erroDataNascimento.Visible = false;
            // 
            // erroEndereco
            // 
            erroEndereco.AutoSize = true;
            erroEndereco.ForeColor = Color.Red;
            erroEndereco.Location = new Point(435, 207);
            erroEndereco.Name = "erroEndereco";
            erroEndereco.Size = new Size(12, 15);
            erroEndereco.TabIndex = 40;
            erroEndereco.Text = "*";
            erroEndereco.Visible = false;
            // 
            // erroTelefone
            // 
            erroTelefone.AutoSize = true;
            erroTelefone.ForeColor = Color.Red;
            erroTelefone.Location = new Point(435, 248);
            erroTelefone.Name = "erroTelefone";
            erroTelefone.Size = new Size(12, 15);
            erroTelefone.TabIndex = 41;
            erroTelefone.Text = "*";
            erroTelefone.Visible = false;
            erroTelefone.Click += erroTelefone_Click;
            // 
            // erroMensagem
            // 
            erroMensagem.AutoSize = true;
            erroMensagem.ForeColor = Color.Red;
            erroMensagem.Location = new Point(382, 390);
            erroMensagem.Name = "erroMensagem";
            erroMensagem.Size = new Size(18, 15);
            erroMensagem.TabIndex = 42;
            erroMensagem.Text = "*  ";
            erroMensagem.Visible = false;
            // 
            // CadastroCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(800, 450);
            Controls.Add(erroMensagem);
            Controls.Add(erroTelefone);
            Controls.Add(erroEndereco);
            Controls.Add(erroDataNascimento);
            Controls.Add(erroCpf);
            Controls.Add(erroRg);
            Controls.Add(erroNome);
            Controls.Add(erroConfirmarSenha);
            Controls.Add(erroSenha);
            Controls.Add(erroEmail);
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
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "CadastroCliente";
            Text = "Onion's Farmers";
            Load += Form3_Load;
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
        private Label erroEmail;
        private Label erroSenha;
        private Label erroConfirmarSenha;
        private Label erroNome;
        private Label erroRg;
        private Label erroCpf;
        private Label erroDataNascimento;
        private Label erroEndereco;
        private Label erroTelefone;
        private Label erroMensagem;
    }
}