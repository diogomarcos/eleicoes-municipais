using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuloUrnaEletronica.model
{
    class Candidato
    {
        private string nome; //atributo que vai receber o nome do candidato        
        private int numero; //atributo que vai receber o numero do candidato
        private string partido; //atributo que vai receber a sigla do partigo
        private char cargo; //atributo que vai receber o cargo do candidato (p - prefeito, v - vereador)
        private string municipio; //atributo que vai receber o municipio
        private int totalVotos; //atributo que vai receber o  total de votos
        
        private Candidato prox; //atributo celula candidato que será usado na lista auto referenciada

        //propriedade para pegar e retornar o Proximo da celula candidato:
        internal Candidato Prox
        {
            get { return prox; }
            set { prox = value; }
        }

        //propriedade para pegar e retornar o total de Votos:
        public int TotalVotos
        {
            get { return totalVotos; }
            set { totalVotos = value; }
        }

        //propriedade para pegar e retornar o nome:
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        //propriedade para pegar e retornar o municipio:
        public string Municipio
        {
            get { return municipio; }
            set { municipio = value; }
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
