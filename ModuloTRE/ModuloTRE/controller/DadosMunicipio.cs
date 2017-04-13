using ModuloTRE.model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ModuloTRE.controller
{
    class DadosMunicipio : PathFile
    {
        //atributo para definir o nome do arquivo txt para salvar dados do municipio
        private string arquivo = @"Cadastro\DadosMunicipio.txt";

        //atributos para definir o primeiro e ultimo da celula Municipio
        private Municipio primeiro, ultimo; 
                
        //construtor padrao
        public DadosMunicipio()
        {
            //Criando uma lista vazia:
            this.primeiro = new Municipio();
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
                        select new Municipio()
                        {
                            Nome = dadosMunicipio[0],
                            Estado = dadosMunicipio[1],
                            THabitantes = Convert.ToInt32(dadosMunicipio[2]),
                            VagasVereador = Convert.ToInt32(dadosMunicipio[3]),
                        };

                    //percorro toda a consulta para adicionar cada item na lista:
                    foreach (var item in consulta)
                    {
                        this.ultimo.Prox = new Municipio();
                        this.ultimo = this.ultimo.Prox;

                        this.ultimo.Nome = item.Nome;
                        this.ultimo.Estado = item.Estado;
                        this.ultimo.THabitantes = item.THabitantes;
                        this.ultimo.VagasVereador = item.VagasVereador;

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
        public void insere(Municipio m)
        {
            this.ultimo.Prox = new Municipio();
            this.ultimo = this.ultimo.Prox;

            this.ultimo.Nome = m.Nome;
            this.ultimo.Estado = m.Estado;
            this.ultimo.THabitantes = m.THabitantes;
            this.ultimo.VagasVereador = m.VagasVereador;

            this.ultimo.Prox = null;
        } //fim do método insere

        //método para salvar os dados do municipio:
        public void Salvar(Municipio m)
        {
            //base.Local = base.Local + arquivo + ".txt";
            //base.Local = Path.Combine(base.Local, arquivo);

            //Caso não tenha o arquivo, crie o mesmo:
            if (!File.Exists(base.Local))
                File.Create(base.Local).Close();

            //salvando o dado no arquivo:
            using (StreamWriter sw = File.AppendText(base.Local))
            {
                sw.Write(m.Nome + ";");
                sw.Write(m.Estado + ";");
                sw.Write(m.THabitantes + ";");
                sw.WriteLine(m.VagasVereador);
                sw.Flush();
            }
            insere(m); //inserindo o dado na lista
        } //fim do método salvar

        //método para listar os dados do municipio:
        public void Listar(ListView lv)
        {
            lv.Items.Clear(); //limpando as dados que estiver na tabela
            Municipio aux = this.primeiro.Prox; //criando uma instância auxiliar para percorrer a lista 
            while (aux != null)
            {
                ListViewItem tab = new ListViewItem(new string[] { aux.Nome, aux.Estado, aux.THabitantes.ToString(), aux.VagasVereador.ToString() });
                lv.Items.Add(tab);
                aux = aux.Prox;
            }
        } //fim do método listar

        //método para listar o nome do municipio em uma comboBox:
        public void Listar(ComboBox cb)
        {
            Municipio aux = this.primeiro.Prox;
            while (aux != null)
            {
                cb.Items.Add(aux.Nome);
                aux = aux.Prox;
            }
        } //fim do método listar

        //método para verificar se a lista esta vazia:
        public bool vazia()
        { return (this.primeiro == this.ultimo); }

        //método para pesquisar a quantidade de vereadores com o parametro municipio:
        public int pesquisa(string municipio)
        {
            if (this.vazia() || municipio == null)
                return 0;
            Municipio aux = this.primeiro;
            while (aux.Prox != null)
            {
                if (aux.Prox.Nome.Equals(municipio))
                    return aux.Prox.VagasVereador;
                aux = aux.Prox;
            }
            return 0;
        } //fim do metodo pesquisa
    }
}
