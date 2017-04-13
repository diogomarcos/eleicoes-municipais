namespace ModuloTRE.view
{
    partial class FrmEleitores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEleitores));
            this.btnListar = new System.Windows.Forms.Button();
            this.gBoxEleitores = new System.Windows.Forms.GroupBox();
            this.ltvEleitores = new System.Windows.Forms.ListView();
            this.columnNome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnNumero = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnMunicipio = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnZona = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnSecao = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gBoxEleitores.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnListar
            // 
            this.btnListar.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListar.Location = new System.Drawing.Point(356, 404);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(75, 23);
            this.btnListar.TabIndex = 4;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // gBoxEleitores
            // 
            this.gBoxEleitores.Controls.Add(this.ltvEleitores);
            this.gBoxEleitores.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gBoxEleitores.Location = new System.Drawing.Point(12, 12);
            this.gBoxEleitores.Name = "gBoxEleitores";
            this.gBoxEleitores.Size = new System.Drawing.Size(746, 369);
            this.gBoxEleitores.TabIndex = 3;
            this.gBoxEleitores.TabStop = false;
            this.gBoxEleitores.Text = "Dados dos Eleitores";
            // 
            // ltvEleitores
            // 
            this.ltvEleitores.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnNome,
            this.columnNumero,
            this.columnMunicipio,
            this.columnZona,
            this.columnSecao});
            this.ltvEleitores.FullRowSelect = true;
            this.ltvEleitores.GridLines = true;
            this.ltvEleitores.Location = new System.Drawing.Point(18, 30);
            this.ltvEleitores.Name = "ltvEleitores";
            this.ltvEleitores.Size = new System.Drawing.Size(706, 320);
            this.ltvEleitores.TabIndex = 0;
            this.ltvEleitores.UseCompatibleStateImageBehavior = false;
            this.ltvEleitores.View = System.Windows.Forms.View.Details;
            // 
            // columnNome
            // 
            this.columnNome.Text = "Nome";
            this.columnNome.Width = 215;
            // 
            // columnNumero
            // 
            this.columnNumero.Text = "Número Título";
            this.columnNumero.Width = 123;
            // 
            // columnMunicipio
            // 
            this.columnMunicipio.Text = "Município";
            this.columnMunicipio.Width = 155;
            // 
            // columnZona
            // 
            this.columnZona.Text = "Zona Eleitoral";
            this.columnZona.Width = 103;
            // 
            // columnSecao
            // 
            this.columnSecao.Text = "Seção Eleitoral";
            this.columnSecao.Width = 99;
            // 
            // FrmEleitores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(768, 435);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.gBoxEleitores);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmEleitores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Visualizar Eleitores";
            this.gBoxEleitores.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.GroupBox gBoxEleitores;
        private System.Windows.Forms.ListView ltvEleitores;
        private System.Windows.Forms.ColumnHeader columnNome;
        private System.Windows.Forms.ColumnHeader columnNumero;
        private System.Windows.Forms.ColumnHeader columnMunicipio;
        private System.Windows.Forms.ColumnHeader columnZona;
        private System.Windows.Forms.ColumnHeader columnSecao;
    }
}