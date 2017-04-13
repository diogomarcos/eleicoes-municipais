namespace ModuloTRE.view
{
    partial class FrmJustificativa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmJustificativa));
            this.ltvJustificativas = new System.Windows.Forms.ListView();
            this.columnNome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnNumero = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnJustificar = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // ltvJustificativas
            // 
            this.ltvJustificativas.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnNome,
            this.columnNumero,
            this.columnJustificar});
            this.ltvJustificativas.GridLines = true;
            this.ltvJustificativas.Location = new System.Drawing.Point(12, 12);
            this.ltvJustificativas.Name = "ltvJustificativas";
            this.ltvJustificativas.Size = new System.Drawing.Size(1081, 430);
            this.ltvJustificativas.TabIndex = 21;
            this.ltvJustificativas.UseCompatibleStateImageBehavior = false;
            this.ltvJustificativas.View = System.Windows.Forms.View.Details;
            // 
            // columnNome
            // 
            this.columnNome.Text = "Nome";
            this.columnNome.Width = 278;
            // 
            // columnNumero
            // 
            this.columnNumero.Text = "Número Titulo";
            this.columnNumero.Width = 149;
            // 
            // columnJustificar
            // 
            this.columnJustificar.Text = "Justificativa";
            this.columnJustificar.Width = 648;
            // 
            // FrmJustificativa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1105, 452);
            this.Controls.Add(this.ltvJustificativas);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmJustificativa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Justificativas";
            this.Load += new System.EventHandler(this.FrmJustificativa_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView ltvJustificativas;
        private System.Windows.Forms.ColumnHeader columnNome;
        private System.Windows.Forms.ColumnHeader columnNumero;
        private System.Windows.Forms.ColumnHeader columnJustificar;
    }
}