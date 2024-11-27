namespace WinFormsApp1
{
    partial class Informacoes
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
            button2 = new Button();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            linkLabel1 = new LinkLabel();
            label1 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // button2
            // 
            button2.BackColor = Color.Gold;
            button2.FlatStyle = FlatStyle.Popup;
            button2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(339, 369);
            button2.Name = "button2";
            button2.Size = new Size(114, 30);
            button2.TabIndex = 25;
            button2.Text = "Voltar";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.FlatStyle = FlatStyle.Popup;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(316, 228);
            label8.Name = "label8";
            label8.Size = new Size(167, 21);
            label8.TabIndex = 24;
            label8.Text = "Onion's Farmer Online";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(272, 285);
            label7.Name = "label7";
            label7.Size = new Size(260, 17);
            label7.TabIndex = 23;
            label7.Text = "Outras formas de contato 0800  4002-8922";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Gold;
            label6.Location = new Point(15, 14);
            label6.Name = "label6";
            label6.Size = new Size(197, 32);
            label6.TabIndex = 22;
            label6.Text = "Onion's Farmers";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(660, 33);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(0, 15);
            linkLabel1.TabIndex = 16;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(569, 122);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 15;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(51, 329);
            label3.Name = "label3";
            label3.Size = new Size(705, 17);
            label3.TabIndex = 29;
            label3.Text = "Copyright 2024 Onion's Farmer Inc. Todos os direitos reservados. Onion's Farmer Brasil Ltda. CNPJ: 00.000.000/0001-23";
            // 
            // Form14
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(button2);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(linkLabel1);
            Controls.Add(label1);
            Name = "Form14";
            Text = "Onion's Farmers";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button2;
        private Label label8;
        private Label label7;
        private Label label6;
        private LinkLabel linkLabel1;
        private Label label1;
        private Label label3;
    }
}