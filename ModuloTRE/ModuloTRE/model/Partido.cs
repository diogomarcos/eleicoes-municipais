using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuloTRE.model
{
    class Partido
    {
        private string nome; //atributo que vai receber o nome        
        private string sigla; //atributo qeu vai receber a sigla
        private Partido prox; //atributo celula partido que será usado na lista auto referenciada

        //propriedade para pegar e retornar o Proximo da celula Partido:
        internal Partido Prox
        {
            get { return prox; }
            set { prox = value; }
        }

        //propriedade para pegar e retornar o Nome:
        public string Nome
        {
            get { return (this.nome); }
            set { this.nome = value; }
        }

        //propriedade para pegar e retornar a Sigla:
        public string Sigla
        {
            get { return (this.sigla); }
            set { this.sigla = value; }
        }


    }
}
