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
    public partial class frmPeriodo : Form
    {
        public frmPeriodo()
        {
            InitializeComponent();
        }

        PeriodoBLL periodo = new PeriodoBLL();
        PeriodoDAL periodoDAL = new PeriodoDAL();

        private void frmPeriodo_Load(object sender, EventArgs e)
        {

        }

        private void RecuperarInformacion()
        {
            periodo.periodo_año = int.Parse(txtAño.Text);
            periodo.periodo_num = byte.Parse(txtNumero.Text);
            periodo.periodo_inicio = dtFechaInicio.Value;
            periodo.periodo_fin = dtFechaFin.Value;
        }

        private void LimpiarPeriodo()
        {
            txtAño.Clear(); txtNumero.Clear();
        }

        private bool ValoresVacios()
        {
            string valoresVacios = "";
            int no_vacios = 0;
            //VERIFICACION DE VALORES VACIOS
            {
                //Informacion personal
                if (txtAño.Text == "")
                {
                    valoresVacios += "Año, ";
                    no_vacios++;
                }
                if (txtNumero.Text == "")
                {
                    valoresVacios += "Número ";
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

        private void cmdAgregar_Click(object sender, EventArgs e)
        {
            if (!ValoresVacios())
            {
                RecuperarInformacion();
                if (periodoDAL.AgregarPeriodo(periodo))
                {
                    MessageBox.Show($"El PERIODO {periodo.periodo_año}-{periodo.periodo_num} se AGREGO correctamente", "Periodo Agregado");

                    dgvPeriodo.DataSource = periodoDAL.MostrarPeriodos().Tables[0];
                    LimpiarPeriodo();
                }
                else
                {
                    MessageBox.Show("NO se pudo ingresar la informacion del periodo", "Error al ingresar periodo");
                }
            }
        }

        private void cmdModificar_Click(object sender, EventArgs e)
        {
            //if (!ValoresVacios())
            //{
            //    RecuperarInformacion();
            //    if (periodoDAL.ModificarPeriodo(periodo))
            //    {
            //        MessageBox.Show($"El PERIODO {periodo.periodo_año}-{periodo.periodo_num} se AGREGO correctamente", "Periodo Agregado");

            //        dgvPeriodo.DataSource = periodoDAL.MostrarPeriodos().Tables[0];
            //        LimpiarPeriodo();
            //    }
            //    else
            //    {
            //        MessageBox.Show("NO se pudo ingresar la informacion del periodo", "Error al ingresar periodo");
            //    }
            //}
        }

        private void dgvPeriodo_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }
    }

    public class PeriodoBLL
    {
        /*CREATE TABLE PERIODO (
    periodo_año    Char(4) NOT NULL,
    periodo_num     CHAR(1) NOT NULL,
    periodo_inicio DATE,
    periodo_fin    DATE
);
*/      public int periodo_año;
        public byte periodo_num;
        public DateTime periodo_inicio;
        public DateTime periodo_fin;
    }
}
