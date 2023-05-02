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
    public partial class frmEdit_Socios : Form
    {
        public frmEdit_Socios()
        {
            InitializeComponent();
        }

        private void btnCerrar(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmdCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
