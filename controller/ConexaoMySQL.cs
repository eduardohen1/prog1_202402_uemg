﻿using FormsCadastro.model;
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
                    string strConexao = "Server="   + dadosConexao.servidor   + ";" +
                                        "Database=" + dadosConexao.nomeBD     + ";" +
                                        "Uid="      + dadosConexao.usuario    + ";" +
                                        "Pwd="      + dadosConexao.senha      + ";" +
                                        "Connection Timeout=900;SSL Mode=Required;" +
                                        "Port="     + dadosConexao.porta;
                    conexao = new MySqlConnection(strConexao);
                    conexao.Open(); //conecta no banco!
                    return true;
                }
                catch (Exception ex)
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
        }//conectar

        public bool desconectar()
        {
            try
            {
                if (conexao.State == System.Data.ConnectionState.Open) 
                    conexao.Close();
                return true;
            }catch(Exception ex)
            {
                MessageBox.Show("Erro ao desconectar do banco de dados:\n" +
                                    ex.ToString(),
                                    "Título do APP",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                return false;
            }
        }//desconectar

        public MySqlConnection getConexao()
        {
            return conexao;
        }

        public bool gravarPessoa(Pessoa pessoa)
        {
            string sql = "";
            bool resposta = true;
            MySqlCommand comando;
            try
            {
                if (pessoa.codigo == 0)
                {
                    //insert
                    sql = "INSERT INTO pessoas(nome, email, telefone) " +
                          "VALUES('" + pessoa.nome + "','" + pessoa.email + "','"
                          + pessoa.telefone + "')";
                }
                else
                {
                    //update
                    sql = "UPDATE pessoa SET " +
                            "nome     = '"  + pessoa.nome     + "', " +
                            "email    = '"  + pessoa.email    + "', " +
                            "telefone = '"  + pessoa.telefone + "'  " +
                          "WHERE codigo = " + pessoa.codigo;
                }
                comando = new MySqlCommand(sql, conexao); //instancio a conexao
                comando.ExecuteNonQuery(); //executo a operação - query sem retorno de dados
                comando.Dispose(); //desaloca o comando da memória.
                resposta = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao gravar Pessoas no banco de dados:\n" +
                                   ex.ToString(),
                                   "Título do APP",
                                   MessageBoxButtons.OK,
                                   MessageBoxIcon.Error);
                resposta = false;
            }
            return resposta;
        }

        /// <summary>
        /// Rotina para buscar os dados no banco de dados
        /// </summary>
        /// <param name="id">Código presente no campo txtCodigo</param>
        /// <param name="tipoConsulta">Caractere '>' buscar próximo; Caractere '<' buscar anterior</param>
        /// <returns>Objeto Pessoa em branco ou com dados do Banco de Dados</returns>
        public Pessoa buscar(int id, string tipoConsulta)
        {
            Pessoa pessoa = new Pessoa();
            string sql = "";
            MySqlCommand comando;
            MySqlDataReader dataReader;

            try
            {
                sql = "SELECT * FROM pessoas ";
                if (tipoConsulta.Equals("<"))
                {
                    sql += " WHERE id < " + id + " ORDER BY id DESC LIMIT 1";
                }
                else
                {
                    sql += " WHERE id > " + id + " ORDER BY id ASC LIMIT 1";
                }
                comando = new MySqlCommand(sql, conexao);
                dataReader = comando.ExecuteReader(); //query com retorno de dados (tabela)
                if (dataReader.HasRows) //verifico se o dataRead tem dados/linhas
                {
                    while(dataReader.Read())//leio as linhas individualmente
                    {
                        pessoa.nome     = dataReader["nome"].ToString();
                        pessoa.email    = dataReader["email"].ToString();
                        pessoa.telefone = dataReader["telefone"].ToString();
                        pessoa.codigo = int.Parse(dataReader["id"].ToString());
                    }
                }
                //desaloco da memória
                dataReader.Dispose();
                dataReader.Close();
                comando.Dispose();                
            }catch(Exception ex)
            {
                MessageBox.Show("Erro ao buscar Pessoa no banco de dados (id=" + id + "):\n" +
                                   ex.ToString(),
                                   "Título do APP",
                                   MessageBoxButtons.OK,
                                   MessageBoxIcon.Error);
            }
            return pessoa;
        }

        public bool deletar(int id)
        {
            bool resposta = false;
            MySqlCommand comando;
            string sql = "DELETE FROM pessoas WHERE id = " + id;
            try
            {
                comando = new MySqlCommand(sql, conexao);
                comando.ExecuteNonQuery(); //executar o comando sem retorno
                comando.Dispose();
                resposta = true;
            }catch(Exception ex)
            {
                MessageBox.Show("Erro ao excluir Pessoa no banco de dados (id=" + id + "):\n" +
                                   ex.ToString(),
                                   "Título do APP",
                                   MessageBoxButtons.OK,
                                   MessageBoxIcon.Error);
                resposta = false;
            }
            return resposta;
        }

    }
}
