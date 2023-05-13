using A.C.Mascotas_Vulnerables___DB.BLL;
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
using static System.Net.Mime.MediaTypeNames;

namespace A.C.Mascotas_Vulnerables___DB.PL
{
    public partial class frmEdit_Socios : Form
    {
        public frmEdit_Socios()
        {
            InitializeComponent();
        }

        ///Drag Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        bool error = false;
        private void Mover(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        //Objetos 
        SocioBLL socio = new SocioBLL();
        SocioDAL socioDAL = new SocioDAL();

        //variables auxiliares
        string idActual;
        private void frmEdit_Socios_Load(object sender, EventArgs e)
        {
            if (lblTitle.Text == "AGREGAR NUEVO SOCIO")
            {
                cmdAgregar.Visible = true;
                pnModificar.Visible = false;
                socioDAL.LlenarCBCiudad(cbCiudad);
            }
            else
            {
                cmdAgregar.Visible = false;
                pnModificar.Visible = true;
                if (txtSocioID.Text != "")
                {
                    idActual = txtSocioID.Text;
                }
            }

        }

        private void Limpiar()
        {
            txtSocioID.Clear(); txtApellidoPSocio.Clear(); txtApellidoMSocio.Clear(); txtNombreSocio.Clear();
            txtRfcSocio.Clear(); txtCorreoSocio.Clear(); txtTelefono2Socio.Clear(); txtTelefono3Socio.Clear();
            txtTelefonoPSocio.Clear(); txtCalleSocio.Clear(); txtNoExtSocio.Clear(); txtNoIntSocio.Clear();
            txtColoniaSocio.Clear(); txtEstado.Clear(); txtPais.Clear(); txtCpSocio.Clear(); cbCiudad.SelectedIndex = 0;
            cbEstadoSocio.SelectedIndex = 0; cbTipoPSocio.SelectedIndex = 0;

        }

        public bool ValoresVaciosUsuario()
        {
            string valoresVacios = "";
            int no_vacios = 0;
            //VERIFICACION DE VALORES VACIOS
            {
                //Informacion personal
                if (txtSocioID.Text == "")
                {
                    valoresVacios += "Socio id, ";
                    no_vacios++;
                }
                if (txtNombreSocio.Text == "")
                {
                    valoresVacios += "Nombre, ";
                    no_vacios++;
                }
                if (txtApellidoMSocio.Text == "")
                {
                    valoresVacios += "Apellido materno, ";
                    no_vacios++;
                }
                if (txtApellidoPSocio.Text == "")
                {
                    valoresVacios += "Apellido paterno, ";
                    no_vacios++;
                }
                if (txtRfcSocio.Text == "")
                {
                    valoresVacios += "RFC, ";
                    no_vacios++;
                }
                if (cbTipoPSocio.Text == "- SELECCIONE -")
                {
                    valoresVacios += "Tipo de persona, ";
                    no_vacios++;
                }
                if (cbEstadoSocio.Text == "- SELECCIONE -")
                {
                    valoresVacios += "Estatus, ";
                    no_vacios++;
                }
                if (txtCorreoSocio.Text == "")
                {
                    valoresVacios += "Correo,";
                    no_vacios++;
                }
                if (txtTelefonoPSocio.Text == "")
                {
                    valoresVacios += "Telefono, ";
                    no_vacios++;
                }

                //Direccion
                if (cbCiudad.Text == "- SELECCIONE CIUDAD -")
                {
                    valoresVacios += "Ciudad, ";
                    no_vacios++;
                }
                if (txtCalleSocio.Text == "")
                {
                    valoresVacios += "Calle, ";
                    no_vacios++;
                }
                if (txtNoExtSocio.Text == "")
                {
                    valoresVacios += "No. exterior,";
                    no_vacios++;
                }
                if (txtCpSocio.Text == "")
                {
                    valoresVacios += "CP, ";
                    no_vacios++;
                }
                if (txtColoniaSocio.Text == "")
                {
                    valoresVacios += "Colonia,";
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

        public void RecuperarInformacion()
        {
            socio.sc_id = int.Parse(txtSocioID.Text);
            socio.sc_apaterno = txtApellidoPSocio.Text;
            socio.sc_amaterno = txtApellidoMSocio.Text;
            socio.sc_nombre_s = txtNombreSocio.Text;
            socio.sc_rfc = txtRfcSocio.Text;
            socio.sc_telefono = txtTelefonoPSocio.Text;
            socio.sc_telefono2 = txtTelefono2Socio.Text;
            socio.sc_telefono3 = txtTelefono3Socio.Text;
            socio.sc_email = txtCorreoSocio.Text;
            socio.sc_fecha_nacimiento = dpFechaNSocio.Value;
            socio.sc_fecha_ingreso = dpFechaISocio.Value;
            socio.sc_tipo_presona = cbTipoPSocio.Text;
            socio.sc_estatus = cbEstadoSocio.Text;

            //Direccion
            socio.sc_calle = txtCalleSocio.Text;
            socio.sc_num_ext = int.Parse(txtNoExtSocio.Text);
            socio.sc_num_int = txtNoIntSocio.Text;
            socio.sc_colonia = txtColoniaSocio.Text;
            socio.sc_cp = txtCpSocio.Text;
        }

        public void longitudTelefono()
        {
            if (txtTelefonoPSocio.TextLength != 10)
            {
                errorD = true;
                error2.SetError(txtTelefonoPSocio, "El numero de telefono requiere 10 digitos");
            }
            else
            {
                errorD = false;
                error2.SetError(txtTelefonoPSocio, "");
            }
        }
        private void cmdAgregar_Click(object sender, EventArgs e)
        {
            error = false;

            //ciclo para recorrer caracter por caracter 
            foreach (char caracter in txtNombreSocio.Text)
            {
                //si alguno de los caracteres es un numero el error es true
                if (!char.IsLetter(caracter) && !char.IsSeparator(caracter))
                {
                    error = true;
                    break;
                }
            }
      
            if (error)
            {
                error1.SetError(txtNombreSocio, "No se admiten números ni espacios en blanco\nIngrese letras solamente");
            }
            else
            {
                error1.SetError(txtNombreSocio, "");
            }
            longitudTelefono();
            if (error || errorD)
            {
                MessageBox.Show("Verifique que los datos sean validos");
            }
            else
            {
                if (!ValoresVaciosUsuario())
                {
                    RecuperarInformacion();
                    if (socioDAL.AgregarSocio(socio))
                    {
                        MessageBox.Show("El SOCIO " + socio.sc_id + " se AGREGO correctamente", "Socio Agregado");
                        Limpiar();
                    }
                    else
                    {
                        MessageBox.Show("NO se pudo ingresar la informacion del socio", "Error al ingresar socio");
                    }
                }
            }
        }

        private void cmdModificar_Click(object sender, EventArgs e)
        {
            if (!ValoresVaciosUsuario())
            {
                RecuperarInformacion();
                if (socioDAL.ModificarSocio(socio, idActual))
                {
                    MessageBox.Show("El SOCIO " + socio.sc_id + " se MODIFICO correctamente", "Socio Modificado");
                    //Limpiar();
                    //Close();
                }
                else
                {
                    MessageBox.Show("NO se pudo modificar la informacion del socio", "Error al modificar socio");
                }
            }
        }

        private void cbCiudad_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbCiudad.SelectedIndex > 0)
            {

                //Recuperar informacion de de la tabla CIUDAD
                DataTable tb = socioDAL.InformacionID($"Select ciudad_id, estado_id From CIUDAD WHERE ci_nombre = '{cbCiudad.Text}'");

                //Reccuperar el id del nombre de la ciudad
                socio.ciudad_id = int.Parse(tb.Rows[0]["ciudad_id"].ToString());//guardarlo

                //Recuperar informacion del ESTADO
                DataTable t = socioDAL.InformacionID($"Select est_nombre, pais_id From ESTADO WHERE estado_id = {tb.Rows[0]["estado_id"]}");
                txtEstado.Text = t.Rows[0]["est_nombre"].ToString();//impriir estado

                //Recuperar informacion del PAIS
                DataTable a = socioDAL.InformacionID($"Select pa_nombre From PAIS WHERE pais_id = {t.Rows[0]["pais_id"]}");
                txtPais.Text = a.Rows[0]["pa_nombre"].ToString();//impriir estado

            }
        }

        private void cmdCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cmdBorrar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("El Socio no puede ser eliminado, pero su estatus puede ser modificado a " +
                "'Inactivo' en Esatus del socio.");
        }


        //Metodo para validar que no haya espacios en blanco
        private void ValidarEspaciosSimbolos(TextBox txt, ErrorProvider er, CancelEventArgs c)
        {
            error = false;

            //ciclo para recorrer caracter por caracter 
            foreach (char caracter in txt.Text)
            {
                //si alguno de los caracteres es un numero el error es true
                if (char.IsSeparator(caracter))
                {
                    error = true;
                    break;
                }
            }
            if (error)
            {
                c.Cancel = true;
                txt.Select(0, txt.Text.Length);
                er.SetError(txt, "No se admiten espacios en blanco\nIngrese el formato correcto");
            }
        }

        //Metodo para validar que haya solamente numeros
        private void ValidarNumeros(TextBox txt, ErrorProvider er, CancelEventArgs c)
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
            }
        }

