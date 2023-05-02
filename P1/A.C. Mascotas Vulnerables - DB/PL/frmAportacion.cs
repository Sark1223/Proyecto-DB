using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A.C.Mascotas_Vulnerables___DB.PL
{
    public partial class frmAportacion : Form
    {
        frmNuevaAportacion nAportacion = new frmNuevaAportacion();
        public frmAportacion()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cmdAportacion(object sender, EventArgs e)
        {
            nAportacion.ShowDialog();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {

        }
    }
}
