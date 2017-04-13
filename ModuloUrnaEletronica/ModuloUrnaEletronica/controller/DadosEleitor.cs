using ModuloUrnaEletronica.model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ModuloUrnaEletronica.controller
{
    class DadosEleitor : PathFile
    {
        //atributo para definir o nome do arquivo txt para salvar dados do eleitor
        private string arquivo = @"UrnaEletronica\Eleitores\";

        //Propriedade para retornar o Arquivo:
        public string Arquivo
        {
            get { return arquivo; }
        }

        //atributos para definir o primeiro e ultimo da celula Eleitor
        private Eleitor primeiro, ultimo;

        //propridade para retornar o primeiro valor da celula:
        internal Eleitor Primeiro
        { get { return (this.primeiro); } }

        //construtor padrao
        public DadosEleitor()
        {
            //Criando uma lista vazia:
            this.primeiro = new Eleitor();
            this.ultimo = this.primeiro;
            this.primeiro.Prox = null;
        }

        //método para verificar se a lista esta vazia:
        public bool vazia()
        { return (this.primeiro == this.ultimo); }

        //método para pegar os dados do arquivos e inserir na lista:
        public void gerarLista(string texto)
        {
            arquivo += texto; //acrescento no arquivo o atributo recebido como parametro onde contem a cidade, zona e secao eleitoral
            
            base.Local = Path.Combine(base.Local, arquivo); //combinando o local da pasta com o arquivo dos dados salvos

            if (File.Exists(base.Local))
            {
                try
                {
                    //faço uma consulta do tipo sql para guarda os dados que estão nos arquivos:
                    var consulta =
                        from linha in File.ReadAllLines(base.Local)
                        let dadosEleitor = linha.Split(';')
                        select new Eleitor()
                        {
                            Nome = dadosEleitor[0],
                            NumeroTitulo = dadosEleitor[1],
                        };

                    //percorro toda a consulta para adicionar cada item na lista:
                    foreach (var item in consulta)
                    {
                        this.ultimo.Prox = new Eleitor();
                        this.ultimo = this.ultimo.Prox;

                        this.ultimo.NumeroTitulo = item.NumeroTitulo;
                        this.ultimo.Status = "SA"; //por padrão todos irão receber "sem avaliação - SA"

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
        public bool pesquisa(string chave)
        {
            if (this.vazia() || chave == null)
            {
                return (false);
            }
            Eleitor aux = this.primeiro;
            while (aux.Prox != null)
            {
                if (aux.Prox.NumeroTitulo == chave)
                {
                    if (aux.Prox.Status == "CV")
                        return (false);
                    else
                    {
                        aux.Prox.Status = "CV"; //mudando o status de votação do candidato
                        return (true);
                    }
                }
                aux = aux.Prox;
            }
            return (false);
        } //fim do método pesquisa
    }
}
