using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormsCadastro.model
{
    public class Pessoa
    {
        //argumentos
        public string nome { get; set; }
        public string email { get; set; }
        public string telefone { get; set; }

        //método construtor
        public Pessoa(string nome, string email, string telefone)
        {
            this.nome = nome;
            this.email = email;
            this.telefone = telefone;
        }
        public Pessoa()
        {
            this.nome = "";
            this.email = "";
            this.telefone = "";
        }

        public string ToString()
        {
            string retorno = "Nome: " + this.nome + "\n"
                + "E-mail: " + this.email + "\n" +
                "Telefone: " + this.telefone;
            return retorno;
        }
 
    }
}
