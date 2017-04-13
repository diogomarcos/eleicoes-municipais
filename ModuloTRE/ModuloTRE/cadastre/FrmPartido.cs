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
    public partial class FrmPartido : Form
    {
        public FrmPartido()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            //instanciando partido:
            Partido p = new Partido();

            //se alguns dos campos estiver vazia exibe a mensagem para preencher os dados:
            if ((txtNome.Text == "") || (txtSigla.Text == ""))
                Acao.MsgCampo();
            else //com os campos preenchido irá salvar os dados:
            {
                p.Nome = txtNome.Text; //atribuição de valor de acordo com a classe e campo em questão
                p.Sigla = txtSigla.Text; //atribuição de valor de acordo com a classe e campo em questão

                FrmPrincipal.Dp.Salvar(p); //salvando os dados no arquivo
                Acao.MsgSalvo(); //exibindo a mensagem

                //limpando os campos:
                txtNome.Clear();
                txtSigla.Clear();
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            //limpando os campos
            txtNome.Clear();
            txtSigla.Clear();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            //exibindo um mensagem ao usuário confirmando se deseja sair
            if (Acao.MsgSair() == DialogResult.Yes)
                Close();
        }
    }
}
