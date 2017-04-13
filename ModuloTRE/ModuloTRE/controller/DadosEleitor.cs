using ModuloTRE.model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ModuloTRE.controller
{
    class DadosEleitor : PathFile
    {
        //atributo para definir o nome do arquivo txt para salvar dados do eleitor
        private string arquivo = @"Cadastro\DadosEleitor.txt";

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

        //método para pegar os dados do arquivos e inserir na lista:
        public void gerarLista()
        {
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
                            Municipio = dadosEleitor[2],
                            ZonaEleitoral = dadosEleitor[3],
                            SecaoEleitoral = dadosEleitor[4],
                        };

                    //percorro toda a consulta para adicionar cada item na lista:
                    foreach (var item in consulta)
                    {
                        this.ultimo.Prox = new Eleitor();
                        this.ultimo = this.ultimo.Prox;

                        this.ultimo.Nome = item.Nome;
                        this.ultimo.NumeroTitulo = item.NumeroTitulo;
                        this.ultimo.Municipio = item.Municipio;
                        this.ultimo.ZonaEleitoral = item.ZonaEleitoral;
                        this.ultimo.SecaoEleitoral = item.SecaoEleitoral;

                        this.ultimo.Prox = null;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro: " + ex.Message); //caso ocorra algum erro será exibindo no tela a mensagem do mesmo
                }
            }
        } //fim do método gerarLista

        //método para inserir os dados na lista:
        public void insere(Eleitor e)
        {
            this.ultimo.Prox = new Eleitor();
            this.ultimo = this.ultimo.Prox;

            this.ultimo.Nome = e.Nome;
            this.ultimo.NumeroTitulo = e.NumeroTitulo;
            this.ultimo.Municipio = e.Municipio;
            this.ultimo.ZonaEleitoral = e.ZonaEleitoral;
            this.ultimo.SecaoEleitoral = e.SecaoEleitoral;

            this.ultimo.Prox = null;
        } //fim do método insere

        //método para salvar os dados do eleitor:
        public void Salvar(Eleitor e)
        {
            //base.Local = base.Local + arquivo + ".txt";
            //base.Local = Path.Combine(base.Local, arquivo);

            //Caso não tenha o arquivo, crie o mesmo:
            if (!File.Exists(base.Local))
                File.Create(base.Local).Close();

            //salvando o dado no arquivo:
            using (StreamWriter sw = File.AppendText(base.Local))
            {
                sw.Write(e.Nome + ";");
                sw.Write(e.NumeroTitulo + ";");
                sw.Write(e.Municipio + ";");
                sw.Write(e.ZonaEleitoral + ";");
                sw.WriteLine(e.SecaoEleitoral);
                sw.Flush();
            }
            insere(e); //inserindo o dado na lista:
        } //fim do método salvar

        //método para listar os dados do eleitor:
        public void Listar(ListView lv)
        {
            lv.Items.Clear(); //limpando as dados que estiver na tabela
            Eleitor aux = this.primeiro.Prox; //criando uma instância auxiliar para percorrer a lista 
            while (aux != null)
            {
                ListViewItem tab = new ListViewItem(new string[] { aux.Nome, aux.NumeroTitulo, aux.Municipio, aux.ZonaEleitoral, aux.SecaoEleitoral });
                lv.Items.Add(tab);
                aux = aux.Prox;
            }
        } //fim do método listar
    }
}
