using ModuloUrnaEletronica.controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ModuloUrnaEletronica.cadastre
{
    public partial class FrmAreaRestrita : Form
    {
        public FrmAreaRestrita()
        {
            InitializeComponent();
        }

        private void FrmAreaRestrita_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void FrmAreaRestrita_Load(object sender, EventArgs e)
        {
            //exibindo os municipios no comboBox:
            //FrmInicial.Due.Listar(cbxMunicipio);
            FrmInicial.Dcidade.Listar(cbxMunicipio);
        }

        private void cbxMunicipio_SelectionChangeCommitted(object sender, EventArgs e)
        {
            cbxZona.Items.Clear(); //limpando as dados antigos para adicionar a nova seleção

            //adicionando os dados da zona eleitoral de acordo com a seleção do municipio:
            FrmInicial.Due.Listar(cbxZona, cbxMunicipio.SelectedItem.ToString(), 1);
        }

        private void cbxZona_SelectionChangeCommitted(object sender, EventArgs e)
        {
            cbxSecao.Items.Clear(); //limpando as dados antigos para adicionar a nova seleção

            //adicionando os dados da secao eleitoral de acordo com a seleção da zona eleitoral:
            FrmInicial.Due.Listar(cbxSecao, cbxZona.SelectedItem.ToString(), 2);
        }

        private void btnConfigurar_Click(object sender, EventArgs e)
        {
            if ((cbxMunicipio.SelectedIndex == -1) || (cbxZona.SelectedIndex == -1) || (cbxSecao.SelectedIndex == -1))
                Acao.MsgCampo();
            else //com os campos preenchido irá salvar os dados:
            {
                string arqCandidato, arqEleitor; //atributos que irão receber a base com dos arquivos salvos

                //atributo arqCandidato recebe a cidade que é a base dos arquivos salvos:
                arqCandidato = cbxMunicipio.SelectedItem.ToString() + ".txt";

                //atributo arqEleitro recebe a cidade, zona eleitoral e secao que é a base dos arquivos salvos:
                arqEleitor = cbxMunicipio.SelectedItem.ToString() + @"\" + cbxMunicipio.SelectedItem.ToString() + "_z" + cbxZona.SelectedItem.ToString() + "s" + cbxSecao.SelectedItem.ToString() + ".txt";

                FrmInicial.Dc.gerarLista(arqCandidato); //gerando a lista auto-referenciada dos candidados
                FrmInicial.De.gerarLista(arqEleitor); //gerando a lista auto-referenciada dos  eleitores
                FrmInicial.Municipio = cbxMunicipio.SelectedItem.ToString(); //pegando o nome do municipio

                txtStatusConfigurar.Text = "Urna Configurada com Sucesso";

                //limpandos/zerando os comboBox:
                cbxMunicipio.SelectedIndex = -1;
                cbxZona.SelectedIndex = -1;
                cbxSecao.SelectedIndex = -1;
            }
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            //instanciando DadosExportar
            DadosExportar de = new DadosExportar();

            de.Salvar(); //salvando os dados
        }
    }
}
