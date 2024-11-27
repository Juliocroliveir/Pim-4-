using WinFormsApp1.Conexao;

namespace WinFormsApp1
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            chamarLogin();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            chamarLogin();
        }
        private void chamarLogin()
        {
            this.Visible = false;
            Login form2 = new Login();
            form2.ShowDialog();
            this.Visible = true;
        }
    }
}
