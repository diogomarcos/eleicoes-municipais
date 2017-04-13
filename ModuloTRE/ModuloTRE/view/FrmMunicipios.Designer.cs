namespace ModuloTRE.view
{
    partial class FrmMunicipios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMunicipios));
            this.btnListar = new System.Windows.Forms.Button();
            this.gBoxMunicipios = new System.Windows.Forms.GroupBox();
            this.ltvMunicipios = new System.Windows.Forms.ListView();
            this.columnNome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnEstado = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnNHabitantes = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnVVereador = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gBoxMunicipios.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnListar
            // 
            this.btnListar.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListar.Location = new System.Drawing.Point(247, 410);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(75, 23);
            this.btnListar.TabIndex = 4;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // gBoxMunicipios
            // 
            this.gBoxMunicipios.Controls.Add(this.ltvMunicipios);
            this.gBoxMunicipios.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gBoxMunicipios.Location = new System.Drawing.Point(12, 12);
            this.gBoxMunicipios.Name = "gBoxMunicipios";
            this.gBoxMunicipios.Size = new System.Drawing.Size(540, 377);
            this.gBoxMunicipios.TabIndex = 3;
            this.gBoxMunicipios.TabStop = false;
            this.gBoxMunicipios.Text = "Dados dos Municípios";
            // 
            // ltvMunicipios
            // 
            this.ltvMunicipios.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnNome,
            this.columnEstado,
            this.columnNHabitantes,
            this.columnVVereador});
            this.ltvMunicipios.FullRowSelect = true;
            this.ltvMunicipios.GridLines = true;
            this.ltvMunicipios.Location = new System.Drawing.Point(18, 29);
            this.ltvMunicipios.Name = "ltvMunicipios";
            this.ltvMunicipios.Size = new System.Drawing.Size(504, 332);
            this.ltvMunicipios.TabIndex = 0;
            this.ltvMunicipios.UseCompatibleStateImageBehavior = false;
            this.ltvMunicipios.View = System.Windows.Forms.View.Details;
            // 
            // columnNome
            // 
            this.columnNome.Text = "Nome";
            this.columnNome.Width = 228;
            // 
            // columnEstado
            // 
            this.columnEstado.Text = "Estado";
            this.columnEstado.Width = 68;
            // 
            // columnNHabitantes
            // 
            this.columnNHabitantes.Text = "Nº Habitantes";
            this.columnNHabitantes.Width = 95;
            // 
            // columnVVereador
            // 
            this.columnVVereador.Text = "Vagas Vereador";
            this.columnVVereador.Width = 104;
            // 
            // FrmMunicipios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(565, 440);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.gBoxMunicipios);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmMunicipios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Visualizar Municípios";
            this.gBoxMunicipios.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.GroupBox gBoxMunicipios;
        private System.Windows.Forms.ListView ltvMunicipios;
        private System.Windows.Forms.ColumnHeader columnNome;
        private System.Windows.Forms.ColumnHeader columnEstado;
        private System.Windows.Forms.ColumnHeader columnNHabitantes;
        private System.Windows.Forms.ColumnHeader columnVVereador;
    }
}