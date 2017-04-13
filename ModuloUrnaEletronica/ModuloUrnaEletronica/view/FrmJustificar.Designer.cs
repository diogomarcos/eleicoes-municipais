namespace ModuloUrnaEletronica.view
{
    partial class FrmJustificar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmJustificar));
            this.gBoxJustificar = new System.Windows.Forms.GroupBox();
            this.txtNumero = new System.Windows.Forms.MaskedTextBox();
            this.btnJustificar = new System.Windows.Forms.Button();
            this.lblJustificativa = new System.Windows.Forms.Label();
            this.lblNumero = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtJustificativa = new System.Windows.Forms.RichTextBox();
            this.gBoxJustificar.SuspendLayout();
            this.SuspendLayout();
            // 
            // gBoxJustificar
            // 
            this.gBoxJustificar.Controls.Add(this.txtNumero);
            this.gBoxJustificar.Controls.Add(this.btnJustificar);
            this.gBoxJustificar.Controls.Add(this.lblJustificativa);
            this.gBoxJustificar.Controls.Add(this.lblNumero);
            this.gBoxJustificar.Controls.Add(this.txtNome);
            this.gBoxJustificar.Controls.Add(this.lblNome);
            this.gBoxJustificar.Controls.Add(this.txtJustificativa);
            this.gBoxJustificar.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gBoxJustificar.Location = new System.Drawing.Point(12, 12);
            this.gBoxJustificar.Name = "gBoxJustificar";
            this.gBoxJustificar.Size = new System.Drawing.Size(506, 285);
            this.gBoxJustificar.TabIndex = 0;
            this.gBoxJustificar.TabStop = false;
            this.gBoxJustificar.Text = "Justificar";
            // 
            // txtNumero
            // 
            this.txtNumero.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumero.Location = new System.Drawing.Point(293, 44);
            this.txtNumero.Mask = "0000,0000,0000";
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(100, 22);
            this.txtNumero.TabIndex = 1;
            // 
            // btnJustificar
            // 
            this.btnJustificar.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJustificar.Location = new System.Drawing.Point(414, 235);
            this.btnJustificar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnJustificar.Name = "btnJustificar";
            this.btnJustificar.Size = new System.Drawing.Size(83, 23);
            this.btnJustificar.TabIndex = 17;
            this.btnJustificar.Text = "Justificar";
            this.btnJustificar.UseVisualStyleBackColor = true;
            this.btnJustificar.Click += new System.EventHandler(this.btnJustificar_Click);
            // 
            // lblJustificativa
            // 
            this.lblJustificativa.AutoSize = true;
            this.lblJustificativa.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJustificativa.Location = new System.Drawing.Point(6, 90);
            this.lblJustificativa.Name = "lblJustificativa";
            this.lblJustificativa.Size = new System.Drawing.Size(87, 16);
            this.lblJustificativa.TabIndex = 8;
            this.lblJustificativa.Text = "Justificativa:";
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumero.Location = new System.Drawing.Point(290, 25);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(122, 16);
            this.lblNumero.TabIndex = 6;
            this.lblNumero.Text = "Número do Título:";
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(9, 44);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(254, 22);
            this.txtNome.TabIndex = 0;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(6, 25);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(49, 16);
            this.lblNome.TabIndex = 4;
            this.lblNome.Text = "Nome:";
            // 
            // txtJustificativa
            // 
            this.txtJustificativa.Location = new System.Drawing.Point(9, 109);
            this.txtJustificativa.Name = "txtJustificativa";
            this.txtJustificativa.Size = new System.Drawing.Size(488, 96);
            this.txtJustificativa.TabIndex = 2;
            this.txtJustificativa.Text = "";
            // 
            // FrmJustificar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(533, 310);
            this.Controls.Add(this.gBoxJustificar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmJustificar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Justificar Voto";
            this.gBoxJustificar.ResumeLayout(false);
            this.gBoxJustificar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gBoxJustificar;
        private System.Windows.Forms.Label lblJustificativa;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.RichTextBox txtJustificativa;
        private System.Windows.Forms.Button btnJustificar;
        private System.Windows.Forms.MaskedTextBox txtNumero;
    }
}