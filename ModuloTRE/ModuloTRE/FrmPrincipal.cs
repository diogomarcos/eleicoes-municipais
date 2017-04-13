using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ModuloTRE.view;
using ModuloTRE.controller;
using ModuloTRE.cadastre;
using System.Threading;

namespace ModuloTRE
{
    public partial class FrmPrincipal : Form
    {
        //instânciando as dados:
        static DadosCandidato dc = new DadosCandidato();
        static DadosEleitor de = new DadosEleitor();
        static DadosMunicipio dm = new DadosMunicipio();
        static DadosPartido dp = new DadosPartido();
        static DadosUrnaEletronica due = new DadosUrnaEletronica();
        static DadosPrefeito dPrefeito = new DadosPrefeito();
        static DadosVereador dVereador = new DadosVereador();
        static DadosJustificativa dJustificativa = new DadosJustificativa();        

        //Propriedades para retornar as dados:
        internal static DadosCandidato Dc
        { get { return FrmPrincipal.dc; } }        

        internal static DadosEleitor De
        { get { return FrmPrincipal.de; } }        

        internal static DadosMunicipio Dm
        { get { return FrmPrincipal.dm; } }        

        internal static DadosPartido Dp
        { get { return FrmPrincipal.dp; } }        

        internal static DadosUrnaEletronica Due
        { get { return FrmPrincipal.due; } }

        internal static DadosPrefeito DPrefeito
        { get { return FrmPrincipal.dPrefeito; } }

        internal static DadosVereador DVereador
        { get { return FrmPrincipal.dVereador; } }

        internal static DadosJustificativa DJustificativa
        { get { return FrmPrincipal.dJustificativa; } }

        static string municipio; //atributo para receber o municipio (será usado na Apuração)

        //propriedade para pegar e retornar o municipio
        public static string Municipio
        {
            get { return FrmPrincipal.municipio; }
            set { FrmPrincipal.municipio = value; }
        }

        public FrmPrincipal()
        {
            Thread t = new Thread(new ThreadStart(SplashScreen));
            t.Start();
            Thread.Sleep(5000);
            InitializeComponent();

            ImageList iconsList = new ImageList();
            iconsList.Images.Add(Image.FromFile(@"D:\EleicoesMunicipais\ModuloTRE\ModuloTRE\img\IconCad.png"));
            iconsList.Images.Add(Image.FromFile(@"D:\EleicoesMunicipais\ModuloTRE\ModuloTRE\img\IconView.png"));
            iconsList.Images.Add(Image.FromFile(@"D:\EleicoesMunicipais\ModuloTRE\ModuloTRE\img\IconExp.png"));
            iconsList.Images.Add(Image.FromFile(@"D:\EleicoesMunicipais\ModuloTRE\ModuloTRE\img\IconApuracao.png"));
            iconsList.Images.Add(Image.FromFile(@"D:\EleicoesMunicipais\ModuloTRE\ModuloTRE\img\IconHelp.png"));
            tabCtrlMenu.ImageList = iconsList;
            tabPgCadastrar.ImageIndex = 0;
            tabPgVisualizar.ImageIndex = 1;
            tabPgExportar.ImageIndex = 2;
            tabPgApuracao.ImageIndex = 3;
            tabPgHelp.ImageIndex = 4;            

            t.Abort();

        }

        public void SplashScreen()
        {
            Application.Run(new FrmLoad());
        }

        private void btnCadCandidato_Click(object sender, EventArgs e)
        {
            panelTela.Controls.Clear(); //limpando o que estiver presente no painel tela
            FrmCandidato novoForm = new FrmCandidato(); //instanciando a formulário que será apresentado
            novoForm.MdiParent = this; //dizendo que o formulario será filho do formulario principal
            novoForm.Show(); //fazendo com que o formulario seja mostrando
            panelTela.Controls.Add(novoForm); //adicionando o formulario no painel tela
            
        }

