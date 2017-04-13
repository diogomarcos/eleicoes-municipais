namespace ModuloTRE.view
{
    partial class FrmApVereador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmApVereador));
            this.gBoxResultado = new System.Windows.Forms.GroupBox();
            this.txtResultado = new System.Windows.Forms.RichTextBox();
            this.ltvVereadores = new System.Windows.Forms.ListView();
            this.columnPosicao = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnNome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnNumero = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnPartido = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnVotos = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnPercentual = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btApurar = new System.Windows.Forms.Button();
            this.gBoxResultado.SuspendLayout();
            this.SuspendLayout();
            // 
            // gBoxResultado
            // 
            this.gBoxResultado.Controls.Add(this.txtResultado);
            this.gBoxResultado.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gBoxResultado.Location = new System.Drawing.Point(708, 51);
            this.gBoxResultado.Name = "gBoxResultado";
            this.gBoxResultado.Size = new System.Drawing.Size(382, 474);
            this.gBoxResultado.TabIndex = 19;
            this.gBoxResultado.TabStop = false;
            this.gBoxResultado.Text = "RESULTADO DA APURAÇÃO";
            // 
            // txtResultado
            // 
            this.txtResultado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtResultado.Enabled = false;
            this.txtResultado.Location = new System.Drawing.Point(16, 29);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(348, 426);
            this.txtResultado.TabIndex = 1;
            this.txtResultado.Text = "";
            // 
            // ltvVereadores
            // 
            this.ltvVereadores.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnPosicao,
            this.columnNome,
            this.columnNumero,
            this.columnPartido,
            this.columnVotos,
            this.columnPercentual});
            this.ltvVereadores.GridLines = true;
            this.ltvVereadores.Location = new System.Drawing.Point(15, 51);
            this.ltvVereadores.Name = "ltvVereadores";
            this.ltvVereadores.Size = new System.Drawing.Size(676, 474);
            this.ltvVereadores.TabIndex = 20;
            this.ltvVereadores.UseCompatibleStateImageBehavior = false;
            this.ltvVereadores.View = System.Windows.Forms.View.Details;
            // 
            // columnPosicao
            // 
            this.columnPosicao.Text = "Posição";
            this.columnPosicao.Width = 52;
            // 
            // columnNome
            // 
            this.columnNome.Text = "Nome";
            this.columnNome.Width = 278;
            // 
            // columnNumero
            // 
            this.columnNumero.Text = "Número";
            // 
            // columnPartido
            // 
            this.columnPartido.Text = "Partido";
            this.columnPartido.Width = 119;
            // 
            // columnVotos
            // 
            this.columnVotos.Text = "Total de Votos";
            this.columnVotos.Width = 87;
            // 
            // columnPercentual
            // 
            this.columnPercentual.Text = "Percentual";
            this.columnPercentual.Width = 74;
            // 
            // btApurar
            // 
            this.btApurar.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btApurar.Location = new System.Drawing.Point(964, 12);
            this.btApurar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btApurar.Name = "btApurar";
            this.btApurar.Size = new System.Drawing.Size(126, 23);
            this.btApurar.TabIndex = 22;
            this.btApurar.Text = "Mostrar Resultado";
            this.btApurar.UseVisualStyleBackColor = true;
            this.btApurar.Click += new System.EventHandler(this.btApurar_Click);
            // 
            // FrmApVereador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1102, 537);
            this.Controls.Add(this.btApurar);
            this.Controls.Add(this.ltvVereadores);
            this.Controls.Add(this.gBoxResultado);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmApVereador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Apuração Votos Vereadores";
            this.Load += new System.EventHandler(this.FrmApVereador_Load);
            this.gBoxResultado.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gBoxResultado;
        private System.Windows.Forms.RichTextBox txtResultado;
        private System.Windows.Forms.ListView ltvVereadores;
        private System.Windows.Forms.ColumnHeader columnPosicao;
        private System.Windows.Forms.ColumnHeader columnNome;
        private System.Windows.Forms.ColumnHeader columnVotos;
        private System.Windows.Forms.ColumnHeader columnPercentual;
        private System.Windows.Forms.Button btApurar;
        private System.Windows.Forms.ColumnHeader columnNumero;
        private System.Windows.Forms.ColumnHeader columnPartido;
    }
}