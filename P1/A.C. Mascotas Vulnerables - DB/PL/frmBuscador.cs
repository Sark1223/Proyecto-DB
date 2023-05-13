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

        bool error = false;
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

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            error = false;

            //ciclo para recorrer caracter por caracter 
            foreach (char caracter in txtBuscar.Text)
            {
                //si alguno de los caracteres es un numero el error es true
                if (!char.IsLetter(caracter) && !char.IsDigit(caracter))
                {
                    error = true;
                    break;
                }
            }
            if (error)
            {
                error1.SetError(txtBuscar, "No se admiten espacios en blanco\nIngrese letras o números solamente");
            }
            else
            {
                error1.SetError(txtBuscar, "");
            }
        }

        private void txtBuscar_Validated(object sender, EventArgs e)
        {
            error1.SetError(txtBuscar, "");
        }

        private void txtBuscar_Validating(object sender, CancelEventArgs e)
        {
            ValidarLetrasNumeros(txtBuscar, error1, e);
        }

        private void dgvSocios_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int indice = e.RowIndex;
            idsocio = dgvSocios.Rows[indice].Cells[0].Value.ToString();
            apaterno = dgvSocios.Rows[indice].Cells[1].Value.ToString();
            amaterno = dgvSocios.Rows[indice].Cells[2].Value.ToString();
            nombre = dgvSocios.Rows[indice].Cells[3].Value.ToString();

            MessageBox.Show("Se ha seleccionado el socio " + idsocio + " " + nombre);
        }

        //Metodo para validar que haya solamente numeros o letras
        private void ValidarLetrasNumeros(TextBox txt, ErrorProvider er, CancelEventArgs c)
        {
            error = false;
            //ciclo para recorrer caracter por caracter 
            foreach (char caracter in txt.Text)
            {
                //si alguno de los caracteres es un numero el error es true
                if (!char.IsLetter(caracter) && !char.IsDigit(caracter))
                {
                    error = true;
                    break;
                }
            }
            if (error)
            {
                c.Cancel = true;
                txt.Select(0, txt.Text.Length);
                er.SetError(txt, "No se admiten espacios en blanco\nIngrese letras o números solamente");
            }
        }
        private void frmBuscador_Load(object sender, EventArgs e)
        {

        }
    }
}
