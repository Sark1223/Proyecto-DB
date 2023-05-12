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
    public partial class frmBuscador : Form
    {
        //frmBuscador busca= new frmBuscador();
        ReciboDAL recibo = new ReciboDAL();

        public frmBuscador()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cmdListo_Click(object sender, EventArgs e)
        {
            //retornar datos
        }

        private void cmdBuscar_Click(object sender, EventArgs e)
        {
            dgvSocios.DataSource = recibo.Buscar(txtBuscar.Text).Tables[0];
        }
        public string idsocio, nombre, apaterno, amaterno;
        private void dgvSocios_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int indice = e.RowIndex;
            idsocio = dgvSocios.Rows[indice].Cells[0].Value.ToString();
            apaterno = dgvSocios.Rows[indice].Cells[1].Value.ToString();
            amaterno = dgvSocios.Rows[indice].Cells[2].Value.ToString();
            nombre = dgvSocios.Rows[indice].Cells[3].Value.ToString();

            MessageBox.Show("Se ha seleccionado el socio " + idsocio + " " + nombre);
        }

        private void frmBuscador_Load(object sender, EventArgs e)
        {

        }
    }
}
