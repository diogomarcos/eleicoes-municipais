using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ModuloTRE.controller;
using ModuloTRE.model;

namespace ModuloTRE.view
{
    public partial class FrmApPrefeito : Form
    {
        public FrmApPrefeito()
        {
            InitializeComponent();
        }

        private void FrmApPrefeito_Load(object sender, EventArgs e)
        {
            FrmPrincipal.DPrefeito.Listar(ltvPrefeitos, FrmPrincipal.DPrefeito.Primeiro.Prox); //mostrando os dados na tabela
        }

        private void btApurar_Click(object sender, EventArgs e)
        {
            string linha1, linha2; //atributos para pegar o percentual das posições
            Votacao a1, a2; //atributo para receber os dados dos vereadores da tabela

            txtResultado.Text = ""; //limpando caso acha algo escrito

            a1 = new Votacao(); //instanciando a apuração
            a1.Nome = ltvPrefeitos.Items[0].SubItems[1].Text; //atribuindo o valor
            a1.Numero = Convert.ToInt32(ltvPrefeitos.Items[0].SubItems[2].Text); //atribuindo o valor
            a1.Partido = ltvPrefeitos.Items[0].SubItems[3].Text; //atribuindo o valor
            a1.TotalVotos = Convert.ToInt32(ltvPrefeitos.Items[0].SubItems[4].Text); //atribuindo o valor
            linha1 = ltvPrefeitos.Items[0].SubItems[5].Text; //atribuindo o valor

            a2 = new Votacao(); //instanciando a apuração
            a2.Nome = ltvPrefeitos.Items[1].SubItems[1].Text; //atribuindo o valor
            a2.Numero = Convert.ToInt32(ltvPrefeitos.Items[1].SubItems[2].Text); //atribuindo o valor
            a2.Partido = ltvPrefeitos.Items[1].SubItems[3].Text; //atribuindo o valor
            a2.TotalVotos = Convert.ToInt32(ltvPrefeitos.Items[1].SubItems[4].Text); //atribuindo o valor
            linha2 = ltvPrefeitos.Items[1].SubItems[5].Text; //atribuindo o valor

            FrmPrincipal.DPrefeito.resultado(txtResultado, linha1, linha2, a1, a2);

        }        
    }
}
