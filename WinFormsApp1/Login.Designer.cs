namespace WinFormsApp1
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            label6 = new Label();
            label4 = new Label();
            label2 = new Label();
            button1 = new Button();
            linkLabel1 = new LinkLabel();
            button2 = new Button();
            button3 = new Button();
            label1 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label7 = new Label();
            label8 = new Label();
            erroMensagem = new Label();
            erroEmail = new Label();
            erroSenha = new Label();
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
            label6.TabIndex = 8;
            label6.Text = "Onion's Farmers";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(453, 25);
            label4.Name = "label4";
            label4.Size = new Size(73, 15);
            label4.TabIndex = 13;
            label4.Text = "Informações";
            label4.Click += label4_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(532, 25);
            label2.Name = "label2";
            label2.Size = new Size(78, 15);
            label2.TabIndex = 11;
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
            button1.TabIndex = 10;
            button1.Text = "Logout";
            button1.UseVisualStyleBackColor = false;
            button1.Visible = false;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(654, 29);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(0, 15);
            linkLabel1.TabIndex = 9;
            // 
            // button2
            // 
            button2.Location = new Point(274, 302);
            button2.Name = "button2";
            button2.Size = new Size(210, 23);
            button2.TabIndex = 21;
            button2.Text = "Crie uma conta";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Gold;
            button3.FlatStyle = FlatStyle.Popup;
            button3.Location = new Point(274, 248);
            button3.Name = "button3";
            button3.Size = new Size(210, 23);
            button3.TabIndex = 20;
            button3.Text = "Entrar";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(280, 284);
            label1.Name = "label1";
            label1.Size = new Size(204, 15);
            label1.TabIndex = 17;
            label1.Text = "Se não for registrado, crie a sua conta";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(274, 199);
            textBox1.Name = "textBox1";
            textBox1.PasswordChar = '*';
            textBox1.PlaceholderText = "Senha";
            textBox1.Size = new Size(210, 23);
            textBox1.TabIndex = 19;
            textBox1.KeyDown += TextBox1_KeyDown;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(274, 153);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "E-mail";
            textBox2.Size = new Size(210, 23);
            textBox2.TabIndex = 18;
            textBox2.KeyDown += TextBox2_KeyDown;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(265, 76);
            label7.Name = "label7";
            label7.Size = new Size(229, 30);
            label7.TabIndex = 16;
            label7.Text = "Entre com a sua conta";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(304, 123);
            label8.Name = "label8";
            label8.Size = new Size(153, 15);
            label8.TabIndex = 15;
            label8.Text = "Usando o seu email e senha";
            // 
            // erroMensagem
            // 
            erroMensagem.AutoSize = true;
            erroMensagem.ForeColor = Color.Red;
            erroMensagem.Location = new Point(304, 344);
            erroMensagem.Name = "erroMensagem";
            erroMensagem.Size = new Size(128, 15);
            erroMensagem.TabIndex = 22;
            erroMensagem.Text = "* Campos Obrigatórios";
            erroMensagem.Visible = false;
            // 
            // erroEmail
            // 
            erroEmail.AutoSize = true;
            erroEmail.ForeColor = Color.Red;
            erroEmail.Location = new Point(256, 156);
            erroEmail.Name = "erroEmail";
            erroEmail.Size = new Size(12, 15);
            erroEmail.TabIndex = 23;
            erroEmail.Text = "*";
            erroEmail.Visible = false;
            // 
            // erroSenha
            // 
            erroSenha.AutoSize = true;
            erroSenha.ForeColor = Color.Red;
            erroSenha.Location = new Point(256, 202);
            erroSenha.Name = "erroSenha";
            erroSenha.Size = new Size(12, 15);
            erroSenha.TabIndex = 24;
            erroSenha.Text = "*";
            erroSenha.Visible = false;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(800, 450);
            Controls.Add(erroSenha);
            Controls.Add(erroEmail);
            Controls.Add(erroMensagem);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(linkLabel1);
            Controls.Add(label6);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Login";
            Text = "Onion's Farmers";
            ResumeLayout(false);
            PerformLayout();
        }

        private void TextBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Label label6;
        private Label label4;
        private Label label2;
        private Button button1;
        private LinkLabel linkLabel1;
        private Button button2;
        private Button button3;
        private Label label1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label7;
        private Label label8;
        private Label erroMensagem;
        private Label erroEmail;
        private Label erroSenha;
    }
}