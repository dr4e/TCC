using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TCC.Formularios;

namespace TCC { 
    public partial class Index : Form
    {
        //Arredondar Botao
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(int nLeft, int nTop, int nRight, int nBottom, int nWidthEllipse, int nHeightEllipse);

        public Index()
        {
            InitializeComponent();
        }

        private void Index_Load(object sender, EventArgs e)
        {
            //Arredondar Botao
            btn_entrar.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btn_entrar.Width, btn_entrar.Height, 30, 30));
        }

        private void btn_entrar_Click(object sender, EventArgs e)
        {
            Frm_Login frm = new Frm_Login();
            this.Hide();
            frm.ShowDialog();
            this.Close();
        }
    }
}
