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
    public partial class FrmJustificativa : Form
    {
        public FrmJustificativa()
        {
            InitializeComponent();
        }

        private void FrmJustificativa_Load(object sender, EventArgs e)
        {
            FrmPrincipal.DJustificativa.Listar(ltvJustificativas); //mostrando os dados na tabela
        }
    }
}
