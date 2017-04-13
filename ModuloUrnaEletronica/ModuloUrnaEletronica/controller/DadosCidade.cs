using ModuloUrnaEletronica.model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ModuloUrnaEletronica.controller
{
    class DadosCidade : PathFile
    {
        //atributo para definir o nome do arquivo txt para salvar dados do municipio
        private string arquivo = @"Cadastro\DadosMunicipio.txt";

        //atributos para definir o primeiro e ultimo da celula Municipio
        private Cidade primeiro, ultimo; 
                
        //construtor padrao
        public DadosCidade()
        {
            //Criando uma lista vazia:
            this.primeiro = new Cidade();
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
                        let dadosMunicipio = linha.Split(';')
                        select new Cidade()
                        {
                            Nome = dadosMunicipio[0],
                        };

                    //percorro toda a consulta para adicionar cada item na lista:
                    foreach (var item in consulta)
                    {
                        this.ultimo.Prox = new Cidade();
                        this.ultimo = this.ultimo.Prox;

                        this.ultimo.Nome = item.Nome;

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
            Cidade aux = this.primeiro.Prox; //criando uma instância auxiliar para percorrer a lista 
            while (aux != null)
            {
                cb.Items.Add(aux.Nome);
                aux = aux.Prox;
            }
        } //fim do método listar
    }
}
