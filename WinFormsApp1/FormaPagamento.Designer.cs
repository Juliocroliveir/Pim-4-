namespace WinFormsApp1
{
    partial class FormaPagamento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormaPagamento));
            label6 = new Label();
            label5 = new Label();
            label7 = new Label();
            label8 = new Label();
            label10 = new Label();
            button1 = new Button();
            linkLabel1 = new LinkLabel();
            label12 = new Label();
            checkedListBox1 = new CheckedListBox();
            label1 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            button2 = new Button();
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
            label6.TabIndex = 73;
            label6.Text = "Onion Farmers";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(392, 25);
            label5.Name = "label5";
            label5.Size = new Size(55, 15);
            label5.TabIndex = 72;
            label5.Text = "Produtos";
            label5.Click += label5_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(453, 25);
            label7.Name = "label7";
            label7.Size = new Size(73, 15);
            label7.TabIndex = 71;
            label7.Text = "Informações";
            label7.Click += label7_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(616, 25);
            label8.Name = "label8";
            label8.Size = new Size(66, 15);
            label8.TabIndex = 70;
            label8.Text = "Seus dados";
            label8.Click += label8_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(532, 25);
            label10.Name = "label10";
            label10.Size = new Size(78, 15);
            label10.TabIndex = 69;
            label10.Text = "Quem somos";
            // 
            // button1
            // 
            button1.BackColor = Color.Gold;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Location = new Point(702, 21);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 68;
            button1.Text = "Logout";
            button1.UseVisualStyleBackColor = false;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(654, 29);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(0, 15);
            linkLabel1.TabIndex = 67;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.Location = new Point(349, 71);
            label12.Name = "label12";
            label12.Size = new Size(98, 21);
            label12.TabIndex = 74;
            label12.Text = "Pagamento";
            // 
            // checkedListBox1
            // 
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Items.AddRange(new object[] { "Débito", "Crédito", "Boleto" });
            checkedListBox1.Location = new Point(304, 152);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(120, 58);
            checkedListBox1.TabIndex = 75;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(304, 108);
            label1.Name = "label1";
            label1.Size = new Size(193, 15);
            label1.TabIndex = 76;
            label1.Text = "Selecione uma forma de pagmento";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(304, 232);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Nome completo";
            textBox1.Size = new Size(193, 23);
            textBox1.TabIndex = 77;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(304, 277);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "0123 4567 8910 1112";
            textBox2.Size = new Size(193, 23);
            textBox2.TabIndex = 78;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(304, 328);
            textBox3.Name = "textBox3";
            textBox3.PlaceholderText = "00/00";
            textBox3.Size = new Size(83, 23);
            textBox3.TabIndex = 79;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(414, 328);
            textBox4.Name = "textBox4";
            textBox4.PlaceholderText = "123";
            textBox4.Size = new Size(83, 23);
            textBox4.TabIndex = 80;
            // 
            // button2
            // 
            button2.BackColor = Color.Gold;
            button2.FlatStyle = FlatStyle.Popup;
            button2.Location = new Point(304, 384);
            button2.Name = "button2";
            button2.Size = new Size(193, 23);
            button2.TabIndex = 81;
            button2.Text = "Finalizar compra";
            button2.UseVisualStyleBackColor = false;
            // 
            // FormaPagamento
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(checkedListBox1);
            Controls.Add(label12);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label7);
            Controls.Add(label8);
            Controls.Add(label10);
            Controls.Add(button1);
            Controls.Add(linkLabel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormaPagamento";
            Text = "Onion Farmers";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label6;
        private Label label5;
        private Label label7;
        private Label label8;
        private Label label10;
        private Button button1;
        private LinkLabel linkLabel1;
        private Label label12;
        private CheckedListBox checkedListBox1;
        private Label label1;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private Button button2;
    }
}