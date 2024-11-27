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
            button5 = new Button();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            button1 = new Button();
            linkLabel1 = new LinkLabel();
            listBox1 = new ListBox();
            label16 = new Label();
            button2 = new Button();
            SuspendLayout();
            // 
            // button5
            // 
            button5.BackColor = Color.DodgerBlue;
            button5.FlatStyle = FlatStyle.Popup;
            button5.Location = new Point(287, 21);
            button5.Name = "button5";
            button5.Size = new Size(91, 23);
            button5.TabIndex = 133;
            button5.Text = "Fornecedores";
            button5.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Gold;
            label6.Location = new Point(12, 9);
            label6.Name = "label6";
            label6.Size = new Size(197, 32);
            label6.TabIndex = 132;
            label6.Text = "Onion's Farmers";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(392, 25);
            label5.Name = "label5";
            label5.Size = new Size(55, 15);
            label5.TabIndex = 131;
            label5.Text = "Produtos";
            label5.Click += label5_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(453, 25);
            label4.Name = "label4";
            label4.Size = new Size(73, 15);
            label4.TabIndex = 130;
            label4.Text = "Informações";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(616, 25);
            label3.Name = "label3";
            label3.Size = new Size(66, 15);
            label3.TabIndex = 129;
            label3.Text = "Seus dados";
            label3.Click += label3_Click;
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
            button1.Text = "Logout";
            button1.UseVisualStyleBackColor = false;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(654, 29);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(0, 15);
            linkLabel1.TabIndex = 126;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Items.AddRange(new object[] { "1 Cliente", "2 Cliente ", "3 Cliente ", "4 Cliente ", "5 Cliente ", "6 Cliente ", "7 Cliente ", "8 Cliente ", "9 Cliente ", "10 Cliente ", "11 Cliente ", "12 Cliente ", "13 Cliente " });
            listBox1.Location = new Point(80, 161);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(619, 199);
            listBox1.TabIndex = 134;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label16.Location = new Point(277, 120);
            label16.Name = "label16";
            label16.Size = new Size(209, 21);
            label16.TabIndex = 145;
            label16.Text = "Fornecedores Cadastrados";
            // 
            // button2
            // 
            button2.BackColor = Color.Gold;
            button2.FlatStyle = FlatStyle.Popup;
            button2.Location = new Point(287, 383);
            button2.Name = "button2";
            button2.Size = new Size(193, 23);
            button2.TabIndex = 146;
            button2.Text = "Adicionar Fornecedor";
            button2.UseVisualStyleBackColor = false;
            // 
            // Form12
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(label16);
            Controls.Add(listBox1);
            Controls.Add(button5);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(linkLabel1);
            Name = "Form12";
            Text = "Form12";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button5;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button button1;
        private LinkLabel linkLabel1;
        private ListBox listBox1;
        private Label label16;
        private Button button2;
    }
}