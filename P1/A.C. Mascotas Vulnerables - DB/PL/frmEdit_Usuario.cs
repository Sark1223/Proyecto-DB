using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.Layout;
using A.C.Mascotas_Vulnerables___DB.BLL;
using A.C.Mascotas_Vulnerables___DB.DAL;
using static System.Net.Mime.MediaTypeNames;
using Image = System.Drawing.Image;

namespace A.C.Mascotas_Vulnerables___DB.PL
{
    public partial class frmEdit_Usuario : Form
    {
        public frmEdit_Usuario()
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

        UsuarioBLL usuario = new UsuarioBLL();
        UsuarioDAL mu = new UsuarioDAL();

        //Variables auxiliares 
        string idActual = "";

        private void frmEdit_Usuario_Load(object sender, EventArgs e)
        {
            if(lblTitle.Text == "AGREGAR USUARIO")
            {
                
                cmdAgregar.Visible = true;
                pnModificar.Visible = false;
                mu.LlenarCBCiudad(cbCiudad);
                Limpiar();

                foto = false;
            }
            else
            {
                cmdAgregar.Visible = false;
                pnModificar.Visible = true;
                idActual = txtID.Text;
                foto = true;
            }
            
            //if (lblTitle.Text == "AGREGAR PLATILLO")
            //{
            //    editar_plato.LlenarCBCategoria(cbCategoria);

            //    cmdAgregarIngrediente.Enabled = false;
            //    cmdAgregarPaso.Enabled = false;

            //    //Habilitar paneles de añadir
            //    //pnAñadirIngre.Visible = true;
            //    pnAñadirPaso.Visible = true;
            //    pnAgregar.Visible = true;

            //    //Inabilitar paneles modificar
            //    pnModificar.Visible = false;
            //    pnModifiIngre.Visible = false;
            //    pnModifiPaso.Visible = false;
            //    imagen = false;
            //}
            //else
            //{
            //    cmdAgregarIngrediente.Enabled = true;
            //    cmdAgregarPaso.Enabled = true;
            //    //Inabilitar paneles de añadir
            //    //pnAñadirIngre.Visible = false;
            //    //pnAñadirPaso.Visible = false;
            //    pnAgregar.Visible = false;

            //    //Mostrar paneles modificar
            //    pnModificar.Visible = true;
            //    pnModifiIngre.Visible = true;
            //    pnModifiPaso.Visible = true;

            //    imagen = true;

            //    if (txtId_platillo.Text != "")
            //    {
            //        ID_Actual = txtId_platillo.Text;
            //    }

            //    if (txtNombre.Text != "")
            //    {
            //        nombre = txtNombre.Text;
            //    }
            //}
            //primeraApertura = false;
        }

        private void cmdCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Limpiar()
        {
            txtID.Clear(); txtApaterno.Clear(); txtAmaterno.Clear(); txtNombre.Clear();
            txtContraseña.Clear(); txtrfc.Clear(); txttelefono.Clear(); txtCorreo.Clear();
            txtCalle.Clear(); txtExterior.Clear(); txtInterior.Clear();
            txtColonia.Clear(); txtPais.Clear(); txtEstado.Clear(); txtcp.Clear(); cbCiudad.SelectedIndex = 0;
            cbCargo.SelectedIndex = 0;
            pbFoto.Image = Properties.Resources.estilo_grafico;
            lblAgregarFoto.Visible = true;
            foto = false;
        }

        public void GuardarImagen()
        {
            MemoryStream memoria = new MemoryStream();
            pbFoto.Image.Save(memoria, System.Drawing.Imaging.ImageFormat.Png);

            usuario.usu_foto = memoria.GetBuffer();
        }

        //
        bool foto = false;
        private void pbFoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog selectorImagen = new OpenFileDialog();
            selectorImagen.Title = "Seleccionar imagen";

            if (selectorImagen.ShowDialog() == DialogResult.OK)
            {
                pbFoto.SizeMode = PictureBoxSizeMode.StretchImage;
                pbFoto.Image = Image.FromStream(selectorImagen.OpenFile());
                lblAgregarFoto.Visible = false;
                foto = true;
            }
        }

