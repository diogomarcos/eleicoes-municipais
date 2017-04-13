namespace ModuloUrnaEletronica.cadastre
{
    partial class FrmAreaRestrita
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAreaRestrita));
            this.tabControlMenu = new System.Windows.Forms.TabControl();
            this.tabPageConfigurar = new System.Windows.Forms.TabPage();
            this.gBoxConfigurar = new System.Windows.Forms.GroupBox();
            this.txtStatusConfigurar = new System.Windows.Forms.TextBox();
            this.btnConfigurar = new System.Windows.Forms.Button();
            this.lblMunicipio = new System.Windows.Forms.Label();
            this.cbxSecao = new System.Windows.Forms.ComboBox();
            this.cbxMunicipio = new System.Windows.Forms.ComboBox();
            this.lblSecao = new System.Windows.Forms.Label();
            this.lblZona = new System.Windows.Forms.Label();
            this.cbxZona = new System.Windows.Forms.ComboBox();
            this.tabPageExportar = new System.Windows.Forms.TabPage();
            this.gBoxExportar = new System.Windows.Forms.GroupBox();
            this.txtStatusExportar = new System.Windows.Forms.TextBox();
            this.btnExportar = new System.Windows.Forms.Button();
            this.tabControlMenu.SuspendLayout();
            this.tabPageConfigurar.SuspendLayout();
            this.gBoxConfigurar.SuspendLayout();
            this.tabPageExportar.SuspendLayout();
            this.gBoxExportar.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlMenu
            // 
            this.tabControlMenu.Controls.Add(this.tabPageConfigurar);
            this.tabControlMenu.Controls.Add(this.tabPageExportar);
            this.tabControlMenu.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControlMenu.Location = new System.Drawing.Point(0, 1);
            this.tabControlMenu.Name = "tabControlMenu";
            this.tabControlMenu.SelectedIndex = 0;
            this.tabControlMenu.Size = new System.Drawing.Size(575, 225);
            this.tabControlMenu.TabIndex = 0;
            // 
            // tabPageConfigurar
            // 
            this.tabPageConfigurar.BackColor = System.Drawing.Color.White;
            this.tabPageConfigurar.Controls.Add(this.gBoxConfigurar);
            this.tabPageConfigurar.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPageConfigurar.Location = new System.Drawing.Point(4, 23);
            this.tabPageConfigurar.Name = "tabPageConfigurar";
            this.tabPageConfigurar.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageConfigurar.Size = new System.Drawing.Size(567, 198);
            this.tabPageConfigurar.TabIndex = 0;
            this.tabPageConfigurar.Text = "Configurar Urna";
            // 
            // gBoxConfigurar
            // 
            this.gBoxConfigurar.Controls.Add(this.txtStatusConfigurar);
            this.gBoxConfigurar.Controls.Add(this.btnConfigurar);
            this.gBoxConfigurar.Controls.Add(this.lblMunicipio);
            this.gBoxConfigurar.Controls.Add(this.cbxSecao);
            this.gBoxConfigurar.Controls.Add(this.cbxMunicipio);
            this.gBoxConfigurar.Controls.Add(this.lblSecao);
            this.gBoxConfigurar.Controls.Add(this.lblZona);
            this.gBoxConfigurar.Controls.Add(this.cbxZona);
            this.gBoxConfigurar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gBoxConfigurar.Location = new System.Drawing.Point(17, 17);
            this.gBoxConfigurar.Name = "gBoxConfigurar";
            this.gBoxConfigurar.Size = new System.Drawing.Size(530, 163);
            this.gBoxConfigurar.TabIndex = 16;
            this.gBoxConfigurar.TabStop = false;
            this.gBoxConfigurar.Text = "Configurar Urna Eletrônica";
            // 
            // txtStatusConfigurar
            // 
            this.txtStatusConfigurar.Location = new System.Drawing.Point(20, 108);
            this.txtStatusConfigurar.Name = "txtStatusConfigurar";
            this.txtStatusConfigurar.Size = new System.Drawing.Size(382, 22);
            this.txtStatusConfigurar.TabIndex = 17;
            // 
            // btnConfigurar
            // 
            this.btnConfigurar.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfigurar.Location = new System.Drawing.Point(425, 107);
            this.btnConfigurar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnConfigurar.Name = "btnConfigurar";
            this.btnConfigurar.Size = new System.Drawing.Size(83, 23);
            this.btnConfigurar.TabIndex = 16;
            this.btnConfigurar.Text = "Configurar";
            this.btnConfigurar.UseVisualStyleBackColor = true;
            this.btnConfigurar.Click += new System.EventHandler(this.btnConfigurar_Click);
            // 
            // lblMunicipio
            // 
            this.lblMunicipio.AutoSize = true;
            this.lblMunicipio.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMunicipio.Location = new System.Drawing.Point(17, 34);
            this.lblMunicipio.Name = "lblMunicipio";
            this.lblMunicipio.Size = new System.Drawing.Size(74, 16);
            this.lblMunicipio.TabIndex = 10;
            this.lblMunicipio.Text = "Município:";
            // 
            // cbxSecao
            // 
            this.cbxSecao.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxSecao.FormattingEnabled = true;
            this.cbxSecao.Location = new System.Drawing.Point(387, 53);
            this.cbxSecao.Name = "cbxSecao";
            this.cbxSecao.Size = new System.Drawing.Size(121, 23);
            this.cbxSecao.TabIndex = 15;
            // 
            // cbxMunicipio
            // 
            this.cbxMunicipio.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxMunicipio.FormattingEnabled = true;
            this.cbxMunicipio.Location = new System.Drawing.Point(20, 53);
            this.cbxMunicipio.Name = "cbxMunicipio";
            this.cbxMunicipio.Size = new System.Drawing.Size(200, 23);
            this.cbxMunicipio.TabIndex = 11;
            this.cbxMunicipio.SelectionChangeCommitted += new System.EventHandler(this.cbxMunicipio_SelectionChangeCommitted);
            // 
            // lblSecao
            // 
            this.lblSecao.AutoSize = true;
            this.lblSecao.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSecao.Location = new System.Drawing.Point(384, 34);
            this.lblSecao.Name = "lblSecao";
            this.lblSecao.Size = new System.Drawing.Size(108, 16);
            this.lblSecao.TabIndex = 14;
            this.lblSecao.Text = "Seção Eleitoral:";
            // 
            // lblZona
            // 
            this.lblZona.AutoSize = true;
            this.lblZona.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblZona.Location = new System.Drawing.Point(242, 34);
            this.lblZona.Name = "lblZona";
            this.lblZona.Size = new System.Drawing.Size(100, 16);
            this.lblZona.TabIndex = 12;
            this.lblZona.Text = "Zona Eleitoral:";
            // 
            // cbxZona
            // 
            this.cbxZona.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxZona.FormattingEnabled = true;
            this.cbxZona.Location = new System.Drawing.Point(245, 52);
            this.cbxZona.Name = "cbxZona";
            this.cbxZona.Size = new System.Drawing.Size(120, 24);
            this.cbxZona.TabIndex = 13;
            this.cbxZona.SelectionChangeCommitted += new System.EventHandler(this.cbxZona_SelectionChangeCommitted);
            // 
            // tabPageExportar
            // 
            this.tabPageExportar.BackColor = System.Drawing.Color.White;
            this.tabPageExportar.Controls.Add(this.gBoxExportar);
            this.tabPageExportar.Location = new System.Drawing.Point(4, 23);
            this.tabPageExportar.Name = "tabPageExportar";
            this.tabPageExportar.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageExportar.Size = new System.Drawing.Size(567, 198);
            this.tabPageExportar.TabIndex = 1;
            this.tabPageExportar.Text = "Exportar Resultados";
            // 
            // gBoxExportar
            // 
            this.gBoxExportar.Controls.Add(this.txtStatusExportar);
            this.gBoxExportar.Controls.Add(this.btnExportar);
            this.gBoxExportar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gBoxExportar.Location = new System.Drawing.Point(17, 17);
            this.gBoxExportar.Name = "gBoxExportar";
            this.gBoxExportar.Size = new System.Drawing.Size(530, 163);
            this.gBoxExportar.TabIndex = 17;
            this.gBoxExportar.TabStop = false;
            this.gBoxExportar.Text = "Exportar Dados da Urna Eletrônica";
            // 
            // txtStatusExportar
            // 
            this.txtStatusExportar.Location = new System.Drawing.Point(20, 67);
            this.txtStatusExportar.Name = "txtStatusExportar";
            this.txtStatusExportar.Size = new System.Drawing.Size(382, 22);
            this.txtStatusExportar.TabIndex = 17;
            // 
            // btnExportar
            // 
            this.btnExportar.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportar.Location = new System.Drawing.Point(425, 66);
            this.btnExportar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(83, 23);
            this.btnExportar.TabIndex = 16;
            this.btnExportar.Text = "Exportar";
            this.btnExportar.UseVisualStyleBackColor = true;
            this.btnExportar.Click += new System.EventHandler(this.btnExportar_Click);
            // 
            // FrmAreaRestrita
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(575, 226);
            this.Controls.Add(this.tabControlMenu);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmAreaRestrita";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Área Restrita";
            this.Load += new System.EventHandler(this.FrmAreaRestrita_Load);
            this.tabControlMenu.ResumeLayout(false);
            this.tabPageConfigurar.ResumeLayout(false);
            this.gBoxConfigurar.ResumeLayout(false);
            this.gBoxConfigurar.PerformLayout();
            this.tabPageExportar.ResumeLayout(false);
            this.gBoxExportar.ResumeLayout(false);
            this.gBoxExportar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlMenu;
        private System.Windows.Forms.TabPage tabPageConfigurar;
        private System.Windows.Forms.GroupBox gBoxConfigurar;
        private System.Windows.Forms.TextBox txtStatusConfigurar;
        private System.Windows.Forms.Button btnConfigurar;
        private System.Windows.Forms.Label lblMunicipio;
        private System.Windows.Forms.ComboBox cbxSecao;
        private System.Windows.Forms.ComboBox cbxMunicipio;
        private System.Windows.Forms.Label lblSecao;
        private System.Windows.Forms.Label lblZona;
        private System.Windows.Forms.ComboBox cbxZona;
        private System.Windows.Forms.TabPage tabPageExportar;
        private System.Windows.Forms.GroupBox gBoxExportar;
        private System.Windows.Forms.TextBox txtStatusExportar;
        private System.Windows.Forms.Button btnExportar;
    }
}