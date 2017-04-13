namespace ModuloTRE.cadastre
{
    partial class FrmMunicipio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMunicipio));
            this.gBoxMunicipio = new System.Windows.Forms.GroupBox();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.nUpDownVagasVereadores = new System.Windows.Forms.NumericUpDown();
            this.lblVagasVereadores = new System.Windows.Forms.Label();
            this.nUpDownHabitantes = new System.Windows.Forms.NumericUpDown();
            this.lblTHabitantes = new System.Windows.Forms.Label();
            this.cbxEstado = new System.Windows.Forms.ComboBox();
            this.lblEstado = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.gBoxMunicipio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUpDownVagasVereadores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUpDownHabitantes)).BeginInit();
            this.SuspendLayout();
            // 
            // gBoxMunicipio
            // 
            this.gBoxMunicipio.Controls.Add(this.btnSair);
            this.gBoxMunicipio.Controls.Add(this.btnLimpar);
            this.gBoxMunicipio.Controls.Add(this.btnSalvar);
            this.gBoxMunicipio.Controls.Add(this.nUpDownVagasVereadores);
            this.gBoxMunicipio.Controls.Add(this.lblVagasVereadores);
            this.gBoxMunicipio.Controls.Add(this.nUpDownHabitantes);
            this.gBoxMunicipio.Controls.Add(this.lblTHabitantes);
            this.gBoxMunicipio.Controls.Add(this.cbxEstado);
            this.gBoxMunicipio.Controls.Add(this.lblEstado);
            this.gBoxMunicipio.Controls.Add(this.txtNome);
            this.gBoxMunicipio.Controls.Add(this.lblNome);
            this.gBoxMunicipio.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gBoxMunicipio.Location = new System.Drawing.Point(12, 12);
            this.gBoxMunicipio.Name = "gBoxMunicipio";
            this.gBoxMunicipio.Size = new System.Drawing.Size(386, 237);
            this.gBoxMunicipio.TabIndex = 1;
            this.gBoxMunicipio.TabStop = false;
            this.gBoxMunicipio.Text = "Cadastro de Município";
            // 
            // btnSair
            // 
            this.btnSair.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Location = new System.Drawing.Point(246, 189);
            this.btnSair.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(74, 23);
            this.btnSair.TabIndex = 10;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Location = new System.Drawing.Point(151, 189);
            this.btnLimpar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(74, 23);
            this.btnLimpar.TabIndex = 9;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.Location = new System.Drawing.Point(58, 189);
            this.btnSalvar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(74, 23);
            this.btnSalvar.TabIndex = 8;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // nUpDownVagasVereadores
            // 
            this.nUpDownVagasVereadores.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nUpDownVagasVereadores.Location = new System.Drawing.Point(191, 123);
            this.nUpDownVagasVereadores.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nUpDownVagasVereadores.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nUpDownVagasVereadores.Name = "nUpDownVagasVereadores";
            this.nUpDownVagasVereadores.Size = new System.Drawing.Size(120, 22);
            this.nUpDownVagasVereadores.TabIndex = 7;
            this.nUpDownVagasVereadores.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblVagasVereadores
            // 
            this.lblVagasVereadores.AutoSize = true;
            this.lblVagasVereadores.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVagasVereadores.Location = new System.Drawing.Point(188, 104);
            this.lblVagasVereadores.Name = "lblVagasVereadores";
            this.lblVagasVereadores.Size = new System.Drawing.Size(144, 16);
            this.lblVagasVereadores.TabIndex = 6;
            this.lblVagasVereadores.Text = "Nº Vagas Vereadores:";
            // 
            // nUpDownHabitantes
            // 
            this.nUpDownHabitantes.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nUpDownHabitantes.Location = new System.Drawing.Point(9, 123);
            this.nUpDownHabitantes.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.nUpDownHabitantes.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nUpDownHabitantes.Name = "nUpDownHabitantes";
            this.nUpDownHabitantes.Size = new System.Drawing.Size(149, 22);
            this.nUpDownHabitantes.TabIndex = 5;
            this.nUpDownHabitantes.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // lblTHabitantes
            // 
            this.lblTHabitantes.AutoSize = true;
            this.lblTHabitantes.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTHabitantes.Location = new System.Drawing.Point(6, 104);
            this.lblTHabitantes.Name = "lblTHabitantes";
            this.lblTHabitantes.Size = new System.Drawing.Size(97, 16);
            this.lblTHabitantes.TabIndex = 4;
            this.lblTHabitantes.Text = "Nº Habitantes:";
            // 
            // cbxEstado
            // 
            this.cbxEstado.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxEstado.FormattingEnabled = true;
            this.cbxEstado.Location = new System.Drawing.Point(293, 51);
            this.cbxEstado.Name = "cbxEstado";
            this.cbxEstado.Size = new System.Drawing.Size(69, 23);
            this.cbxEstado.TabIndex = 3;
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.Location = new System.Drawing.Point(290, 33);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(54, 16);
            this.lblEstado.TabIndex = 2;
            this.lblEstado.Text = "Estado:";
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(9, 52);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(256, 22);
            this.txtNome.TabIndex = 1;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(6, 33);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(49, 16);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome:";
            // 
            // FrmMunicipio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(411, 262);
            this.Controls.Add(this.gBoxMunicipio);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmMunicipio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro: Municipio";
            this.Load += new System.EventHandler(this.FrmMunicipio_Load);
            this.gBoxMunicipio.ResumeLayout(false);
            this.gBoxMunicipio.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUpDownVagasVereadores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUpDownHabitantes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gBoxMunicipio;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.NumericUpDown nUpDownVagasVereadores;
        private System.Windows.Forms.Label lblVagasVereadores;
        private System.Windows.Forms.NumericUpDown nUpDownHabitantes;
        private System.Windows.Forms.Label lblTHabitantes;
        private System.Windows.Forms.ComboBox cbxEstado;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblNome;
    }
}