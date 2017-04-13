using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuloTRE.model
{
    class UrnaEletronica
    {
        private string municipio; //atributo que vai receber o municipio
        private string zonaELeitoral; //atributo que vai receber a zona eleitoral
        private string secaoEleitoral; //atributo que vai receber a secao eleitoral
        private UrnaEletronica prox; //atributo celula UrnaEletronica que será usado na lista auto referenciada

        //propriedade que vai pegar e retornar o Proximo da celula Urna Eletronica:
        internal UrnaEletronica Prox
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
        public string ZonaELeitoral
        {
            get { return (this.zonaELeitoral); }
            set { this.zonaELeitoral = value; }
        }

        //propriedade que vai pegar e retornar o municipio:
        public string Municipio
        {
            get { return (this.municipio); }
            set { this.municipio = value; }
        }
    }
}
