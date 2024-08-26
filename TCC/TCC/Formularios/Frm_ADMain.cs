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
    public partial class Frm_ADMain : Form
    {
        //Arredondar botao
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(int nLeft, int nTop, int nRight, int nBottom, int nWidthEllipse, int nHeightEllipse);

        public Frm_ADMain()
        {
            InitializeComponent();
        }

        private void btn_funcionarios_Load(object sender, EventArgs e)
        {
            Button[] botoes = { btn_vender, btn_funcio, btn_historico, btn_produtos, btn_sair};

            foreach (Button botao in botoes)
            {
                botao.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, botao.Width, botao.Height, 30, 30));
            }
        }
    }
}
