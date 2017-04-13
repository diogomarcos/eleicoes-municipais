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
    public partial class FrmCandidato : Form
    {
        public FrmCandidato()
        {
            InitializeComponent();
        }
        
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            //instanciando candidato:
            Candidato c = new Candidato();

            //se alguns dos campos estiver vazia exibe a mensagem para preencher os dados:
            if ((txtNome.Text == "") || (txtNumero.Text == "") || (cbxMunicipio.SelectedIndex == -1) || (cbxPartido.SelectedIndex == -1))
                Acao.MsgCampo();
            else //com os campos preenchido irá salvar os dados:
            {
                c.Nome = txtNome.Text; //atribuição de valor de acordo com a classe e campo em questão
                c.Numero = Convert.ToInt32(txtNumero.Text); //atribuição de valor de acordo com a classe e campo em questão
                c.Municipio = cbxMunicipio.SelectedItem.ToString(); //atribuição de valor de acordo com a classe e campo em questão
                c.Partido = cbxPartido.SelectedItem.ToString(); //atribuição de valor de acordo com a classe e campo em questão

                //verifica qual o radioButtion está selecionado e atriui o valor a variavel
                if (rBtnPrefeito.Checked == true)
                    c.Cargo = 'P';
                if (rBtnVereador.Checked == true)
                    c.Cargo = 'V';

                FrmPrincipal.Dc.Salvar(c); //salvando os dados no arquivo
                Acao.MsgSalvo(); //exibindo a mensagem

                //limpando os campos:
                txtNome.Clear();
                txtNumero.Clear();
                cbxMunicipio.SelectedIndex = -1;
                cbxPartido.SelectedIndex = -1;
                rBtnPrefeito.Checked = true;
                rBtnVereador.Checked = false;
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            //limpando os campos:
            txtNome.Clear();
            txtNumero.Clear();
            cbxMunicipio.SelectedIndex = -1;
            cbxPartido.SelectedIndex = -1;
            rBtnPrefeito.Checked = true;
            rBtnVereador.Checked = false;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            //exibindo um mensagem ao usuário confirmando se deseja sair
            if (Acao.MsgSair() == DialogResult.Yes)
                Close();
        }

        private void FrmCandidato_Load(object sender, EventArgs e)
        {
            //exibindo os dados no comboBox:
            FrmPrincipal.Dm.Listar(cbxMunicipio);
            FrmPrincipal.Dp.Listar(cbxPartido);
        }
        
        private void txtNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Char.IsLetter(e.KeyChar)) || (Char.IsWhiteSpace(e.KeyChar)))
                e.Handled = true;
        }
    }
}
