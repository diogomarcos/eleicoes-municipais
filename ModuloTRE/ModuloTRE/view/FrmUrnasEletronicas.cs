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
    public partial class FrmUrnasEletronicas : Form
    {
        public FrmUrnasEletronicas()
        {
            InitializeComponent();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            //exibindo o dados na tabela:
            FrmPrincipal.Due.Listar(ltvUrnasEletronicas);
        }
    }
}
