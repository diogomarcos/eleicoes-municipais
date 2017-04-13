using ModuloTRE.model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ModuloTRE.controller
{
    class DadosJustificativa : PathFile
    {
        //atributos para definir o primeiro e ultimo da celula Candidato
        private Justificativa primeiro, ultimo;

        private string subDir = @"Apuracao\"; //atributo com o local do sub-diretorio
        private string arqJustificativas = "_Justificativa.txt"; //atributo com o nome para o arquivo justificar

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

        //método para limpar e criar uma nova celula:
        public void limpar()
        {
            if (!this.vazia())
            {
                this.primeiro = new Justificativa();
                this.ultimo = this.primeiro;
                this.primeiro.Prox = null;
            }
        } //fim do método limpar

        //método para pegar os dados do arquivo e inserir na lista:
        public void gerarLista(string municipio)
        {
            //atributo com o nomes do arquivo:
            string justificativas = base.Local + subDir + municipio + @"\" + municipio + arqJustificativas;

            if (File.Exists(justificativas))
            {
                try
                {
                    //faço uma consulta do tipo sql para guarda os dados que estão nos arquivos:
                    var consulta =
                        from linha in File.ReadAllLines(justificativas)
                        let dadosJustificativa = linha.Split(';')
                        select new Justificativa()
                        {
                            NumeroTitulo = dadosJustificativa[0],
                            Nome = dadosJustificativa[1],
                            Justificar = dadosJustificativa[2],

                        };

                    //percorro toda a consulta para adicionar cada item na lista:
                    foreach (var item in consulta)
                    {
                        this.ultimo.Prox = new Justificativa();
                        this.ultimo = this.ultimo.Prox;

                        this.ultimo.NumeroTitulo = item.NumeroTitulo;
                        this.ultimo.Nome = item.Nome;
                        this.ultimo.Justificar = item.Justificar;

                        this.ultimo.Prox = null;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro: " + ex.Message); //caso ocorra algum erro será exibindo no tela a mensagem do mesmo
                }
            }
        }

        //método para listar os dados das Justificativas:
        public void Listar(ListView lv)
        {
            lv.Items.Clear(); //limpando as dados que estiver na tabela
            Justificativa aux = this.primeiro.Prox; //criando uma instância auxiliar para percorrer a lista 
            while (aux != null)
            {
                ListViewItem tab = new ListViewItem(new string[] { aux.Nome, aux.NumeroTitulo.ToString(), aux.Justificar });
                lv.Items.Add(tab);
                aux = aux.Prox;
            }
        } //fim do método listar
    }
}
