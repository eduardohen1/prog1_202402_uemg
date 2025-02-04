using FormsCadastro.model;

namespace FormsCadastro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void arquivoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cadastroDePessoasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pessoa pessoa = new Pessoa();
            pessoa.nome = "Eduardo";
            pessoa.email = "a@a.com";
            pessoa.telefone= "123456789";

            MessageBox.Show("Pessoa: " + pessoa.ToString(), "Titulo",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //pessoa.ToString();

        }
    }
}
