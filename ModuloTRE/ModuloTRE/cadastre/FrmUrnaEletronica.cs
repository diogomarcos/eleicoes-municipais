using ModuloTRE.controller;
using ModuloTRE.model;
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
    public partial class FrmUrnaEletronica : Form
    {
        public FrmUrnaEletronica()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            //instanciando urnaeletronica
            UrnaEletronica ue = new UrnaEletronica();

            //se alguns dos campos estiver vazia exibe a mensagem para preencher os dados:
            if ((cbxMunicipio.SelectedIndex == -1) || (txtZona.Text == "") || (txtSecao.Text == ""))
                Acao.MsgCampo();
            else //com os campos preenchido irá salvar os dados:
            {
                ue.Municipio = cbxMunicipio.SelectedItem.ToString(); //atribuição de valor de acordo com a classe e campo em questão
                ue.ZonaELeitoral = txtZona.Text; //atribuição de valor de acordo com a classe e campo em questão
                ue.SecaoEleitoral = txtSecao.Text; //atribuição de valor de acordo com a classe e campo em questão

                FrmPrincipal.Due.Salvar(ue); //salvando os dados no arquivo
                Acao.MsgSalvo(); //exibindo a mensagem

                //limpando os campos:
                cbxMunicipio.SelectedIndex = -1;
                txtZona.Text = "";
                txtSecao.Text = "";
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            //limpando os campos:
            cbxMunicipio.SelectedIndex = -1;
            txtZona.Text = "";
            txtSecao.Text = "";
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            //exibindo um mensagem ao usuário confirmando se deseja sair
            if (Acao.MsgSair() == DialogResult.Yes)
                Close();
        }

        private void FrmUrnaEletronica_Load(object sender, EventArgs e)
        {
            //exibindo os dados no comboBox:
            FrmPrincipal.Dm.Listar(cbxMunicipio);
        }
    }
}
