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
    public partial class frmEstadoRecibo : Form
    {
        public frmEstadoRecibo()
        {
            InitializeComponent();
        }

        EstatusBLL estatus = new EstatusBLL();
        AportacionDAL aportacionDAL = new AportacionDAL();

        private void cmdCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmEstadoRecibo_Load(object sender, EventArgs e)
        {
            dgvEstatus.DataSource = aportacionDAL.MostrarEstatus().Tables[0];
        }

        private bool ValoresVacios()
        {
            string valoresVacios = "";
            int no_vacios = 0;
            //VERIFICACION DE VALORES VACIOS
            {
                //Informacion personal
                if (txtcodigo.Text == "")
                {
                    valoresVacios += "Codigo, ";
                    no_vacios++;
                }
                if (txtdescripcion.Text == "")
                {
                    valoresVacios += "Descripcion";
                    no_vacios++;
                }

            }
            if (no_vacios > 0)
            {
                MessageBox.Show("No puede dejar información en blanco \r\n\r\n" +
                                "No. de valores vacios: " + no_vacios + "\r\n" +
                                "Valores vacios: " + valoresVacios, "ERROR AL INGRESAR VALORES");
                return true;
            }
            else
            {
                return false;
            }
        }

        private void recuperarInfo()
        {
            estatus.estatus_id = txtcodigo.Text;
            estatus.estatus_descripcion = txtdescripcion.Text;
        }

        private void cmdAgregar_Click(object sender, EventArgs e)
        {
            if (!ValoresVacios())
            {
                recuperarInfo();
                if (aportacionDAL.AgregarEstatus(estatus))
                {
                    MessageBox.Show("El ESTATUS " + estatus.estatus_descripcion + " se AGREGO correctamente", "Estatus Agregado");
                    //Limpiar();
                    dgvEstatus.DataSource = aportacionDAL.MostrarEstatus().Tables[0];
                }
                else
                {
                    MessageBox.Show("NO se pudo ingresar la informacion del estatus", "Error al ingresar status");
                }
            }
        }
    }

    public class EstatusBLL
    {
        public string estatus_id;
        public string estatus_descripcion;
    }
}
