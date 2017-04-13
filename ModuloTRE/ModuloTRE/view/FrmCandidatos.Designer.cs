namespace ModuloTRE.view
{
    partial class FrmCandidatos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCandidatos));
            this.gBoxCandidatos = new System.Windows.Forms.GroupBox();
            this.ltvCandidatos = new System.Windows.Forms.ListView();
            this.columnNome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnNumero = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnMunicipio = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnPartido = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnCargo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnListar = new System.Windows.Forms.Button();
            this.gBoxCandidatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // gBoxCandidatos
            // 
            this.gBoxCandidatos.Controls.Add(this.ltvCandidatos);
            this.gBoxCandidatos.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gBoxCandidatos.Location = new System.Drawing.Point(12, 12);
            this.gBoxCandidatos.Name = "gBoxCandidatos";
            this.gBoxCandidatos.Size = new System.Drawing.Size(638, 401);
            this.gBoxCandidatos.TabIndex = 1;
            this.gBoxCandidatos.TabStop = false;
            this.gBoxCandidatos.Text = "Dados dos Candidatos";
            // 
            // ltvCandidatos
            // 
            this.ltvCandidatos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnNome,
            this.columnNumero,
            this.columnMunicipio,
            this.columnPartido,
            this.columnCargo});
            this.ltvCandidatos.FullRowSelect = true;
            this.ltvCandidatos.GridLines = true;
            this.ltvCandidatos.Location = new System.Drawing.Point(19, 28);
            this.ltvCandidatos.Name = "ltvCandidatos";
            this.ltvCandidatos.Size = new System.Drawing.Size(600, 356);
            this.ltvCandidatos.TabIndex = 0;
            this.ltvCandidatos.UseCompatibleStateImageBehavior = false;
            this.ltvCandidatos.View = System.Windows.Forms.View.Details;
            // 
            // columnNome
            // 
            this.columnNome.Text = "Nome";
            this.columnNome.Width = 162;
            // 
            // columnNumero
            // 
            this.columnNumero.Text = "Número";
            this.columnNumero.Width = 94;
            // 
            // columnMunicipio
            // 
            this.columnMunicipio.Text = "Município";
            this.columnMunicipio.Width = 139;
            // 
            // columnPartido
            // 
            this.columnPartido.Text = "Partido";
            this.columnPartido.Width = 78;
            // 
            // columnCargo
            // 
            this.columnCargo.Text = "Cargo";
            this.columnCargo.Width = 116;
            // 
            // btnListar
            // 
            this.btnListar.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListar.Location = new System.Drawing.Point(301, 428);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(75, 23);
            this.btnListar.TabIndex = 3;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // FrmCandidatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(662, 459);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.gBoxCandidatos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmCandidatos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vizualizar Candidatos";
            this.gBoxCandidatos.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gBoxCandidatos;
        private System.Windows.Forms.ListView ltvCandidatos;
        private System.Windows.Forms.ColumnHeader columnNome;
        private System.Windows.Forms.ColumnHeader columnNumero;
        private System.Windows.Forms.ColumnHeader columnMunicipio;
        private System.Windows.Forms.ColumnHeader columnPartido;
        private System.Windows.Forms.ColumnHeader columnCargo;
        private System.Windows.Forms.Button btnListar;
    }
}