
namespace TCC.Formularios
{
    partial class Frm_Saldo
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
            this.pic_calc = new System.Windows.Forms.PictureBox();
            this.lbl_titulo1 = new System.Windows.Forms.Label();
            this.lbl_titulo2 = new System.Windows.Forms.Label();
            this.txt_Saldo = new System.Windows.Forms.TextBox();
            this.btn_Enviar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pic_calc)).BeginInit();
            this.SuspendLayout();
            // 
            // pic_calc
            // 
            this.pic_calc.BackColor = System.Drawing.Color.Transparent;
            this.pic_calc.Image = global::TCC.Properties.Resources.calculadora;
            this.pic_calc.Location = new System.Drawing.Point(623, 171);
            this.pic_calc.Name = "pic_calc";
            this.pic_calc.Size = new System.Drawing.Size(598, 403);
            this.pic_calc.TabIndex = 0;
            this.pic_calc.TabStop = false;
            // 
            // lbl_titulo1
            // 
            this.lbl_titulo1.AutoSize = true;
            this.lbl_titulo1.BackColor = System.Drawing.Color.Transparent;
            this.lbl_titulo1.Font = new System.Drawing.Font("Cooper Black", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titulo1.Location = new System.Drawing.Point(12, 244);
            this.lbl_titulo1.Name = "lbl_titulo1";
            this.lbl_titulo1.Size = new System.Drawing.Size(539, 74);
            this.lbl_titulo1.TabIndex = 1;
            this.lbl_titulo1.Text = "Informe o saldo";
            // 
            // lbl_titulo2
            // 
            this.lbl_titulo2.AutoSize = true;
            this.lbl_titulo2.BackColor = System.Drawing.Color.Transparent;
            this.lbl_titulo2.Font = new System.Drawing.Font("Cooper Black", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titulo2.Location = new System.Drawing.Point(12, 331);
            this.lbl_titulo2.Name = "lbl_titulo2";
            this.lbl_titulo2.Size = new System.Drawing.Size(316, 74);
            this.lbl_titulo2.TabIndex = 2;
            this.lbl_titulo2.Text = "do caixa:";
            // 
            // txt_Saldo
            // 
            this.txt_Saldo.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Saldo.Location = new System.Drawing.Point(330, 353);
            this.txt_Saldo.Name = "txt_Saldo";
            this.txt_Saldo.Size = new System.Drawing.Size(201, 41);
            this.txt_Saldo.TabIndex = 3;
            // 
            // btn_Enviar
            // 
            this.btn_Enviar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(92)))), ((int)(((byte)(151)))));
            this.btn_Enviar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_Enviar.FlatAppearance.BorderSize = 0;
            this.btn_Enviar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btn_Enviar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btn_Enviar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Enviar.Font = new System.Drawing.Font("Cooper Black", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Enviar.Location = new System.Drawing.Point(129, 434);
            this.btn_Enviar.Name = "btn_Enviar";
            this.btn_Enviar.Size = new System.Drawing.Size(210, 56);
            this.btn_Enviar.TabIndex = 4;
            this.btn_Enviar.Text = "Enviar";
            this.btn_Enviar.UseVisualStyleBackColor = false;
            this.btn_Enviar.Click += new System.EventHandler(this.btn_Enviar_Click);
            // 
            // Frm_Saldo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TCC.Properties.Resources.BGpadrao;
            this.ClientSize = new System.Drawing.Size(1264, 761);
            this.Controls.Add(this.btn_Enviar);
            this.Controls.Add(this.txt_Saldo);
            this.Controls.Add(this.lbl_titulo2);
            this.Controls.Add(this.lbl_titulo1);
            this.Controls.Add(this.pic_calc);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_Saldo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Saldo";
            this.Load += new System.EventHandler(this.Frm_Saldo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic_calc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pic_calc;
        private System.Windows.Forms.Label lbl_titulo1;
        private System.Windows.Forms.Label lbl_titulo2;
        private System.Windows.Forms.TextBox txt_Saldo;
        private System.Windows.Forms.Button btn_Enviar;
    }
}