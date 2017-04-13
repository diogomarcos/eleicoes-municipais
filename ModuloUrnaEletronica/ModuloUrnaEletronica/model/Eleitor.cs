using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ModuloUrnaEletronica.model
{
    class Eleitor
    {
        private string nome; //atributo que vai receber o nome o eleitor
        private string numeroTitulo; //atributo que vai receber o numero do titulo do eleitor
        private string status; //atributo que vai receber o status da votação do eleitor        
        private Eleitor prox; //atributo celula eleitor que será usado na lista auto referenciada

        //propriedade que vai pegar e retornar o Proximo da celula eleitor:
        internal Eleitor Prox
        {
            get { return prox; }
            set { prox = value; }
        }

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        //propriedade que vai pegar e retornar o numero do titulo do eleitor:
        public string NumeroTitulo
        {
            get { return (this.numeroTitulo); }
            set { this.numeroTitulo = value; }
        }

        /*
         * propriedade que vai pegar e retornar o status da votação do eleitor
         * onde: 
         *  - status CV = Voto confirmado
         *  - status SA = Sem avaliação, ou seja não compareceu para realizar a votação  
         */
        public string Status
        {
            get { return status; }
            set { status = value; }
        }
    }
}
