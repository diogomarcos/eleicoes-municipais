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
    public partial class FrmVotar : Form
    {
        Candidato c; //atributo para recebe a pesquisa do candidato
        Eleitor e; //atributo para recebe a eleitor da pesquisa
        bool eleitor; //atributo para recebe a resposta da pesquisa do eleitor
        bool resp; //atributo para recebe a resposta da pesquisa do candidato

        public FrmVotar()
        {
            InitializeComponent();
        }

        private void btnValidar_Click(object sender, EventArgs e)
        {
            if (txtNumero.MaskCompleted)
            {
                eleitor = FrmInicial.De.pesquisa(txtNumero.Text);

                if (eleitor == true) //se achar o eleitor irá ser mostrado a tela para proceguir com a votação
                    gBoxAutenticação.Visible = false; //escondendo a caixa de autenticação
                else
                {
                    //se não achar o eleitor irá mostrar um mensagem dizendo sobre o mesmo e irá voltar para a tela inicial
                    MessageBox.Show("Eleitor, você não pertence a essa Zona Eleitoral(Favor Justificar seu voto), \nOu já realizou o voto.");

                    this.Close(); //fechando o formulario FrmVotar
                }
                txtNumero.Text = "";
            }
            
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (txtVereador.Visible == true)
                txtVereador.Text += "1";
            else
                txtPrefeito.Text += "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (txtVereador.Visible == true)
                txtVereador.Text += "2";
            else
                txtPrefeito.Text += "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (txtVereador.Visible == true)
                txtVereador.Text += "3";
            else
                txtPrefeito.Text += "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (txtVereador.Visible == true)
                txtVereador.Text += "4";
            else
                txtPrefeito.Text += "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (txtVereador.Visible == true)
                txtVereador.Text += "5";
            else
                txtPrefeito.Text += "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (txtVereador.Visible == true)
                txtVereador.Text += "6";
            else
                txtPrefeito.Text += "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (txtVereador.Visible == true)
                txtVereador.Text += "7";
            else
                txtPrefeito.Text += "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (txtVereador.Visible == true)
                txtVereador.Text += "8";
            else
                txtPrefeito.Text += "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (txtVereador.Visible == true)
                txtVereador.Text += "9";
            else
                txtPrefeito.Text += "9";
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if (txtVereador.Visible == true)
                txtVereador.Text += "0";
            else
                txtPrefeito.Text += "0";
        }

        private void btnBranco_Click(object sender, EventArgs e)
        {
            if (txtVereador.Visible == true)
            {
                FrmInicial.VotosBranco += 1; //fazendo a contagem dos votos em branco

                txtVereador.Visible = false; //escondendo a txt Vereador
                txtPrefeito.Visible = true; //mostrando o txtPrefeito
                txtNome.Text = ""; //apagando o Nome
                txtPartido.Text = ""; //apagando o Partido
                lblDesc.Visible = false; //escondendo a descrição
                lblCandidato.Text = "Prefeito(a)"; //mudando o cargo do candidato
            }
            else
            {
                FrmInicial.VotosBranco += 1; //fazendo a contagem dos votos em branco

                MessageBox.Show("FIM DA VOTAÇÃO!");
                this.Close(); //fechando o formulario FrmVotar                
            }
        }

        private void btnCorrige_Click(object sender, EventArgs e)
        {
            txtVereador.Text = "";
            txtPrefeito.Text = "";
            txtNome.Text = ""; //apagando o Nome
            txtPartido.Text = ""; //apagando o Partido
            lblDesc.Visible = false; //escondendo a descrição
        }

        private void btnConfirma_Click(object sender, EventArgs e)
        {
            if (txtVereador.Visible == true)
            {
                //pego a resposta do candidato da pesquisa:
                resp = FrmInicial.Dc.pesquisa(Convert.ToInt32(txtVereador.Text), 0);

                if (resp == false) //se resp for false então faz a contagem dos votos nulo
                {
                    FrmInicial.VotosNulo += 1;
                }

                txtVereador.Visible = false; //escondendo a txt Vereador
                txtPrefeito.Visible = true; //mostrando o txtPrefeito
                txtNome.Text = ""; //apagando o Nome
                txtPartido.Text = ""; //apagando o Partido
                lblDesc.Visible = false; //escondendo a descrição
                lblCandidato.Text = "Prefeito(a)"; //mudando o cargo do candidato
            }
            else
            {
                //pego a resposta do candidato da pesquisa:
                resp = FrmInicial.Dc.pesquisa(Convert.ToInt32(txtPrefeito.Text), 0);

                if (resp == false) //se resp for false então faz a contagem dos votos nulo
                {
                    FrmInicial.VotosNulo += 1;
                }

                MessageBox.Show("FIM DA VOTAÇÃO!");
                this.Close(); //fechahdo o formulario FrmVotar
            }
        }

        private void txtVereador_TextChanged(object sender, EventArgs e)
        {
            if (txtVereador.MaskCompleted)
            {
                //pego o candidato da pesquisa:
                c = FrmInicial.Dc.pesquisa(Convert.ToInt32(txtVereador.Text));

                if (c == null) //se o retorno for nulo apenas mostro o texto NULO
                {
                    txtNome.Text = "NULO"; //atribuindo o nome
                    lblDesc.Visible = true; //mostrando a descrição
                }
                else //senao irá mostro o nome do candidato e o partido
                {
                    txtNome.Text = c.Nome; //atribuindo o nome
                    txtPartido.Text = c.Partido; //atribuindo o partido
                    lblDesc.Visible = true; //mostrando a descrição
                }
            }

        }

        private void txtPrefeito_TextChanged(object sender, EventArgs e)
        {
            if (txtPrefeito.MaskCompleted)
            {
                //pego o candidato da pesquisa:
                c = FrmInicial.Dc.pesquisa(Convert.ToInt32(txtPrefeito.Text));

                if (c == null) //se o retorno for nulo apenas mostro o texto NULO
                {
                    txtNome.Text = "NULO"; //atribuindo o nome
                    lblDesc.Visible = true; //mostrando a descrição
                }
                else //senao irá mostro o nome do candidato e o partido
                {
                    txtNome.Text = c.Nome; //atribuindo o nome
                    txtPartido.Text = c.Partido; //atribuindo o partido
                    lblDesc.Visible = true; //mostrando a descrição
                }
            }
        }
    }
}
