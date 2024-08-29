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
    public partial class Frm_FuncioMain : Form
    {
        //Arredondar Botao
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(int nLeft, int nTop, int nRight, int nBottom, int nWidthEllipse, int nHeightEllipse);

        public Frm_FuncioMain()
        {
            InitializeComponent();
        }

        private void Frm_FuncioMain_Load(object sender, EventArgs e)
        {
            btn_vender.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btn_vender.Width, btn_vender.Height, 30, 30));
            btn_sair.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btn_sair.Width, btn_sair.Height, 30, 30));
        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_vender_Click(object sender, EventArgs e)
        {
            Frm_Saldo frm = new Frm_Saldo();
            this.Hide();
            frm.ShowDialog();
            this.Close();

        }
    }
}
