namespace ModuloTRE.cadastre
{
    partial class FrmUrnaEletronica
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUrnaEletronica));
            this.gBoxUrnaEletronica = new System.Windows.Forms.GroupBox();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.txtSecao = new System.Windows.Forms.TextBox();
            this.lblSecao = new System.Windows.Forms.Label();
            this.txtZona = new System.Windows.Forms.TextBox();
            this.lblZona = new System.Windows.Forms.Label();
            this.cbxMunicipio = new System.Windows.Forms.ComboBox();
            this.lblMunicipio = new System.Windows.Forms.Label();
            this.gBoxUrnaEletronica.SuspendLayout();
            this.SuspendLayout();
            // 
            // gBoxUrnaEletronica
            // 
            this.gBoxUrnaEletronica.Controls.Add(this.btnSair);
            this.gBoxUrnaEletronica.Controls.Add(this.btnLimpar);
            this.gBoxUrnaEletronica.Controls.Add(this.btnSalvar);
            this.gBoxUrnaEletronica.Controls.Add(this.txtSecao);
            this.gBoxUrnaEletronica.Controls.Add(this.lblSecao);
            this.gBoxUrnaEletronica.Controls.Add(this.txtZona);
            this.gBoxUrnaEletronica.Controls.Add(this.lblZona);
            this.gBoxUrnaEletronica.Controls.Add(this.cbxMunicipio);
            this.gBoxUrnaEletronica.Controls.Add(this.lblMunicipio);
            this.gBoxUrnaEletronica.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gBoxUrnaEletronica.Location = new System.Drawing.Point(12, 12);
            this.gBoxUrnaEletronica.Name = "gBoxUrnaEletronica";
            this.gBoxUrnaEletronica.Size = new System.Drawing.Size(597, 211);
            this.gBoxUrnaEletronica.TabIndex = 1;
            this.gBoxUrnaEletronica.TabStop = false;
            this.gBoxUrnaEletronica.Text = "Cadastro de Urna Eletrônica";
            // 
            // btnSair
            // 
            this.btnSair.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Location = new System.Drawing.Point(348, 141);
            this.btnSair.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(74, 23);
            this.btnSair.TabIndex = 13;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Location = new System.Drawing.Point(253, 141);
            this.btnLimpar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(74, 23);
            this.btnLimpar.TabIndex = 12;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.Location = new System.Drawing.Point(160, 141);
            this.btnSalvar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(74, 23);
            this.btnSalvar.TabIndex = 11;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // txtSecao
            // 
            this.txtSecao.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSecao.Location = new System.Drawing.Point(443, 64);
            this.txtSecao.Name = "txtSecao";
            this.txtSecao.Size = new System.Drawing.Size(143, 22);
            this.txtSecao.TabIndex = 5;
            // 
            // lblSecao
            // 
            this.lblSecao.AutoSize = true;
            this.lblSecao.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSecao.Location = new System.Drawing.Point(440, 44);
            this.lblSecao.Name = "lblSecao";
            this.lblSecao.Size = new System.Drawing.Size(108, 16);
            this.lblSecao.TabIndex = 4;
            this.lblSecao.Text = "Seção Eleitoral:";
            // 
            // txtZona
            // 
            this.txtZona.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtZona.Location = new System.Drawing.Point(274, 64);
            this.txtZona.Name = "txtZona";
            this.txtZona.Size = new System.Drawing.Size(145, 22);
            this.txtZona.TabIndex = 3;
            // 
            // lblZona
            // 
            this.lblZona.AutoSize = true;
            this.lblZona.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblZona.Location = new System.Drawing.Point(271, 44);
            this.lblZona.Name = "lblZona";
            this.lblZona.Size = new System.Drawing.Size(104, 16);
            this.lblZona.TabIndex = 2;
            this.lblZona.Text = "Zona  Eleitoral:";
            // 
            // cbxMunicipio
            // 
            this.cbxMunicipio.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxMunicipio.FormattingEnabled = true;
            this.cbxMunicipio.Location = new System.Drawing.Point(9, 63);
            this.cbxMunicipio.Name = "cbxMunicipio";
            this.cbxMunicipio.Size = new System.Drawing.Size(237, 23);
            this.cbxMunicipio.TabIndex = 1;
            // 
            // lblMunicipio
            // 
            this.lblMunicipio.AutoSize = true;
            this.lblMunicipio.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMunicipio.Location = new System.Drawing.Point(6, 44);
            this.lblMunicipio.Name = "lblMunicipio";
            this.lblMunicipio.Size = new System.Drawing.Size(74, 16);
            this.lblMunicipio.TabIndex = 0;
            this.lblMunicipio.Text = "Município:";
            // 
            // FrmUrnaEletronica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(623, 236);
            this.Controls.Add(this.gBoxUrnaEletronica);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmUrnaEletronica";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro: Urna Eletrônica";
            this.Load += new System.EventHandler(this.FrmUrnaEletronica_Load);
            this.gBoxUrnaEletronica.ResumeLayout(false);
            this.gBoxUrnaEletronica.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gBoxUrnaEletronica;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.TextBox txtSecao;
        private System.Windows.Forms.Label lblSecao;
        private System.Windows.Forms.TextBox txtZona;
        private System.Windows.Forms.Label lblZona;
        private System.Windows.Forms.ComboBox cbxMunicipio;
        private System.Windows.Forms.Label lblMunicipio;
    }
}