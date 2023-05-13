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

namespace A.C.Mascotas_Vulnerables___DB.PL
{
    public partial class frmAportacion : Form
    {
        frmNuevaAportacion nAportacion = new frmNuevaAportacion();
        public frmAportacion()
        {
            InitializeComponent();
        }
        ///Drag Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void Mover(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        public void ObtenerObjetoNuevaAportacion(frmNuevaAportacion nuevaAportacion)
        {
            nAportacion = nuevaAportacion;
        }

        private void cmdAportacion(object sender, EventArgs e)
        {
            nAportacion.ShowDialog();
        }

        private void cmdCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnModificarEstatus_Click(object sender, EventArgs e)
        {

        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
