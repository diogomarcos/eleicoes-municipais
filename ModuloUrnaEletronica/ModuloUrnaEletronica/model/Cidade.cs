using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ModuloUrnaEletronica.model
{
    class Cidade
    {
        private string nome; //atributo para pegar o nome
        private Cidade prox; //atributo celula cidade que será usado na lista auto referenciada

        //propriedade para peger e retornar o proximo da celula cidade:
        internal Cidade Prox
        {
            get { return prox; }
            set { prox = value; }
        }

        //propriedade para pegar e retornar o nome:
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
    }
}
