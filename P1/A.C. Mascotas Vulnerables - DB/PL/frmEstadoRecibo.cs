using A.C.Mascotas_Vulnerables___DB.BLL;
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

        HistorialBLL historial = new HistorialBLL();
        HistorialDAL historialDAL = new HistorialDAL();

        public int usuario_id;
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

                    int num = 1 + historialDAL.RetornarUltimaModificacion();
                    historial.historia_num = num;
                    historial.usuario_id = usuario_id;
                    historial.cambio = $"Se AGREGO el nuevo ESTATUS: {estatus.estatus_id}";

                    DateTime date = DateTime.Today;
                    DateTime time = DateTime.Now;

                    historial.fecha = date;
                    historial.hora = time;
                    historialDAL.AgregarModificacion(historial);
                }
                else
                {
                    MessageBox.Show("NO se pudo ingresar la informacion del estatus", "Error al ingresar status");
                }
            }
        }

        private void cmdModificar_Click(object sender, EventArgs e)
        {
            if (modifiEstatus && codigo != "AC")
            {
                recuperarInfo();
                if (aportacionDAL.ModificarEstatus(estatus, codigo))
                {
                    MessageBox.Show("El ESTATUS: " + codigo + " se MODIFICO correctamente", "Estatus Modificado");
                    dgvEstatus.DataSource = aportacionDAL.MostrarEstatus().Tables[0];
                    modifiEstatus = false;

                    codigo = "";

                    int num = 1 + historialDAL.RetornarUltimaModificacion();
                    historial.historia_num = num;
                    historial.usuario_id = usuario_id;
                    historial.cambio = $"Se MODIFICO el ESTATUS: {codigo}";

                    DateTime date = DateTime.Today;
                    DateTime time = DateTime.Now;

                    historial.fecha = date;
                    historial.hora = time;
                    historialDAL.AgregarModificacion(historial);
                }
                else
                {
                    MessageBox.Show("NO se pudo modificar la informacion del Estatus", "Error al modificar estatus");
                }
            }
            else
            {
                if(codigo == "AC")
                {
                    MessageBox.Show("NO puede MODIFICAR el ESTATUS 'AC'", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("Debe seleccionar primero un registro para modificarlo", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                
            }
        }

        bool modifiEstatus; string codigo;
        private void dgvEstatus_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int indice = e.RowIndex;
            codigo = dgvEstatus.Rows[indice].Cells[0].Value.ToString();
            txtcodigo.Text = codigo;
            txtdescripcion.Text = dgvEstatus.Rows[indice].Cells[1].Value.ToString();

            modifiEstatus = true;
        }
    }

    public class EstatusBLL
    {
        public string estatus_id;
        public string estatus_descripcion;
    }
}
