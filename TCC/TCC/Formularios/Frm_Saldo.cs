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
    public partial class Frm_Saldo : Form
    {
        //Arredondar Botao
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(int nLeft, int nTop, int nRight, int nBottom, int nWidthEllipse, int nHeightEllipse);
        public Frm_Saldo()
        {
            InitializeComponent();
        }

        private void Frm_Saldo_Load(object sender, EventArgs e)
        {
            btn_Enviar.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btn_Enviar.Width, btn_Enviar.Height, 30, 30));
        }

        private void btn_Enviar_Click(object sender, EventArgs e)
        {
            Frm_Caixa frm = new Frm_Caixa();
            this.Hide();
            frm.ShowDialog();
            this.Close();
        }
    }
}
