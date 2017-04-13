using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ModuloTRE.model
{
    class Votacao
    {
        private string nome; //atributo que vai receber o nome do candidato
        private int numero; //atributo que vai receber o numero do candidato
        private string partido; //atributo que vai receber a sigla do partigo
        private string cargo; //atributo que vai receber o cargo do candidato (p - prefeito, v - vereador)
        private int totalVotos; //atributo que vai receber o  total de votos
        private Votacao prox; //atributo celula votacao que será usado na lista auto referenciada

        //propriedade para pegar e retornar o Proximo da celula votacao:
        internal Votacao Prox
        {
            get { return prox; }
            set { prox = value; }
        }

        //propriedade para pegar e retornar o totalVotos:
        public int TotalVotos
        {
            get { return totalVotos; }
            set { totalVotos = value; }
        }

        //propriedade para pegar e retornar o cargo:
        public string Cargo
        {
            get { return cargo; }
            set { cargo = value; }
        }

        //propriedade para pegar e retornar o partido:
        public string Partido
        {
            get { return partido; }
            set { partido = value; }
        }

        //propriedade para pegar e retornar o numero:
        public int Numero
        {
            get { return numero; }
            set { numero = value; }
        }

        //propriedade para pegar e retornar o nome:
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
    }
}
