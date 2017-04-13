namespace ModuloTRE
{
    partial class FrmPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.panelFundo = new System.Windows.Forms.Panel();
            this.panelTela = new System.Windows.Forms.Panel();
            this.tabCtrlMenu = new System.Windows.Forms.TabControl();
            this.tabPgCadastrar = new System.Windows.Forms.TabPage();
            this.btnCadCandidato = new System.Windows.Forms.Button();
            this.btnCadEleitor = new System.Windows.Forms.Button();
            this.btnUrna = new System.Windows.Forms.Button();
            this.btnPartido = new System.Windows.Forms.Button();
            this.btnMunicipio = new System.Windows.Forms.Button();
            this.tabPgVisualizar = new System.Windows.Forms.TabPage();
            this.btnCandidato = new System.Windows.Forms.Button();
            this.btnEleitor = new System.Windows.Forms.Button();
            this.btnViewUrna = new System.Windows.Forms.Button();
            this.btnViewPartido = new System.Windows.Forms.Button();
            this.btnViewMunicipio = new System.Windows.Forms.Button();
            this.tabPgExportar = new System.Windows.Forms.TabPage();
            this.btnExportar = new System.Windows.Forms.Button();
            this.tabPgApuracao = new System.Windows.Forms.TabPage();
            this.btnJustificativa = new System.Windows.Forms.Button();
            this.btnImportar = new System.Windows.Forms.Button();
            this.btnVereador = new System.Windows.Forms.Button();
            this.btnPrefeito = new System.Windows.Forms.Button();
            this.tabPgHelp = new System.Windows.Forms.TabPage();
            this.btnAbout = new System.Windows.Forms.Button();
            this.btnManual = new System.Windows.Forms.Button();
            this.panelFundo.SuspendLayout();
            this.tabCtrlMenu.SuspendLayout();
            this.tabPgCadastrar.SuspendLayout();
            this.tabPgVisualizar.SuspendLayout();
            this.tabPgExportar.SuspendLayout();
            this.tabPgApuracao.SuspendLayout();
            this.tabPgHelp.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelFundo
            // 
            this.panelFundo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelFundo.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panelFundo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelFundo.Controls.Add(this.panelTela);
            this.panelFundo.Controls.Add(this.tabCtrlMenu);
            this.panelFundo.Location = new System.Drawing.Point(1, 0);
            this.panelFundo.Name = "panelFundo";
            this.panelFundo.Size = new System.Drawing.Size(1088, 549);
            this.panelFundo.TabIndex = 1;
            // 
            // panelTela
            // 
            this.panelTela.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelTela.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panelTela.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelTela.BackgroundImage")));
            this.panelTela.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelTela.Location = new System.Drawing.Point(3, 107);
            this.panelTela.Name = "panelTela";
            this.panelTela.Size = new System.Drawing.Size(1082, 442);
            this.panelTela.TabIndex = 1;
            // 
            // tabCtrlMenu
            // 
            this.tabCtrlMenu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabCtrlMenu.Controls.Add(this.tabPgCadastrar);
            this.tabCtrlMenu.Controls.Add(this.tabPgVisualizar);
            this.tabCtrlMenu.Controls.Add(this.tabPgExportar);
            this.tabCtrlMenu.Controls.Add(this.tabPgApuracao);
            this.tabCtrlMenu.Controls.Add(this.tabPgHelp);
            this.tabCtrlMenu.Cursor = System.Windows.Forms.Cursors.Default;
            this.tabCtrlMenu.Location = new System.Drawing.Point(3, 3);
            this.tabCtrlMenu.Name = "tabCtrlMenu";
            this.tabCtrlMenu.SelectedIndex = 0;
            this.tabCtrlMenu.Size = new System.Drawing.Size(1082, 102);
            this.tabCtrlMenu.TabIndex = 0;
            // 
            // tabPgCadastrar
            // 
            this.tabPgCadastrar.BackColor = System.Drawing.Color.White;
            this.tabPgCadastrar.Controls.Add(this.btnCadCandidato);
            this.tabPgCadastrar.Controls.Add(this.btnCadEleitor);
            this.tabPgCadastrar.Controls.Add(this.btnUrna);
            this.tabPgCadastrar.Controls.Add(this.btnPartido);
            this.tabPgCadastrar.Controls.Add(this.btnMunicipio);
            this.tabPgCadastrar.Cursor = System.Windows.Forms.Cursors.Default;
            this.tabPgCadastrar.ImageKey = "(none)";
            this.tabPgCadastrar.Location = new System.Drawing.Point(4, 22);
            this.tabPgCadastrar.Name = "tabPgCadastrar";
            this.tabPgCadastrar.Padding = new System.Windows.Forms.Padding(3);
            this.tabPgCadastrar.Size = new System.Drawing.Size(1074, 76);
            this.tabPgCadastrar.TabIndex = 0;
            this.tabPgCadastrar.Text = "Cadastrar";
            // 
            // btnCadCandidato
            // 
            this.btnCadCandidato.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCadCandidato.BackgroundImage")));
            this.btnCadCandidato.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCadCandidato.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCadCandidato.Location = new System.Drawing.Point(330, 6);
            this.btnCadCandidato.Name = "btnCadCandidato";
            this.btnCadCandidato.Size = new System.Drawing.Size(75, 64);
            this.btnCadCandidato.TabIndex = 4;
            this.btnCadCandidato.UseVisualStyleBackColor = true;
            this.btnCadCandidato.Click += new System.EventHandler(this.btnCadCandidato_Click);
            // 
            // btnCadEleitor
            // 
            this.btnCadEleitor.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCadEleitor.BackgroundImage")));
            this.btnCadEleitor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCadEleitor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCadEleitor.Location = new System.Drawing.Point(249, 6);
            this.btnCadEleitor.Name = "btnCadEleitor";
            this.btnCadEleitor.Size = new System.Drawing.Size(75, 64);
            this.btnCadEleitor.TabIndex = 3;
            this.btnCadEleitor.UseVisualStyleBackColor = true;
            this.btnCadEleitor.Click += new System.EventHandler(this.btnCadEleitor_Click);
            // 
            // btnUrna
            // 
            this.btnUrna.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnUrna.BackgroundImage")));
            this.btnUrna.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnUrna.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUrna.Location = new System.Drawing.Point(168, 6);
            this.btnUrna.Name = "btnUrna";
            this.btnUrna.Size = new System.Drawing.Size(75, 64);
            this.btnUrna.TabIndex = 2;
            this.btnUrna.UseVisualStyleBackColor = true;
            this.btnUrna.Click += new System.EventHandler(this.btnUrna_Click);
            // 
            // btnPartido
            // 
            this.btnPartido.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPartido.BackgroundImage")));
            this.btnPartido.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPartido.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPartido.Location = new System.Drawing.Point(87, 6);
            this.btnPartido.Name = "btnPartido";
            this.btnPartido.Size = new System.Drawing.Size(75, 64);
            this.btnPartido.TabIndex = 1;
            this.btnPartido.UseVisualStyleBackColor = true;
            this.btnPartido.Click += new System.EventHandler(this.btnPartido_Click);
            // 
            // btnMunicipio
            // 
            this.btnMunicipio.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMunicipio.BackgroundImage")));
            this.btnMunicipio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnMunicipio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMunicipio.Location = new System.Drawing.Point(6, 6);
            this.btnMunicipio.Name = "btnMunicipio";
            this.btnMunicipio.Size = new System.Drawing.Size(75, 64);
            this.btnMunicipio.TabIndex = 0;
            this.btnMunicipio.UseVisualStyleBackColor = true;
            this.btnMunicipio.Click += new System.EventHandler(this.btnMunicipio_Click);
            // 
            // tabPgVisualizar
            // 
            this.tabPgVisualizar.BackColor = System.Drawing.Color.White;
            this.tabPgVisualizar.Controls.Add(this.btnCandidato);
            this.tabPgVisualizar.Controls.Add(this.btnEleitor);
            this.tabPgVisualizar.Controls.Add(this.btnViewUrna);
            this.tabPgVisualizar.Controls.Add(this.btnViewPartido);
            this.tabPgVisualizar.Controls.Add(this.btnViewMunicipio);
            this.tabPgVisualizar.Location = new System.Drawing.Point(4, 22);
            this.tabPgVisualizar.Name = "tabPgVisualizar";
            this.tabPgVisualizar.Padding = new System.Windows.Forms.Padding(3);
            this.tabPgVisualizar.Size = new System.Drawing.Size(1074, 76);
            this.tabPgVisualizar.TabIndex = 1;
            this.tabPgVisualizar.Text = "Visualizar";
            // 
            // btnCandidato
            // 
            this.btnCandidato.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCandidato.BackgroundImage")));
            this.btnCandidato.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCandidato.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCandidato.Location = new System.Drawing.Point(330, 6);
            this.btnCandidato.Name = "btnCandidato";
            this.btnCandidato.Size = new System.Drawing.Size(75, 64);
            this.btnCandidato.TabIndex = 4;
            this.btnCandidato.UseVisualStyleBackColor = true;
            this.btnCandidato.Click += new System.EventHandler(this.btnCandidato_Click);
            // 
            // btnEleitor
            // 
            this.btnEleitor.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEleitor.BackgroundImage")));
            this.btnEleitor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnEleitor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEleitor.Location = new System.Drawing.Point(249, 6);
            this.btnEleitor.Name = "btnEleitor";
            this.btnEleitor.Size = new System.Drawing.Size(75, 64);
            this.btnEleitor.TabIndex = 3;
            this.btnEleitor.UseVisualStyleBackColor = true;
            this.btnEleitor.Click += new System.EventHandler(this.btnEleitor_Click);
            // 
            // btnViewUrna
            // 
            this.btnViewUrna.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnViewUrna.BackgroundImage")));
            this.btnViewUrna.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnViewUrna.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnViewUrna.Location = new System.Drawing.Point(168, 6);
            this.btnViewUrna.Name = "btnViewUrna";
            this.btnViewUrna.Size = new System.Drawing.Size(75, 64);
            this.btnViewUrna.TabIndex = 2;
            this.btnViewUrna.UseVisualStyleBackColor = true;
            this.btnViewUrna.Click += new System.EventHandler(this.btnViewUrna_Click);
            // 
            // btnViewPartido
            // 
            this.btnViewPartido.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnViewPartido.BackgroundImage")));
            this.btnViewPartido.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnViewPartido.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnViewPartido.Location = new System.Drawing.Point(87, 6);
            this.btnViewPartido.Name = "btnViewPartido";
            this.btnViewPartido.Size = new System.Drawing.Size(75, 64);
            this.btnViewPartido.TabIndex = 1;
            this.btnViewPartido.UseVisualStyleBackColor = true;
            this.btnViewPartido.Click += new System.EventHandler(this.btnViewPartido_Click);
            // 
            // btnViewMunicipio
            // 
            this.btnViewMunicipio.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnViewMunicipio.BackgroundImage")));
            this.btnViewMunicipio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnViewMunicipio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnViewMunicipio.Location = new System.Drawing.Point(6, 6);
            this.btnViewMunicipio.Name = "btnViewMunicipio";
            this.btnViewMunicipio.Size = new System.Drawing.Size(75, 64);
            this.btnViewMunicipio.TabIndex = 0;
            this.btnViewMunicipio.UseVisualStyleBackColor = true;
            this.btnViewMunicipio.Click += new System.EventHandler(this.btnViewMunicipio_Click);
            // 
            // tabPgExportar
            // 
            this.tabPgExportar.Controls.Add(this.btnExportar);
            this.tabPgExportar.Location = new System.Drawing.Point(4, 22);
            this.tabPgExportar.Name = "tabPgExportar";
            this.tabPgExportar.Size = new System.Drawing.Size(1074, 76);
            this.tabPgExportar.TabIndex = 2;
            this.tabPgExportar.Text = "Exportar";
            this.tabPgExportar.UseVisualStyleBackColor = true;
            // 
            // btnExportar
            // 
            this.btnExportar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExportar.BackgroundImage")));
            this.btnExportar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnExportar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExportar.Location = new System.Drawing.Point(6, 6);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(75, 64);
            this.btnExportar.TabIndex = 0;
            this.btnExportar.UseVisualStyleBackColor = true;
            this.btnExportar.Click += new System.EventHandler(this.btnExportar_Click);
            // 
            // tabPgApuracao
            // 
            this.tabPgApuracao.Controls.Add(this.btnJustificativa);
            this.tabPgApuracao.Controls.Add(this.btnImportar);
            this.tabPgApuracao.Controls.Add(this.btnVereador);
            this.tabPgApuracao.Controls.Add(this.btnPrefeito);
            this.tabPgApuracao.Location = new System.Drawing.Point(4, 22);
            this.tabPgApuracao.Name = "tabPgApuracao";
            this.tabPgApuracao.Size = new System.Drawing.Size(1074, 76);
            this.tabPgApuracao.TabIndex = 5;
            this.tabPgApuracao.Text = "Apuração";
            this.tabPgApuracao.UseVisualStyleBackColor = true;
            // 
            // btnJustificativa
            // 
            this.btnJustificativa.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnJustificativa.BackgroundImage")));
            this.btnJustificativa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnJustificativa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnJustificativa.Enabled = false;
            this.btnJustificativa.Location = new System.Drawing.Point(249, 6);
            this.btnJustificativa.Name = "btnJustificativa";
            this.btnJustificativa.Size = new System.Drawing.Size(75, 64);
            this.btnJustificativa.TabIndex = 2;
            this.btnJustificativa.UseVisualStyleBackColor = true;
            this.btnJustificativa.Click += new System.EventHandler(this.btnJustificativa_Click);
            // 
            // btnImportar
            // 
            this.btnImportar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnImportar.BackgroundImage")));
            this.btnImportar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnImportar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnImportar.Location = new System.Drawing.Point(6, 6);
            this.btnImportar.Name = "btnImportar";
            this.btnImportar.Size = new System.Drawing.Size(75, 64);
            this.btnImportar.TabIndex = 0;
            this.btnImportar.UseVisualStyleBackColor = true;
            this.btnImportar.Click += new System.EventHandler(this.btnImportar_Click);
            // 
            // btnVereador
            // 
            this.btnVereador.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnVereador.BackgroundImage")));
            this.btnVereador.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnVereador.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVereador.Enabled = false;
            this.btnVereador.Location = new System.Drawing.Point(168, 6);
            this.btnVereador.Name = "btnVereador";
            this.btnVereador.Size = new System.Drawing.Size(75, 64);
            this.btnVereador.TabIndex = 1;
            this.btnVereador.UseVisualStyleBackColor = true;
            this.btnVereador.Click += new System.EventHandler(this.btnVereador_Click);
            // 
            // btnPrefeito
            // 
            this.btnPrefeito.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPrefeito.BackgroundImage")));
            this.btnPrefeito.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPrefeito.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrefeito.Enabled = false;
            this.btnPrefeito.Location = new System.Drawing.Point(87, 6);
            this.btnPrefeito.Name = "btnPrefeito";
            this.btnPrefeito.Size = new System.Drawing.Size(75, 64);
            this.btnPrefeito.TabIndex = 1;
            this.btnPrefeito.UseVisualStyleBackColor = true;
            this.btnPrefeito.Click += new System.EventHandler(this.btnPrefeito_Click);
            // 
            // tabPgHelp
            // 
            this.tabPgHelp.Controls.Add(this.btnAbout);
            this.tabPgHelp.Controls.Add(this.btnManual);
            this.tabPgHelp.Location = new System.Drawing.Point(4, 22);
            this.tabPgHelp.Name = "tabPgHelp";
            this.tabPgHelp.Size = new System.Drawing.Size(1074, 76);
            this.tabPgHelp.TabIndex = 3;
            this.tabPgHelp.Text = "Help";
            this.tabPgHelp.UseVisualStyleBackColor = true;
            // 
            // btnAbout
            // 
            this.btnAbout.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAbout.BackgroundImage")));
            this.btnAbout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAbout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAbout.Location = new System.Drawing.Point(87, 6);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(75, 64);
            this.btnAbout.TabIndex = 1;
            this.btnAbout.UseVisualStyleBackColor = true;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // btnManual
            // 
            this.btnManual.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnManual.BackgroundImage")));
            this.btnManual.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnManual.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnManual.Location = new System.Drawing.Point(6, 6);
            this.btnManual.Name = "btnManual";
            this.btnManual.Size = new System.Drawing.Size(75, 64);
            this.btnManual.TabIndex = 0;
            this.btnManual.UseVisualStyleBackColor = true;
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1089, 547);
            this.Controls.Add(this.panelFundo);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Módulo TRE";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmPrincipal_FormClosing);
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.panelFundo.ResumeLayout(false);
            this.tabCtrlMenu.ResumeLayout(false);
            this.tabPgCadastrar.ResumeLayout(false);
            this.tabPgVisualizar.ResumeLayout(false);
            this.tabPgExportar.ResumeLayout(false);
            this.tabPgApuracao.ResumeLayout(false);
            this.tabPgHelp.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelFundo;
        private System.Windows.Forms.TabControl tabCtrlMenu;
        private System.Windows.Forms.TabPage tabPgCadastrar;
        private System.Windows.Forms.TabPage tabPgVisualizar;
        private System.Windows.Forms.TabPage tabPgExportar;
        private System.Windows.Forms.TabPage tabPgHelp;
        private System.Windows.Forms.Panel panelTela;
        private System.Windows.Forms.Button btnMunicipio;
        private System.Windows.Forms.Button btnCadEleitor;
        private System.Windows.Forms.Button btnUrna;
        private System.Windows.Forms.Button btnPartido;
        private System.Windows.Forms.Button btnCadCandidato;
        private System.Windows.Forms.Button btnCandidato;
        private System.Windows.Forms.Button btnEleitor;
        private System.Windows.Forms.Button btnViewUrna;
        private System.Windows.Forms.Button btnViewPartido;
        private System.Windows.Forms.Button btnViewMunicipio;
        private System.Windows.Forms.Button btnExportar;
        private System.Windows.Forms.TabPage tabPgApuracao;
        private System.Windows.Forms.Button btnVereador;
        private System.Windows.Forms.Button btnPrefeito;
        private System.Windows.Forms.Button btnAbout;
        private System.Windows.Forms.Button btnManual;
        private System.Windows.Forms.Button btnJustificativa;
        private System.Windows.Forms.Button btnImportar;



    }
}