        private void RecuperarInformacion()
        {
            usuario.usu_id = int.Parse(txtID.Text);
            usuario.usu_apaterno = txtApaterno.Text;
            usuario.usu_amaterno = txtAmaterno.Text;
            usuario.usu_nombres = txtNombre.Text;
            GuardarImagen();
            usuario.usu_cargo = cbCargo.Text;
            usuario.usu_contraseña = txtContraseña.Text;
            usuario.usu_rfc = txtrfc.Text;
            usuario.usu_fechana_nacimiento = dtNacimiento.Value;
            usuario.usu_Telefono = long.Parse(txttelefono.Text);
            usuario.usu_eMail = txtCorreo.Text;
            usuario.usu_Fecha_ingreso = dtIngreso.Value;

            //Direccion
            usuario.usu_calle = txtCalle.Text;
            usuario.usu_noExte = int.Parse(txtExterior.Text);
            usuario.usu_noInte = txtInterior.Text;
            usuario.usu_colonia = txtColonia.Text;
            usuario.usu_CP = txtcp.Text;
        }

        //VALIDACION DE VALORES INGRESADOS POR EL USUARIO
        public bool ValoresVaciosUsuario()
        {
            string valoresVacios = "";
            int no_vacios = 0;
            //VERIFICACION DE VALORES VACIOS
            {
                //Informacion personal
                if (txtID.Text == "")
                {
                    valoresVacios += "Usuario id, ";
                    no_vacios++;
                }
                if (txtContraseña.Text == "")
                {
                    valoresVacios += "Contraseña, ";
                    no_vacios++;
                }
                if (txtNombre.Text == "")
                {
                    valoresVacios += "Nombre, ";
                    no_vacios++;
                }
                if (txtApaterno.Text == "")
                {
                    valoresVacios += "Apellido paterno, ";
                    no_vacios++;
                }
                if (txtAmaterno.Text == "")
                {
                    valoresVacios += "Apellido materno,";
                    no_vacios++;
                }
                if (txtrfc.Text == "")
                {
                    valoresVacios += "RFC, ";
                    no_vacios++;
                }
                if (foto == false)
                {
                    valoresVacios += "Imagen";
                    no_vacios++;
                }
                if (cbCargo.Text == "- SELECCIONE CARGO -")
                {
                    valoresVacios += "Cargo, ";
                    no_vacios++;
                }
                if (txtCorreo.Text == "")
                {
                    valoresVacios += "Correo,";
                    no_vacios++;
                }
                if (txttelefono.Text == "")
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
                if (txtCalle.Text == "")
                {
                    valoresVacios += "Calle, ";
                    no_vacios++;
                }
                if (txtExterior.Text == "")
                {
                    valoresVacios += "No. exterior,";
                    no_vacios++;
                }
                if (txtcp.Text == "")
                {
                    valoresVacios += "CP, ";
                    no_vacios++;
                }
                if (txtColonia.Text == "")
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

        private void cmdAgregar_Click(object sender, EventArgs e)
        {
            error = false;

            //ciclo para recorrer caracter por caracter 
            foreach (char caracter in txtNombre.Text)
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
                error1.SetError(txtNombre, "No se admiten números ni espacios en blanco\nIngrese letras solamente");
            }
            else
            {
                error1.SetError(txtNombre, "");
            }
            if (error)
            {
                MessageBox.Show("Verifique que los datos sean validos");
            }
            else
            {
                if (!ValoresVaciosUsuario())
                {
                    RecuperarInformacion();
                    usuario.usu_estatus = "Activo";//Al agregar un usuario significa que esta activo
                    if (mu.AgregarUsuario(usuario))
                    {
                        MessageBox.Show("El USUARIO " + usuario.usu_id + " se AGREGO correctamente", "Usuario Agregado");

                        Limpiar();
                    }
                    else
                    {
                        MessageBox.Show("NO se pudo ingresar la informacion del usuario", "Error al ingresar usuario");
                    }
                }
            }
            
        }

        private void cbCiudad_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbCiudad.SelectedIndex > 0)
            {

                //Recuperar informacion de de la tabla CIUDAD
                DataTable tb = mu.InformacionID($"Select ciudad_id, estado_id From CIUDAD WHERE ci_nombre = '{cbCiudad.Text}'");

                //Reccuperar el id del nombre de la ciudad
                usuario.ciudad_id = int.Parse(tb.Rows[0]["ciudad_id"].ToString());//guardarlo

                //Recuperar informacion del ESTADO
                DataTable t = mu.InformacionID($"Select est_nombre, pais_id From ESTADO WHERE estado_id = {tb.Rows[0]["estado_id"]}");
                txtEstado.Text = t.Rows[0]["est_nombre"].ToString();//impriir estado

                //Recuperar informacion del PAIS
                DataTable a = mu.InformacionID($"Select pa_nombre From PAIS WHERE pais_id = {t.Rows[0]["pais_id"]}");
                txtPais.Text = a.Rows[0]["pa_nombre"].ToString();//impriir estado

            }
        }

        private void cmdModificar_Click(object sender, EventArgs e)
        {
            if (!ValoresVaciosUsuario())
            {
                RecuperarInformacion();
                usuario.usu_estatus = "Activo";
                if (mu.ModificarUsuario(usuario,idActual))
                {
                    MessageBox.Show("El USUARIO " + usuario.usu_id + " se MODIFICO correctamente", "Usuario Modificado");

                }
                else
                {
                    MessageBox.Show("NO se pudo Modificar la informacion del usuario", "Error al Modificar usuario");
                }
            }
        }

        private void pbBorrar_Click(object sender, EventArgs e)
        {
            string Mesaje = $"Esta seguro de que quiere eliminar al Usuario {idActual}?";
            if(MessageBox.Show(Mesaje, "ATENCIÓN",MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                mu.EliminarUsuario(idActual);
                MessageBox.Show("El Usuario ha sido eliminado, sin embargo, los recibos creados por el mismo, " +
                    "seguiran guardados en la base de datos.");
                Close();
            }
            
        }

        bool error = false;

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

        //Validacion de telefono
        private void txttelefono_TextChanged(object sender, EventArgs e)
        {
            error = false;

            //ciclo para recorrer caracter por caracter 
            foreach (char caracter in txttelefono.Text)
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
                error1.SetError(txttelefono, "No se admiten letras ni espacios en blanco\nIngrese números solamente");
            }
            else
            {
                error1.SetError(txttelefono, "");
            }
        }

        private void txttelefono_Validated(object sender, EventArgs e)
        {
            error1.SetError(txttelefono, "");
        }

        private void txttelefono_Validating(object sender, CancelEventArgs e)
        {
            ValidarNumeros(txttelefono, error1, e);
        }

        //validacion de numero exterior
        private void txtExterior_TextChanged(object sender, EventArgs e)
        {
            error = false;

            //ciclo para recorrer caracter por caracter 
            foreach (char caracter in txtExterior.Text)
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
                error1.SetError(txtExterior, "No se admiten letras ni espacios en blanco\nIngrese números solamente");
            }
            else
            {
                error1.SetError(txtExterior, "");
            }
        }

        private void txtExterior_Validated(object sender, EventArgs e)
        {
            error1.SetError(txtExterior, "");
        }

        private void txtExterior_Validating(object sender, CancelEventArgs e)
        {
            ValidarNumeros(txtExterior, error1, e);
        }

        //Validacion de numero interior
        private void txtInterior_TextChanged(object sender, EventArgs e)
        {
            error = false;

            //ciclo para recorrer caracter por caracter 
            foreach (char caracter in txtInterior.Text)
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
                error1.SetError(txtInterior, "No se admiten letras ni espacios en blanco\nIngrese números solamente");
            }
            else
            {
                error1.SetError(txtInterior, "");
            }
        }

        private void txtInterior_Validated(object sender, EventArgs e)
        {
            error1.SetError(txtInterior, "");
        }

        private void txtInterior_Validating(object sender, CancelEventArgs e)
        {
            ValidarNumeros(txtInterior, error1, e);
        }

        //Validacion de codigo postal
        private void txtcp_TextChanged(object sender, EventArgs e)
        {
            error = false;

            //ciclo para recorrer caracter por caracter 
            foreach (char caracter in txtcp.Text)
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
                error1.SetError(txtcp, "No se admiten letras ni espacios en blanco\nIngrese números solamente");
            }
            else
            {
                error1.SetError(txtcp, "");
            }
        }

        private void txtcp_Validated(object sender, EventArgs e)
        {
            error1.SetError(txtcp, "");
        }

        private void txtcp_Validating(object sender, CancelEventArgs e)
        {
            ValidarNumeros(txtcp, error1, e);
        }

        //Validacion de nombre
        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            int espacio = 0;
            error = false;

            //ciclo para recorrer caracter por caracter 
            foreach (char caracter in txtNombre.Text)
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
                    if (espacio == txtNombre.TextLength)
                    {
                        error = true;
                        break;
                    }
                }
            }
            if (error)
            {
                error1.SetError(txtNombre, "No se admiten números ni espacios en blanco\nIngrese letras solamente");
            }
            else
            {
                error1.SetError(txtNombre, "");
            }
        }

        private void txtNombre_Validated(object sender, EventArgs e)
        {
            error1.SetError(txtNombre, "");
        }

        private void txtNombre_Validating(object sender, CancelEventArgs e)
        {
            ValidarLetrasEspacios(txtNombre, error1, e);
        }

        //Validacion de rfc
        private void txtrfc_TextChanged(object sender, EventArgs e)
        {
            error = false;

            //ciclo para recorrer caracter por caracter 
            foreach (char caracter in txtrfc.Text)
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
                error1.SetError(txtrfc, "No se admiten espacios en blanco\nIngrese letras o números solamente");
            }
            else
            {
                error1.SetError(txtrfc, "");
            }
        }

        private void txtrfc_Validated(object sender, EventArgs e)
        {
            error1.SetError(txtrfc, "");
        }

        private void txtrfc_Validating(object sender, CancelEventArgs e)
        {
            ValidarLetrasNumeros(txtrfc, error1, e);
        }

        //Validacion de calle
        private void txtCalle_TextChanged(object sender, EventArgs e)
        {
            error = false;
            int espacio = 0;
            //ciclo para recorrer caracter por caracter 
            foreach (char caracter in txtCalle.Text)
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
                    if (espacio == txtCalle.TextLength)
                    {
                        error = true;
                        break;
                    }
                }
            }
            if (error)
            {
                error1.SetError(txtCalle, "No se admiten letras ni espacios en blanco\nIngrese números solamente");
            }
            else
            {
                error1.SetError(txtCalle, "");
            }
        }

        private void txtCalle_Validated(object sender, EventArgs e)
        {
            error1.SetError(txtCalle, "");
        }

        private void txtCalle_Validating(object sender, CancelEventArgs e)
        {
            ValidarLetrNumEsp(txtCalle, error1, e);
        }

        //Validacion de colonia
        private void txtColonia_TextChanged(object sender, EventArgs e)
        {
            error = false;
            int espacio = 0;
            //ciclo para recorrer caracter por caracter 
            foreach (char caracter in txtColonia.Text)
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
                    if (espacio == txtColonia.TextLength)
                    {
                        error = true;
                        break;
                    }
                }
            }
            if (error)
            {
                error1.SetError(txtColonia, "No se admiten letras ni espacios en blanco\nIngrese números solamente");
            }
            else
            {
                error1.SetError(txtColonia, "");
            }
        }

        private void txtColonia_Validated(object sender, EventArgs e)
        {
            error1.SetError(txtColonia, "");
        }

        private void txtColonia_Validating(object sender, CancelEventArgs e)
        {
            ValidarLetrNumEsp(txtColonia, error1, e);
        }

        //Validacion de apellido paterno
        private void txtApaterno_TextChanged(object sender, EventArgs e)
        {
            error = false;

            //ciclo para recorrer caracter por caracter 
            foreach (char caracter in txtApaterno.Text)
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
                error1.SetError(txtApaterno, "No se admiten números ni espacios en blanco\nIngrese letras solamente");
            }
            else
            {
                error1.SetError(txtApaterno, "");
            }
        }

        private void txtApaterno_Validated(object sender, EventArgs e)
        {
            error1.SetError(txtApaterno, "");
        }

        private void txtApaterno_Validating(object sender, CancelEventArgs e)
        {
            ValidarLetras(txtApaterno, error1, e);
        }

        //Validacion de apellido materno
        private void txtAmaterno_TextChanged(object sender, EventArgs e)
        {
            error = false;

            //ciclo para recorrer caracter por caracter 
            foreach (char caracter in txtAmaterno.Text)
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
                error1.SetError(txtAmaterno, "No se admiten números ni espacios en blanco\nIngrese letras solamente");
            }
            else
            {
                error1.SetError(txtAmaterno, "");
            }
        }

        private void txtAmaterno_Validated(object sender, EventArgs e)
        {
            error1.SetError(txtAmaterno, "");
        }

        private void txtAmaterno_Validating(object sender, CancelEventArgs e)
        {
            ValidarLetras(txtAmaterno, error1, e);
        }
    }
}
