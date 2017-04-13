namespace ModuloTRE.cadastre
{
    partial class FrmCandidato
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCandidato));
            this.gBoxCandidato = new System.Windows.Forms.GroupBox();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.rBtnVereador = new System.Windows.Forms.RadioButton();
            this.rBtnPrefeito = new System.Windows.Forms.RadioButton();
            this.lblCargo = new System.Windows.Forms.Label();
            this.cbxPartido = new System.Windows.Forms.ComboBox();
            this.lblPartido = new System.Windows.Forms.Label();
            this.cbxMunicipio = new System.Windows.Forms.ComboBox();
            this.lblMunicipio = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.lblNumero = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.gBoxCandidato.SuspendLayout();
            this.SuspendLayout();
            // 
            // gBoxCandidato
            // 
            this.gBoxCandidato.Controls.Add(this.btnSair);
            this.gBoxCandidato.Controls.Add(this.btnLimpar);
            this.gBoxCandidato.Controls.Add(this.btnSalvar);
            this.gBoxCandidato.Controls.Add(this.rBtnVereador);
            this.gBoxCandidato.Controls.Add(this.rBtnPrefeito);
            this.gBoxCandidato.Controls.Add(this.lblCargo);
            this.gBoxCandidato.Controls.Add(this.cbxPartido);
            this.gBoxCandidato.Controls.Add(this.lblPartido);
            this.gBoxCandidato.Controls.Add(this.cbxMunicipio);
            this.gBoxCandidato.Controls.Add(this.lblMunicipio);
            this.gBoxCandidato.Controls.Add(this.txtNumero);
            this.gBoxCandidato.Controls.Add(this.lblNumero);
            this.gBoxCandidato.Controls.Add(this.txtNome);
            this.gBoxCandidato.Controls.Add(this.lblNome);
            this.gBoxCandidato.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gBoxCandidato.Location = new System.Drawing.Point(12, 12);
            this.gBoxCandidato.Name = "gBoxCandidato";
            this.gBoxCandidato.Size = new System.Drawing.Size(458, 277);
            this.gBoxCandidato.TabIndex = 1;
            this.gBoxCandidato.TabStop = false;
            this.gBoxCandidato.Text = "Cadastro de Candidato";
            // 
            // btnSair
            // 
            this.btnSair.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Location = new System.Drawing.Point(286, 237);
            this.btnSair.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(74, 23);
            this.btnSair.TabIndex = 13;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Location = new System.Drawing.Point(191, 237);
            this.btnLimpar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(74, 23);
            this.btnLimpar.TabIndex = 12;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.Location = new System.Drawing.Point(98, 237);
            this.btnSalvar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(74, 23);
            this.btnSalvar.TabIndex = 11;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // rBtnVereador
            // 
            this.rBtnVereador.AutoSize = true;
            this.rBtnVereador.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rBtnVereador.Location = new System.Drawing.Point(128, 183);
            this.rBtnVereador.Name = "rBtnVereador";
            this.rBtnVereador.Size = new System.Drawing.Size(84, 20);
            this.rBtnVereador.TabIndex = 10;
            this.rBtnVereador.TabStop = true;
            this.rBtnVereador.Text = "Vereador";
            this.rBtnVereador.UseVisualStyleBackColor = true;
            // 
            // rBtnPrefeito
            // 
            this.rBtnPrefeito.AutoSize = true;
            this.rBtnPrefeito.Checked = true;
            this.rBtnPrefeito.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rBtnPrefeito.Location = new System.Drawing.Point(23, 183);
            this.rBtnPrefeito.Name = "rBtnPrefeito";
            this.rBtnPrefeito.Size = new System.Drawing.Size(76, 20);
            this.rBtnPrefeito.TabIndex = 9;
            this.rBtnPrefeito.TabStop = true;
            this.rBtnPrefeito.Text = "Prefeito";
            this.rBtnPrefeito.UseVisualStyleBackColor = true;
            // 
            // lblCargo
            // 
            this.lblCargo.AutoSize = true;
            this.lblCargo.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCargo.Location = new System.Drawing.Point(6, 164);
            this.lblCargo.Name = "lblCargo";
            this.lblCargo.Size = new System.Drawing.Size(50, 16);
            this.lblCargo.TabIndex = 8;
            this.lblCargo.Text = "Cargo:";
            // 
            // cbxPartido
            // 
            this.cbxPartido.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxPartido.FormattingEnabled = true;
            this.cbxPartido.Location = new System.Drawing.Point(326, 115);
            this.cbxPartido.Name = "cbxPartido";
            this.cbxPartido.Size = new System.Drawing.Size(121, 23);
            this.cbxPartido.TabIndex = 7;
            // 
            // lblPartido
            // 
            this.lblPartido.AutoSize = true;
            this.lblPartido.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPartido.Location = new System.Drawing.Point(322, 96);
            this.lblPartido.Name = "lblPartido";
            this.lblPartido.Size = new System.Drawing.Size(58, 16);
            this.lblPartido.TabIndex = 6;
            this.lblPartido.Text = "Partido:";
            // 
            // cbxMunicipio
            // 
            this.cbxMunicipio.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxMunicipio.FormattingEnabled = true;
            this.cbxMunicipio.Location = new System.Drawing.Point(9, 115);
            this.cbxMunicipio.Name = "cbxMunicipio";
            this.cbxMunicipio.Size = new System.Drawing.Size(269, 23);
            this.cbxMunicipio.TabIndex = 5;
            // 
            // lblMunicipio
            // 
            this.lblMunicipio.AutoSize = true;
            this.lblMunicipio.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMunicipio.Location = new System.Drawing.Point(6, 96);
            this.lblMunicipio.Name = "lblMunicipio";
            this.lblMunicipio.Size = new System.Drawing.Size(74, 16);
            this.lblMunicipio.TabIndex = 4;
            this.lblMunicipio.Text = "Município:";
            // 
            // txtNumero
            // 
            this.txtNumero.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumero.Location = new System.Drawing.Point(262, 53);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(185, 22);
            this.txtNumero.TabIndex = 3;
            this.txtNumero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumero_KeyPress);
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumero.Location = new System.Drawing.Point(259, 34);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(131, 16);
            this.lblNumero.TabIndex = 2;
            this.lblNumero.Text = "Número Candidato:";
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(9, 53);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(225, 22);
            this.txtNome.TabIndex = 1;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(6, 34);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(49, 16);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome:";
            // 
            // FrmCandidato
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(482, 299);
            this.Controls.Add(this.gBoxCandidato);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmCandidato";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro: Candidato";
            this.Load += new System.EventHandler(this.FrmCandidato_Load);
            this.gBoxCandidato.ResumeLayout(false);
            this.gBoxCandidato.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gBoxCandidato;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.RadioButton rBtnVereador;
        private System.Windows.Forms.RadioButton rBtnPrefeito;
        private System.Windows.Forms.Label lblCargo;
        private System.Windows.Forms.ComboBox cbxPartido;
        private System.Windows.Forms.Label lblPartido;
        private System.Windows.Forms.ComboBox cbxMunicipio;
        private System.Windows.Forms.Label lblMunicipio;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblNome;
    }
}