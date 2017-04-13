using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ModuloTRE.model
{
    class Justificativa
    {
        private string numeroTitulo; //atributo que vai receber o numero do Titulo do Eleitor
        private string nome; //atributo que vai receber o nome do Eleitor
        private string justificar; //atritubo que vai receber a justificativa
        private Justificativa prox; //atributo celula Justificativa que será usado na lista auto referenciada

        //propriedade que vai pegar e retornar o Proximo da celula Justificativa:
        internal Justificativa Prox
        {
            get { return prox; }
            set { prox = value; }
        }

        //propriedade que vai pegar e retornar o Justificar:
        public string Justificar
        {
            get { return justificar; }
            set { justificar = value; }
        }

        //propriedade que vai pegar e retornar o Nome:
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        //propriedade que vai pegar e retornar o Numero do Titulo:
        public string NumeroTitulo
        {
            get { return numeroTitulo; }
            set { numeroTitulo = value; }
        }
    }
}
