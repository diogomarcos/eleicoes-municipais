using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuloTRE.model
{
    class Pessoa
    {
        private string nome; //atributo que vai receber o nome
        private string municipio; //atributo que vai receber o municipio
        
        //propriedade que vai pegar e retornar o municipio:
        public string Municipio
        {
            get { return (this.municipio); }
            set { this.municipio = value; }
        }

        //propriedade que vai pegar e retornar o nome:
        public string Nome
        {
            get { return (this.nome); }
            set { this.nome = value; }
        }
    }
}