        //Metodo para validar que haya solamente letras
        private void ValidarLetras(TextBox txt, ErrorProvider er, CancelEventArgs c)
        {
            error = false;

            //ciclo para recorrer caracter por caracter 
            foreach (char caracter in txt.Text)
            {
                //si alguno de los caracteres es un numero el error es true
                if (!char.IsLetter(caracter))
                {
                    error = true;
                    break;
                }
            }
            if (error)
            {
                c.Cancel = true;
                txt.Select(0, txt.Text.Length);
                er.SetError(txt, "No se admiten números ni espacios en blanco\nIngrese letras solamente");
            }
        }

        //Metodo para validar que haya solamente letras o espacios
        private void ValidarLetrasEspacios(TextBox txt, ErrorProvider er, CancelEventArgs c)
        {
            error = false;
            int espacio = 0;
            //ciclo para recorrer caracter por caracter 
            foreach (char caracter in txt.Text)
            {
                //si alguno de los caracteres es un numero el error es true
                if (!char.IsLetter(caracter) && !char.IsSeparator(caracter))
                {
                    error = true;
                    break;
                }
                if(char.IsSeparator(caracter))
                {
                    espacio++;
                    if(espacio == txt.TextLength)
                    {
                        error = true;
                        break;
                    }
                }
            }
            if (error)
            {
                c.Cancel = true;
                txt.Select(0, txt.Text.Length);
                er.SetError(txt, "No se admiten números ni espacios en blanco\nIngrese letras solamente");
            }
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

        //Metodo para validar que haya numeros o letras con espacios
        private void ValidarLetrNumEsp(TextBox txt, ErrorProvider er, CancelEventArgs c)
        {
            error = false;
            int espacio = 0;
            //ciclo para recorrer caracter por caracter 
            foreach (char caracter in txt.Text)
            {
                //si alguno de los caracteres es un numero el error es true
                if (!char.IsLetter(caracter) && !char.IsDigit(caracter) && !char.IsSeparator(caracter))
                {
                    error = true;
                    break;
                }
                if (char.IsSeparator(caracter))
                {
                    espacio++;
                    if (espacio == txt.TextLength)
                    {
                        error = true;
                        break;
                    }
                }
            }
            if (error)
            {
                c.Cancel = true;
                txt.Select(0, txt.Text.Length);
                er.SetError(txt, "No se admiten espacios en blanco\nIngrese letras o números solamente");
            }
        }

        //va,idaciones de Socio ID
        private void txtSocioID_TextChanged(object sender, EventArgs e)
        {
            error = false;

            //ciclo para recorrer caracter por caracter 
            foreach (char caracter in txtSocioID.Text)
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
                error1.SetError(txtSocioID, "No se admiten letras ni espacios en blanco\nIngrese números solamente");
            }
            else
            {
                error1.SetError(txtSocioID, "");
            }
        }

