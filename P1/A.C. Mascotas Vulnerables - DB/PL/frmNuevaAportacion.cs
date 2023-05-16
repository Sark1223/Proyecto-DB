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
            txtFolio.Text="";
            lblAMaterno.Text = ""; lblAPaterno.Text = ""; txtImporte.Text = ""; txtMtoEscrito.Text = "";
            cbEncargado2.SelectedIndex = 0;
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
    }
}
