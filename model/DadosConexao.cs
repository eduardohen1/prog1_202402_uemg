using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormsCadastro.model
{
    public class DadosConexao
    {
        public string servidor { get; set; }
        public string usuario { get; set; }
        public string senha { get; set; }
        public string nomeBD { get; set; }
        public int porta { get; set; }

        //construtor:
        public DadosConexao(string servidor, string usuario, string senha, 
            string nomeBD, int porta)
        {
            this.servidor = servidor;
            this.usuario = usuario;
            this.senha = senha;
            this.nomeBD = nomeBD;
            this.porta = porta;
        }

        public DadosConexao(string servidor, string usuario, string senha,
            string nomeBD)
        {
            this.servidor = servidor;
            this.usuario = usuario;
            this.senha = senha;
            this.nomeBD = nomeBD;
            this.porta = 3306;
        }

        //métodos:
        public string ToString()
        {
            return "Servidor: "   + this.servidor + "\n" +
                   "Usuário: "    + this.usuario  + "\n" +
                   "Senha: "      + this.senha    + "\n" +
                   "Nome do BD: " + this.nomeBD   + "\n" +
                   "Porta: "      + this.porta;
        }

    }
}