        private void txtSocioID_Validated(object sender, EventArgs e)
        {
            error1.SetError(txtSocioID, "");
        }

        private void txtSocioID_Validating(object sender, CancelEventArgs e)
        {
            ValidarNumeros(txtSocioID, error1, e);
        }

        bool errorD = false;
        //Validaciones de Telefono Personal Socio
        private void txtTelefonoPSocio_TextChanged(object sender, EventArgs e)
        {
            error = false;
            //ciclo para recorrer caracter por caracter 
            foreach (char caracter in txtTelefonoPSocio.Text)
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
                error1.SetError(txtTelefonoPSocio, "No se admiten letras ni espacios en blanco\nIngrese números solamente");
            }
            else
            {
                error1.SetError(txtTelefonoPSocio, "");
            }
        }

        private void txtTelefonoPSocio_Validated(object sender, EventArgs e)
        {
            error1.SetError(txtTelefonoPSocio, "");
        }

        private void txtTelefonoPSocio_Validating(object sender, CancelEventArgs e)
        {
            ValidarNumeros(txtTelefonoPSocio, error1, e);
            if(txtTelefonoPSocio.TextLength != 10)
            {
                errorD = true;
                error2.SetError(txtTelefonoPSocio, "El numero de telefono requiere 10 digitos");
            }
            else
            {
                errorD = false;
                error2.SetError(txtTelefonoPSocio, "");
            }


        }

        //Validaciones de Telefono 2 Socio
        private void txtTelefono2Socio_TextChanged(object sender, EventArgs e)
        {
            error = false;

            //ciclo para recorrer caracter por caracter 
            foreach (char caracter in txtTelefono2Socio.Text)
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
                error1.SetError(txtTelefono2Socio, "No se admiten letras ni espacios en blanco\nIngrese números solamente");
            }
            else
            {
                error1.SetError(txtTelefono2Socio, "");
            }
        }

        private void txtTelefono2Socio_Validated(object sender, EventArgs e)
        {
            error1.SetError(txtTelefono2Socio, "");
        }

        private void txtTelefono2Socio_Validating(object sender, CancelEventArgs e)
        {
            ValidarNumeros(txtTelefono2Socio, error1, e);
        }

        //Validaciones de Telefono 3 Socio
        private void txtTelefono3Socio_TextChanged(object sender, EventArgs e)
        {
            error = false;

            //ciclo para recorrer caracter por caracter 
            foreach (char caracter in txtTelefono3Socio.Text)
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
                error1.SetError(txtTelefono3Socio, "No se admiten letras ni espacios en blanco\nIngrese números solamente");
            }
            else
            {
                error1.SetError(txtTelefono3Socio, "");
            }
        }

        private void txtTelefono3Socio_Validated(object sender, EventArgs e)
        {
            error1.SetError(txtTelefono3Socio, "");
        }

        private void txtTelefono3Socio_Validating(object sender, CancelEventArgs e)
        {
            ValidarNumeros(txtTelefono3Socio, error1, e);
        }

        //Validar Apellido Paterno de Socio
        private void txtApellidoPSocio_TextChanged(object sender, EventArgs e)
        {
            error = false;

            //ciclo para recorrer caracter por caracter 
            foreach (char caracter in txtApellidoPSocio.Text)
            {
                //si alguno de los caracteres es un numero el error es true
                if (!char.IsLetter(caracter))
                {
                    error = true;
                    break;
                }
            }
            if (error)
            {
                error1.SetError(txtApellidoPSocio, "No se admiten números ni espacios en blanco\nIngrese letras solamente");
            }
            else
            {
                error1.SetError(txtApellidoPSocio, "");
            }
        }

        private void txtApellidoPSocio_Validated(object sender, EventArgs e)
        {
            error1.SetError(txtApellidoPSocio, "");
        }

        private void txtApellidoPSocio_Validating(object sender, CancelEventArgs e)
        {
            ValidarLetras(txtApellidoPSocio, error1, e);
        }

        //Validar Apellido Materno de Socio
        private void txtApellidoMSocio_TextChanged(object sender, EventArgs e)
        {
            error = false;

            //ciclo para recorrer caracter por caracter 
            foreach (char caracter in txtApellidoMSocio.Text)
            {
                //si alguno de los caracteres es un numero el error es true
                if (!char.IsLetter(caracter))
                {
                    error = true;
                    break;
                }
            }
            if (error)
            {
                error1.SetError(txtApellidoMSocio, "No se admiten números ni espacios en blanco\nIngrese letras solamente");
            }
            else
            {
                error1.SetError(txtApellidoMSocio, "");
            }
        }

        private void txtApellidoMSocio_Validated(object sender, EventArgs e)
        {
            error1.SetError(txtApellidoMSocio, "");
        }

        private void txtApellidoMSocio_Validating(object sender, CancelEventArgs e)
        {
            ValidarLetras(txtApellidoMSocio, error1, e);
        }

        //validaciones de Nombre de Socio
        private void txtNombreSocio_TextChanged(object sender, EventArgs e)
        {
            int espacio = 0;
            error = false;

            //ciclo para recorrer caracter por caracter 
            foreach (char caracter in txtNombreSocio.Text)
            {
                //si alguno de los caracteres es un numero el error es true
                if (!char.IsLetter(caracter) && !char.IsSeparator(caracter))
                {
                    error = true;
                    break;
                }
                if (char.IsSeparator(caracter))
                {
                    espacio++;
                    if (espacio == txtNombreSocio.TextLength)
                    {
                        error = true;
                        break;
                    }
                }
            }
            if (error)
            {
                error1.SetError(txtNombreSocio, "No se admiten números ni espacios en blanco\nIngrese letras solamente");
            }
            else
            {
                error1.SetError(txtNombreSocio, "");
            }
        }

        private void txtNombreSocio_Validated(object sender, EventArgs e)
        {
            error1.SetError(txtNombreSocio, "");
        }

        private void txtNombreSocio_Validating(object sender, CancelEventArgs e)
        {
            ValidarLetrasEspacios(txtNombreSocio, error1, e);
        }

        //Validaciones de RFC de Socio
        private void txtRfcSocio_TextChanged(object sender, EventArgs e)
        {
            error = false;

            //ciclo para recorrer caracter por caracter 
            foreach (char caracter in txtRfcSocio.Text)
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
                error1.SetError(txtRfcSocio, "No se admiten espacios en blanco\nIngrese letras o números solamente");
            }
            else
            {
                error1.SetError(txtRfcSocio, "");
            }
        }

        private void txtRfcSocio_Validated(object sender, EventArgs e)
        {
            error1.SetError(txtRfcSocio, "");
        }

        private void txtRfcSocio_Validating(object sender, CancelEventArgs e)
        {
            ValidarLetrasNumeros(txtRfcSocio, error1, e);
        }

        //Validaciones de Numero Exterior de Socio
        private void txtNoExtSocio_TextChanged(object sender, EventArgs e)
        {
            error = false;

            //ciclo para recorrer caracter por caracter 
            foreach (char caracter in txtNoExtSocio.Text)
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
                error1.SetError(txtNoExtSocio, "No se admiten letras ni espacios en blanco\nIngrese números solamente");
            }
            else
            {
                error1.SetError(txtNoExtSocio, "");
            }
        }

        private void txtNoExtSocio_Validated(object sender, EventArgs e)
        {
            error1.SetError(txtNoExtSocio, "");
        }

        private void txtNoExtSocio_Validating(object sender, CancelEventArgs e)
        {
            ValidarNumeros(txtNoExtSocio, error1, e);
        }

        //validaciones de Numero Interior de Socio
        private void txtNoIntSocio_TextChanged(object sender, EventArgs e)
        {
            error = false;

            //ciclo para recorrer caracter por caracter 
            foreach (char caracter in txtNoIntSocio.Text)
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
                error1.SetError(txtNoIntSocio, "No se admiten letras ni espacios en blanco\nIngrese números solamente");
            }
            else
            {
                error1.SetError(txtNoIntSocio, "");
            }
        }

        private void txtNoIntSocio_Validated(object sender, EventArgs e)
        {
            error1.SetError(txtNoIntSocio, "");
        }

        private void txtNoIntSocio_Validating(object sender, CancelEventArgs e)
        {
            ValidarNumeros(txtNoIntSocio, error1, e);
        }

        //Validaciones de codigo postal socio
        private void txtCpSocio_TextChanged(object sender, EventArgs e)
        {
            error = false;

            //ciclo para recorrer caracter por caracter 
            foreach (char caracter in txtCpSocio.Text)
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
                error1.SetError(txtCpSocio, "No se admiten letras ni espacios en blanco\nIngrese números solamente");
            }
            else
            {
                error1.SetError(txtCpSocio, "");
            }
        }

        private void txtCpSocio_Validating(object sender, CancelEventArgs e)
        {
            ValidarNumeros(txtCpSocio, error1, e);
        }

        private void txtCpSocio_Validated(object sender, EventArgs e)
        {
            error1.SetError(txtCpSocio, "");
        }

        //Validaciones de calle de socio
        private void txtCalleSocio_TextChanged(object sender, EventArgs e)
        {
            error = false;
            int espacio = 0;
            //ciclo para recorrer caracter por caracter 
            foreach (char caracter in txtCalleSocio.Text)
            {
                //si alguno de los caracteres es un numero el error es true
                if (!char.IsLetter(caracter) && !char.IsDigit(caracter) && !char.IsSeparator(caracter))
                {
                    error = true;
                    break;
                }
                if (char.IsSeparator(caracter))
                {
                    espacio++;
                    if (espacio == txtCalleSocio.TextLength)
                    {
                        error = true;
                        break;
                    }
                }
            }
            if (error)
            {
                error1.SetError(txtCalleSocio, "No se admiten letras ni espacios en blanco\nIngrese números solamente");
            }
            else
            {
                error1.SetError(txtCalleSocio, "");
            }
        }

        private void txtCalleSocio_Validated(object sender, EventArgs e)
        {
            error1.SetError(txtCalleSocio, "");
        }

        private void txtCalleSocio_Validating(object sender, CancelEventArgs e)
        {
            ValidarLetrNumEsp(txtCalleSocio, error1, e);
        }

        //Validaciones de colonia de socio
        private void txtColoniaSocio_TextChanged(object sender, EventArgs e)
        {
            error = false;
            int espacio = 0;
            //ciclo para recorrer caracter por caracter 
            foreach (char caracter in txtColoniaSocio.Text)
            {
                //si alguno de los caracteres es un numero el error es true
                if (!char.IsLetter(caracter) && !char.IsDigit(caracter) && !char.IsSeparator(caracter))
                {
                    error = true;
                    break;
                }
                if (char.IsSeparator(caracter))
                {
                    espacio++;
                    if (espacio == txtColoniaSocio.TextLength)
                    {
                        error = true;
                        break;
                    }
                }
            }
            if (error)
            {
                error1.SetError(txtColoniaSocio, "No se admiten letras ni espacios en blanco\nIngrese números solamente");
            }
            else
            {
                error1.SetError(txtColoniaSocio, "");
            }
        }

        private void txtColoniaSocio_Validated(object sender, EventArgs e)
        {
            error1.SetError(txtColoniaSocio, "");
        }

        private void txtColoniaSocio_Validating(object sender, CancelEventArgs e)
        {
            ValidarLetrNumEsp(txtColoniaSocio, error1, e);
        }

        private void txtCorreoSocio_TextChanged(object sender, EventArgs e)
        {
            error = false;
            //ciclo para recorrer caracter por caracter 
            foreach (char caracter in txtCorreoSocio.Text)
            {
                //si alguno de los caracteres es un numero el error es true
                if (char.IsSeparator(caracter))
                {
                    error = true;
                    break;
                }
            }
            if (error)
            {
                error1.SetError(txtCorreoSocio, "No se admiten espacios en blanco\nIngrese el formato correcto solamente");
            }
            else
            {
                error1.SetError(txtCorreoSocio, "");
            }
        }

        private void txtCorreoSocio_Validated(object sender, EventArgs e)
        {
            error1.SetError(txtCorreoSocio, "");
        }

        private void txtCorreoSocio_Validating(object sender, CancelEventArgs e)
        {
            ValidarEspaciosSimbolos(txtCorreoSocio, error1, e);
        }
    }
}