        private void FrmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Deseja Sair", "Deseja Sair", MessageBoxButtons.YesNo) == DialogResult.No)
                e.Cancel = true;
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            //gerando as listas auto referenciadas:
            dc.gerarLista();
            de.gerarLista();
            dm.gerarLista();
            dp.gerarLista();
            due.gerarLista();
        }

        private void btnCadEleitor_Click(object sender, EventArgs e)
        {
            panelTela.Controls.Clear(); //limpando o que estiver presente no painel tela
            FrmEleitor novoForm = new FrmEleitor(); //instanciando a formulário que será apresentado
            novoForm.MdiParent = this; //dizendo que o formulario será filho do formulario principal
            novoForm.Show(); //fazendo com que o formulario seja mostrando
            panelTela.Controls.Add(novoForm); //adicionando o formulario no painel tela
        }

        private void btnMunicipio_Click(object sender, EventArgs e)
        {
            panelTela.Controls.Clear(); //limpando o que estiver presente no painel tela
            FrmMunicipio novoForm = new FrmMunicipio(); //instanciando a formulário que será apresentado
            novoForm.MdiParent = this; //dizendo que o formulario será filho do formulario principal
            novoForm.Show(); //fazendo com que o formulario seja mostrando
            panelTela.Controls.Add(novoForm); //adicionando o formulario no painel tela
        }

        private void btnPartido_Click(object sender, EventArgs e)
        {
            panelTela.Controls.Clear(); //limpando o que estiver presente no painel tela
            FrmPartido novoForm = new FrmPartido(); //instanciando a formulário que será apresentado
            novoForm.MdiParent = this; //dizendo que o formulario será filho do formulario principal
            novoForm.Show(); //fazendo com que o formulario seja mostrando
            panelTela.Controls.Add(novoForm); //adicionando o formulario no painel tela
        }

        private void btnUrna_Click(object sender, EventArgs e)
        {
            panelTela.Controls.Clear(); //limpando o que estiver presente no painel tela
            FrmUrnaEletronica novoForm = new FrmUrnaEletronica(); //instanciando a formulário que será apresentado
            novoForm.MdiParent = this; //dizendo que o formulario será filho do formulario principal
            novoForm.Show(); //fazendo com que o formulario seja mostrando
            panelTela.Controls.Add(novoForm); //adicionando o formulario no painel tela
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            panelTela.Controls.Clear(); //limpando o que estiver presente no painel tela
            FrmExportar novoForm = new FrmExportar(); //instanciando a formulário que será apresentado
            novoForm.MdiParent = this; //dizendo que o formulario será filho do formulario principal
            novoForm.Show(); //fazendo com que o formulario seja mostrando
            panelTela.Controls.Add(novoForm); //adicionando o formulario no painel tela
        }

        private void btnCandidato_Click(object sender, EventArgs e)
        {
            panelTela.Controls.Clear(); //limpando o que estiver presente no painel tela
            FrmCandidatos novoForm = new FrmCandidatos(); //instanciando a formulário que será apresentado
            novoForm.MdiParent = this; //dizendo que o formulario será filho do formulario principal
            novoForm.Show(); //fazendo com que o formulario seja mostrando
            panelTela.Controls.Add(novoForm); //adicionando o formulario no painel tela
        }

        private void btnEleitor_Click(object sender, EventArgs e)
        {
            panelTela.Controls.Clear(); //limpando o que estiver presente no painel tela
            FrmEleitores novoForm = new FrmEleitores(); //instanciando a formulário que será apresentado
            novoForm.MdiParent = this; //dizendo que o formulario será filho do formulario principal
            novoForm.Show(); //fazendo com que o formulario seja mostrando
            panelTela.Controls.Add(novoForm); //adicionando o formulario no painel tela
        }

