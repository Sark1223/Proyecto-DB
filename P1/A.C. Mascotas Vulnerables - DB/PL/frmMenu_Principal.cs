using A.C.Mascotas_Vulnerables___DB.DAL;
using A.C.Mascotas_Vulnerables___DB.PL;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace A.C.Mascotas_Vulnerables___DB
{
    public partial class frmMenu_Principal : Form
    {
        public frmMenu_Principal()
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
        //Objetos de formas
        frmAportacion aportacion = new frmAportacion();
        frmSocios socios = new frmSocios();
        SocioDAL socio = new SocioDAL();
        frmUsuarios usuarios = new frmUsuarios();
        UsuarioDAL mu = new UsuarioDAL();
        frmLugar lugar = new frmLugar();
        frmPeriodo periodo = new frmPeriodo();
        PeriodoDAL periodoDAL = new PeriodoDAL();   

        private void lblLogo_Click(object sender, EventArgs e)
        {

        }

        public void ObtenerObjetoAportacion(frmAportacion aportacion, frmNuevaAportacion nuevaAportacion) 
        {
            this.aportacion = aportacion;
            aportacion.ObtenerObjetoNuevaAportacion(nuevaAportacion);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmdIniciar_Click(object sender, EventArgs e)
        {
            aportacion.ShowDialog();
        }

        private void cmdSocio(object sender, EventArgs e)
        {
            socios.dgvSocios.DataSource = socio.MostratSocios().Tables[0];
            socios.ShowDialog();
        }

        private void frmMenu_Principal_Load(object sender, EventArgs e)
        {
        }

        private void cmdAdministra_Click(object sender, EventArgs e)
        {
            usuarios.dgvUsuarios.DataSource = mu.MostrarUsuarios().Tables[0];
            usuarios.ShowDialog();
        }

        private void cmdLugares_Click(object sender, EventArgs e)
        {
            lugar.ShowDialog();
        }

        private void cmdPeriodo_Click(object sender, EventArgs e)
        {
            periodo.dgvPeriodo.DataSource = periodoDAL.MostrarPeriodos().Tables[0];
            periodo.ShowDialog();
        }
    }
}
