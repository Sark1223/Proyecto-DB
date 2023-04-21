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
    public partial class Form1 : Form
    {
        Form menu = new Form();
        Form Inicio = new InicioSesion();
        public Form1()
        {
            InitializeComponent();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
            Inicio.Show();
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            if(PanIzquierdo.Width == 50)
            {
                PanIzquierdo.Visible = false;
                PanIzquierdo.Width = 235;
                lblLogo.Show();
                PanelTransition.ShowSync(PanIzquierdo);
                LogoTransition.ShowSync(Logo);
                Logo.Width = 80;
                Logo.Height = 70;
                Logo.Location = new Point(79, 70);
            }
            else
            {
                //LogoTransition.Hide(Logo);
                lblLogo.Hide();
                PanIzquierdo.Visible = false;
                PanIzquierdo.Width = 50;
                PanelTransition.ShowSync(PanIzquierdo);
                Logo.Width = 45;
                Logo.Height = 40;
                Logo.Location = new Point(2, 90);
            }
        }

        private void AbrirForm(object frm)
        {
            //Condicion para cerrar otros paneles si hay alguno abierto
            if(this.PanDerecho.Controls.Count > 0)
            {
                this.PanDerecho.Controls.RemoveAt(0);
                Form gestion = frm as Form;
                //
                gestion.TopLevel = false;
                //Rellenar el panel
                gestion.Dock = DockStyle.Fill;
                //Agregar el panel
                this.PanDerecho.Controls.Add(gestion);

                this.PanDerecho.Tag = gestion;
                gestion.Show();
            }
        }

        private void Logo_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void x2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PanIzquierdo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void f1_Click(object sender, EventArgs e)
        {
            AbrirForm(new Gestion());
        }
    }
}
