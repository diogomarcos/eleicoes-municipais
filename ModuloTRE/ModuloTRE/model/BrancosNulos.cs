using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ModuloTRE.model
{
    class BrancosNulos
    {
        private int brancos; //atributo que vai receber a contagem de votos em brancos
        private int nulos; //atributo que vai receber a contagem de votos nulos
        
        //propriedade que vai receber e retornar os votos em brancos:
        public int Brancos
        {
            get { return brancos; }
            set { brancos = value; }
        }
        
        //propriedade que vai receber e retornar os votos nulos:
        public int Nulos
        {
            get { return nulos; }
            set { nulos = value; }
        }
    }
}
