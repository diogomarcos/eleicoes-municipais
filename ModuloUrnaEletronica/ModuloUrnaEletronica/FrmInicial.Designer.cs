namespace ModuloUrnaEletronica
{
    partial class FrmInicial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmInicial));
            this.btnClose = new System.Windows.Forms.Button();
            this.LblAreaRestrita = new System.Windows.Forms.LinkLabel();
            this.btnVotar = new System.Windows.Forms.Button();
            this.btnJustificar = new System.Windows.Forms.Button();
            this.gBoxAreaRestrita = new System.Windows.Forms.GroupBox();
            this.btnFechar = new System.Windows.Forms.Button();
            this.btnEntrar = new System.Windows.Forms.Button();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.lblSenha = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.gBoxAreaRestrita.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.FlatAppearance.BorderColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(573, 2);
            this.btnClose.Margin = new System.Windows.Forms.Padding(0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(41, 40);
            this.btnClose.TabIndex = 0;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // LblAreaRestrita
            // 
            this.LblAreaRestrita.AutoSize = true;
            this.LblAreaRestrita.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LblAreaRestrita.Location = new System.Drawing.Point(12, 348);
            this.LblAreaRestrita.Name = "LblAreaRestrita";
            this.LblAreaRestrita.Size = new System.Drawing.Size(68, 13);
            this.LblAreaRestrita.TabIndex = 1;
            this.LblAreaRestrita.TabStop = true;
            this.LblAreaRestrita.Text = "Área Restrita";
            this.LblAreaRestrita.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LblAreaRestrita_LinkClicked);
            // 
            // btnVotar
            // 
            this.btnVotar.BackColor = System.Drawing.Color.Green;
            this.btnVotar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnVotar.BackgroundImage")));
            this.btnVotar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVotar.Location = new System.Drawing.Point(57, 110);
            this.btnVotar.Name = "btnVotar";
            this.btnVotar.Size = new System.Drawing.Size(250, 120);
            this.btnVotar.TabIndex = 2;
            this.btnVotar.UseVisualStyleBackColor = false;
            this.btnVotar.Click += new System.EventHandler(this.btnVotar_Click);
            // 
            // btnJustificar
            // 
            this.btnJustificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnJustificar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnJustificar.BackgroundImage")));
            this.btnJustificar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnJustificar.Location = new System.Drawing.Point(313, 110);
            this.btnJustificar.Name = "btnJustificar";
            this.btnJustificar.Size = new System.Drawing.Size(250, 120);
            this.btnJustificar.TabIndex = 3;
            this.btnJustificar.UseVisualStyleBackColor = false;
            this.btnJustificar.Click += new System.EventHandler(this.btnJustificar_Click);
            // 
            // gBoxAreaRestrita
            // 
            this.gBoxAreaRestrita.BackColor = System.Drawing.Color.Transparent;
            this.gBoxAreaRestrita.Controls.Add(this.btnFechar);
            this.gBoxAreaRestrita.Controls.Add(this.btnEntrar);
            this.gBoxAreaRestrita.Controls.Add(this.txtSenha);
            this.gBoxAreaRestrita.Controls.Add(this.lblSenha);
            this.gBoxAreaRestrita.Controls.Add(this.txtUsuario);
            this.gBoxAreaRestrita.Controls.Add(this.lblUsuario);
            this.gBoxAreaRestrita.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gBoxAreaRestrita.Location = new System.Drawing.Point(57, 95);
            this.gBoxAreaRestrita.Name = "gBoxAreaRestrita";
            this.gBoxAreaRestrita.Size = new System.Drawing.Size(506, 170);
            this.gBoxAreaRestrita.TabIndex = 4;
            this.gBoxAreaRestrita.TabStop = false;
            this.gBoxAreaRestrita.Text = "Área Restrita";
            this.gBoxAreaRestrita.Visible = false;
            // 
            // btnFechar
            // 
            this.btnFechar.BackColor = System.Drawing.Color.Transparent;
            this.btnFechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFechar.FlatAppearance.BorderColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnFechar.FlatAppearance.BorderSize = 0;
            this.btnFechar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnFechar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFechar.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnFechar.Image = ((System.Drawing.Image)(resources.GetObject("btnFechar.Image")));
            this.btnFechar.Location = new System.Drawing.Point(463, 9);
            this.btnFechar.Margin = new System.Windows.Forms.Padding(0);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(41, 40);
            this.btnFechar.TabIndex = 18;
            this.btnFechar.UseVisualStyleBackColor = false;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // btnEntrar
            // 
            this.btnEntrar.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEntrar.Location = new System.Drawing.Point(394, 112);
            this.btnEntrar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Size = new System.Drawing.Size(83, 23);
            this.btnEntrar.TabIndex = 17;
            this.btnEntrar.Text = "Entrar";
            this.btnEntrar.UseVisualStyleBackColor = true;
            this.btnEntrar.Click += new System.EventHandler(this.btnEntrar_Click);
            // 
            // txtSenha
            // 
            this.txtSenha.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenha.Location = new System.Drawing.Point(347, 62);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(130, 22);
            this.txtSenha.TabIndex = 14;
            this.txtSenha.UseSystemPasswordChar = true;
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenha.Location = new System.Drawing.Point(288, 65);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(53, 16);
            this.lblSenha.TabIndex = 13;
            this.lblSenha.Text = "Senha:";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.Location = new System.Drawing.Point(97, 59);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(167, 22);
            this.txtUsuario.TabIndex = 12;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.Location = new System.Drawing.Point(32, 62);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(59, 16);
            this.lblUsuario.TabIndex = 11;
            this.lblUsuario.Text = "Usuário:";
            // 
            // FrmInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(616, 370);
            this.Controls.Add(this.gBoxAreaRestrita);
            this.Controls.Add(this.btnJustificar);
            this.Controls.Add(this.btnVotar);
            this.Controls.Add(this.LblAreaRestrita);
            this.Controls.Add(this.btnClose);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmInicial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Módulo Urna Eletrônica";
            this.Load += new System.EventHandler(this.FrmInicial_Load);
            this.gBoxAreaRestrita.ResumeLayout(false);
            this.gBoxAreaRestrita.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.LinkLabel LblAreaRestrita;
        private System.Windows.Forms.Button btnVotar;
        private System.Windows.Forms.Button btnJustificar;
        private System.Windows.Forms.GroupBox gBoxAreaRestrita;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Button btnEntrar;
        private System.Windows.Forms.Button btnFechar;
    }
}

