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

namespace ModuloTRE.view
{
    public partial class FrmApVereador : Form
    {
        public FrmApVereador()
        {
            InitializeComponent();
        }

        private void FrmApVereador_Load(object sender, EventArgs e)
        {
            FrmPrincipal.DVereador.Listar(ltvVereadores, FrmPrincipal.DVereador.Primeiro.Prox);//mostrando os dados na tabela
        }

        private void btApurar_Click(object sender, EventArgs e)
        {
            string linha; //atributos para pegar o percentual das posições
            Votacao v; //atributo para receber os dados dos vereadores da tabela

            txtResultado.Text = ""; //limpando caso acha algo escrito

            //exibindo o resultado da apuração:
            txtResultado.Text = "APURAÇÃO: \n" +
                "Os Vereadores Eleitos do municipio - " + FrmPrincipal.Municipio + "\n\n";

            int vagas = FrmPrincipal.Dm.pesquisa(FrmPrincipal.Municipio); //pegando a quantidade de vereadores do municipio

            for (int i = 0; i < vagas; i++)
            {                
                v = new Votacao(); //instanciando a apuração
                v.Nome = ltvVereadores.Items[i].SubItems[1].Text; //atribuindo o valor
                v.Numero = Convert.ToInt32(ltvVereadores.Items[i].SubItems[2].Text); //atribuindo o valor
                v.Partido = ltvVereadores.Items[i].SubItems[3].Text; //atribuindo o valor
                v.TotalVotos = Convert.ToInt32(ltvVereadores.Items[i].SubItems[4].Text); //atribuindo o valor
                linha = ltvVereadores.Items[i].SubItems[5].Text; //atribuindo o valor

                FrmPrincipal.DVereador.resultado(txtResultado, v, linha); //mostrando o resultado
            }
        }        
    }
}
