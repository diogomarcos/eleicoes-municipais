using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuloTRE.model
{
    class Eleitor : Pessoa
    {
        private string numeroTitulo; //atributo que vai receber o numero do titulo do eleitor
        private string zonaEleitoral; //atributo que vai receber a zona eleitoral
        private string secaoEleitoral; //atributo que vai receber a secao eleitoral
        private Eleitor prox; //atributo celula eleitor que será usado na lista auto referenciada

        //propriedade que vai pegar e retornar o Proximo da celula eleitor:
        internal Eleitor Prox
        {
            get { return prox; }
            set { prox = value; }
        }

        //propriedade que vai pegar e retornar a secao eleitoral:
        public string SecaoEleitoral
        {
            get { return (this.secaoEleitoral); }
            set { this.secaoEleitoral = value; }
        }

        //propriedade que vai pegar e retornar a zona eleitoral:
        public string ZonaEleitoral
        {
            get { return (this.zonaEleitoral); }
            set { this.zonaEleitoral = value; }
        }

        //propriedade que vai pegar e retornar o numero do titulo do eleitor:
        public string NumeroTitulo
        {
            get { return (this.numeroTitulo); }
            set { this.numeroTitulo = value; }
        }
    }
}
