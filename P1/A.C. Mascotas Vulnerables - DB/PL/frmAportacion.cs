using A.C.Mascotas_Vulnerables___DB.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A.C.Mascotas_Vulnerables___DB.PL
{
    public partial class frmAportacion : Form
    {
        frmNuevaAportacion nAportacion = new frmNuevaAportacion();
        AportacionDAL apDAL = new AportacionDAL();
        
        public frmAportacion()
        {
            InitializeComponent();
        }

        ///Drag Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void Mover(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        public void ObtenerObjetoNuevaAportacion(frmNuevaAportacion nuevaAportacion)
        {
            nAportacion = nuevaAportacion;
        }

        private void cmdAportacion(object sender, EventArgs e)
        {
            nAportacion.lblEncargado2.Visible = false;
            nAportacion.lblTitle.Text = "Datos\r\ndel\r\nRecibo";
            nAportacion.ShowDialog();
        }

        private void cmdCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnModificarEstatus_Click(object sender, EventArgs e)
        {
            nAportacion.lblTitle.Text = "Datos\r\ndel\r\nRecibo\r\n(editar)";
            nAportacion.ShowDialog();
            dgvRecibos.DataSource = apDAL.MostrarRecibos().Tables[0];
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }
        public string folio, fecha, monto, mtoescrito, firmaasistente, firmaadministrativo;

        private void dgvRecibos_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int indice = e.RowIndex;

            //Obtener toda la informacion por medio del folio
            DataTable tb = apDAL.InformacionID($"Select * from RECIBO WHERE rec_folio = {dgvRecibos.Rows[indice].Cells[0].Value}");
            
            //Mostrar ID
            nAportacion.txtFolio.Text = tb.Rows[0]["rec_folio"].ToString();
            nAportacion.dtFecha.Value = (DateTime)tb.Rows[0]["rec_fecha"];

            //Obtener datos de Socio
            {
                DataTable t = apDAL.InformacionID($"Select sc_apaterno,sc_amaterno,sc_nombre_s from SOCIO WHERE socio_id = {tb.Rows[0]["socio_id"]}");

                nAportacion.lblAPaterno.Text = t.Rows[0]["sc_apaterno"].ToString();
                nAportacion.lblAPaterno.Text = t.Rows[0]["sc_amaterno"].ToString();
                nAportacion.lblAPaterno.Text = t.Rows[0]["sc_nombre_s"].ToString();
            }
            
            //Obtener Importe
            nAportacion.txtImporte.Text = tb.Rows[0]["rec_monto"].ToString();
            nAportacion.txtMtoEscrito.Text = tb.Rows[0]["rec_mto_escrito"].ToString();

            //Estatus
            string estatus = tb.Rows[0]["estatus_id"].ToString();

            apDAL.LlenarCB_Estatus(nAportacion.cbEstatus);

            //Imprimir ciudad
            bool bandera = false;
            int i = 0;
            while (bandera == false)
            {
                nAportacion.cbEstatus.SelectedIndex = i;
                if (nAportacion.cbEstatus.SelectedItem.ToString() == estatus)
                {
                    bandera = true;
                }
                i++;
            }

            //Periodo
            nAportacion.lblPeriodo.Text = $"{tb.Rows[0]["periodo_año"]} - {tb.Rows[0]["periodo_num"]}";

            //Encargado 1
            {
                DataTable t = apDAL.InformacionID($"Select usu_apaterno,usu_amaterno,usu_nombre_s from USUARIO WHERE usuario_id = {tb.Rows[0]["usuario_id"]}");

                string apaterno = t.Rows[0]["usu_apaterno"].ToString();
                string amaterno = t.Rows[0]["usu_amaterno"].ToString();
                string nombres = t.Rows[0]["usu_nombre_s"].ToString();

                nAportacion.txtEncargado1.Text = $"{nombres} {apaterno} {amaterno}";

            }

            //Encargado 2
            {
                string id = apDAL.SepararValores(tb.Rows[0]["rec_firma_administrativo"].ToString(), 0);
                DataTable t = apDAL.InformacionID($"Select usu_apaterno,usu_amaterno,usu_nombre_s from USUARIO WHERE usuario_id = {id}");

                string apaterno = t.Rows[0]["usu_apaterno"].ToString();
                string amaterno = t.Rows[0]["usu_amaterno"].ToString();
                string nombres = t.Rows[0]["usu_nombre_s"].ToString();

                //nAportacion.cbEncargado2.Visible= false;
                nAportacion.lblEncargado2.Text = $"{nombres} {apaterno} {amaterno}";
                nAportacion.lblEncargado2.Visible = true;
            }

        }
    }
}
