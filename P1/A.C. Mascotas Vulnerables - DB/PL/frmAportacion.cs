using A.C.Mascotas_Vulnerables___DB.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
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
        frmEstadoRecibo estadoRecibo = new frmEstadoRecibo();
        frmImprimir imp = new frmImprimir();
        
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

        public void ObtenerObjetoNuevaAportacion(frmNuevaAportacion nuevaAportacion, frmEstadoRecibo estador)
        {
            this.nAportacion = nuevaAportacion;
            nAportacion.ObtenerObjetoEstadoR(estador);
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
        bool modifi = false;
        private void btnModificarEstatus_Click(object sender, EventArgs e)
        {
            if (modifi == true)
            {
                nAportacion.lblTitle.Text = "Datos\r\ndel\r\nRecibo\r\n(editar)";
                nAportacion.ShowDialog();
                dgvRecibos.DataSource = apDAL.MostrarRecibos().Tables[0];
                modifi = false;
            }
            else
            {
                MessageBox.Show("Debe seleccionar primero un registro para modificarlo", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }
        public string folio, fecha, monto, mtoescrito, firmaasistente, firmaadministrativo;

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            imp.ShowDialog();
        }

        public void ImprimirHorizontal(object sender, PrintPageEventArgs e)
        {
            Font letra = new Font("Arial", 11, FontStyle.Regular, GraphicsUnit.Point);
            //Reporte 1 horizontal
            {
                //dibujar folio
                e.Graphics.DrawString("Fecha: " + nAportacion.dtFecha.Value, letra, Brushes.Black, new RectangleF(500, 20, 450, 20));
                ////dibujar monto
                e.Graphics.DrawString("Periodo: " + nAportacion.lblPeriodo.Text, letra, Brushes.Black, new RectangleF(500, 60, 450, 20));
                //dibujar imagen
                e.Graphics.DrawImage(pictureBox1.Image, new Rectangle(20, 20, 45, 55));
                //dibujar folio
                e.Graphics.DrawString("A.C MASCOTAS VULNERABLES", letra, Brushes.Black, new RectangleF(100, 20, 600, 20));

                //Encabezado
                e.Graphics.DrawString("DATOS DE APORTACION", letra, Brushes.Black, new RectangleF(325, 125, 500, 30));
                e.Graphics.DrawLine(new Pen(Color.Black, 1), new Point(6, 150), new Point(846, 150));

                //dibuja datos del socio
                e.Graphics.DrawString("Socio: " + $"{nAportacion.lblNombre.Text} {nAportacion.lblAPaterno.Text} {nAportacion.lblAMaterno.Text}",
                    letra, Brushes.Black, new RectangleF(8, 160, 500, 30));
                e.Graphics.DrawLine(new Pen(Color.Black, 2), new Point(61, 182), new Point(320, 182));

                //dibuja datos de aportacion
                e.Graphics.DrawString("Aportación: " + nAportacion.txtImporte.Text + "   " + nAportacion.txtMtoEscrito.Text,
                    letra, Brushes.Black, new RectangleF(8, 210, 500, 30));
                e.Graphics.DrawLine(new Pen(Color.Black, 2), new Point(100, 230), new Point(360, 230));

                //dibuja rectangulo
                e.Graphics.DrawRectangle(new Pen(Color.Black, 1), 6, 6, 840, 100);

                //dibuja segundo rectangulo
                e.Graphics.DrawRectangle(new Pen(Color.Black, 1), 6, 120, 840, 215);

                //Linea de firma derecha
                e.Graphics.DrawLine(new Pen(Color.Black, 2), new Point(485, 310), new Point(835, 310));
                e.Graphics.DrawString(nAportacion.txtEncargado1.Text + " " + nAportacion.dtFecha.Value, letra, Brushes.Black, new RectangleF(485, 290, 600, 20));
                e.Graphics.DrawString("Firma", letra, Brushes.Black, new RectangleF(650, 316, 600, 20));

                //Linea de firma izquierda
                e.Graphics.DrawLine(new Pen(Color.Black, 2), new Point(7, 310), new Point(345, 310));
                e.Graphics.DrawString(nAportacion.lblEncargado2.Text + " " + nAportacion.dtFecha.Value, letra, Brushes.Black, new RectangleF(8, 290, 600, 20));
                e.Graphics.DrawString("Firma", letra, Brushes.Black, new RectangleF(35, 316, 600, 20));
            }
            //Reporte 2 horizontal
            {
                //dibujar folio
                e.Graphics.DrawString("Fecha: " + nAportacion.dtFecha.Value, letra, Brushes.Black, new RectangleF(500, 360, 450, 360));
                //dibujar monto
                e.Graphics.DrawString("Periodo: " + nAportacion.lblPeriodo.Text, letra, Brushes.Black, new RectangleF(500, 400, 450, 400));
                //dibujar imagen
                e.Graphics.DrawImage(pictureBox1.Image, new Rectangle(20, 360, 45, 55));
                //dibujar folio
                e.Graphics.DrawString("A.C MASCOTAS VULNERABLES", letra, Brushes.Black, new RectangleF(100, 360, 600, 20));

                //Encabezado
                e.Graphics.DrawString("DATOS DE APORTACION", letra, Brushes.Black, new RectangleF(325, 460, 500, 30));
                e.Graphics.DrawLine(new Pen(Color.Black, 1), new Point(6, 485), new Point(846, 485));

                //dibuja datos del socio
                e.Graphics.DrawString("Socio: " + $"{nAportacion.lblNombre.Text} {nAportacion.lblAPaterno.Text} {nAportacion.lblAMaterno.Text}",
                    letra, Brushes.Black, new RectangleF(8, 500, 500, 30));
                e.Graphics.DrawLine(new Pen(Color.Black, 2), new Point(61, 522), new Point(320, 522));

                //dibuja datos de aportacion
                e.Graphics.DrawString("Aportación: " + nAportacion.txtImporte.Text + "   " + nAportacion.txtMtoEscrito.Text,
                    letra, Brushes.Black, new RectangleF(8, 550, 500, 30));
                e.Graphics.DrawLine(new Pen(Color.Black, 2), new Point(100, 572), new Point(360, 572));

                //dibuja rectangulo
                e.Graphics.DrawRectangle(new Pen(Color.Black, 1), 6, 345, 840, 100);

                //dibuja segundo rectangulo
                e.Graphics.DrawRectangle(new Pen(Color.Black, 1), 6, 453, 840, 215);

                //Linea de firma derecha
                e.Graphics.DrawLine(new Pen(Color.Black, 2), new Point(485, 645), new Point(835, 645));
                e.Graphics.DrawString(nAportacion.txtEncargado1.Text + " " + nAportacion.dtFecha.Value, letra, Brushes.Black, new RectangleF(485, 625, 600, 20));
                e.Graphics.DrawString("Firma", letra, Brushes.Black, new RectangleF(650, 650, 600, 20));

                //Linea de firma izquierda
                e.Graphics.DrawLine(new Pen(Color.Black, 2), new Point(7, 645), new Point(345, 645));
                e.Graphics.DrawString(nAportacion.lblEncargado2.Text + " " + nAportacion.dtFecha.Value, letra, Brushes.Black, new RectangleF(8, 625, 600, 20));
                e.Graphics.DrawString("Firma", letra, Brushes.Black, new RectangleF(35, 650, 600, 20));
            }
            //Reporte 3 horizontal
            {
                //dibujar folio
                e.Graphics.DrawString("Fecha: " + nAportacion.dtFecha.Value, letra, Brushes.Black, new RectangleF(500, 685, 450, 685));
                ////dibujar monto
                e.Graphics.DrawString("Periodo: " + nAportacion.lblPeriodo.Text, letra, Brushes.Black, new RectangleF(500, 725, 450, 725));
                //dibujar imagen
                e.Graphics.DrawImage(pictureBox1.Image, new Rectangle(20, 685, 45, 55));
                //dibujar folio
                e.Graphics.DrawString("A.C MASCOTAS VULNERABLES", letra, Brushes.Black, new RectangleF(100, 685, 600, 20));

                //Encabezado
                e.Graphics.DrawString("DATOS DE APORTACION", letra, Brushes.Black, new RectangleF(325, 810, 500, 30));
                e.Graphics.DrawLine(new Pen(Color.Black, 1), new Point(6, 836), new Point(846, 836));

                //dibuja datos del socio
                e.Graphics.DrawString("Socio: " + $"{nAportacion.lblNombre.Text} {nAportacion.lblAPaterno.Text} {nAportacion.lblAMaterno.Text}",
                    letra, Brushes.Black, new RectangleF(8, 850, 500, 30));
                e.Graphics.DrawLine(new Pen(Color.Black, 2), new Point(61, 872), new Point(320, 872));

                //dibuja datos de aportacion
                e.Graphics.DrawString("Aportación: " + nAportacion.txtImporte.Text + "   " + nAportacion.txtMtoEscrito.Text,
                    letra, Brushes.Black, new RectangleF(8, 900, 500, 30));
                e.Graphics.DrawLine(new Pen(Color.Black, 2), new Point(100, 922), new Point(360, 922));

                //dibuja rectangulo
                e.Graphics.DrawRectangle(new Pen(Color.Black, 1), 6, 675, 840, 118);

                //dibuja segundo rectangulo
                e.Graphics.DrawRectangle(new Pen(Color.Black, 1), 6, 800, 840, 215);

                //Linea de firma derecha
                e.Graphics.DrawLine(new Pen(Color.Black, 2), new Point(485, 992), new Point(835, 992));
                e.Graphics.DrawString(nAportacion.txtEncargado1.Text + " " + nAportacion.dtFecha.Value, letra, Brushes.Black, new RectangleF(485, 972, 600, 20));
                e.Graphics.DrawString("Firma", letra, Brushes.Black, new RectangleF(650, 995, 600, 20));

                //Linea de firma izquierda
                e.Graphics.DrawLine(new Pen(Color.Black, 2), new Point(7, 992), new Point(345, 992));
                e.Graphics.DrawString(nAportacion.lblEncargado2.Text + " " + nAportacion.dtFecha.Value, letra, Brushes.Black, new RectangleF(8, 972, 600, 20));
                e.Graphics.DrawString("Firma", letra, Brushes.Black, new RectangleF(35, 995, 600, 20));
            }

        }

        public void ImprimirVertical(object sender, PrintPageEventArgs e)
        {
            imprimirRec = new PrintDocument();
            PrinterSettings configImpres = new PrinterSettings();
            imprimirRec.PrinterSettings = configImpres;
            //imprimirRec.PrintPage += ImprimirHorizontal;
        

            Font letra = new Font("Arial", 6, FontStyle.Regular, GraphicsUnit.Point);
            //Reporte 1 vertical
            {
                //dibujar folio
                e.Graphics.DrawString("Fecha: " + nAportacion.dtFecha.Value, letra, Brushes.Black, new RectangleF(135, 80, 450, 20));
                //dibujar monto
                e.Graphics.DrawString("Periodo: " + nAportacion.lblPeriodo.Text, letra, Brushes.Black, new RectangleF(135, 90, 450, 20));
                //dibujar imagen
                e.Graphics.DrawImage(pictureBox1.Image, new Rectangle(125, 10, 30, 35));
                //dibujar titulo
                e.Graphics.DrawString("A.C MASCOTAS VULNERABLES", letra, Brushes.Black, new RectangleF(80, 50, 600, 20));

                //dibuja datos del socio
                e.Graphics.DrawString("Socio: ", letra, Brushes.Black, new RectangleF(8, 120, 500, 30));
                e.Graphics.DrawString($"{nAportacion.lblNombre.Text} {nAportacion.lblAPaterno.Text} {nAportacion.lblAMaterno.Text}", letra, Brushes.Black, new RectangleF(8, 135, 500, 30));
                e.Graphics.DrawLine(new Pen(Color.Black, 1), new Point(8, 145), new Point(150, 145));

                //dibuja datos de aportacion
                e.Graphics.DrawString("Aportación: ", letra, Brushes.Black, new RectangleF(8, 150, 500, 30));
                e.Graphics.DrawString(nAportacion.txtImporte.Text + "   " + nAportacion.txtMtoEscrito.Text, letra, Brushes.Black, new RectangleF(8, 165, 500, 30));
                e.Graphics.DrawLine(new Pen(Color.Black, 1), new Point(8, 175), new Point(150, 175));

                //dibuja rectangulo
                e.Graphics.DrawRectangle(new Pen(Color.Black, 1), 6, 6, 250, 300);

                //Linea de firma derecha
                e.Graphics.DrawLine(new Pen(Color.Black, 1), new Point(60, 200), new Point(250, 200));
                e.Graphics.DrawString(nAportacion.txtEncargado1.Text + " " + nAportacion.dtFecha.Value, letra, Brushes.Black, new RectangleF(60, 188, 600, 20));
                e.Graphics.DrawString("Firma", letra, Brushes.Black, new RectangleF(150, 205, 600, 20));

                //Linea de firma izquierda
                e.Graphics.DrawLine(new Pen(Color.Black, 1), new Point(60, 230), new Point(250, 230));
                e.Graphics.DrawString(nAportacion.lblEncargado2.Text + " " + nAportacion.dtFecha.Value, letra, Brushes.Black, new RectangleF(60, 218, 600, 20));
                e.Graphics.DrawString("Firma", letra, Brushes.Black, new RectangleF(150, 235, 600, 20));
            }
            //Reporte 2 vertical
            {
                //dibujar folio
                e.Graphics.DrawString("Fecha: " + nAportacion.dtFecha.Value, letra, Brushes.Black, new RectangleF(390, 80, 450, 20));
                //dibujar monto
                e.Graphics.DrawString("Periodo: " + nAportacion.lblPeriodo.Text, letra, Brushes.Black, new RectangleF(390, 90, 450, 20));
                //dibujar imagen
                e.Graphics.DrawImage(pictureBox1.Image, new Rectangle(380, 10, 30, 35));
                //dibujar titulo
                e.Graphics.DrawString("A.C MASCOTAS VULNERABLES", letra, Brushes.Black, new RectangleF(330, 50, 600, 20));

                //dibuja datos del socio
                e.Graphics.DrawString("Socio: ", letra, Brushes.Black, new RectangleF(261, 120, 500, 30));
                e.Graphics.DrawString($"{nAportacion.lblNombre.Text} {nAportacion.lblAPaterno.Text} {nAportacion.lblAMaterno.Text}", letra, Brushes.Black, new RectangleF(261, 135, 500, 30));
                e.Graphics.DrawLine(new Pen(Color.Black, 1), new Point(262, 148), new Point(415, 148));

                //dibuja datos de aportacion
                e.Graphics.DrawString("Aportación: ", letra, Brushes.Black, new RectangleF(263, 150, 500, 30));
                e.Graphics.DrawString(nAportacion.txtImporte.Text + "   " + nAportacion.txtMtoEscrito.Text, letra, Brushes.Black, new RectangleF(261, 165, 500, 30));
                e.Graphics.DrawLine(new Pen(Color.Black, 1), new Point(262, 175), new Point(415, 175));

                //dibuja rectangulo
                e.Graphics.DrawRectangle(new Pen(Color.Black, 1), 260, 6, 250, 300);

                //Linea de firma derecha
                e.Graphics.DrawLine(new Pen(Color.Black, 1), new Point(330, 200), new Point(507, 200));
                e.Graphics.DrawString(nAportacion.txtEncargado1.Text + " " + nAportacion.dtFecha.Value, letra, Brushes.Black, new RectangleF(330, 188, 600, 20));
                e.Graphics.DrawString("Firma", letra, Brushes.Black, new RectangleF(420, 205, 600, 20));

                //Linea de firma izquierda
                e.Graphics.DrawLine(new Pen(Color.Black, 1), new Point(330, 230), new Point(507, 230));
                e.Graphics.DrawString(nAportacion.lblEncargado2.Text + " " + nAportacion.dtFecha.Value, letra, Brushes.Black, new RectangleF(330, 218, 600, 20));
                e.Graphics.DrawString("Firma", letra, Brushes.Black, new RectangleF(420, 235, 600, 20));
            }
            //Reporte 3 vertical
            {
                //dibujar folio
                e.Graphics.DrawString("Fecha: " + nAportacion.dtFecha.Value, letra, Brushes.Black, new RectangleF(645, 80, 450, 20));
                //dibujar monto
                e.Graphics.DrawString("Periodo: " + nAportacion.lblPeriodo.Text, letra, Brushes.Black, new RectangleF(645, 90, 450, 20));
                //dibujar imagen
                e.Graphics.DrawImage(pictureBox1.Image, new Rectangle(635, 10, 30, 35));
                //dibujar titulo
                e.Graphics.DrawString("A.C MASCOTAS VULNERABLES", letra, Brushes.Black, new RectangleF(585, 50, 600, 20));

                //dibuja datos del socio
                e.Graphics.DrawString("Socio: ", letra, Brushes.Black, new RectangleF(518, 120, 500, 30));
                e.Graphics.DrawString($"{nAportacion.lblNombre.Text} {nAportacion.lblAPaterno.Text} {nAportacion.lblAMaterno.Text}", letra, Brushes.Black, new RectangleF(518, 135, 500, 30));
                e.Graphics.DrawLine(new Pen(Color.Black, 1), new Point(518, 148), new Point(645, 148));

                //dibuja datos de aportacion
                e.Graphics.DrawString("Aportación: ", letra, Brushes.Black, new RectangleF(518, 150, 500, 30));
                e.Graphics.DrawString(nAportacion.txtImporte.Text + "   " + nAportacion.txtMtoEscrito.Text, letra, Brushes.Black, new RectangleF(518, 165, 500, 30));
                e.Graphics.DrawLine(new Pen(Color.Black, 1), new Point(518, 175), new Point(645, 175));

                //dibuja rectangulo
                e.Graphics.DrawRectangle(new Pen(Color.Black, 1), 515, 6, 250, 300);

                //Linea de firma derecha
                e.Graphics.DrawLine(new Pen(Color.Black, 1), new Point(585, 200), new Point(760, 200));
                e.Graphics.DrawString(nAportacion.txtEncargado1.Text + " " + nAportacion.dtFecha.Value, letra, Brushes.Black, new RectangleF(585, 188, 600, 20));
                e.Graphics.DrawString("Firma", letra, Brushes.Black, new RectangleF(655, 205, 600, 20));

                //Linea de firma izquierda
                e.Graphics.DrawLine(new Pen(Color.Black, 1), new Point(585, 230), new Point(760, 230));
                e.Graphics.DrawString(nAportacion.lblEncargado2.Text + " " + nAportacion.dtFecha.Value, letra, Brushes.Black, new RectangleF(585, 218, 600, 20));
                e.Graphics.DrawString("Firma", letra, Brushes.Black, new RectangleF(655, 235, 600, 20));
            }
            //imprimirRec.Print();
        }
        
        private void frmAportacion_Load(object sender, EventArgs e)
        {

        }

        public void dgvRecibos_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
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
                nAportacion.lblAMaterno.Text = t.Rows[0]["sc_amaterno"].ToString();
                nAportacion.lblNombre.Text = t.Rows[0]["sc_nombre_s"].ToString();
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

            modifi = true;

        }
    }
}