        private void btnViewMunicipio_Click(object sender, EventArgs e)
        {
            panelTela.Controls.Clear(); //limpando o que estiver presente no painel tela
            FrmMunicipios novoForm = new FrmMunicipios(); //instanciando a formulário que será apresentado
            novoForm.MdiParent = this; //dizendo que o formulario será filho do formulario principal
            novoForm.Show(); //fazendo com que o formulario seja mostrando
            panelTela.Controls.Add(novoForm); //adicionando o formulario no painel tela
        }

        private void btnViewPartido_Click(object sender, EventArgs e)
        {
            panelTela.Controls.Clear(); //limpando o que estiver presente no painel tela
            FrmPartidos novoForm = new FrmPartidos(); //instanciando a formulário que será apresentado
            novoForm.MdiParent = this; //dizendo que o formulario será filho do formulario principal
            novoForm.Show(); //fazendo com que o formulario seja mostrando
            panelTela.Controls.Add(novoForm); //adicionando o formulario no painel tela
        }

        private void btnViewUrna_Click(object sender, EventArgs e)
        {
            panelTela.Controls.Clear(); //limpando o que estiver presente no painel tela
            FrmUrnasEletronicas novoForm = new FrmUrnasEletronicas(); //instanciando a formulário que será apresentado
            novoForm.MdiParent = this; //dizendo que o formulario será filho do formulario principal
            novoForm.Show(); //fazendo com que o formulario seja mostrando
            panelTela.Controls.Add(novoForm); //adicionando o formulario no painel tela
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            panelTela.Controls.Clear(); //limpando o que estiver presente no painel tela
            FrmAbout novoForm = new FrmAbout(); //instanciando a formulário que será apresentado
            novoForm.MdiParent = this; //dizendo que o formulario será filho do formulario principal
            novoForm.Show(); //fazendo com que o formulario seja mostrando
            panelTela.Controls.Add(novoForm); //adicionando o formulario no painel tela
        }

        private void btnPrefeito_Click(object sender, EventArgs e)
        {
            panelTela.Controls.Clear(); //limpando o que estiver presente no painel tela
            FrmApPrefeito novoForm = new FrmApPrefeito(); //instanciando a formulário que será apresentado
            novoForm.MdiParent = this; //dizendo que o formulario será filho do formulario principal
            novoForm.Show(); //fazendo com que o formulario seja mostrando
            panelTela.Controls.Add(novoForm); //adicionando o formulario no painel tela
        }

        private void btnVereador_Click(object sender, EventArgs e)
        {
            panelTela.Controls.Clear(); //limpando o que estiver presente no painel tela
            FrmApVereador novoForm = new FrmApVereador(); //instanciando a formulário que será apresentado
            novoForm.MdiParent = this; //dizendo que o formulario será filho do formulario principal
            novoForm.Show(); //fazendo com que o formulario seja mostrando
            panelTela.Controls.Add(novoForm); //adicionando o formulario no painel tela
        }

        private void btnImportar_Click(object sender, EventArgs e)
        {
            panelTela.Controls.Clear(); //limpando o que estiver presente no painel tela
            FrmImportar novoForm = new FrmImportar(); //instanciando o formulario que será apresentado
            novoForm.MdiParent = this; //dizendo que o formulario será filho do formulario principal
            novoForm.Show(); //fazendo com que o formulario seja mostrando
            panelTela.Controls.Add(novoForm); //adicionando o formulario no painel tela

            //habilitando os botões:
            btnPrefeito.Enabled = true;
            btnVereador.Enabled = true;
            btnJustificativa.Enabled = true;
        }

        private void btnJustificativa_Click(object sender, EventArgs e)
        {
            panelTela.Controls.Clear(); //limpando o que estiver presente no painel tela
            FrmJustificativa novoForm = new FrmJustificativa(); //instanciando o formulario que será apresentado
            novoForm.MdiParent = this; //dizendo que o formulario será filho do formulario principal
            novoForm.Show(); //fazendo com que o formulario seja mostrando
            panelTela.Controls.Add(novoForm); //adicionando o formulario no painel tela
        }
    }
}
