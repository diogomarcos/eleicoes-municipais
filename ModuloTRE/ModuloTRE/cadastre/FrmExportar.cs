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
    public partial class FrmExportar : Form
    {
        public FrmExportar()
        {
            InitializeComponent();
        }

        private void FrmExportar_Load(object sender, EventArgs e)
        {
            //exibindo as dados no comboBox:            
            FrmPrincipal.Dm.Listar(cbxMunicipioE);
            FrmPrincipal.Dm.Listar(cbxMunicipioC);
        }

        private void cbxMunicipioE_SelectionChangeCommitted(object sender, EventArgs e)
        {
            cbxZona.Items.Clear(); //limpando as dados antigos para adicionar a nova seleção

            //adicionando os dados da zona eleitoral de acordo com a seleção do municipio:
            FrmPrincipal.Due.Listar(cbxZona, cbxMunicipioE.SelectedItem.ToString());
        }

        private void cbxZona_SelectionChangeCommitted(object sender, EventArgs e)
        {
            cbxSecao.Items.Clear(); //limpando as dados antigos para adicionar a nova seleção

            //adicionando os dados da secao eleitoral de acordo com a seleção da zona eleitoral:
            FrmPrincipal.Due.Listar(cbxSecao, cbxZona.SelectedItem.ToString(), 0);
        }

        private void btnExportarE_Click(object sender, EventArgs e)
        {
            //instanciando dadosexportar
            DadosExportar dex = new DadosExportar();

            //se alguns dos campos estiver vazia exibe a mensagem para preencher os dados:
            if ((cbxMunicipioE.SelectedIndex == -1) || (cbxZona.SelectedIndex == -1) || (cbxSecao.SelectedIndex == -1))
                Acao.MsgCampo();
            else //com os campos preenchido irá salvar os dados:
            {
                //exportando os dados de acordo com as seleções (municipio, zona e  secao):
                dex.Salvar(cbxMunicipioE.SelectedItem.ToString(), cbxZona.SelectedItem.ToString(), cbxSecao.SelectedItem.ToString(), FrmPrincipal.De);

                //limpando/zerando os comboBox:
                cbxMunicipioE.SelectedIndex = -1;
                cbxZona.SelectedIndex = -1;
                cbxSecao.SelectedIndex = -1;
            }
        }

        private void cbxCargo_SelectionChangeCommitted(object sender, EventArgs e)
        {
            cbxMunicipioC.Items.Clear(); //limpando as dados antigos para adicionar a nova seleção

            //adicionando os dados ao comboBox:
            FrmPrincipal.Dm.Listar(cbxMunicipioC);
        }

        private void btnExportarC_Click(object sender, EventArgs e)
        {
            //instanciando o dadosexportar
            DadosExportar dex = new DadosExportar();

            //se alguns dos campos estiver vazia exibe a mensagem para preencher os dados:
            if ((cbxMunicipioC.SelectedIndex == -1))
                Acao.MsgCampo();
            else //com os campos preenchido irá salvar os dados:
            {
                //exportando os dados de acordo com o cargo e municipio:
                dex.Salvar(cbxMunicipioC.SelectedItem.ToString(), FrmPrincipal.Dc);

                //limpando/zerando os comboBox:
                cbxMunicipioC.SelectedIndex = -1;
            }  
        }

        private void btnAbrirE_Click(object sender, EventArgs e)
        {
            DadosExportar dex = new DadosExportar();
            dex.Abrir();
        }
    }
}
