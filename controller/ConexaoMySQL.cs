using FormsCadastro.model;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormsCadastro.controller
{
    public class ConexaoMySQL
    {
        MySqlConnection conexao = new MySqlConnection();
        DadosConexao dadosConexao;

        public ConexaoMySQL(DadosConexao dadosConexao)
        {
            this.dadosConexao = dadosConexao;
        }

        public bool conectar()
        {
            if (dadosConexao != null)
            {
                try
                {
                    string strConexao = "Server=" + dadosConexao.servidor + ";" +
                                        "Database=" + dadosConexao.nomeBD + ";" +
                                        "Uid=" + dadosConexao.usuario + ";" +
                                        "Pwd=" + dadosConexao.senha + ";" +
                                        "Connection Timeout=900;SSL Mode=Required;" +
                                        "Port=" + dadosConexao.porta;
                    conexao = new MySqlConnection(strConexao);
                    conexao.Open();
                    return true;
                }catch(Exception ex)
                {
                    MessageBox.Show("Erro ao conectar no banco de dados:\n" +
                                    ex.ToString(),
                                    "Título do APP",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                    return false;
                }
            }
            else
            {
                MessageBox.Show("Dados de conexão com o banco de dados vazio. Verifique!",
                                    "Título do APP",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                return false;
            }

    }
}
