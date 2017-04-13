using ModuloTRE.model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ModuloTRE.controller
{
    class DadosVereador : PathFile
    {
        //atributos para definir o primeiro e ultimo da celula Votacao para vereador
        private Votacao primeiro, ultimo;

        private string subDir = @"Apuracao\"; //atributo com o local do sub-diretorio
        private string arqVotacoes = "_Votacoes.txt"; //atributo com o nome para o arquivo votar
        private string arqBrancosNulos = "_BrancoNulo.txt"; //atributo com o nome para o arquivo

        private int cont;//atributo para fazer a contagem da posição da tabela
        private int votosValidos;//atributo para fazer a contagem dos votos validos
        private int votosBrancos;//atributo para fazer a contagem dos votos em brancos
        private int votosNulos;//atributo para fazer a contagem dos votos Nulos:
        

        internal Votacao Ultimo
        {
            get { return ultimo; }
            set { ultimo = value; }
        }

        internal Votacao Primeiro
        {
            get { return primeiro; }
            set { primeiro = value; }
        }

        //construtor padrao
        public DadosVereador()
        {
            //Criando uma lista vazia:
            this.primeiro = new Votacao();
            this.ultimo = this.primeiro;
            this.primeiro.Prox = null;
        }

        //método para verificar se a lista esta vazia:
        public bool vazia()
        { return (this.primeiro == this.ultimo); }

        //método para pegar os dados do arquivo e inserir na lista:
        public void gerarLista(string municipio)
        {
            cont = 1; //começando a contagem da posição com 1;
            votosValidos = 0; //zerando a contagem dos votos validos
            votosBrancos = 0; //zerando a contagem dos votos em brancos
            votosNulos = 0; //zerando a contagem dos votos nulos

            //criando auxiliares para percorrerem as listas:
            Votacao aux = null;
            Votacao temp = null;

            //atributos com os nomes dos arquivos:
            string votacoes = base.Local + subDir + municipio + @"\" + municipio + arqVotacoes;
            string brancosNulos = base.Local + subDir + municipio + @"\" + municipio + arqBrancosNulos;

            if (File.Exists(votacoes))
            {
                try
                {
                    //faço uma consulta do tipo sql para guarda os dados que estão nos arquivos:
                    var consulta =
                        from linha in File.ReadAllLines(votacoes)
                        let dadosVereador = linha.Split(';')
                        select new Votacao()
                        {
                            Nome = dadosVereador[0],
                            Numero = Convert.ToInt32(dadosVereador[1]),
                            Partido = dadosVereador[2],
                            Cargo = dadosVereador[3],
                            TotalVotos = Convert.ToInt32(dadosVereador[4])
                        };
                    //percorro toda a consulta para adicionar cada item na lista:
                    foreach (var item in consulta)
                    {
                        if (item.Cargo == "V")
                        {
                            if (this.vazia())
                            {
                                this.ultimo.Prox = new Votacao();
                                this.ultimo = this.ultimo.Prox;

                                this.ultimo.Nome = item.Nome;
                                this.ultimo.Numero = item.Numero;
                                this.ultimo.Partido = item.Partido;
                                this.ultimo.Cargo = "Vereador";
                                this.ultimo.TotalVotos = item.TotalVotos;

                                votosValidos += item.TotalVotos; //realizando a contagem de votos validos

                                this.ultimo.Prox = null;
                            }
                            else
                            {
                                aux = this.primeiro;

                                //pesquisa o item desejado:
                                while ((aux.Prox != null) && (Convert.ToInt32(aux.Prox.TotalVotos) > Convert.ToInt32(item.TotalVotos)))
                                {
                                    aux = aux.Prox;
                                }

                                if (aux.Prox != null)
                                {
                                    temp = aux.Prox;
                                    aux.Prox = new Votacao();

                                    aux.Prox.Nome = item.Nome; //copia o item a ser inserido nesta nova célula
                                    aux.Prox.Numero = item.Numero; //copia o item a ser inserido nesta nova célula
                                    aux.Prox.Partido = item.Partido; //copia o item a ser inserido nesta nova célula
                                    aux.Prox.Cargo = "Vereador"; //copia o item a ser inserido nesta nova célula
                                    aux.Prox.TotalVotos = item.TotalVotos; //copia o item a ser inserido nesta nova célula 

                                    votosValidos += item.TotalVotos; //realizando a contagem de votos validos

                                    aux.Prox.Prox = temp; //faz a nova célula apontar para a seguinte célula
                                }
                                else
                                {
                                    this.ultimo.Prox = new Votacao();
                                    this.ultimo = this.ultimo.Prox;

                                    this.ultimo.Nome = item.Nome;
                                    this.ultimo.Numero = item.Numero;
                                    this.ultimo.Partido = item.Partido;
                                    this.ultimo.Cargo = "Vereador";

                                    this.ultimo.TotalVotos = item.TotalVotos;

                                    votosValidos += item.TotalVotos; //realizando a contagem de votos validos

                                    this.ultimo.Prox = null;
                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro: " + ex.Message); //caso ocorra algum erro será exibindo no tela a mensagem do mesmo
                }
            }

            if (File.Exists(brancosNulos))
            {
                try
                {
                    //faço uma consulta do tipo sql para guarda os dados que estão nos arquivos:
                    var consulta =
                        from linha in File.ReadAllLines(brancosNulos)
                        let dadosBrancosNulos = linha.Split(';')
                        select new BrancosNulos()
                        {
                            Brancos = Convert.ToInt32(dadosBrancosNulos[0]),
                            Nulos = Convert.ToInt32(dadosBrancosNulos[1]),
                        };
                    //percorro toda a consulta para adicionar cada item na lista:
                    foreach (var item in consulta)
                    {
                        votosBrancos += item.Brancos; //realizando a contagem de votos em brancos
                        votosNulos += item.Nulos; //realizando a contagem de votos nulos
                        votosValidos += votosBrancos; //realizando a contagem de votos validos
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro: " + ex.Message); //caso ocorra algum erro será exibindo no tela a mensagem do mesmo
                }

                Acao.MsgSalvo();
            }
        } //fim do método gerarLista

        //método para listar os dados da votacao recursivo:
        public void Listar(ListView lv, Votacao aux)
        {
            ListViewItem tab; //atributo que vai receber os dados de cada posição da lista

            //condição de parada:
            if (aux.Prox == null)
            {
                //adicionando os valores no atributo:
                tab = new ListViewItem(new string[] { cont.ToString(), aux.Nome, aux.Numero.ToString(), aux.Partido, aux.TotalVotos.ToString(), (100 * aux.TotalVotos / votosValidos) + "%" });
                lv.Items.Add(tab); //adicionando os dados na tabela
                return; //usado para dar fim ao loop
            }

            //adicionando os valores no atributo:
            tab = new ListViewItem(new string[] { cont.ToString(), aux.Nome, aux.Numero.ToString(), aux.Partido, aux.TotalVotos.ToString(), (100 * aux.TotalVotos / votosValidos) + "%" });
            lv.Items.Add(tab); //adicionando os dados na tabela
            cont++; //criando a posição que irá ficar na tabela
            Listar(lv, aux.Prox); //fazendo a chamada recursiva
        } //fim do método listar

        //método para listar os dados da Apuracao dinamico:
        public void Listar(ListView lv)
        {
            lv.Items.Clear(); //limpando as dados que estiver na tabela
            Votacao aux = this.primeiro.Prox; //criando uma instância auxiliar para percorrer a lista 
            while (aux != null)
            {
                ListViewItem tab = new ListViewItem(new string[] { cont.ToString(), aux.Nome, aux.Numero.ToString(), aux.Partido, aux.TotalVotos.ToString(), (100 * aux.TotalVotos / votosValidos) + "%" });
                lv.Items.Add(tab);
                aux = aux.Prox;
                cont++;
            }
        } //fim do método listar

        //método para limpar e criar uma nova celula:
        public void limpar()
        {
            if (!this.vazia())
            {
                this.primeiro = new Votacao();
                this.ultimo = this.primeiro;
                this.primeiro.Prox = null;
            }
        } //fim do método limpar

        public void resultado(RichTextBox txt, Votacao candidato, string linha)
        {
            string resultado = null;
            resultado = "Nome: " + candidato.Nome + "\n" +
                    "Numero: " + candidato.Numero + "\n" +
                    "Partido: " + candidato.Partido + "\n" +
                    "Total de Votos: " + candidato.TotalVotos + "\n" +
                    "Porcetagem de Votos: " + linha + "\n\n";

            txt.Text += resultado;
        }
    }
}
