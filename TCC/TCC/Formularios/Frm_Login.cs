using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TCC.Formularios
{
    public partial class Frm_Login : Form
    {
        //Arredondar Botao
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(int nLeft, int nTop, int nRight, int nBottom, int nWidthEllipse, int nHeightEllipse);
        public Frm_Login()
        {
            InitializeComponent();
        }

        private void Frm_login_Load(object sender, EventArgs e)
        {
            //Arredondar Botao
            btn_logar.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btn_logar.Width, btn_logar.Height, 30, 30));
        }

        private void btn_logar_Click(object sender, EventArgs e)
        {
            if (msk_cpf.Text.Equals("487,875,938-07"))
            {
                Frm_ADMain frm = new Frm_ADMain();
                this.Hide();
                frm.ShowDialog();
                this.Close();
            }else if (msk_cpf.Text.Equals("111,111,111-11"))
            {
                Frm_FuncioMain frm = new Frm_FuncioMain(); 
                this.Hide();
                frm.ShowDialog();
                this.Close();
            }
        }
    }
}
