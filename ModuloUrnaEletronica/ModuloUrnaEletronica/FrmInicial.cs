using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ModuloUrnaEletronica.cadastre;
using ModuloUrnaEletronica.controller;
using ModuloUrnaEletronica.view;

namespace ModuloUrnaEletronica
{
    public partial class FrmInicial : Form
    {
        //instanciando os dados:
        static DadosUrnaEletronica due = new DadosUrnaEletronica();
        static DadosCidade dcidade = new DadosCidade();
        
        static DadosCandidato dc = new DadosCandidato();
        static DadosEleitor de = new DadosEleitor();
        static DadosJustificativa dj = new DadosJustificativa();

        

        //atributo para receber o nome do municipio:
        static string municipio = null;

        //atributos para receber os votos em branco e nulos:
        static int votosBranco = 0;
        static int votosNulo = 0;

        //Propriedade para receber e retornar o Municipio:
        public static string Municipio
        {
            get { return FrmInicial.municipio; }
            set { FrmInicial.municipio = value; }
        }

        //Propriedade para receber e retornar os votos em branco:
        public static int VotosBranco
        {
            get { return FrmInicial.votosBranco; }
            set { FrmInicial.votosBranco = value; }
        }

        //Propriedade para receber e retornar os votos nulo:
        public static int VotosNulo
        {
            get { return FrmInicial.votosNulo; }
            set { FrmInicial.votosNulo = value; }
        }

        //Propriedades para retornar as dados:
        internal static DadosCandidato Dc
        { get { return FrmInicial.dc; } }        

        internal static DadosEleitor De
        { get { return FrmInicial.de;} }
        
        internal static DadosUrnaEletronica Due
        { get { return FrmInicial.due; } }

        internal static DadosJustificativa Dj
        { get { return FrmInicial.dj; } }

        internal static DadosCidade Dcidade
        { get { return FrmInicial.dcidade; } }


        public FrmInicial()
        {
            InitializeComponent();
        }

        private void FrmInicial_Load(object sender, EventArgs e)
        {
            //gerando as listas auto referenciadas:
            due.gerarLista();
            dcidade.gerarLista();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            //Mensagem para verificar se é usuário quer mesmo sair do programa:
            if (MessageBox.Show("Deseja Sair", "Deseja Sair", MessageBoxButtons.YesNo) == DialogResult.Yes)
                Close();
        }

        private void btnVotar_Click(object sender, EventArgs e)
        {
            //se as listas não estiverem vazia é mostrado o FrmJustificar
            if ((!dc.vazia()) && (!de.vazia()))
            {
                //instanciando o FrmVotar
                FrmVotar votar = new FrmVotar();
                votar.ShowDialog(); //mostrando o formulario
            }
            else
                //se as listas estiverem vazia é mostrato um mensagem informando o mesmo 
                MessageBox.Show("A Urna ainda não está configurada!");

        }

        private void btnJustificar_Click(object sender, EventArgs e)
        {
            //se as listas não estiverem vazia é mostrado o FrmJustificar
            if ((!dc.vazia()) && (!de.vazia()))
            {
                //instanciando o FrmJustificar
                FrmJustificar justificar = new FrmJustificar();
                justificar.ShowDialog(); //mostrando o formulario
            }
            else
                //se as listas estiverem vazia é mostrato um mensagem informando o mesmo 
                MessageBox.Show("A Urna ainda não está configurada!");
        }

        private void LblAreaRestrita_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            gBoxAreaRestrita.Visible = true; //mostrando o grupo box Logar área restrita
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            gBoxAreaRestrita.Visible = false; //ocultando o grupo box Logar área restrita
            txtUsuario.Text = ""; //limpando o campo caso tenha algo preenchido
            txtSenha.Text = ""; //limpando o campo caso tenha algo preenchido
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            if ((txtUsuario.Text == "") || (txtSenha.Text == ""))
                MessageBox.Show("Favor Preencher todos os campos!");
            else
            {
                //se usuario e senha estiverem de acordo é liberado o acesso
                if ((txtUsuario.Text == "admin") && (txtSenha.Text == "admin"))
                {
                    //instanciando o FrmAreaRestrita
                    FrmAreaRestrita areaRestrita = new FrmAreaRestrita();
                    areaRestrita.ShowDialog(); //mostrando o formulario
                    gBoxAreaRestrita.Visible = false; //escondendo o grupo box Logar área restrita
                }
                else
                    //se o usuario e senha estiverem errado é exibido uma mensagem informando o mesmo
                    MessageBox.Show("Usuário e/ou Senha Incorretos!");
            }
        }        
    }
}
