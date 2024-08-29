
namespace TCC.Formularios
{
    partial class Frm_ADMCadastroFuncio
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
            this.lbl_titulo = new System.Windows.Forms.Label();
            this.lbl_nome = new System.Windows.Forms.Label();
            this.lbl_cpf = new System.Windows.Forms.Label();
            this.lbl_senha = new System.Windows.Forms.Label();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.msk_cpf = new System.Windows.Forms.MaskedTextBox();
            this.txt_senha = new System.Windows.Forms.TextBox();
            this.btn_cadastrar = new System.Windows.Forms.Button();
            this.pic_voltar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pic_voltar)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.BackColor = System.Drawing.Color.Transparent;
            this.lbl_titulo.Font = new System.Drawing.Font("Cooper Black", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titulo.Location = new System.Drawing.Point(455, 134);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(416, 112);
            this.lbl_titulo.TabIndex = 3;
            this.lbl_titulo.Text = "Cadastrar Funcionário";
            this.lbl_titulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_nome
            // 
            this.lbl_nome.AutoSize = true;
            this.lbl_nome.BackColor = System.Drawing.Color.Transparent;
            this.lbl_nome.Font = new System.Drawing.Font("Cooper Black", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nome.Location = new System.Drawing.Point(491, 273);
            this.lbl_nome.Name = "lbl_nome";
            this.lbl_nome.Size = new System.Drawing.Size(65, 21);
            this.lbl_nome.TabIndex = 4;
            this.lbl_nome.Text = "Nome";
            // 
            // lbl_cpf
            // 
            this.lbl_cpf.AutoSize = true;
            this.lbl_cpf.BackColor = System.Drawing.Color.Transparent;
            this.lbl_cpf.Font = new System.Drawing.Font("Cooper Black", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cpf.Location = new System.Drawing.Point(491, 370);
            this.lbl_cpf.Name = "lbl_cpf";
            this.lbl_cpf.Size = new System.Drawing.Size(50, 21);
            this.lbl_cpf.TabIndex = 5;
            this.lbl_cpf.Text = "CPF";
            // 
            // lbl_senha
            // 
            this.lbl_senha.AutoSize = true;
            this.lbl_senha.BackColor = System.Drawing.Color.Transparent;
            this.lbl_senha.Font = new System.Drawing.Font("Cooper Black", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_senha.Location = new System.Drawing.Point(491, 477);
            this.lbl_senha.Name = "lbl_senha";
            this.lbl_senha.Size = new System.Drawing.Size(69, 21);
            this.lbl_senha.TabIndex = 6;
            this.lbl_senha.Text = "Senha";
            // 
            // txt_nome
            // 
            this.txt_nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nome.Location = new System.Drawing.Point(495, 297);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(318, 35);
            this.txt_nome.TabIndex = 7;
            // 
            // msk_cpf
            // 
            this.msk_cpf.Font = new System.Drawing.Font("Cooper Black", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msk_cpf.Location = new System.Drawing.Point(495, 394);
            this.msk_cpf.Mask = "000.000.000-00";
            this.msk_cpf.Name = "msk_cpf";
            this.msk_cpf.Size = new System.Drawing.Size(318, 35);
            this.msk_cpf.TabIndex = 8;
            // 
            // txt_senha
            // 
            this.txt_senha.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_senha.Location = new System.Drawing.Point(495, 501);
            this.txt_senha.Name = "txt_senha";
            this.txt_senha.PasswordChar = '*';
            this.txt_senha.Size = new System.Drawing.Size(318, 35);
            this.txt_senha.TabIndex = 9;
            // 
            // btn_cadastrar
            // 
            this.btn_cadastrar.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btn_cadastrar.FlatAppearance.BorderSize = 0;
            this.btn_cadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cadastrar.Font = new System.Drawing.Font("Cooper Black", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cadastrar.ForeColor = System.Drawing.Color.White;
            this.btn_cadastrar.Location = new System.Drawing.Point(589, 599);
            this.btn_cadastrar.Name = "btn_cadastrar";
            this.btn_cadastrar.Size = new System.Drawing.Size(140, 51);
            this.btn_cadastrar.TabIndex = 10;
            this.btn_cadastrar.Text = "Cadastrar";
            this.btn_cadastrar.UseVisualStyleBackColor = false;
            // 
            // pic_voltar
            // 
            this.pic_voltar.BackColor = System.Drawing.Color.Transparent;
            this.pic_voltar.Image = global::TCC.Properties.Resources.equerda;
            this.pic_voltar.Location = new System.Drawing.Point(1217, 12);
            this.pic_voltar.Name = "pic_voltar";
            this.pic_voltar.Size = new System.Drawing.Size(35, 38);
            this.pic_voltar.TabIndex = 11;
            this.pic_voltar.TabStop = false;
            // 
            // Frm_ADMCadastroFuncio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TCC.Properties.Resources.BGcadastro;
            this.ClientSize = new System.Drawing.Size(1264, 761);
            this.Controls.Add(this.pic_voltar);
            this.Controls.Add(this.btn_cadastrar);
            this.Controls.Add(this.txt_senha);
            this.Controls.Add(this.msk_cpf);
            this.Controls.Add(this.txt_nome);
            this.Controls.Add(this.lbl_senha);
            this.Controls.Add(this.lbl_cpf);
            this.Controls.Add(this.lbl_nome);
            this.Controls.Add(this.lbl_titulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_ADMCadastroFuncio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastrar Funcionário";
            this.Load += new System.EventHandler(this.Frm_ADMCadastroFuncio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic_voltar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_titulo;
        private System.Windows.Forms.Label lbl_nome;
        private System.Windows.Forms.Label lbl_cpf;
        private System.Windows.Forms.Label lbl_senha;
        private System.Windows.Forms.TextBox txt_nome;
        private System.Windows.Forms.MaskedTextBox msk_cpf;
        private System.Windows.Forms.TextBox txt_senha;
        private System.Windows.Forms.Button btn_cadastrar;
        private System.Windows.Forms.PictureBox pic_voltar;
    }
}