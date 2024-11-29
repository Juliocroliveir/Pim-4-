namespace WinFormsApp1
{
    partial class CarrinhoCompra
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CarrinhoCompra));
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            label9 = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label4 = new Label();
            label6 = new Label();
            label5 = new Label();
            label7 = new Label();
            label8 = new Label();
            label10 = new Label();
            button1 = new Button();
            linkLabel1 = new LinkLabel();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            label15 = new Label();
            button2 = new Button();
            label16 = new Label();
            label17 = new Label();
            label18 = new Label();
            label19 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = Properties.Resources.semente_800x445;
            pictureBox2.Location = new Point(47, 132);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(126, 92);
            pictureBox2.TabIndex = 48;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackgroundImage = Properties.Resources.OIP__1_;
            pictureBox3.Location = new Point(47, 239);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(126, 88);
            pictureBox3.TabIndex = 49;
            pictureBox3.TabStop = false;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(190, 187);
            label9.Name = "label9";
            label9.Size = new Size(68, 15);
            label9.TabIndex = 54;
            label9.Text = "R$ 3.99 / kg";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(190, 154);
            label1.Name = "label1";
            label1.Size = new Size(166, 15);
            label1.TabIndex = 53;
            label1.Text = "Semente de tomante organica";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(190, 290);
            label2.Name = "label2";
            label2.Size = new Size(68, 15);
            label2.TabIndex = 56;
            label2.Text = "R$ 2.99 / kg";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(190, 257);
            label3.Name = "label3";
            label3.Size = new Size(166, 15);
            label3.TabIndex = 55;
            label3.Text = "Semente de tomante organica";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(273, 184);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Quantidade";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 57;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(273, 287);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "Quantidade";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 58;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(532, 132);
            label4.Name = "label4";
            label4.Size = new Size(52, 15);
            label4.TabIndex = 59;
            label4.Text = "SubTotal";
            label4.Click += label4_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Gold;
            label6.Location = new Point(12, 9);
            label6.Name = "label6";
            label6.Size = new Size(181, 32);
            label6.TabIndex = 66;
            label6.Text = "Onion Farmers";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(392, 25);
            label5.Name = "label5";
            label5.Size = new Size(55, 15);
            label5.TabIndex = 65;
            label5.Text = "Produtos";
            label5.Click += label5_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(453, 25);
            label7.Name = "label7";
            label7.Size = new Size(73, 15);
            label7.TabIndex = 64;
            label7.Text = "Informações";
            label7.Click += label7_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(616, 25);
            label8.Name = "label8";
            label8.Size = new Size(66, 15);
            label8.TabIndex = 63;
            label8.Text = "Seus dados";
            label8.Click += label8_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(532, 25);
            label10.Name = "label10";
            label10.Size = new Size(78, 15);
            label10.TabIndex = 62;
            label10.Text = "Quem somos";
            // 
            // button1
            // 
            button1.BackColor = Color.Gold;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Location = new Point(702, 21);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 61;
            button1.Text = "Logout";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(654, 29);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(0, 15);
            linkLabel1.TabIndex = 60;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(532, 85);
            label11.Name = "label11";
            label11.Size = new Size(159, 21);
            label11.TabIndex = 67;
            label11.Text = "Detalhes do pedido";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.Location = new Point(180, 85);
            label12.Name = "label12";
            label12.Size = new Size(76, 21);
            label12.TabIndex = 68;
            label12.Text = "Carrinho";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(532, 163);
            label13.Name = "label13";
            label13.Size = new Size(33, 15);
            label13.TabIndex = 69;
            label13.Text = "Frete";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(532, 192);
            label14.Name = "label14";
            label14.Size = new Size(30, 15);
            label14.TabIndex = 70;
            label14.Text = "Taxa";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label15.Location = new Point(532, 222);
            label15.Name = "label15";
            label15.Size = new Size(33, 15);
            label15.TabIndex = 71;
            label15.Text = "Total";
            // 
            // button2
            // 
            button2.BackColor = Color.Gold;
            button2.FlatStyle = FlatStyle.Popup;
            button2.Location = new Point(532, 257);
            button2.Name = "button2";
            button2.Size = new Size(209, 23);
            button2.TabIndex = 72;
            button2.Text = "Continuar comprando";
            button2.UseVisualStyleBackColor = false;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label16.ForeColor = Color.Green;
            label16.Location = new Point(689, 222);
            label16.Name = "label16";
            label16.Size = new Size(53, 15);
            label16.TabIndex = 76;
            label16.Text = "R$ 13,40";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(689, 192);
            label17.Name = "label17";
            label17.Size = new Size(44, 15);
            label17.TabIndex = 75;
            label17.Text = "R$ 2,90";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(689, 163);
            label18.Name = "label18";
            label18.Size = new Size(44, 15);
            label18.TabIndex = 74;
            label18.Text = "R$ 3,50";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(689, 132);
            label19.Name = "label19";
            label19.Size = new Size(44, 15);
            label19.TabIndex = 73;
            label19.Text = "R$ 7,00";
            // 
            // CarrinhoCompra
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(800, 450);
            Controls.Add(label16);
            Controls.Add(label17);
            Controls.Add(label18);
            Controls.Add(label19);
            Controls.Add(button2);
            Controls.Add(label15);
            Controls.Add(label14);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label7);
            Controls.Add(label8);
            Controls.Add(label10);
            Controls.Add(button1);
            Controls.Add(linkLabel1);
            Controls.Add(label4);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(label9);
            Controls.Add(label1);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "CarrinhoCompra";
            Text = "Onion Farmers";
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Label label9;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label4;
        private Label label6;
        private Label label5;
        private Label label7;
        private Label label8;
        private Label label10;
        private Button button1;
        private LinkLabel linkLabel1;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label14;
        private Label label15;
        private Button button2;
        private Label label16;
        private Label label17;
        private Label label18;
        private Label label19;
    }
}