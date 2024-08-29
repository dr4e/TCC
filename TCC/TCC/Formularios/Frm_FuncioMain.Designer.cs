
namespace TCC.Formularios
{
    partial class Frm_FuncioMain
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
            this.btn_vender = new System.Windows.Forms.Button();
            this.btn_sair = new System.Windows.Forms.Button();
            this.lbl_titulo = new System.Windows.Forms.Label();
            this.pic_voltar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pic_voltar)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_vender
            // 
            this.btn_vender.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(92)))), ((int)(((byte)(151)))));
            this.btn_vender.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_vender.FlatAppearance.BorderSize = 0;
            this.btn_vender.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btn_vender.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btn_vender.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_vender.Font = new System.Drawing.Font("Cooper Black", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_vender.Location = new System.Drawing.Point(321, 537);
            this.btn_vender.Name = "btn_vender";
            this.btn_vender.Size = new System.Drawing.Size(209, 60);
            this.btn_vender.TabIndex = 0;
            this.btn_vender.Text = "Vender";
            this.btn_vender.UseVisualStyleBackColor = false;
            this.btn_vender.Click += new System.EventHandler(this.btn_vender_Click);
            // 
            // btn_sair
            // 
            this.btn_sair.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(92)))), ((int)(((byte)(151)))));
            this.btn_sair.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_sair.FlatAppearance.BorderSize = 0;
            this.btn_sair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sair.Font = new System.Drawing.Font("Cooper Black", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sair.Location = new System.Drawing.Point(773, 537);
            this.btn_sair.Name = "btn_sair";
            this.btn_sair.Size = new System.Drawing.Size(209, 60);
            this.btn_sair.TabIndex = 2;
            this.btn_sair.Text = "Sair";
            this.btn_sair.UseVisualStyleBackColor = false;
            this.btn_sair.Click += new System.EventHandler(this.btn_sair_Click);
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.AutoSize = true;
            this.lbl_titulo.BackColor = System.Drawing.Color.Transparent;
            this.lbl_titulo.Font = new System.Drawing.Font("Cooper Black", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titulo.Location = new System.Drawing.Point(444, 118);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(431, 74);
            this.lbl_titulo.TabIndex = 3;
            this.lbl_titulo.Text = "Funcionário";
            // 
            // pic_voltar
            // 
            this.pic_voltar.BackColor = System.Drawing.Color.Transparent;
            this.pic_voltar.Image = global::TCC.Properties.Resources.equerda;
            this.pic_voltar.Location = new System.Drawing.Point(1217, 12);
            this.pic_voltar.Name = "pic_voltar";
            this.pic_voltar.Size = new System.Drawing.Size(35, 38);
            this.pic_voltar.TabIndex = 4;
            this.pic_voltar.TabStop = false;
            // 
            // Frm_FuncioMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TCC.Properties.Resources.BGfuncionariotudo;
            this.ClientSize = new System.Drawing.Size(1264, 761);
            this.Controls.Add(this.pic_voltar);
            this.Controls.Add(this.lbl_titulo);
            this.Controls.Add(this.btn_sair);
            this.Controls.Add(this.btn_vender);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_FuncioMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Index";
            this.Load += new System.EventHandler(this.Frm_FuncioMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic_voltar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_vender;
        private System.Windows.Forms.Button btn_sair;
        private System.Windows.Forms.Label lbl_titulo;
        private System.Windows.Forms.PictureBox pic_voltar;
    }
}