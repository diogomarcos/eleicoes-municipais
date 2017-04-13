namespace ModuloTRE.view
{
    partial class FrmPartidos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPartidos));
            this.btnListar = new System.Windows.Forms.Button();
            this.gBoxPartidos = new System.Windows.Forms.GroupBox();
            this.ltvPartidos = new System.Windows.Forms.ListView();
            this.columnNome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnSigla = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gBoxPartidos.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnListar
            // 
            this.btnListar.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListar.Location = new System.Drawing.Point(184, 415);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(75, 23);
            this.btnListar.TabIndex = 3;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // gBoxPartidos
            // 
            this.gBoxPartidos.Controls.Add(this.ltvPartidos);
            this.gBoxPartidos.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gBoxPartidos.Location = new System.Drawing.Point(12, 12);
            this.gBoxPartidos.Name = "gBoxPartidos";
            this.gBoxPartidos.Size = new System.Drawing.Size(409, 381);
            this.gBoxPartidos.TabIndex = 2;
            this.gBoxPartidos.TabStop = false;
            this.gBoxPartidos.Text = "Dados dos Partidos";
            // 
            // ltvPartidos
            // 
            this.ltvPartidos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnNome,
            this.columnSigla});
            this.ltvPartidos.FullRowSelect = true;
            this.ltvPartidos.GridLines = true;
            this.ltvPartidos.Location = new System.Drawing.Point(17, 30);
            this.ltvPartidos.Name = "ltvPartidos";
            this.ltvPartidos.Size = new System.Drawing.Size(375, 337);
            this.ltvPartidos.TabIndex = 0;
            this.ltvPartidos.UseCompatibleStateImageBehavior = false;
            this.ltvPartidos.View = System.Windows.Forms.View.Details;
            // 
            // columnNome
            // 
            this.columnNome.Text = "Nome";
            this.columnNome.Width = 242;
            // 
            // columnSigla
            // 
            this.columnSigla.Text = "Sigla";
            this.columnSigla.Width = 123;
            // 
            // FrmPartidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(433, 449);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.gBoxPartidos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmPartidos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Visualizar Partidos";
            this.gBoxPartidos.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.GroupBox gBoxPartidos;
        private System.Windows.Forms.ListView ltvPartidos;
        private System.Windows.Forms.ColumnHeader columnNome;
        private System.Windows.Forms.ColumnHeader columnSigla;
    }
}