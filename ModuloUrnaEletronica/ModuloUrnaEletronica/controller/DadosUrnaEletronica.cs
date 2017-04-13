using ModuloUrnaEletronica.model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ModuloUrnaEletronica.controller
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
                            ZonaEleitoral = dadosUrnaEletronica[1],
                            SecaoEleitoral = dadosUrnaEletronica[2],
                        };

                    //percorro toda a consulta para adicionar cada item na lista:
                    foreach (var item in consulta)
                    {
                        this.ultimo.Prox = new UrnaEletronica();
                        this.ultimo = this.ultimo.Prox;

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

        //método para listar o Municipio em uma comboBox:
        public void Listar(ComboBox cb)
        {
            UrnaEletronica aux = this.primeiro.Prox; //criando uma instância auxiliar para percorrer a lista 
            while (aux != null)
            {
                cb.Items.Add(aux.Municipio);
                aux = aux.Prox;
            }
        } //fim do método listar

        //método para listar o nome da Secao Eleitoral em uma comboBox de acordo com a zona eleitoral:
        public void Listar(ComboBox cb, string filtro, int op)
        {
            UrnaEletronica aux = this.primeiro.Prox; //criando uma instância auxiliar para percorrer a lista
            if (op == 1)
            { //se opção igual a 1 irá percorrer a lista e exibir a zona eleitoral
                while (aux != null)
                {
                    if (aux.Municipio == filtro)
                        cb.Items.Add(aux.ZonaEleitoral);
                    aux = aux.Prox;
                }
            }
            else
            { //se opção diferente de 1 irá percorrer a lista e exibir a Secao Eleitoral
                while (aux != null)
                {
                    if (aux.ZonaEleitoral == filtro)
                        cb.Items.Add(aux.SecaoEleitoral);
                    aux = aux.Prox;
                }
            }
        } //fim do método listar        
    }
}
