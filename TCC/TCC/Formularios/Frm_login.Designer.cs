namespace TCC.Formularios
{
    partial class Frm_login
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
            this.pic_voltar = new System.Windows.Forms.PictureBox();
            this.lbl_titulo = new System.Windows.Forms.Label();
            this.lbl_subTitulo = new System.Windows.Forms.Label();
            this.lbl_cpf = new System.Windows.Forms.Label();
            this.lbl_senha = new System.Windows.Forms.Label();
            this.msk_cpf = new System.Windows.Forms.MaskedTextBox();
            this.msk_senha = new System.Windows.Forms.MaskedTextBox();
            this.btn_logar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pic_voltar)).BeginInit();
            this.SuspendLayout();
            // 
            // pic_voltar
            // 
            this.pic_voltar.Location = new System.Drawing.Point(1180, 12);
            this.pic_voltar.Name = "pic_voltar";
            this.pic_voltar.Size = new System.Drawing.Size(72, 33);
            this.pic_voltar.TabIndex = 1;
            this.pic_voltar.TabStop = false;
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.AutoSize = true;
            this.lbl_titulo.BackColor = System.Drawing.Color.Transparent;
            this.lbl_titulo.Font = new System.Drawing.Font("Cooper Black", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titulo.Location = new System.Drawing.Point(509, 197);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_titulo.Size = new System.Drawing.Size(253, 74);
            this.lbl_titulo.TabIndex = 2;
            this.lbl_titulo.Text = "Entrar";
            // 
            // lbl_subTitulo
            // 
            this.lbl_subTitulo.AutoSize = true;
            this.lbl_subTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lbl_subTitulo.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_subTitulo.Location = new System.Drawing.Point(552, 284);
            this.lbl_subTitulo.Name = "lbl_subTitulo";
            this.lbl_subTitulo.Size = new System.Drawing.Size(154, 24);
            this.lbl_subTitulo.TabIndex = 3;
            this.lbl_subTitulo.Text = "Entrar na conta";
            // 
            // lbl_cpf
            // 
            this.lbl_cpf.AutoSize = true;
            this.lbl_cpf.BackColor = System.Drawing.Color.Transparent;
            this.lbl_cpf.Font = new System.Drawing.Font("Cooper Black", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cpf.Location = new System.Drawing.Point(492, 334);
            this.lbl_cpf.Name = "lbl_cpf";
            this.lbl_cpf.Size = new System.Drawing.Size(50, 21);
            this.lbl_cpf.TabIndex = 4;
            this.lbl_cpf.Text = "CPF";
            // 
            // lbl_senha
            // 
            this.lbl_senha.AutoSize = true;
            this.lbl_senha.BackColor = System.Drawing.Color.Transparent;
            this.lbl_senha.Font = new System.Drawing.Font("Cooper Black", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_senha.Location = new System.Drawing.Point(492, 439);
            this.lbl_senha.Name = "lbl_senha";
            this.lbl_senha.Size = new System.Drawing.Size(69, 21);
            this.lbl_senha.TabIndex = 5;
            this.lbl_senha.Text = "Senha";
            // 
            // msk_cpf
            // 
            this.msk_cpf.Font = new System.Drawing.Font("Cooper Black", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msk_cpf.Location = new System.Drawing.Point(496, 358);
            this.msk_cpf.Mask = "000.000.000-00";
            this.msk_cpf.Name = "msk_cpf";
            this.msk_cpf.Size = new System.Drawing.Size(284, 35);
            this.msk_cpf.TabIndex = 6;
            // 
            // msk_senha
            // 
            this.msk_senha.Font = new System.Drawing.Font("Cooper Black", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msk_senha.Location = new System.Drawing.Point(496, 463);
            this.msk_senha.Name = "msk_senha";
            this.msk_senha.PasswordChar = '*';
            this.msk_senha.Size = new System.Drawing.Size(284, 35);
            this.msk_senha.TabIndex = 7;
            // 
            // btn_logar
            // 
            this.btn_logar.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btn_logar.FlatAppearance.BorderSize = 0;
            this.btn_logar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_logar.Font = new System.Drawing.Font("Cooper Black", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_logar.ForeColor = System.Drawing.Color.White;
            this.btn_logar.Location = new System.Drawing.Point(556, 540);
            this.btn_logar.Name = "btn_logar";
            this.btn_logar.Size = new System.Drawing.Size(140, 51);
            this.btn_logar.TabIndex = 8;
            this.btn_logar.Text = "Logar";
            this.btn_logar.UseVisualStyleBackColor = false;
            this.btn_logar.Click += new System.EventHandler(this.btn_logar_Click);
            // 
            // Frm_login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TCC.Properties.Resources.BGlogin;
            this.ClientSize = new System.Drawing.Size(1264, 761);
            this.Controls.Add(this.btn_logar);
            this.Controls.Add(this.msk_senha);
            this.Controls.Add(this.msk_cpf);
            this.Controls.Add(this.lbl_senha);
            this.Controls.Add(this.lbl_cpf);
            this.Controls.Add(this.lbl_subTitulo);
            this.Controls.Add(this.lbl_titulo);
            this.Controls.Add(this.pic_voltar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "login";
            this.Load += new System.EventHandler(this.Frm_login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic_voltar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pic_voltar;
        private System.Windows.Forms.Label lbl_titulo;
        private System.Windows.Forms.Label lbl_subTitulo;
        private System.Windows.Forms.Label lbl_cpf;
        private System.Windows.Forms.Label lbl_senha;
        private System.Windows.Forms.MaskedTextBox msk_cpf;
        private System.Windows.Forms.MaskedTextBox msk_senha;
        private System.Windows.Forms.Button btn_logar;
    }
}