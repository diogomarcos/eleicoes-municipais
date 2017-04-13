using ModuloUrnaEletronica.controller;
using ModuloUrnaEletronica.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ModuloUrnaEletronica.view
{
    public partial class FrmJustificar : Form
    {
        public FrmJustificar()
        {
            InitializeComponent();
        }

        private void btnJustificar_Click(object sender, EventArgs e)
        {
            if ((txtNome.Text == "") || (txtNumero.Text == "") || (txtJustificativa.Text == ""))
                Acao.MsgCampo();
            else
            {
                //instanciando a classe Justificativa
                Justificativa j = new Justificativa();

                j.Nome = txtNome.Text; //atribuido o nome
                j.NumeroTitulo = txtNumero.Text; //atribuindo o numero do titulo
                j.Justificar = txtJustificativa.Text; //atribuindo a justificativa

                FrmInicial.Dj.insere(j); //inserindo a justificativa na lista
                Acao.MsgSalvo(); //exibindo mensagem do dado salvo
                this.Close(); //fechando a FrmJustificar
            }

        }
    }
}
