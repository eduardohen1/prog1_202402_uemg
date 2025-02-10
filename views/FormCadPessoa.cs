using FormsCadastro.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormsCadastro.views
{
    public partial class FormCadPessoa : Form
    {
        public FormCadPessoa()
        {
            InitializeComponent();
        }

        private void FormCadPessoa_Load(object sender, EventArgs e)
        {
            limparTela();
        }

        private void limparTela()
        {
            txtNome.Clear();
            txtEmail.Clear();
            txtTelefone.Clear();
            txtNome.Focus();
        }

        private bool verificaTela()
        {
            bool resposta = true;
            if (txtNome.Text.Trim().Length == 0)
            {
                resposta = false;
                MessageBox.Show("Nome é obrigatório", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNome.Focus();
            }

            if (txtEmail.Text.Trim().Length == 0 && resposta)
            {
                resposta = false;
                MessageBox.Show("E-mail é obrigatório", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEmail.Focus();
            }
            return resposta;
        }
        private void bntGravar_Click(object sender, EventArgs e)
        {
            try
            {
                if (verificaTela())
                {
                    Pessoa pessoa = new Pessoa();
                    pessoa.nome = txtNome.Text;
                    pessoa.email = txtEmail.Text;
                    pessoa.telefone = txtTelefone.Text;

                    //gravar em BD
                    MessageBox.Show("Pessoa: " + pessoa.ToString(), "CAdastro de Pessoa",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    limparTela();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message, "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
