using ModuloUrnaEletronica.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ModuloUrnaEletronica.controller
{
    class DadosJustificativa
    {
        //atributos para definir o primeiro e ultimo da celula Candidato
        private Justificativa primeiro, ultimo;

        //propridade para retornar o primeiro valor da celula:
        internal Justificativa Primeiro
        { get { return (this.primeiro); } } 

        //construtor padrao
        public DadosJustificativa()
        {
            //Criando uma lista vazia:
            this.primeiro = new Justificativa();
            this.ultimo = this.primeiro;
            this.primeiro.Prox = null;
        }

        //método para verificar se a lista esta vazia:
        public bool vazia()
        { return (this.primeiro == this.ultimo); }

        //método para inserir os dados na lista:
        public void insere(Justificativa c)
        {
            this.ultimo.Prox = new Justificativa();
            this.ultimo = this.ultimo.Prox;

            this.ultimo.Nome = c.Nome;
            this.ultimo.NumeroTitulo = c.NumeroTitulo;
            this.ultimo.Justificar = c.Justificar;

            this.ultimo.Prox = null;
        } //fim do método insere
    }
}
