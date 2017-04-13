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
    public partial class FrmMunicipio : Form
    {
        public FrmMunicipio()
        {
            InitializeComponent();
        }

        private void FrmMunicipio_Load(object sender, EventArgs e)
        {
            Acao.Estado(cbxEstado);
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            //instanciando municipio
            Municipio m = new Municipio();

            //se alguns dos campos estiver vazia exibe a mensagem para preencher os dados:
            if ((txtNome.Text == "") || (cbxEstado.SelectedIndex == -1) || (nUpDownHabitantes.Value == 0) || (nUpDownVagasVereadores.Value == 0))
                Acao.MsgCampo();
            else //com os campos preenchido irá salvar os dados:
            {
                m.Nome = txtNome.Text; //atribuição de valor de acordo com a classe e campo em questão
                m.Estado = cbxEstado.SelectedItem.ToString(); //atribuição de valor de acordo com a classe e campo em questão
                m.THabitantes = (int)nUpDownHabitantes.Value; //atribuição de valor de acordo com a classe e campo em questão
                m.VagasVereador = (int)nUpDownVagasVereadores.Value; //atribuição de valor de acordo com a classe e campo em questão

                FrmPrincipal.Dm.Salvar(m); //salvando os dados no arquivo
                Acao.MsgSalvo(); //exibindo a mensagem

                //limpando os campos:
                txtNome.Clear();
                cbxEstado.SelectedIndex = -1;
                nUpDownHabitantes.Value = 100;
                nUpDownVagasVereadores.Value = 1;
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            //limpando os campos:
            txtNome.Clear();
            cbxEstado.SelectedIndex = -1;
            nUpDownHabitantes.Value = 100;
            nUpDownVagasVereadores.Value = 1;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            //exibindo um mensagem ao usuário confirmando se deseja sair
            if (Acao.MsgSair() == DialogResult.Yes)
                Close();
        }
    }
}
