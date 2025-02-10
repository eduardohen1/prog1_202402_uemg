using FormsCadastro.controller;
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
        ConexaoMySQL conexaoMySQL;

        public FormCadPessoa()
        {
            InitializeComponent();
        }

        private void FormCadPessoa_Load(object sender, EventArgs e)
        {
            limparTela();
            DadosConexao dadosConexao = new DadosConexao(
                    "localhost",
                    "root",
                    "123456",
                    "CadPessoas",
                    3306
                );
            conexaoMySQL = new ConexaoMySQL(dadosConexao);
            if (conexaoMySQL.conectar())
                MessageBox.Show("Conectado no banco de dados!");
        }

        private void limparTela()
        {
            txtNome.Clear();
            txtEmail.Clear();
            txtTelefone.Clear();
            txtNome.Focus();
            txtCodigo.Text = "0";
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
                    pessoa.codigo = int.Parse(txtCodigo.Text);

                    //gravar em BD
                    if (conexaoMySQL.gravarPessoa(pessoa))
                    {
                        MessageBox.Show("Cadastro gravado com sucesso!", "Cdastro de Pessoa",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        limparTela();
                    }
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
