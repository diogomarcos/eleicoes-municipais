using ModuloUrnaEletronica.model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ModuloUrnaEletronica.controller
{
    class DadosExportar : PathFile
    {
        private string arqVotacoes = "_Votacoes.txt"; //atributo com o nome para o arquivo votar
        private string arqStatusEleitores = "_StatusEleitores.txt"; //atributo com o nome para o arquivo eleitor
        private string arqJustificativas = "_Justificativa.txt"; //atributo com o nome para o arquivo justificar
        private string arqBrancosNulos = "_BrancoNulo.txt"; //atributo com o nome para o arquivo 
        private string subDir = @"Apuracao\"; //atributo com o local do sub-diretorio

        //método para salvar as exportações das votações e status dos eleitores, e as justificativas:
        public void Salvar()
        {
            base.Local = Path.Combine(base.Local, subDir); //combinando o local da pasta com o arquivo dos dados salvos

            //atributos com os nomes dos arquivos:
            string votacoes = base.Local + FrmInicial.Municipio + @"\" + FrmInicial.Municipio + arqVotacoes;
            string statusEleitores = base.Local + FrmInicial.Municipio + @"\" + FrmInicial.Municipio + arqStatusEleitores;
            string justificativas = base.Local + FrmInicial.Municipio + @"\" + FrmInicial.Municipio + arqJustificativas;
            string brancosNulos = base.Local + FrmInicial.Municipio + @"\" + FrmInicial.Municipio + arqBrancosNulos;

            //Caso não tenha o diretorio cria o mesmo:
            Directory.CreateDirectory(base.Local + FrmInicial.Municipio);

            //criando auxiliares que serão utilizadas para percorrerem as listas(eleitor, candidato e justificativa)
            Eleitor auxE = FrmInicial.De.Primeiro.Prox;
            Candidato auxC = FrmInicial.Dc.Primeiro.Prox;
            Justificativa auxJ = FrmInicial.Dj.Primeiro.Prox;

            //verificando se os arquivo já existem:
            if ((!File.Exists(votacoes)) || (!File.Exists(statusEleitores)) || (!File.Exists(justificativas)) || (!File.Exists(brancosNulos)) )
            {
                File.Create(votacoes).Close(); //criando o arquivo votação
                File.Create(statusEleitores).Close(); //criando o arquivo statusEleitores
                File.Create(justificativas).Close(); //criando o arquivo justificativa
                File.Create(brancosNulos).Close(); //criando o arquivo brancoNulo
            }

            //Salvando os dados das votações no arquivo:
            using (StreamWriter sw = File.AppendText(votacoes))
            {
                //percorro toda a lista para adicionar o Numero o titulo no arquivo:
                while (auxC != null)
                {
                    sw.Write(auxC.Nome + ";");
                    sw.Write(auxC.Numero + ";");
                    sw.Write(auxC.Partido + ";");
                    sw.Write(auxC.Cargo + ";");
                    sw.WriteLine(auxC.TotalVotos);

                    auxC = auxC.Prox;
                }
            }

            //Salvando os dados de status dos Eleitores
            using (StreamWriter sw = File.AppendText(statusEleitores))
            {
                //percorro toda a lista para adicionar o Numero o titulo no arquivo:
                while (auxE != null)
                {
                    sw.Write(auxE.NumeroTitulo + ";");
                    sw.WriteLine(auxE.Status);
                    auxE = auxE.Prox;
                }
            }

            //Salvando os dados das justificativas
            using (StreamWriter sw = File.AppendText(justificativas))
            {
                //percorro toda a lista para adicionar o Numero o titulo no arquivo:
                while (auxJ != null)
                {
                    sw.Write(auxJ.Nome + ";");
                    sw.Write(auxJ.NumeroTitulo + ";");
                    sw.WriteLine(auxJ.Justificar);
                    auxJ = auxJ.Prox;
                }
            }

            //Salvando os dados dos votos brancos e nulos
            using (StreamWriter sw = File.AppendText(brancosNulos))
            {
                sw.Write(FrmInicial.VotosBranco + ";");
                sw.WriteLine(FrmInicial.VotosNulo);
            }
            MessageBox.Show("Dados Exportados com sucesso", "Confirmação"); //Mensagem de confirmação
        } //fim do método para salvar
    }
}
