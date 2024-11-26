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
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            button3 = new Button();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            textBox7 = new TextBox();
            textBox8 = new TextBox();
            textBox9 = new TextBox();
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
            label7.Click += label7_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(124, 121);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "email@dominio.com";
            textBox2.Size = new Size(210, 23);
            textBox2.TabIndex = 24;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(124, 162);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Senha de no minimo 6 digitos";
            textBox1.Size = new Size(210, 23);
            textBox1.TabIndex = 23;
            // 
            // button3
            // 
            button3.BackColor = Color.Gold;
            button3.FlatStyle = FlatStyle.Popup;
            button3.Location = new Point(285, 344);
            button3.Name = "button3";
            button3.Size = new Size(210, 23);
            button3.TabIndex = 22;
            button3.Text = "Cadastrar usando esse email";
            button3.UseVisualStyleBackColor = false;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(124, 204);
            textBox3.Name = "textBox3";
            textBox3.PlaceholderText = "Repita a senha";
            textBox3.Size = new Size(210, 23);
            textBox3.TabIndex = 25;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(453, 121);
            textBox4.Name = "textBox4";
            textBox4.PlaceholderText = "CPF";
            textBox4.Size = new Size(210, 23);
            textBox4.TabIndex = 28;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(124, 245);
            textBox5.Name = "textBox5";
            textBox5.PlaceholderText = "Nome";
            textBox5.Size = new Size(210, 23);
            textBox5.TabIndex = 27;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(124, 286);
            textBox6.Name = "textBox6";
            textBox6.PlaceholderText = "RG";
            textBox6.Size = new Size(210, 23);
            textBox6.TabIndex = 26;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(453, 245);
            textBox7.Name = "textBox7";
            textBox7.PlaceholderText = "Telefone";
            textBox7.Size = new Size(210, 23);
            textBox7.TabIndex = 31;
            // 
            // textBox8
            // 
            textBox8.Location = new Point(453, 162);
            textBox8.Name = "textBox8";
            textBox8.PlaceholderText = "Data de nascimento";
            textBox8.Size = new Size(210, 23);
            textBox8.TabIndex = 30;
            // 
            // textBox9
            // 
            textBox9.Location = new Point(453, 203);
            textBox9.Name = "textBox9";
            textBox9.PlaceholderText = "Endereço";
            textBox9.Size = new Size(210, 23);
            textBox9.TabIndex = 29;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox7);
            Controls.Add(textBox8);
            Controls.Add(textBox9);
            Controls.Add(textBox4);
            Controls.Add(textBox5);
            Controls.Add(textBox6);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(button3);
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
        private TextBox textBox2;
        private TextBox textBox1;
        private Button button3;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private TextBox textBox7;
        private TextBox textBox8;
        private TextBox textBox9;
    }
}