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
    public partial class FrmEleitor : Form
    {
        public FrmEleitor()
        {
            InitializeComponent();
        }

        private void txtNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Char.IsLetter(e.KeyChar)) || (Char.IsWhiteSpace(e.KeyChar)))
                e.Handled = true;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            //instanciando eleitor e dadoseleitor:
            Eleitor el = new Eleitor();

            //se alguns dos campos estiver vazia exibe a mensagem para preencher os dados:
            if ((txtNome.Text == "") || (txtNumero.Text == "") || (cbxMunicipio.SelectedIndex == -1) || (cbxZona.SelectedIndex == -1) || (cbxSecao.SelectedIndex == -1))
                Acao.MsgCampo();
            else //com os campos preenchido irá salvar os dados:
            {
                el.Nome = txtNome.Text; //atribuição de valor de acordo com a classe e campo em questão
                el.NumeroTitulo = txtNumero.Text; //atribuição de valor de acordo com a classe e campo em questão
                el.Municipio = cbxMunicipio.SelectedItem.ToString(); //atribuição de valor de acordo com a classe e campo em questão
                el.ZonaEleitoral = cbxZona.SelectedItem.ToString(); //atribuição de valor de acordo com a classe e campo em questão
                el.SecaoEleitoral = cbxSecao.SelectedItem.ToString(); //atribuição de valor de acordo com a classe e campo em questão

                FrmPrincipal.De.Salvar(el); //salvando os dados no arquivo
                Acao.MsgSalvo(); //exibindo a mensagem

                //limpando os campos:
                txtNome.Text = "";
                txtNumero.Text = "";
                cbxMunicipio.SelectedIndex = -1;
                cbxZona.SelectedIndex = -1;
                cbxSecao.SelectedIndex = -1;
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            //limpando os campos:
            txtNome.Text = "";
            txtNumero.Text = "";
            cbxMunicipio.SelectedIndex = -1;
            cbxZona.SelectedIndex = -1;
            cbxSecao.SelectedIndex = -1;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            //exibindo um mensagem ao usuário confirmando se deseja sair
            if (Acao.MsgSair() == DialogResult.Yes)
                Close();
        }

        private void FrmEleitor_Load(object sender, EventArgs e)
        {
            //exibindo as dados no comboBox:            
            FrmPrincipal.Dm.Listar(cbxMunicipio);
        }

        private void cbxMunicipio_SelectionChangeCommitted(object sender, EventArgs e)
        {
            cbxZona.Items.Clear(); //limpando as dados antigos para adicionar a nova seleção
            
            //adicionando os dados da zona eleitoral de acordo com a seleção do municipio:
            FrmPrincipal.Due.Listar(cbxZona, cbxMunicipio.SelectedItem.ToString());
        }

        private void cbxZona_SelectionChangeCommitted(object sender, EventArgs e)
        {
            cbxSecao.Items.Clear(); //limpando as dados antigos para adicionar a nova seleção

            //adicionando os dados da secao eleitoral de acordo com a seleção da zona eleitoral:
            FrmPrincipal.Due.Listar(cbxSecao, cbxZona.SelectedItem.ToString(), 0);
        }
    }
}
