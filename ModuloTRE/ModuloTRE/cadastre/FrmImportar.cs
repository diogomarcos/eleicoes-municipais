using ModuloTRE.controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ModuloTRE.cadastre
{
    public partial class FrmImportar : Form
    {
        public FrmImportar()
        {
            InitializeComponent();
        }

        private void FrmImportar_Load(object sender, EventArgs e)
        {
            //exibindo as dados no comboBox:            
            FrmPrincipal.Dm.Listar(cbxMunicipio);
        }

        private void btnImportar_Click(object sender, EventArgs e)
        {
            //se alguns dos campos estiver vazia exibe a mensagem para preencher os dados:
            if ((cbxMunicipio.SelectedIndex == -1))
                Acao.MsgCampo();
            else //com o campo preenchido irá importar os dados:
            {
                //limpando a lista caso já tenha algo nele:
                FrmPrincipal.DPrefeito.limpar();
                FrmPrincipal.DVereador.limpar();
                FrmPrincipal.DJustificativa.limpar();

                FrmPrincipal.Municipio = cbxMunicipio.SelectedItem.ToString();

                //Gerando a lista a partir dos arquivos:
                FrmPrincipal.DPrefeito.gerarLista(FrmPrincipal.Municipio);
                FrmPrincipal.DVereador.gerarLista(FrmPrincipal.Municipio);
                FrmPrincipal.DJustificativa.gerarLista(FrmPrincipal.Municipio);

                //fechando o janela:
                this.Close();
            }
        }
    }
}
