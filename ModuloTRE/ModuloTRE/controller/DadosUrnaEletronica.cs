using ModuloTRE.model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ModuloTRE.controller
{
    class DadosUrnaEletronica : PathFile
    {
        //atributo para definir o nome do arquivo txt para salvar dados da Urna Eletronica
        private string arquivo = @"Cadastro\DadosUrnaEletronica.txt";

        //atributos para definir o primeiro e ultimo da celula Candidato
        private UrnaEletronica primeiro, ultimo; 

        //construtor padrao
        public DadosUrnaEletronica()
        {
            //Criando uma lista vazia:
            this.primeiro = new UrnaEletronica();
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
                        let dadosUrnaEletronica = linha.Split(';')
                        select new UrnaEletronica()
                        {
                            Municipio = dadosUrnaEletronica[0],
                            ZonaELeitoral = dadosUrnaEletronica[1],
                            SecaoEleitoral = dadosUrnaEletronica[2],
                        };

                    //percorro toda a consulta para adicionar cada item na lista:
                    foreach (var item in consulta)
                    {
                        this.ultimo.Prox = new UrnaEletronica();
                        this.ultimo = this.ultimo.Prox;

                        this.ultimo.Municipio = item.Municipio;
                        this.ultimo.ZonaELeitoral = item.ZonaELeitoral;
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
        public void insere(UrnaEletronica ue)
        {
            this.ultimo.Prox = new UrnaEletronica();
            this.ultimo = this.ultimo.Prox;

            this.ultimo.Municipio = ue.Municipio;
            this.ultimo.ZonaELeitoral = ue.ZonaELeitoral;
            this.ultimo.SecaoEleitoral = ue.SecaoEleitoral;

            this.ultimo.Prox = null;
        } //fim do método insere

        //método para salvar os dados da Urna Eletronica:
        public void Salvar(UrnaEletronica ue)
        {
            //base.Local = base.Local + arquivo + ".txt";
            //base.Local = Path.Combine(base.Local, arquivo);

            //Caso não tenha o arquivo, crie o mesmo:
            if (!File.Exists(base.Local))
                File.Create(base.Local).Close();

            //salvando o dado no arquivo:
            using (StreamWriter sw = File.AppendText(base.Local))
            {
                sw.Write(ue.Municipio + ";");
                sw.Write(ue.ZonaELeitoral + ";");
                sw.WriteLine(ue.SecaoEleitoral);
                sw.Flush();
            }
            insere(ue); //inserindo o dado na lista
        } //fim do método salvar

        //método para listar os dados da Urna Eletronica:
        public void Listar(ListView lv)
        {
            lv.Items.Clear(); //limpando as dados que estiver na tabela
            UrnaEletronica aux = this.primeiro.Prox; //criando uma instância auxiliar para percorrer a lista 
            while (aux != null)
            {
                ListViewItem tab = new ListViewItem(new string[] { aux.Municipio, aux.ZonaELeitoral, aux.SecaoEleitoral });
                lv.Items.Add(tab);
                aux = aux.Prox;
            }
        } //fim do método listar

        //método para listar o nome da Zona Eleitoral em uma comboBox de acordo com o municipio:
        public void Listar(ComboBox cb, string filtro)
        {
            UrnaEletronica aux = this.primeiro.Prox; //criando uma instância auxiliar para percorrer a lista 
            while (aux != null)
            {
                if (aux.Municipio == filtro)
                    cb.Items.Add(aux.ZonaELeitoral);
                aux = aux.Prox;
            }
        } //fim do método listar

        //método para listar o nome da Secao Eleitoral em uma comboBox de acordo com a zona eleitoral:
        public void Listar(ComboBox cb, string filtro, int op)
        {
            UrnaEletronica aux = this.primeiro.Prox; //criando uma instância auxiliar para percorrer a lista 
            while (aux != null)
            {
                if (aux.ZonaELeitoral == filtro)
                    cb.Items.Add(aux.SecaoEleitoral);
                aux = aux.Prox;
            }
        } //fim do método listar
    }
}
