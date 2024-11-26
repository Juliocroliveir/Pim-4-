using WinFormsApp1.Conexao;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
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
            //var TesteConexao1 = new TesteConexao();
            //TesteConexao1.Testar();
            this.Visible = false;
            Form2 form2 = new Form2();
            
            form2.ShowDialog();
            this.Visible = true;

        }
    }
}
