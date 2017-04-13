namespace ModuloTRE.cadastre
{
    partial class FrmImportar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmImportar));
            this.gBoxImportar = new System.Windows.Forms.GroupBox();
            this.lblMunicipio = new System.Windows.Forms.Label();
            this.cbxMunicipio = new System.Windows.Forms.ComboBox();
            this.btnImportar = new System.Windows.Forms.Button();
            this.gBoxImportar.SuspendLayout();
            this.SuspendLayout();
            // 
            // gBoxImportar
            // 
            this.gBoxImportar.Controls.Add(this.lblMunicipio);
            this.gBoxImportar.Controls.Add(this.cbxMunicipio);
            this.gBoxImportar.Controls.Add(this.btnImportar);
            this.gBoxImportar.Location = new System.Drawing.Point(12, 12);
            this.gBoxImportar.Name = "gBoxImportar";
            this.gBoxImportar.Size = new System.Drawing.Size(333, 134);
            this.gBoxImportar.TabIndex = 19;
            this.gBoxImportar.TabStop = false;
            this.gBoxImportar.Text = "Importar dados Apuração";
            // 
            // lblMunicipio
            // 
            this.lblMunicipio.AutoSize = true;
            this.lblMunicipio.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMunicipio.Location = new System.Drawing.Point(6, 29);
            this.lblMunicipio.Name = "lblMunicipio";
            this.lblMunicipio.Size = new System.Drawing.Size(74, 16);
            this.lblMunicipio.TabIndex = 18;
            this.lblMunicipio.Text = "Município:";
            // 
            // cbxMunicipio
            // 
            this.cbxMunicipio.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxMunicipio.FormattingEnabled = true;
            this.cbxMunicipio.Location = new System.Drawing.Point(9, 48);
            this.cbxMunicipio.Name = "cbxMunicipio";
            this.cbxMunicipio.Size = new System.Drawing.Size(310, 23);
            this.cbxMunicipio.TabIndex = 19;
            // 
            // btnImportar
            // 
            this.btnImportar.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImportar.Location = new System.Drawing.Point(245, 94);
            this.btnImportar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnImportar.Name = "btnImportar";
            this.btnImportar.Size = new System.Drawing.Size(74, 23);
            this.btnImportar.TabIndex = 17;
            this.btnImportar.Text = "Importar";
            this.btnImportar.UseVisualStyleBackColor = true;
            this.btnImportar.Click += new System.EventHandler(this.btnImportar_Click);
            // 
            // FrmImportar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(358, 158);
            this.Controls.Add(this.gBoxImportar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmImportar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Importar Dados";
            this.Load += new System.EventHandler(this.FrmImportar_Load);
            this.gBoxImportar.ResumeLayout(false);
            this.gBoxImportar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gBoxImportar;
        private System.Windows.Forms.Label lblMunicipio;
        private System.Windows.Forms.ComboBox cbxMunicipio;
        private System.Windows.Forms.Button btnImportar;
    }
}