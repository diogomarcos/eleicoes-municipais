using ModuloUrnaEletronica.model;
using ModuloUrnaEletronica.controller;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ModuloUrnaEletronica.controller
{
    class DadosCandidato : PathFile
    {
        //atributo para definir o nome do arquivo txt para salvar dados do candidato
        private string arquivo = @"UrnaEletronica\Candidatos\";

        //Propriedade para retornar o Arquivo:
        public string Arquivo
        {
            get { return arquivo; }
        }

        //atributos para definir o primeiro e ultimo da celula Candidato
        private Candidato primeiro, ultimo;

        //propridade para retornar o primeiro valor da celula:
        internal Candidato Primeiro
        { get { return (this.primeiro); } } 

        //construtor padrao
        public DadosCandidato()
        {
            //Criando uma lista vazia:
            this.primeiro = new Candidato();
            this.ultimo = this.primeiro;
            this.primeiro.Prox = null;
        }

        //método para verificar se a lista esta vazia:
        public bool vazia()
        { return (this.primeiro == this.ultimo); }

        //método para pegar os dados do arquivos e inserir na lista:
        public void gerarLista(string texto)
        {
            arquivo += texto; //acrescento no arquivo o atributo recebido como parametro onde contem a cidade
            base.Local = Path.Combine(base.Local, arquivo); //combinando o local da pasta com o arquivo dos dados salvos

            if (File.Exists(base.Local))
            {
                try
                {
                    //faço uma consulta do tipo sql para guarda os dados que estão nos arquivos:
                    var consulta =
                        from linha in File.ReadAllLines(base.Local)
                        let dadosCandidato = linha.Split(';')
                        select new Candidato()
                        {
                            Nome = dadosCandidato[0],
                            Numero = Convert.ToInt32(dadosCandidato[1]),
                            Municipio = dadosCandidato[2],
                            Partido = dadosCandidato[3],
                            Cargo = Convert.ToChar(dadosCandidato[4]),
                        };

                    //percorro toda a consulta para adicionar cada item na lista:
                    foreach (var item in consulta)
                    {
                        this.ultimo.Prox = new Candidato();
                        this.ultimo = this.ultimo.Prox;

                        this.ultimo.Nome = item.Nome;
                        this.ultimo.Numero = item.Numero;
                        this.ultimo.Municipio = item.Municipio;
                        this.ultimo.Partido = item.Partido;
                        this.ultimo.Cargo = item.Cargo;
                        this.ultimo.TotalVotos = 0; //por padrão todos o candidatos recebe 0 votos

                        this.ultimo.Prox = null;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro: " + ex.Message); //caso ocorra algum erro será exibindo no tela a mensagem do mesmo
                }
            }
        } //fim do método gerarLista   

        //método para pesquisar o candidato na lista
        public Candidato pesquisa(int chave)
        {
            if (this.vazia() || chave == 0)
                return null;
            Candidato aux = this.primeiro;
            while (aux.Prox != null)
            {
                if (aux.Prox.Numero.Equals(chave))
                    return aux.Prox;
                aux = aux.Prox;
            }
            return null;
        } //fim do método pesquisa

        //método para pesquisar o candidato na lista
        public bool pesquisa(int chave, int op)
        {
            if (this.vazia() || chave == 0)
                return false;
            Candidato aux = this.primeiro;
            while (aux.Prox != null)
            {
                if (aux.Prox.Numero.Equals(chave))
                {
                    aux.Prox.TotalVotos += 1; //fazendo a contagem de votos
                    return true;
                }
                aux = aux.Prox;
            }
            return false;
        } //fim do método pesquisa
    }
}
