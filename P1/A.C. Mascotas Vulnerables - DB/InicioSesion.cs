using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A.C.Mascotas_Vulnerables___DB
{
    public partial class InicioSesion : Form
    {
        public InicioSesion()
        {
            InitializeComponent();
        }

        private void InicioSesion_Load(object sender, EventArgs e)
        {
            lblBienvenido.Parent = pbInicio;
            lblBienvenido.BackColor = Color.Transparent;
        }

        private void cmdCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
