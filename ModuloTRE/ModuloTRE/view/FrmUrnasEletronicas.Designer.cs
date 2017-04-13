namespace ModuloTRE.view
{
    partial class FrmUrnasEletronicas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUrnasEletronicas));
            this.btnListar = new System.Windows.Forms.Button();
            this.gBoxUrnasEletronicas = new System.Windows.Forms.GroupBox();
            this.ltvUrnasEletronicas = new System.Windows.Forms.ListView();
            this.columnMunicipio = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnZona = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnSecao = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gBoxUrnasEletronicas.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnListar
            // 
            this.btnListar.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListar.Location = new System.Drawing.Point(209, 432);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(75, 23);
            this.btnListar.TabIndex = 4;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // gBoxUrnasEletronicas
            // 
            this.gBoxUrnasEletronicas.Controls.Add(this.ltvUrnasEletronicas);
            this.gBoxUrnasEletronicas.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gBoxUrnasEletronicas.Location = new System.Drawing.Point(12, 12);
            this.gBoxUrnasEletronicas.Name = "gBoxUrnasEletronicas";
            this.gBoxUrnasEletronicas.Size = new System.Drawing.Size(462, 407);
            this.gBoxUrnasEletronicas.TabIndex = 3;
            this.gBoxUrnasEletronicas.TabStop = false;
            this.gBoxUrnasEletronicas.Text = "Dados das Urnas Eletrônicas";
            // 
            // ltvUrnasEletronicas
            // 
            this.ltvUrnasEletronicas.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnMunicipio,
            this.columnZona,
            this.columnSecao});
            this.ltvUrnasEletronicas.FullRowSelect = true;
            this.ltvUrnasEletronicas.GridLines = true;
            this.ltvUrnasEletronicas.Location = new System.Drawing.Point(21, 32);
            this.ltvUrnasEletronicas.Name = "ltvUrnasEletronicas";
            this.ltvUrnasEletronicas.Size = new System.Drawing.Size(419, 358);
            this.ltvUrnasEletronicas.TabIndex = 0;
            this.ltvUrnasEletronicas.UseCompatibleStateImageBehavior = false;
            this.ltvUrnasEletronicas.View = System.Windows.Forms.View.Details;
            // 
            // columnMunicipio
            // 
            this.columnMunicipio.Text = "Município";
            this.columnMunicipio.Width = 188;
            // 
            // columnZona
            // 
            this.columnZona.Text = "Zona Eleitoral";
            this.columnZona.Width = 105;
            // 
            // columnSecao
            // 
            this.columnSecao.Text = "Seção Eleitoral";
            this.columnSecao.Width = 115;
            // 
            // FrmUrnasEletronicas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(487, 462);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.gBoxUrnasEletronicas);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmUrnasEletronicas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Visualizar Urnas Eletrônicas";
            this.gBoxUrnasEletronicas.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.GroupBox gBoxUrnasEletronicas;
        private System.Windows.Forms.ListView ltvUrnasEletronicas;
        private System.Windows.Forms.ColumnHeader columnMunicipio;
        private System.Windows.Forms.ColumnHeader columnZona;
        private System.Windows.Forms.ColumnHeader columnSecao;
    }
}