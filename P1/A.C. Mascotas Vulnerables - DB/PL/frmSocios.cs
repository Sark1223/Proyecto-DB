using A.C.Mascotas_Vulnerables___DB.DAL;
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
    public partial class frmSocios : Form
    {
        public frmSocios()
        {
            InitializeComponent();
        }

        //Objetos de formas
        frmEdit_Socios edit_Socios = new frmEdit_Socios();
        SocioDAL socio = new SocioDAL();

        private void cmdAgregarUsuario_Click(object sender, EventArgs e)
        {
            edit_Socios.cbTipoPSocio.Items.Clear();
            edit_Socios.cbTipoPSocio.Items.Insert(0, "- SELECCIONE  -");
            edit_Socios.cbTipoPSocio.Items.Insert(1, "Fisica");
            edit_Socios.cbTipoPSocio.Items.Insert(2, "Moral");
            edit_Socios.cbTipoPSocio.SelectedIndex = 0;

            edit_Socios.cbEstadoSocio.Items.Clear();
            edit_Socios.cbEstadoSocio.Items.Insert(0, "- SELECCIONE  -");
            edit_Socios.cbEstadoSocio.Items.Insert(1, "Activo");
            edit_Socios.cbEstadoSocio.Items.Insert(2, "Inactivo");
            edit_Socios.cbEstadoSocio.SelectedIndex = 0;

            edit_Socios.lblTitle.Text = "AGREGAR NUEVO SOCIO";
            edit_Socios.ShowDialog();
            dgvSocios.DataSource = socio.MostratSocios().Tables[0];
        }

        private void cmdCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
