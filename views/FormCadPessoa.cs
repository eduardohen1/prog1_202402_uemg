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

        //botão de excluir
        private void button2_Click(object sender, EventArgs e)
        {
            if (int.Parse(txtCodigo.Text) > 0)
            {
                if (
                    MessageBox.Show("Deseja realmente excluir esse registro?",
                                    "Título APP",
                                    MessageBoxButtons.YesNo,
                                    MessageBoxIcon.Question) == DialogResult.Yes
                    )
                {
                    if (conexaoMySQL.deletar(int.Parse(txtCodigo.Text)))
                    {
                        MessageBox.Show("Dados deletados com sucesso!",
                                        "Título APP",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);
                        limparTela();
                    }
                }
                else
                {
                    MessageBox.Show("Os dados não foram deletados!",
                                    "Título APP",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                }
            }
        }

        private void btnPosterior_Click(object sender, EventArgs e)
        {
            if (txtCodigo.Text.Length == 0)
                txtCodigo.Text = "0";

            int id = int.Parse(txtCodigo.Text);
            try
            {
                Pessoa pessoa = conexaoMySQL.buscar(id, ">");
                if (pessoa.codigo > 0)
                {
                    txtCodigo.Text = pessoa.codigo.ToString();
                    txtNome.Text = pessoa.nome;
                    txtEmail.Text = pessoa.email;
                    txtTelefone.Text = pessoa.telefone;
                }
                else
                {
                    limparTela();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message, "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            if (txtCodigo.Text.Length == 0)
                txtCodigo.Text = "0";

            int id = int.Parse(txtCodigo.Text);
            try
            {
                Pessoa pessoa = conexaoMySQL.buscar(id, "<");
                if (pessoa.codigo > 0)
                {
                    txtCodigo.Text = pessoa.codigo.ToString();
                    txtNome.Text = pessoa.nome;
                    txtEmail.Text = pessoa.email;
                    txtTelefone.Text = pessoa.telefone;
                }
                else
                {
                    limparTela();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message, "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            limparTela();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
