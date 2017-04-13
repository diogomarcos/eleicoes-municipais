namespace ModuloTRE.cadastre
{
    partial class FrmExportar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmExportar));
            this.gBoxDados = new System.Windows.Forms.GroupBox();
            this.btnAbrirE = new System.Windows.Forms.Button();
            this.gBoxCandidatos = new System.Windows.Forms.GroupBox();
            this.lblMunicipioC = new System.Windows.Forms.Label();
            this.cbxMunicipioC = new System.Windows.Forms.ComboBox();
            this.btnExportarC = new System.Windows.Forms.Button();
            this.gBoxEleitores = new System.Windows.Forms.GroupBox();
            this.lblMunicipioE = new System.Windows.Forms.Label();
            this.btnExportarE = new System.Windows.Forms.Button();
            this.cbxMunicipioE = new System.Windows.Forms.ComboBox();
            this.cbxSecao = new System.Windows.Forms.ComboBox();
            this.lblZona = new System.Windows.Forms.Label();
            this.lblSecao = new System.Windows.Forms.Label();
            this.cbxZona = new System.Windows.Forms.ComboBox();
            this.gBoxDados.SuspendLayout();
            this.gBoxCandidatos.SuspendLayout();
            this.gBoxEleitores.SuspendLayout();
            this.SuspendLayout();
            // 
            // gBoxDados
            // 
            this.gBoxDados.Controls.Add(this.btnAbrirE);
            this.gBoxDados.Controls.Add(this.gBoxCandidatos);
            this.gBoxDados.Controls.Add(this.gBoxEleitores);
            this.gBoxDados.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gBoxDados.Location = new System.Drawing.Point(12, 12);
            this.gBoxDados.Name = "gBoxDados";
            this.gBoxDados.Size = new System.Drawing.Size(561, 409);
            this.gBoxDados.TabIndex = 1;
            this.gBoxDados.TabStop = false;
            this.gBoxDados.Text = "Exportar dados das Urnas Eletrônicas";
            // 
            // btnAbrirE
            // 
            this.btnAbrirE.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbrirE.Location = new System.Drawing.Point(468, 370);
            this.btnAbrirE.Name = "btnAbrirE";
            this.btnAbrirE.Size = new System.Drawing.Size(87, 23);
            this.btnAbrirE.TabIndex = 17;
            this.btnAbrirE.Text = "Abrir Pasta";
            this.btnAbrirE.UseVisualStyleBackColor = true;
            this.btnAbrirE.Click += new System.EventHandler(this.btnAbrirE_Click);
            // 
            // gBoxCandidatos
            // 
            this.gBoxCandidatos.Controls.Add(this.lblMunicipioC);
            this.gBoxCandidatos.Controls.Add(this.cbxMunicipioC);
            this.gBoxCandidatos.Controls.Add(this.btnExportarC);
            this.gBoxCandidatos.Location = new System.Drawing.Point(29, 205);
            this.gBoxCandidatos.Name = "gBoxCandidatos";
            this.gBoxCandidatos.Size = new System.Drawing.Size(503, 145);
            this.gBoxCandidatos.TabIndex = 18;
            this.gBoxCandidatos.TabStop = false;
            this.gBoxCandidatos.Text = "Exportar dados Candidatos";
            // 
            // lblMunicipioC
            // 
            this.lblMunicipioC.AutoSize = true;
            this.lblMunicipioC.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMunicipioC.Location = new System.Drawing.Point(6, 29);
            this.lblMunicipioC.Name = "lblMunicipioC";
            this.lblMunicipioC.Size = new System.Drawing.Size(74, 16);
            this.lblMunicipioC.TabIndex = 18;
            this.lblMunicipioC.Text = "Município:";
            // 
            // cbxMunicipioC
            // 
            this.cbxMunicipioC.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxMunicipioC.FormattingEnabled = true;
            this.cbxMunicipioC.Location = new System.Drawing.Point(9, 48);
            this.cbxMunicipioC.Name = "cbxMunicipioC";
            this.cbxMunicipioC.Size = new System.Drawing.Size(200, 23);
            this.cbxMunicipioC.TabIndex = 19;
            // 
            // btnExportarC
            // 
            this.btnExportarC.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportarC.Location = new System.Drawing.Point(418, 100);
            this.btnExportarC.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnExportarC.Name = "btnExportarC";
            this.btnExportarC.Size = new System.Drawing.Size(74, 23);
            this.btnExportarC.TabIndex = 17;
            this.btnExportarC.Text = "Exportar";
            this.btnExportarC.UseVisualStyleBackColor = true;
            this.btnExportarC.Click += new System.EventHandler(this.btnExportarC_Click);
            // 
            // gBoxEleitores
            // 
            this.gBoxEleitores.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.gBoxEleitores.Controls.Add(this.lblMunicipioE);
            this.gBoxEleitores.Controls.Add(this.btnExportarE);
            this.gBoxEleitores.Controls.Add(this.cbxMunicipioE);
            this.gBoxEleitores.Controls.Add(this.cbxSecao);
            this.gBoxEleitores.Controls.Add(this.lblZona);
            this.gBoxEleitores.Controls.Add(this.lblSecao);
            this.gBoxEleitores.Controls.Add(this.cbxZona);
            this.gBoxEleitores.Location = new System.Drawing.Point(29, 33);
            this.gBoxEleitores.Name = "gBoxEleitores";
            this.gBoxEleitores.Size = new System.Drawing.Size(503, 145);
            this.gBoxEleitores.TabIndex = 17;
            this.gBoxEleitores.TabStop = false;
            this.gBoxEleitores.Text = "Exportar dados Eleitores";
            // 
            // lblMunicipioE
            // 
            this.lblMunicipioE.AutoSize = true;
            this.lblMunicipioE.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMunicipioE.Location = new System.Drawing.Point(6, 32);
            this.lblMunicipioE.Name = "lblMunicipioE";
            this.lblMunicipioE.Size = new System.Drawing.Size(74, 16);
            this.lblMunicipioE.TabIndex = 10;
            this.lblMunicipioE.Text = "Município:";
            // 
            // btnExportarE
            // 
            this.btnExportarE.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportarE.Location = new System.Drawing.Point(418, 102);
            this.btnExportarE.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnExportarE.Name = "btnExportarE";
            this.btnExportarE.Size = new System.Drawing.Size(74, 23);
            this.btnExportarE.TabIndex = 16;
            this.btnExportarE.Text = "Exportar";
            this.btnExportarE.UseVisualStyleBackColor = true;
            this.btnExportarE.Click += new System.EventHandler(this.btnExportarE_Click);
            // 
            // cbxMunicipioE
            // 
            this.cbxMunicipioE.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxMunicipioE.FormattingEnabled = true;
            this.cbxMunicipioE.Location = new System.Drawing.Point(9, 51);
            this.cbxMunicipioE.Name = "cbxMunicipioE";
            this.cbxMunicipioE.Size = new System.Drawing.Size(200, 23);
            this.cbxMunicipioE.TabIndex = 11;
            this.cbxMunicipioE.SelectionChangeCommitted += new System.EventHandler(this.cbxMunicipioE_SelectionChangeCommitted);
            // 
            // cbxSecao
            // 
            this.cbxSecao.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxSecao.FormattingEnabled = true;
            this.cbxSecao.Location = new System.Drawing.Point(371, 51);
            this.cbxSecao.Name = "cbxSecao";
            this.cbxSecao.Size = new System.Drawing.Size(121, 23);
            this.cbxSecao.TabIndex = 15;
            // 
            // lblZona
            // 
            this.lblZona.AutoSize = true;
            this.lblZona.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblZona.Location = new System.Drawing.Point(227, 32);
            this.lblZona.Name = "lblZona";
            this.lblZona.Size = new System.Drawing.Size(100, 16);
            this.lblZona.TabIndex = 12;
            this.lblZona.Text = "Zona Eleitoral:";
            // 
            // lblSecao
            // 
            this.lblSecao.AutoSize = true;
            this.lblSecao.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSecao.Location = new System.Drawing.Point(368, 32);
            this.lblSecao.Name = "lblSecao";
            this.lblSecao.Size = new System.Drawing.Size(108, 16);
            this.lblSecao.TabIndex = 14;
            this.lblSecao.Text = "Seção Eleitoral:";
            // 
            // cbxZona
            // 
            this.cbxZona.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxZona.FormattingEnabled = true;
            this.cbxZona.Location = new System.Drawing.Point(230, 50);
            this.cbxZona.Name = "cbxZona";
            this.cbxZona.Size = new System.Drawing.Size(120, 24);
            this.cbxZona.TabIndex = 13;
            this.cbxZona.SelectionChangeCommitted += new System.EventHandler(this.cbxZona_SelectionChangeCommitted);
            // 
            // FrmExportar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(589, 435);
            this.Controls.Add(this.gBoxDados);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmExportar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Exportar Dados Urnas Eletrônicas";
            this.Load += new System.EventHandler(this.FrmExportar_Load);
            this.gBoxDados.ResumeLayout(false);
            this.gBoxCandidatos.ResumeLayout(false);
            this.gBoxCandidatos.PerformLayout();
            this.gBoxEleitores.ResumeLayout(false);
            this.gBoxEleitores.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gBoxDados;
        private System.Windows.Forms.Button btnAbrirE;
        private System.Windows.Forms.GroupBox gBoxCandidatos;
        private System.Windows.Forms.Label lblMunicipioC;
        private System.Windows.Forms.ComboBox cbxMunicipioC;
        private System.Windows.Forms.Button btnExportarC;
        private System.Windows.Forms.GroupBox gBoxEleitores;
        private System.Windows.Forms.Label lblMunicipioE;
        private System.Windows.Forms.Button btnExportarE;
        private System.Windows.Forms.ComboBox cbxMunicipioE;
        private System.Windows.Forms.ComboBox cbxSecao;
        private System.Windows.Forms.Label lblZona;
        private System.Windows.Forms.Label lblSecao;
        private System.Windows.Forms.ComboBox cbxZona;
    }
}