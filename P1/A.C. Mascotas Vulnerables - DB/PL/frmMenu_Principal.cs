using A.C.Mascotas_Vulnerables___DB.PL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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

        //Objetos de formas
        frmAportacion aportacion = new frmAportacion();
        frmSocios socio = new frmSocios();

        private void lblLogo_Click(object sender, EventArgs e)
        {

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmdIniciar_Click(object sender, EventArgs e)
        {
            aportacion.ShowDialog();
        }

        //private void cmdSocios(object sender, EventArgs e)
        //{
            
        //}

        private void cmdSocio(object sender, EventArgs e)
        {
            socio.ShowDialog();
        }

        private void frmMenu_Principal_Load(object sender, EventArgs e)
        {
        }
    }
}
