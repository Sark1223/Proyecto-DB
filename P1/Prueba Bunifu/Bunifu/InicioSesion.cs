using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bunifu
{
    public partial class InicioSesion : Form
    {
        public InicioSesion()
        {
            InitializeComponent();
        }

        private void InicioSesion_Load(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton1_MouseHover(object sender, EventArgs e)
        {
            //btnCerrar.BackColor = Color.Black;
        }

        private void btnCerrar_MouseLeave(object sender, EventArgs e)
        {
            //btnCerrar.BackColor = Color.PaleVioletRed;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtContra_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            Form forma = new Form1();
            forma.Show();
            this.Hide();
        }
    }
}
