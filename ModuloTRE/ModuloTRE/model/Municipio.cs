using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuloTRE.model
{
    class Municipio
    {
        private string nome; //atributo que vai receber o nome
        private string estado; //atributo que vai receber o estado
        private int tHabitantes; //atributo que vai receber a quatidade de habitantes
        private int vagasVereador; //atributo que vai receber o número de vagas para vereador
        private Municipio prox; //atributo celula municipio que será usado na lista auto referenciada

        //propriedade para pegar e retornar o Proximo da celula Municipio:
        internal Municipio Prox
        {
            get { return prox; }
            set { prox = value; }
        }

        //propriedade para pegar e retornar o numero de vagas para vereador:
        public int VagasVereador
        {
            get { return (this.vagasVereador); }
            set { this.vagasVereador = value; }
        }

        //propriedade para pegar e retornar a quatidade de habitantes do municipio:
        public int THabitantes
        {
            get { return (this.tHabitantes); }
            set { this.tHabitantes = value; }
        }

        //propriedade para pegar e retornar o estado:
        public string Estado
        {
            get { return (this.estado); }
            set { this.estado = value; }
        }

        //propriedade para pegar e retornar o nome:
        public string Nome
        {
            get { return (this.nome); }
            set { this.nome = value; }
        }
    }
}
