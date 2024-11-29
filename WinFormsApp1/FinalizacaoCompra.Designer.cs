namespace WinFormsApp1
{
    partial class FinalizacaoCompra
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FinalizacaoCompra));
            label6 = new Label();
            label5 = new Label();
            label7 = new Label();
            label8 = new Label();
            label10 = new Label();
            button1 = new Button();
            linkLabel1 = new LinkLabel();
            label12 = new Label();
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
            label6.TabIndex = 80;
            label6.Text = "Onion Farmers";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(392, 25);
            label5.Name = "label5";
            label5.Size = new Size(55, 15);
            label5.TabIndex = 79;
            label5.Text = "Produtos";
            label5.Click += label5_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(453, 25);
            label7.Name = "label7";
            label7.Size = new Size(73, 15);
            label7.TabIndex = 78;
            label7.Text = "Informações";
            label7.Click += label7_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(616, 25);
            label8.Name = "label8";
            label8.Size = new Size(66, 15);
            label8.TabIndex = 77;
            label8.Text = "Seus dados";
            label8.Click += label8_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(532, 25);
            label10.Name = "label10";
            label10.Size = new Size(78, 15);
            label10.TabIndex = 76;
            label10.Text = "Quem somos";
            // 
            // button1
            // 
            button1.BackColor = Color.Gold;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Location = new Point(702, 21);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 75;
            button1.Text = "Logout";
            button1.UseVisualStyleBackColor = false;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(654, 29);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(0, 15);
            linkLabel1.TabIndex = 74;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.Location = new Point(303, 170);
            label12.Name = "label12";
            label12.Size = new Size(185, 21);
            label12.TabIndex = 81;
            label12.Text = "Compra bem efetuada!";
            // 
            // button2
            // 
            button2.BackColor = Color.Gold;
            button2.FlatStyle = FlatStyle.Popup;
            button2.Location = new Point(295, 213);
            button2.Name = "button2";
            button2.Size = new Size(193, 23);
            button2.TabIndex = 82;
            button2.Text = "Verificar novas opções";
            button2.UseVisualStyleBackColor = false;
            // 
            // FinalizacaoCompra
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(label12);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label7);
            Controls.Add(label8);
            Controls.Add(label10);
            Controls.Add(button1);
            Controls.Add(linkLabel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FinalizacaoCompra";
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
        private Button button2;
    }
}