using A.C.Mascotas_Vulnerables___DB.BLL;
using A.C.Mascotas_Vulnerables___DB.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.Drawing.Printing;
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
        frmImprimir imprimir = new frmImprimir();

        HistorialDAL historialDAL = new HistorialDAL();
        HistorialBLL historial = new HistorialBLL();

        //frmAportacion aportacion = new frmAportacion();

        public void ObtenerObjetoEstadoR(frmEstadoRecibo estado)
        {
            this.estadoRecibo = estado;
        }

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
        public string idSocio, usuario_id; bool socio = false;
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
                if (cbPeriodo.Text == "- PERIODO -")
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
            lblNombre.Text = ""; txtMtoEscrito.Text = "";

        }

        private void btnAgregarRecibo_Click(object sender, EventArgs e)
        {
            if (!ValoresVacios())
            {
                Captarinformacion_Agregar();
                if (AportacionDAL.AgregarRecibo(res))
                {
                    MessageBox.Show("El RECIBO " + res.rec_folio + " se AGREGO correctamente", "Recibo Agregado");
                    
                    int num = 1 + historialDAL.RetornarUltimaModificacion();
                    historial.historia_num = num;
                    historial.usuario_id = res.usuario_id;
                    historial.cambio = $"Se agrego el recibo con folio: {res.rec_folio}";

                    DateTime date = DateTime.Today;
                    DateTime time = DateTime.Now;

                    historial.fecha = date;
                    historial.hora = time;
                    historialDAL.AgregarModificacion(historial);

                    //imprimirRec = new PrintDocument();
                    //PrinterSettings configImpres = new PrinterSettings();
                    //imprimirRec.PrinterSettings = configImpres;
                    //imprimirRec.PrintPage += Imprimir;
                    //imprimirRec.Print();

                    DialogResult aver = imprimir.ShowDialog();

                    if (aver == DialogResult.OK)
                    {
                        imprimirRec = new PrintDocument();
                        PrinterSettings configImpres = new PrinterSettings();
                        imprimirRec.PrinterSettings = configImpres;
                        imprimirRec.PrintPage += ImprimirHorizontal;
                        imprimirRec.Print();
                    }
                    else if (aver == DialogResult.Cancel )
                    {
                        imprimirRec = new PrintDocument();
                        PrinterSettings configImpres = new PrinterSettings();
                        imprimirRec.PrinterSettings = configImpres;
                        imprimirRec.PrintPage += ImprimirVertical;
                        imprimirRec.Print();
                    }

                    LimpiarRecibo();
                    Close();
                }
                else
                {
                    MessageBox.Show("NO se pudo ingresar la informacion del recibo", "Error al ingresar recibo");
                }
            }

            /*CREATE TABLE HISTORIAL (
    historia_num          INTEGER NOT NULL,
    usuario_id            tinyint NOT NULL,
    cambio				  VARCHAR(100) not null,
    fecha                 DATE NOT NULL,
	hora				  Time not null
);*/


        }
        //public void Imprimir(object sender, PrintPageEventArgs e)
        //{
        //    Font letra = new Font("Arial", 14, FontStyle.Regular, GraphicsUnit.Point);
        //    //dibujar folio
        //    e.Graphics.DrawString("Folio: " + res.rec_folio, letra, Brushes.Black, new RectangleF(600, 20, 450, 20));
        //    //dibujar monto
        //    e.Graphics.DrawString("Monto: " + res.rec_monto + ".00 $", letra, Brushes.Black, new RectangleF(600, 60, 450, 20));
        //    //dibujar imagen
        //    e.Graphics.DrawImage(pictureBox1.Image, new Rectangle(20, 20, 45, 55));
        //    //dibujar folio
        //    e.Graphics.DrawString("A.C MASCOTAS VULNERABLES", letra, Brushes.Black, new RectangleF(100, 20, 600, 20));

        //    //Recuperacion de datos de socio
        //    DataTable t = AportacionDAL.InformacionID($"Select usu_apaterno,usu_amaterno,usu_nombre_s from USUARIO WHERE usuario_id = {res.socio_id}");
        //    string apaterno = t.Rows[0]["usu_apaterno"].ToString();
        //    string amaterno = t.Rows[0]["usu_amaterno"].ToString();
        //    string nombres = t.Rows[0]["usu_nombre_s"].ToString();

        //    //dibuja datos del socio
        //    e.Graphics.DrawString($"{nombres} {apaterno} {amaterno}", letra, Brushes.Black, new RectangleF(100, 60, 500, 30));

        //    //dibuja rectangulo
        //    e.Graphics.DrawRectangle(new Pen(Color.Black, 1), 6, 6, 845, 100);
        //    e.Graphics.DrawRectangle(new Pen(Color.Black, 1), 6, 120, 845, 275);
        //    e.Graphics.DrawLine(new Pen(Color.Black, 2), new Point(725, 385), new Point(845, 385));
        //}
        private void cmdAgregarEstatus_Click(object sender, EventArgs e)
        {
            if(cmdAgregarEstatus.Tag.ToString() == "no")
            {
                MessageBox.Show("Solo los Administradores pueden agregar nuevos Estatus.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            else
            {
                estadoRecibo.ShowDialog();
            }
            
        }

        private void txtFolio_Validating(object sender, CancelEventArgs e)
        {
            if(ValidarNumeros(txtFolio, error1, e))
            {
                if (!AportacionDAL.ValidarID(txtFolio.Text, folio, txtFolio, error1))
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

                    int num = 1 + historialDAL.RetornarUltimaModificacion();
                    historial.historia_num = num;
                    historial.usuario_id = int.Parse(usuario_id);
                    historial.cambio = $"Se agrego el recibo con folio: {folio}";

                    DateTime date = DateTime.Today;
                    DateTime time = DateTime.Now;

                    historial.fecha = date;
                    historial.hora = time;
                    historialDAL.AgregarModificacion(historial);
                }
                else
                {
                    MessageBox.Show("NO se pudo ingresar la informacion del recibo", "Error al ingresar recibo");
                }

            }
            
        }
        public void ImprimirHorizontal(object sender, PrintPageEventArgs e)
        {
            Font letra = new Font("Arial", 11, FontStyle.Regular, GraphicsUnit.Point);
            //Reporte 1 horizontal
            {
                //dibujar folio
                e.Graphics.DrawString("Fecha: " + dtFecha.Value, letra, Brushes.Black, new RectangleF(500, 20, 450, 20));
                ////dibujar monto
                e.Graphics.DrawString("Periodo: " + lblPeriodo.Text, letra, Brushes.Black, new RectangleF(500, 60, 450, 20));
                //dibujar imagen
                e.Graphics.DrawImage(pictureBox1.Image, new Rectangle(20, 20, 45, 55));
                //dibujar folio
                e.Graphics.DrawString("A.C MASCOTAS VULNERABLES", letra, Brushes.Black, new RectangleF(100, 20, 600, 20));

                //Encabezado
                e.Graphics.DrawString("DATOS DE APORTACION", letra, Brushes.Black, new RectangleF(325, 125, 500, 30));
                e.Graphics.DrawLine(new Pen(Color.Black, 1), new Point(6, 150), new Point(846, 150));

                //dibuja datos del socio
                e.Graphics.DrawString("Socio: " + $"{lblNombre.Text} {lblAPaterno.Text} {lblAMaterno.Text}",
                    letra, Brushes.Black, new RectangleF(8, 160, 500, 30));
                e.Graphics.DrawLine(new Pen(Color.Black, 2), new Point(61, 182), new Point(320, 182));

                //dibuja datos de aportacion
                e.Graphics.DrawString("Aportación: " + txtImporte.Text + "   " + txtMtoEscrito.Text,
                    letra, Brushes.Black, new RectangleF(8, 210, 500, 30));
                e.Graphics.DrawLine(new Pen(Color.Black, 2), new Point(100, 230), new Point(360, 230));

                //dibuja rectangulo
                e.Graphics.DrawRectangle(new Pen(Color.Black, 1), 6, 6, 840, 100);

                //dibuja segundo rectangulo
                e.Graphics.DrawRectangle(new Pen(Color.Black, 1), 6, 120, 840, 215);

                //Linea de firma derecha
                e.Graphics.DrawLine(new Pen(Color.Black, 2), new Point(485, 310), new Point(835, 310));
                e.Graphics.DrawString(res.rec_firma_asistente, letra, Brushes.Black, new RectangleF(485, 290, 600, 20));
                e.Graphics.DrawString("Firma", letra, Brushes.Black, new RectangleF(650, 316, 600, 20));

                //Linea de firma izquierda
                e.Graphics.DrawLine(new Pen(Color.Black, 2), new Point(7, 310), new Point(345, 310));
                e.Graphics.DrawString(res.rec_firma_administrativo, letra, Brushes.Black, new RectangleF(8, 290, 600, 20));
                e.Graphics.DrawString("Firma", letra, Brushes.Black, new RectangleF(35, 316, 600, 20));
            }
            //Reporte 2 horizontal
            {
                //dibujar folio
                e.Graphics.DrawString("Fecha: " + dtFecha.Value, letra, Brushes.Black, new RectangleF(500, 360, 450, 360));
                //dibujar monto
                e.Graphics.DrawString("Periodo: " + lblPeriodo.Text, letra, Brushes.Black, new RectangleF(500, 400, 450, 400));
                //dibujar imagen
                e.Graphics.DrawImage(pictureBox1.Image, new Rectangle(20, 360, 45, 55));
                //dibujar folio
                e.Graphics.DrawString("A.C MASCOTAS VULNERABLES", letra, Brushes.Black, new RectangleF(100, 360, 600, 20));

                //Encabezado
                e.Graphics.DrawString("DATOS DE APORTACION", letra, Brushes.Black, new RectangleF(325, 460, 500, 30));
                e.Graphics.DrawLine(new Pen(Color.Black, 1), new Point(6, 485), new Point(846, 485));

                //dibuja datos del socio
                e.Graphics.DrawString("Socio: " + $"{lblNombre.Text} {lblAPaterno.Text} {lblAMaterno.Text}",
                    letra, Brushes.Black, new RectangleF(8, 500, 500, 30));
                e.Graphics.DrawLine(new Pen(Color.Black, 2), new Point(61, 522), new Point(320, 522));

                //dibuja datos de aportacion
                e.Graphics.DrawString("Aportación: " + txtImporte.Text + "   " + txtMtoEscrito.Text,
                    letra, Brushes.Black, new RectangleF(8, 550, 500, 30));
                e.Graphics.DrawLine(new Pen(Color.Black, 2), new Point(100, 572), new Point(360, 572));

                //dibuja rectangulo
                e.Graphics.DrawRectangle(new Pen(Color.Black, 1), 6, 345, 840, 100);

                //dibuja segundo rectangulo
                e.Graphics.DrawRectangle(new Pen(Color.Black, 1), 6, 453, 840, 215);

                //Linea de firma derecha
                e.Graphics.DrawLine(new Pen(Color.Black, 2), new Point(485, 645), new Point(835, 645));
                e.Graphics.DrawString(res.rec_firma_asistente, letra, Brushes.Black, new RectangleF(485, 625, 600, 20));
                e.Graphics.DrawString("Firma", letra, Brushes.Black, new RectangleF(650, 650, 600, 20));

                //Linea de firma izquierda
                e.Graphics.DrawLine(new Pen(Color.Black, 2), new Point(7, 645), new Point(345, 645));
                e.Graphics.DrawString(res.rec_firma_administrativo, letra, Brushes.Black, new RectangleF(8, 625, 600, 20));
                e.Graphics.DrawString("Firma", letra, Brushes.Black, new RectangleF(35, 650, 600, 20));
            }
            //Reporte 3 horizontal
            {
                //dibujar folio
                e.Graphics.DrawString("Fecha: " + dtFecha.Value, letra, Brushes.Black, new RectangleF(500, 685, 450, 685));
                ////dibujar monto
                e.Graphics.DrawString("Periodo: " + lblPeriodo.Text, letra, Brushes.Black, new RectangleF(500, 725, 450, 725));
                //dibujar imagen
                e.Graphics.DrawImage(pictureBox1.Image, new Rectangle(20, 685, 45, 55));
                //dibujar folio
                e.Graphics.DrawString("A.C MASCOTAS VULNERABLES", letra, Brushes.Black, new RectangleF(100, 685, 600, 20));

                //Encabezado
                e.Graphics.DrawString("DATOS DE APORTACION", letra, Brushes.Black, new RectangleF(325, 810, 500, 30));
                e.Graphics.DrawLine(new Pen(Color.Black, 1), new Point(6, 836), new Point(846, 836));

                //dibuja datos del socio
                e.Graphics.DrawString("Socio: " + $"{lblNombre.Text}   {lblAPaterno.Text}   {lblAMaterno.Text}",
                    letra, Brushes.Black, new RectangleF(8, 850, 500, 30));
                e.Graphics.DrawLine(new Pen(Color.Black, 2), new Point(61, 872), new Point(320, 872));

                //dibuja datos de aportacion
                e.Graphics.DrawString("Aportación: " + txtImporte.Text + "   " + txtMtoEscrito.Text,
                    letra, Brushes.Black, new RectangleF(8, 900, 500, 30));
                e.Graphics.DrawLine(new Pen(Color.Black, 2), new Point(100, 922), new Point(360, 922));

                //dibuja rectangulo
                e.Graphics.DrawRectangle(new Pen(Color.Black, 1), 6, 675, 840, 118);

                //dibuja segundo rectangulo
                e.Graphics.DrawRectangle(new Pen(Color.Black, 1), 6, 800, 840, 215);

                //Linea de firma derecha
                e.Graphics.DrawLine(new Pen(Color.Black, 2), new Point(485, 992), new Point(835, 992));
                e.Graphics.DrawString(res.rec_firma_asistente, letra, Brushes.Black, new RectangleF(485, 972, 600, 20));
                e.Graphics.DrawString("Firma", letra, Brushes.Black, new RectangleF(650, 995, 600, 20));

                //Linea de firma izquierda
                e.Graphics.DrawLine(new Pen(Color.Black, 2), new Point(7, 992), new Point(345, 992));
                e.Graphics.DrawString(res.rec_firma_administrativo, letra, Brushes.Black, new RectangleF(8, 972, 600, 20));
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
                e.Graphics.DrawString("Fecha: " + res.rec_fecha, letra, Brushes.Black, new RectangleF(135, 80, 450, 20));
                //dibujar monto
                e.Graphics.DrawString("Periodo: " + lblPeriodo.Text, letra, Brushes.Black, new RectangleF(135, 90, 450, 20));
                //dibujar imagen
                e.Graphics.DrawImage(pictureBox1.Image, new Rectangle(125, 10, 30, 35));
                //dibujar titulo
                e.Graphics.DrawString("A.C MASCOTAS VULNERABLES", letra, Brushes.Black, new RectangleF(80, 50, 600, 20));

                //dibuja datos del socio
                e.Graphics.DrawString("Socio: ", letra, Brushes.Black, new RectangleF(8, 120, 500, 30));
                e.Graphics.DrawString($"{lblNombre.Text} {lblAPaterno.Text} {lblAMaterno.Text}", letra, Brushes.Black, new RectangleF(8, 135, 500, 30));
                e.Graphics.DrawLine(new Pen(Color.Black, 1), new Point(8, 145), new Point(150, 145));

                //dibuja datos de aportacion
                e.Graphics.DrawString("Aportación: ", letra, Brushes.Black, new RectangleF(8, 150, 500, 30));
                e.Graphics.DrawString(txtImporte.Text + "   " + txtMtoEscrito.Text, letra, Brushes.Black, new RectangleF(8, 165, 500, 30));
                e.Graphics.DrawLine(new Pen(Color.Black, 1), new Point(8, 175), new Point(150, 175));

                //dibuja rectangulo
                e.Graphics.DrawRectangle(new Pen(Color.Black, 1), 6, 6, 250, 300);

                //Linea de firma derecha
                e.Graphics.DrawLine(new Pen(Color.Black, 1), new Point(60, 200), new Point(250, 200));
                e.Graphics.DrawString(res.rec_firma_asistente, letra, Brushes.Black, new RectangleF(60, 188, 600, 20));
                e.Graphics.DrawString("Firma", letra, Brushes.Black, new RectangleF(100, 205, 600, 20));

                //Linea de firma izquierda
                e.Graphics.DrawLine(new Pen(Color.Black, 1), new Point(60, 230), new Point(250, 230));
                e.Graphics.DrawString(res.rec_firma_administrativo, letra, Brushes.Black, new RectangleF(60, 218, 600, 20));
                e.Graphics.DrawString("Firma", letra, Brushes.Black, new RectangleF(100, 235, 600, 20));
            }
            //Reporte 2 vertical
            {
                //dibujar folio
                e.Graphics.DrawString("Fecha: " + res.rec_fecha, letra, Brushes.Black, new RectangleF(390, 80, 450, 20));
                //dibujar monto
                e.Graphics.DrawString("Periodo: " + lblPeriodo.Text, letra, Brushes.Black, new RectangleF(390, 90, 450, 20));
                //dibujar imagen
                e.Graphics.DrawImage(pictureBox1.Image, new Rectangle(380, 10, 30, 35));
                //dibujar titulo
                e.Graphics.DrawString("A.C MASCOTAS VULNERABLES", letra, Brushes.Black, new RectangleF(330, 50, 600, 20));

                //dibuja datos del socio
                e.Graphics.DrawString("Socio: ", letra, Brushes.Black, new RectangleF(261, 120, 500, 30));
                e.Graphics.DrawString($"{lblNombre.Text} {lblAPaterno.Text} {lblAMaterno.Text}", letra, Brushes.Black, new RectangleF(261, 135, 500, 30));
                e.Graphics.DrawLine(new Pen(Color.Black, 1), new Point(262, 148), new Point(415, 148));

                //dibuja datos de aportacion
                e.Graphics.DrawString("Aportación: ", letra, Brushes.Black, new RectangleF(263, 150, 500, 30));
                e.Graphics.DrawString(txtImporte.Text + "   " + txtMtoEscrito.Text, letra, Brushes.Black, new RectangleF(261, 165, 500, 30));
                e.Graphics.DrawLine(new Pen(Color.Black, 1), new Point(262, 175), new Point(415, 175));

                //dibuja rectangulo
                e.Graphics.DrawRectangle(new Pen(Color.Black, 1), 260, 6, 250, 300);

                //Linea de firma derecha
                e.Graphics.DrawLine(new Pen(Color.Black, 1), new Point(330, 200), new Point(507, 200));
                e.Graphics.DrawString(res.rec_firma_asistente, letra, Brushes.Black, new RectangleF(330, 188, 600, 20));
                e.Graphics.DrawString("Firma", letra, Brushes.Black, new RectangleF(370, 205, 600, 20));

                //Linea de firma izquierda
                e.Graphics.DrawLine(new Pen(Color.Black, 1), new Point(330, 230), new Point(507, 230));
                e.Graphics.DrawString(res.rec_firma_administrativo, letra, Brushes.Black, new RectangleF(330, 218, 600, 20));
                e.Graphics.DrawString("Firma", letra, Brushes.Black, new RectangleF(370, 235, 600, 20));
            }
            //Reporte 3 vertical
            {
                //dibujar folio
                e.Graphics.DrawString("Fecha: " + res.rec_fecha, letra, Brushes.Black, new RectangleF(645, 80, 450, 20));
                //dibujar monto
                e.Graphics.DrawString("Periodo: " + lblPeriodo.Text, letra, Brushes.Black, new RectangleF(645, 90, 450, 20));
                //dibujar imagen
                e.Graphics.DrawImage(pictureBox1.Image, new Rectangle(635, 10, 30, 35));
                //dibujar titulo
                e.Graphics.DrawString("A.C MASCOTAS VULNERABLES", letra, Brushes.Black, new RectangleF(585, 50, 600, 20));

                //dibuja datos del socio
                e.Graphics.DrawString("Socio: ", letra, Brushes.Black, new RectangleF(518, 120, 500, 30));
                e.Graphics.DrawString($"{lblNombre.Text} {lblAPaterno.Text} {lblAMaterno.Text}", letra, Brushes.Black, new RectangleF(518, 135, 500, 30));
                e.Graphics.DrawLine(new Pen(Color.Black, 1), new Point(518, 148), new Point(645, 148));

                //dibuja datos de aportacion
                e.Graphics.DrawString("Aportación: ", letra, Brushes.Black, new RectangleF(518, 150, 500, 30));
                e.Graphics.DrawString(txtImporte.Text + "   " + txtMtoEscrito.Text, letra, Brushes.Black, new RectangleF(518, 165, 500, 30));
                e.Graphics.DrawLine(new Pen(Color.Black, 1), new Point(518, 175), new Point(645, 175));

                //dibuja rectangulo
                e.Graphics.DrawRectangle(new Pen(Color.Black, 1), 515, 6, 250, 300);

                //Linea de firma derecha
                e.Graphics.DrawLine(new Pen(Color.Black, 1), new Point(585, 200), new Point(760, 200));
                e.Graphics.DrawString(res.rec_firma_asistente, letra, Brushes.Black, new RectangleF(585, 188, 600, 20));
                e.Graphics.DrawString("Firma", letra, Brushes.Black, new RectangleF(605, 205, 600, 20));

                //Linea de firma izquierda
                e.Graphics.DrawLine(new Pen(Color.Black, 1), new Point(585, 230), new Point(760, 230));
                e.Graphics.DrawString(res.rec_firma_administrativo, letra, Brushes.Black, new RectangleF(585, 218, 600, 20));
                e.Graphics.DrawString("Firma", letra, Brushes.Black, new RectangleF(605, 235, 600, 20));
            }
            //imprimirRec.Print();
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
