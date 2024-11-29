namespace WinFormsApp1
{
    partial class Funcionario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Funcionario));
            label6 = new Label();
            label4 = new Label();
            label2 = new Label();
            button1 = new Button();
            btoListarFornecedor = new Button();
            btoListarSementes = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
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
            label6.TabIndex = 61;
            label6.Text = "Onion Farmers";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(453, 25);
            label4.Name = "label4";
            label4.Size = new Size(73, 15);
            label4.TabIndex = 60;
            label4.Text = "Informações";
            label4.Click += label4_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(532, 25);
            label2.Name = "label2";
            label2.Size = new Size(78, 15);
            label2.TabIndex = 59;
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
            button1.TabIndex = 58;
            button1.Text = "Logout";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // btoListarFornecedor
            // 
            btoListarFornecedor.BackColor = Color.Gold;
            btoListarFornecedor.FlatStyle = FlatStyle.Popup;
            btoListarFornecedor.Location = new Point(514, 140);
            btoListarFornecedor.Name = "btoListarFornecedor";
            btoListarFornecedor.Size = new Size(122, 23);
            btoListarFornecedor.TabIndex = 58;
            btoListarFornecedor.Text = "Listar Fornecedor";
            btoListarFornecedor.UseVisualStyleBackColor = false;
            btoListarFornecedor.Click += btoListarFornecedor_Click;
            // 
            // btoListarSementes
            // 
            btoListarSementes.BackColor = Color.Gold;
            btoListarSementes.FlatStyle = FlatStyle.Popup;
            btoListarSementes.Location = new Point(514, 242);
            btoListarSementes.Name = "btoListarSementes";
            btoListarSementes.Size = new Size(122, 23);
            btoListarSementes.TabIndex = 58;
            btoListarSementes.Text = "Listar Sementes";
            btoListarSementes.UseVisualStyleBackColor = false;
            btoListarSementes.Click += btoListarSementes_Click_1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(139, 116);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(149, 187);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 62;
            pictureBox1.TabStop = false;
            // 
            // Funcionario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(btoListarSementes);
            Controls.Add(btoListarFornecedor);
            Controls.Add(button1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Funcionario";
            Text = "Onion Farmers";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label6;
        private Label label4;
        private Label label2;
        private Button button1;
        private Button btoListarFornecedor;
        private Button btoListarSementes;
        private PictureBox pictureBox1;
    }
}