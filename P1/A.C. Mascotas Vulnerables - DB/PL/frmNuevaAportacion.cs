using A.C.Mascotas_Vulnerables___DB.BLL;
using A.C.Mascotas_Vulnerables___DB.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A.C.Mascotas_Vulnerables___DB.PL
{
    public partial class frmNuevaAportacion : Form
    {
        public frmNuevaAportacion()
        {
            InitializeComponent();
            
        }

        frmBuscador buscador = new frmBuscador();
        BuscadorDAL bus  =  new BuscadorDAL();
        AportacionDAL AportacionDAL = new AportacionDAL();
        ReciboBLL res = new ReciboBLL();
        frmEstadoRecibo estadoRecibo = new frmEstadoRecibo();

        //frmAportacion aportacion = new frmAportacion();

        private void cmdCerrar(object sender, EventArgs e)
        {
            this.Close();
        }
        string folio, numValido;

        private void frmNuevaAportacion_Load(object sender, EventArgs e)
        {
            if (lblTitle.Text == "Datos\r\ndel\r\nRecibo")
            {
                
                AportacionDAL.LlenarCBEncargado2(cbEncargado2);
                AportacionDAL.LlenaCBPeriodo(cbPeriodo);
                socio = false;
                pnEstatus.Visible = false;
                cmdGuardar.Visible = false;
                cbPeriodo.Visible = true;
                lblPeriodo.Visible = false;
                LimpiarRecibo();
                numValido = AportacionDAL.IncrementarID();
                txtFolio.Text = numValido.ToString();
            }
            else
            {
                cmdGuardar.Visible = true;
                pnEstatus.Visible = true;
                cbEncargado2.Visible = false;
                cbPeriodo.Visible = false;
                lblPeriodo.Visible = true;

                folio = txtFolio.Text;

                MessageBox.Show("Intenta modificar un recibo, el UNICO valor MODIFICABLE en esta ventana es ESTATUS, cualquier otro cambio no se guardara.", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            LimpiarRecibo();
            error1.Clear();
            Close();
        }
        string idSocio; bool socio = false;
        private void BuscarSOcio(object sender, EventArgs e)
        {
            buscador.dgvSocios.DataSource = bus.MostrarTabla().Tables[0];
            if (buscador.ShowDialog() == DialogResult.OK)
            {
                idSocio = buscador.idsocio;
                lblNombre.Text = buscador.nombre;
                lblAPaterno.Text = buscador.apaterno;
                lblAMaterno.Text = buscador.amaterno;
                socio = true;
            }
            else
            {
                socio = false;
            }
        }
        private void MostrarReicbo(object sender, EventArgs e)
        {
            
        }

        private void Captarinformacion_Agregar()
        {
            res.rec_folio = long.Parse(txtFolio.Text);
            res.rec_fecha = dtFecha.Value;
            res.usuario_id = int.Parse(AportacionDAL.SepararValores(txtEncargado1.Text, 0));
            res.socio_id = int.Parse(idSocio);
            res.rec_monto = double.Parse(txtImporte.Text);
            res.rec_mto_escrito = txtMtoEscrito.Text;
            res.estatus_id = "AC";
            res.periodo_año = AportacionDAL.SepararValores(cbPeriodo.Text, 0);
            res.periodo_num = byte.Parse(AportacionDAL.SepararValores(cbPeriodo.Text, 2));
            DateTime hoy = DateTime.Now;
            res.rec_firma_asistente = txtEncargado1.Text + " " + hoy.ToString();
            res.rec_firma_administrativo = cbEncargado2.Text + " " + hoy.ToString();
        }
        public bool ValoresVacios()
        {
            string valoresVacios = "";
            int no_vacios = 0;
            //VERIFICACION DE VALORES VACIOS
            {
                //Informacion personal
                if (txtFolio.Text == "")
                {
                    valoresVacios += "Socio id, ";
                    no_vacios++;
                }
                if (socio == false)
                {
                    valoresVacios += "Socio, ";
                    no_vacios++;
                }
                if (txtImporte.Text == "")
                {
                    valoresVacios += "Importe, ";
                    no_vacios++;
                }
                if (cbEncargado2.Text == "- SELECCIONE ENCARGADO -")
                {
                    valoresVacios += "Encargado 2, ";
                    no_vacios++;
                }
                if (cbEncargado2.Text == "- PERIODO -")
                {
                    valoresVacios += "Periodo";
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
        public void LimpiarRecibo()
        {
            txtFolio.Clear(); txtImporte.Clear();lblAMaterno.Text = "";lblAPaterno.Text="";
            lblNombre.Text = ""; txtMtoEscrito.Text = ""; cbEncargado2.SelectedIndex = 0;

        }

        private void btnAgregarRecibo_Click(object sender, EventArgs e)
        {
            if (!ValoresVacios())
            {
                Captarinformacion_Agregar();
                if (AportacionDAL.AgregarRecibo(res))
                {
                    MessageBox.Show("El RECIBO " + res.rec_folio + " se AGREGO correctamente", "Recibo Agregado");
                    LimpiarRecibo();
                    Close();
                }
                else
                {
                    MessageBox.Show("NO se pudo ingresar la informacion del recibo", "Error al ingresar recibo");
                }
            }
        }

        private void cmdAgregarEstatus_Click(object sender, EventArgs e)
        {
            estadoRecibo.ShowDialog();
        }

        private void txtFolio_Validating(object sender, CancelEventArgs e)
        {
            if(ValidarNumeros(txtFolio, error1, e))
            {
                if (!AportacionDAL.ValidarID(txtFolio.Text, "0", txtFolio, error1))
                {
                    // Cancel the event and select the text to be corrected by the user.
                    e.Cancel = true;
                    txtFolio.Select(0, txtFolio.Text.Length);
                }
                else
                {
                    if (txtFolio.Text != "")
                    {
                        res.rec_folio = int.Parse(txtFolio.Text);
                    }

                }
            }
            
            
        }

        private void txtFolio_Validated(object sender, EventArgs e)
        {
            error1.SetError(txtFolio, "");
            
        }

        [SuppressMessage("ReSharper", "CompareOfFloatsByEqualityOperator")]
        string texto ="";
        private string NumeroALetras(double value)
        {
            string num2Text; value = Math.Truncate(value);
            if (value == 0) num2Text = "CERO";
            else if (value == 1) num2Text = "UNO";
            else if (value == 2) num2Text = "DOS";
            else if (value == 3) num2Text = "TRES";
            else if (value == 4) num2Text = "CUATRO";
            else if (value == 5) num2Text = "CINCO";
            else if (value == 6) num2Text = "SEIS";
            else if (value == 7) num2Text = "SIETE";
            else if (value == 8) num2Text = "OCHO";
            else if (value == 9) num2Text = "NUEVE";
            else if (value == 10) num2Text = "DIEZ";
            else if (value == 11) num2Text = "ONCE";
            else if (value == 12) num2Text = "DOCE";
            else if (value == 13) num2Text = "TRECE";
            else if (value == 14) num2Text = "CATORCE";
            else if (value == 15) num2Text = "QUINCE";
            else if (value < 20) num2Text = "DIECI" + NumeroALetras(value - 10);
            else if (value == 20) num2Text = "VEINTE";
            else if (value < 30) num2Text = "VEINTI" + NumeroALetras(value - 20);
            else if (value == 30) num2Text = "TREINTA";
            else if (value == 40) num2Text = "CUARENTA";
            else if (value == 50) num2Text = "CINCUENTA";
            else if (value == 60) num2Text = "SESENTA";
            else if (value == 70) num2Text = "SETENTA";
            else if (value == 80) num2Text = "OCHENTA";
            else if (value == 90) num2Text = "NOVENTA";
            else if (value < 100) num2Text = NumeroALetras(Math.Truncate(value / 10) * 10) + " Y " + NumeroALetras(value % 10);
            else if (value == 100) num2Text = "CIEN";
            else if (value < 200) num2Text = "CIENTO " + NumeroALetras(value - 100);
            else if ((value == 200) || (value == 300) || (value == 400) || (value == 600) || (value == 800)) num2Text = NumeroALetras(Math.Truncate(value / 100)) + "CIENTOS";
            else if (value == 500) num2Text = "QUINIENTOS";
            else if (value == 700) num2Text = "SETECIENTOS";
            else if (value == 900) num2Text = "NOVECIENTOS";
            else if (value < 1000) num2Text = NumeroALetras(Math.Truncate(value / 100) * 100) + " " + NumeroALetras(value % 100);
            else if (value == 1000) num2Text = "MIL";
            else if (value < 2000) num2Text = "MIL " + NumeroALetras(value % 1000);
            else if (value < 1000000)
            {
                num2Text = NumeroALetras(Math.Truncate(value / 1000)) + " MIL";
                if ((value % 1000) > 0)
                {
                    num2Text = num2Text + " " + NumeroALetras(value % 1000);
                }
            }
            else if (value == 1000000)
            {
                num2Text = "UN MILLON";
            }
            else if (value < 2000000)
            {
                num2Text = "UN MILLON " + NumeroALetras(value % 1000000);
            }
            else if (value < 1000000000000)
            {
                num2Text = NumeroALetras(Math.Truncate(value / 1000000)) + " MILLONES ";
                if ((value - Math.Truncate(value / 1000000) * 1000000) > 0)
                {
                    num2Text = num2Text + " " + NumeroALetras(value - Math.Truncate(value / 1000000) * 1000000);
                }
            }
            else if (value == 1000000000000) num2Text = "UN BILLON";
            else if (value < 2000000000000) num2Text = "UN BILLON " + NumeroALetras(value - Math.Truncate(value / 1000000000000) * 1000000000000);
            else
            {
                num2Text = NumeroALetras(Math.Truncate(value / 1000000000000)) + " BILLONES";
                if ((value - Math.Truncate(value / 1000000000000) * 1000000000000) > 0)
                {
                    num2Text = num2Text + " " + NumeroALetras(value - Math.Truncate(value / 1000000000000) * 1000000000000);
                }
            }
            return num2Text;
        }

        private void txtImporte_Validating(object sender, CancelEventArgs e)
        {
            if( ValidarNumeros(txtImporte, error1, e))
            {
                texto = NumeroALetras(double.Parse(txtImporte.Text));
                txtMtoEscrito.Text = texto;
            }
            
        }

        private void txtImporte_Validated(object sender, EventArgs e)
        {
            error1.SetError(txtImporte, "");
            
        }

        private void cmdGuardar_Click(object sender, EventArgs e)
        {
            if(cbEstatus.SelectedIndex != 0)
            {
                res.estatus_id = cbEstatus.Text;
                if (AportacionDAL.Modificar(res, folio))
                {
                    MessageBox.Show("El RECIBO " + res.rec_folio + " se AGREGO correctamente", "Recibo Agregado");
                    //Limpiar();
                }
                else
                {
                    MessageBox.Show("NO se pudo ingresar la informacion del recibo", "Error al ingresar recibo");
                }
            }
            
        }

        //Metodo para validar que haya solamente numeros o letras
        bool error;

        private void txtImporte_TextChanged(object sender, EventArgs e)
        {
            
        }

        private bool ValidarNumeros(TextBox txt, ErrorProvider er, CancelEventArgs c)
        {
            error = false;

            //ciclo para recorrer caracter por caracter 
            foreach (char caracter in txt.Text)
            {
                //si alguno de los caracteres es un numero el error es true
                if (!char.IsDigit(caracter))
                {
                    error = true;
                    break;
                }
            }
            if (error)
            {
                c.Cancel = true;
                txt.Select(0, txt.Text.Length);
                er.SetError(txt, "No se admiten letras ni espacios en blanco\nIngrese números solamente");
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
