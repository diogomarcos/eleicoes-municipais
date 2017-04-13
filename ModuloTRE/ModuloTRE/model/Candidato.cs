using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuloTRE.model
{
    class Candidato : Pessoa
    {
        private int numero; //atributo que vai receber o numero do cadidato
        private string partido; //atributo que vai receber a sigla do partigo
        private char cargo; //atributo que vai receber o cargo do candidato (p - prefeito, v - vereador)
        private Candidato prox; //atributo celula candidato que será usado na lista auto referenciada

        //propriedade para pegar e retornar o Proximo da celula candidato:
        internal Candidato Prox
        {
            get { return prox; }
            set { prox = value; }
        }

        //propriedade para pegar e retornar o cargo:
        public char Cargo
        {
            get { return (this.cargo); }
            set { this.cargo = value; }
        }

        //propriedade para pegar e retornar o partido:
        public string Partido
        {
            get { return (this.partido); }
            set { this.partido = value; }
        }

        //propriedade para pegar e retornar o numero do cadidato:
        public int Numero
        {
            get { return this.numero; }
            set { this.numero = value; }
        }
    }
}
