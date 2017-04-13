using ModuloTRE.model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ModuloTRE.controller
{
    class DadosPartido : PathFile
    {
        //atributo para definir o nome do arquivo txt para salvar dados do partido
        private string arquivo = @"Cadastro\DadosPartido.txt";

        //atributos para definir o primeiro e ultimo da celula Partido
        private Partido primeiro, ultimo; 

        //construtor padrao
        public DadosPartido()
        {
            //Criando uma lista vazia:
            this.primeiro = new Partido();
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
                        let dadosPartido = linha.Split(';')
                        select new Partido()
                        {
                            Nome = dadosPartido[0],
                            Sigla = dadosPartido[1],
                        };

                    //percorro toda a consulta para adicionar cada item na lista:
                    foreach (var item in consulta)
                    {
                        this.ultimo.Prox = new Partido();
                        this.ultimo = this.ultimo.Prox;

                        this.ultimo.Nome = item.Nome;
                        this.ultimo.Sigla = item.Sigla;

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
        public void insere(Partido p)
        {
            this.ultimo.Prox = new Partido();
            this.ultimo = this.ultimo.Prox;

            this.ultimo.Nome = p.Nome;
            this.ultimo.Sigla = p.Sigla;

            this.ultimo.Prox = null;
        } //fim do método insere

        //método para salvar os dados do partido:
        public void Salvar(Partido p)
        {
            //base.Local = base.Local + arquivo + ".txt";
            //base.Local = Path.Combine(base.Local, arquivo);

            //Caso não tenha o arquivo, crie o mesmo:
            if (!File.Exists(base.Local))
                File.Create(base.Local).Close();

            //salvando o dado no arquivo:
            using (StreamWriter sw = File.AppendText(base.Local))
            {
                sw.Write(p.Nome + ";");
                sw.WriteLine(p.Sigla);
                sw.Flush();
            }
            insere(p); //inserindo o dado na lista
        } //fim do método salvar

        //método para listar os dados do partido:
        public void Listar(ListView lv)
        {
            lv.Items.Clear(); //limpando as dados que estiver na tabela
            Partido aux = this.primeiro.Prox; //criando uma instância auxiliar para percorrer a lista 
            while (aux != null)
            {
                ListViewItem tab = new ListViewItem(new string[] { aux.Nome, aux.Sigla });
                lv.Items.Add(tab);
                aux = aux.Prox;
            }
        } //fim do método listar

        //método para listar a sigla do partido em uma comboBox:
        public void Listar(ComboBox cb)
        {
            Partido aux = this.primeiro.Prox; //criando uma instância auxiliar para percorrer a lista 
            while (aux != null)
            {
                cb.Items.Add(aux.Sigla);
                aux = aux.Prox;
            }
        } //fim do método listar
    }
}
