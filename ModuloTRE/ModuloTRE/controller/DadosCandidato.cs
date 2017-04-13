using ModuloTRE.model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ModuloTRE.controller
{
    class DadosCandidato : PathFile
    {
        //atributo para definir o nome do arquivo txt para salvar dados do candidato
        private string arquivo = @"Cadastro\DadosCandidato.txt";

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
        public void insere(Candidato c)
        {
            this.ultimo.Prox = new Candidato();
            this.ultimo = this.ultimo.Prox;

            this.ultimo.Nome = c.Nome;
            this.ultimo.Numero = c.Numero;
            this.ultimo.Municipio = c.Municipio;
            this.ultimo.Partido = c.Partido;
            this.ultimo.Cargo = c.Cargo;

            this.ultimo.Prox = null;
        } //fim do método insere

        //método para salvar os dados do candidato:
        public void Salvar(Candidato c)
        {
            //Caso não tenha o arquivo, crie o mesmo:
            if (!File.Exists(base.Local))
                File.Create(base.Local).Close();

            //salvando o dado no arquivo:
            using (StreamWriter sw = File.AppendText(base.Local))
            {
                sw.Write(c.Nome + ";");
                sw.Write(c.Numero + ";");
                sw.Write(c.Municipio + ";");
                sw.Write(c.Partido + ";");
                sw.WriteLine(c.Cargo);
                sw.Flush();
            }
            insere(c); //inserindo o dado na lista
        } //fim do método salvar

        //método para listar os dados do candidato:
        public void Listar(ListView lv)
        {
            lv.Items.Clear(); //limpando as dados que estiver na tabela
            Candidato aux = this.primeiro.Prox; //criando uma instância auxiliar para percorrer a lista 
            while (aux != null)
            {
                ListViewItem tab = new ListViewItem(new string[] { aux.Nome, aux.Numero.ToString(), aux.Municipio, aux.Partido, aux.Cargo.ToString() });
                lv.Items.Add(tab);
                aux = aux.Prox;
            }
        } //fim do método listar        
    }
}
