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
            textBox7 = new TextBox();
            textBox9 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            textBox2 = new TextBox();
            button3 = new Button();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            button1 = new Button();
            linkLabel1 = new LinkLabel();
            SuspendLayout();
            // 
            // textBox7
            // 
            textBox7.Location = new Point(285, 293);
            textBox7.Name = "textBox7";
            textBox7.PlaceholderText = "Telefone";
            textBox7.Size = new Size(210, 23);
            textBox7.TabIndex = 62;
            // 
            // textBox9
            // 
            textBox9.Location = new Point(285, 247);
            textBox9.Name = "textBox9";
            textBox9.PlaceholderText = "Endereço";
            textBox9.Size = new Size(210, 23);
            textBox9.TabIndex = 61;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(285, 157);
            textBox5.Name = "textBox5";
            textBox5.PlaceholderText = "Nome";
            textBox5.Size = new Size(210, 23);
            textBox5.TabIndex = 59;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(285, 198);
            textBox6.Name = "textBox6";
            textBox6.PlaceholderText = "CNPJ";
            textBox6.Size = new Size(210, 23);
            textBox6.TabIndex = 60;
            textBox6.TextChanged += textBox6_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(285, 116);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "email@dominio.com";
            textBox2.Size = new Size(210, 23);
            textBox2.TabIndex = 58;
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
            label6.Size = new Size(197, 32);
            label6.TabIndex = 56;
            label6.Text = "Onion's Farmers";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(392, 25);
            label5.Name = "label5";
            label5.Size = new Size(55, 15);
            label5.TabIndex = 55;
            label5.Text = "Produtos";
            label5.Visible = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(453, 25);
            label4.Name = "label4";
            label4.Size = new Size(73, 15);
            label4.TabIndex = 54;
            label4.Text = "Informações";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(616, 25);
            label3.Name = "label3";
            label3.Size = new Size(66, 15);
            label3.TabIndex = 53;
            label3.Text = "Seus dados";
            label3.Visible = false;
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(532, 25);
            label2.Name = "label2";
            label2.Size = new Size(78, 15);
            label2.TabIndex = 52;
            label2.Text = "Quem somos";
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
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(654, 29);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(0, 15);
            linkLabel1.TabIndex = 50;
            // 
            // Form13
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox7);
            Controls.Add(textBox9);
            Controls.Add(textBox5);
            Controls.Add(textBox6);
            Controls.Add(textBox2);
            Controls.Add(button3);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(linkLabel1);
            Name = "Form13";
            Text = "Form13";
            Load += Form13_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox7;
        private TextBox textBox9;
        private TextBox textBox5;
        private TextBox textBox6;
        private TextBox textBox2;
        private Button button3;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button button1;
        private LinkLabel linkLabel1;
    }
}