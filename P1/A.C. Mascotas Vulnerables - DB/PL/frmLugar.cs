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
    public partial class frmLugar : Form
    {
        public frmLugar()
        {
            InitializeComponent();
        }

        private void frmLugar_Load(object sender, EventArgs e)
        {
            lugar.LlenarCBPais(cbPais);
            lugar.LlenarCBEstado(cbEstado);
            dgvCiudad.DataSource = lugar.MostrarCiudad().Tables[0];
            dgvEstado.DataSource = lugar.MostrarEstados().Tables[0];
            dgvPais.DataSource = lugar.MostrarPaises().Tables[0];
        }

        //Objetos de forma
        PaisBLL pais = new PaisBLL(); 
        EstadoBLL estado = new EstadoBLL();
        CiudadBLL ciudad = new CiudadBLL();
        
        //Objetos de Clases
        LugarDAL lugar = new LugarDAL();

        //METODOS DE PAIS ------------------------------------------------------------
        private void RecuperarInformacionPais()
        {
            pais.pais_id = int.Parse(txtPaisID.Text);
            pais.pa_nombre = txtNombrePais.Text;
        }

        private void btnAgregarPais_Click(object sender, EventArgs e)
        {
            RecuperarInformacionPais();
            if (lugar.AgregarPais(pais))
            {
                MessageBox.Show("El PAIS " + pais.pais_id + "se AGREGO correctamente", "Pais Agregado");
                lugar.LlenarCBPais(cbPais);
                dgvPais.DataSource = lugar.MostrarPaises().Tables[0];
            }
            else
            {
                MessageBox.Show("NO se pudo ingresar la informacion del pais", "Error al ingresar pais");
            }
        }

        //METODOS DE ESTADO ------------------------------------------------------------
        private void RecuperarInformacionEstado()
        {
            estado.estado_id = int.Parse(txtEstadoID.Text);
            estado.est_nombre = txtNombreEstado.Text;
            //estado.estado_id = int.Parse(txtNombreEstado.Text);
        }

        private void btnAgregarEstado_Click(object sender, EventArgs e)
        {
            RecuperarInformacionEstado();
            if (lugar.AgregarEstado(estado))
            {
                MessageBox.Show("El ESTADO " + estado.est_nombre + "se AGREGO correctamente", "Estado Agregado");
                lugar.LlenarCBEstado(cbEstado);
                dgvEstado.DataSource = lugar.MostrarEstados().Tables[0];
            }
            else
            {
                MessageBox.Show("NO se pudo ingresar la informacion del estado", "Error al ingresar estado");
            }
        }

        private void cbPais_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbPais.SelectedIndex > 0)
            {

                //Recuperar informacion de de la tabla CIUDAD
                string id = lugar.ObtenerID($"Select pais_id From PAIS WHERE pa_nombre ='{cbPais.Text}'");

                //Reccuperar el id del nombre de la ciudad
                estado.pais_id = int.Parse(id);//guardarlo
            }
        }

        //METODOS DE CIUDAD ------------------------------------------------------------
        private void RecuperarInformacionCiudad()
        {
            ciudad.ciudad_id = int.Parse(txtCiudadID.Text);
            ciudad.ciudad_nombre = txtNombreCiudad.Text;
            //estado.estado_id = int.Parse(txtNombreEstado.Text);
        }

        private void btnAgregarCiudad_Click(object sender, EventArgs e)
        {
            RecuperarInformacionCiudad();
            if (lugar.AgregarCiudad(ciudad))
            {
                MessageBox.Show("La CIUDAD " + ciudad.ciudad_nombre + "se AGREGO correctamente", "Ciudad Agregado");
                dgvCiudad.DataSource = lugar.MostrarCiudad().Tables[0];
            }
            else
            {
                MessageBox.Show("NO se pudo ingresar la informacion del ciudad", "Error al ingresar ciudad");
            }
        }

        private void cbEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbEstado.SelectedIndex > 0)
            {

                //Recuperar informacion de de la tabla CIUDAD
                string id = lugar.ObtenerID($"Select estado_id From ESTADO WHERE est_nombre = '{cbEstado.Text}'");

                //Reccuperar el id del nombre de la ciudad
                ciudad.estado_id = int.Parse(id);//guardarlo
            }
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }

    public class CiudadBLL
    {
        public int ciudad_id;
        public string ciudad_nombre;
        public int estado_id;
    }

    public class EstadoBLL
    {
        
        public int estado_id;
        public string est_nombre;
        public int pais_id;
    }

    public class PaisBLL
    {
        public int pais_id;
        public string pa_nombre;
    }
}
