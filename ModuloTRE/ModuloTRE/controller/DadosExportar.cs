using ModuloTRE.model;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ModuloTRE.controller
{
    class DadosExportar : PathFile
    {
        //DadosEleitor de = new DadosEleitor(); //instanciando a classe dadosEleitor
        //DadosCandidato dc = new DadosCandidato(); //instanciando a  classe dadosCandidato
        private string novoArquivo = null; //atributo para o nome do novo arquivo
        private string subDir = @"UrnaEletronica\"; //atributo com o local do sub-diretorio
        private DialogResult resp; //atributo para pegar a resposta do messagebox

        //método para abrir a pasta onde estão sendo salvos os arquivos:
        public void Abrir()
        { Process.Start(base.Local + subDir); }

        //método para salvar a exportação dos eleitores de acordo com o urna eletronica:
        public void Salvar(string municipio, string zona, string secao, DadosEleitor de)
        {
            novoArquivo = base.Local;
            base.Local = Path.Combine(base.Local, de.Arquivo); //combinando o local da pasta com o arquivo dos dados salvos

            //criando o diretorio do municipio:
            novoArquivo = novoArquivo + subDir + @"Eleitores\" + municipio;
            Directory.CreateDirectory(novoArquivo);

            //Nome do arquivo que será criado de acordo com o municipio, zona e secao:
            //O pardão do arquivo é nome do municipio mais 'z' que representa o zona juntamente  com numero, mais 's' como seção juntamente com numero do mesmo.
            novoArquivo = novoArquivo + @"\"+ municipio + "_z" + zona + "s" + secao + ".txt";

            Eleitor aux = de.Primeiro.Prox; //criando uma instância auxiliar para percorrer a lista
            //verifica que o arquivo já existe:
                if (File.Exists(novoArquivo))
                {
                    //se o arquivo já existe exibe uma mensagem para confirmar se quer atualizar o mesmo:
                    resp = MessageBox.Show("O Arquivo já existe! Deseja Atualizar o mesmo?", "Arquivo Existente", MessageBoxButtons.YesNo);

                    //se o resp for true então o arquivo é sobrescrito:
                    if (resp == DialogResult.Yes)
                    {
                        using (StreamWriter sw = new StreamWriter(novoArquivo))
                        {
                            //percorro toda a lista para adicionar o Numero o titulo no arquivo:
                            while (aux != null)
                            {
                                if ((municipio == aux.Municipio) && (zona == aux.ZonaEleitoral) && (secao == aux.SecaoEleitoral))
                                {
                                    sw.Write(aux.Nome + ";");
                                    sw.WriteLine(aux.NumeroTitulo);
                                }
                                aux = aux.Prox;
                            }
                        }
                    }
                    MessageBox.Show("Dados Exportados com sucesso", "Confirmação"); //Mensagem de confirmação
                }
                else //se o arquivo não existe, é criado o mesmo, e os dados é salvado
                {
                    File.Create(novoArquivo).Close();

                    using (StreamWriter sw = File.AppendText(novoArquivo))
                    {
                        //percorro toda a lista para adicionar o Numero o titulo no arquivo:
                        while (aux != null)
                        {
                            if ((municipio == aux.Municipio) && (zona == aux.ZonaEleitoral) && (secao == aux.SecaoEleitoral))
                            {
                                sw.Write(aux.Nome + ";");
                                sw.WriteLine(aux.NumeroTitulo);
                            }
                            aux = aux.Prox;
                        }
                    }
                    MessageBox.Show("Dados Exportados com sucesso", "Confirmação"); //Mensagem de confirmação
                }     
        } //fim do método salvar

        //método para salvar a exportação dos candidatos de acordo com o urna eletronica:
        public void Salvar(string municipio, DadosCandidato dc)
        {
            novoArquivo = base.Local;
            novoArquivo = novoArquivo + subDir + @"Candidatos\"; //definindo o local onde os arquivos dos candidatos serão salvos
            base.Local = Path.Combine(base.Local, dc.Arquivo); //combinando o local da pasta com o arquivo dos dados salvos
            
            //Nome do arquivo que será criado de acordo com o cidade:
            Directory.CreateDirectory(novoArquivo);//criando o diretorio prefeitos caso não exista

            novoArquivo = novoArquivo + municipio + ".txt"; //cria o arquivo no diretorio em questão

            Candidato aux = dc.Primeiro.Prox; //criando uma instância auxiliar para percorrer a lista

            //verifica que o arquivo já existe:
            if (File.Exists(novoArquivo))
            {
                //se o arquivo já existe exibe uma mensagem para confirmar se quer atualizar o mesmo:
                resp = MessageBox.Show("O Arquivo já existe! Deseja Atualizar o mesmo?", "Arquivo Existente", MessageBoxButtons.YesNo);

                //se o resp for true então o arquivo é sobrescrito:
                if (resp == DialogResult.Yes)
                {
                    using (StreamWriter sw = new StreamWriter(novoArquivo))
                    {
                        //percorro toda a lista para adicionar o Numero o titulo no arquivo:
                        while (aux != null)
                        {
                            if ((municipio == aux.Municipio))
                            {
                                sw.Write(aux.Nome + ";");
                                sw.Write(aux.Numero + ";");
                                sw.Write(aux.Municipio + ";");
                                sw.Write(aux.Partido + ";");
                                sw.WriteLine(aux.Cargo);
                            }
                            aux = aux.Prox;
                        }
                    }
                }
                MessageBox.Show("Dados Exportados com sucesso", "Confirmação"); //Mensagem de confirmação
            }
            else //se o arquivo não existe, é criado o mesmo, e os dados é salvado
            {
                File.Create(novoArquivo).Close();

                using (StreamWriter sw = File.AppendText(novoArquivo))
                {
                    //percorro toda a lista para adicionar o Numero o titulo no arquivo:
                    while (aux != null)
                    {
                        if ((municipio == aux.Municipio))
                        {
                            sw.Write(aux.Nome + ";");
                            sw.Write(aux.Numero + ";");
                            sw.Write(aux.Municipio + ";");
                            sw.Write(aux.Partido + ";");
                            sw.WriteLine(aux.Cargo);
                        }
                        aux = aux.Prox;
                    }
                }
                MessageBox.Show("Dados Exportados com sucesso", "Confirmação"); //Mensagem de confirmação
            }     
        } //fim do método salvar
    }
}
