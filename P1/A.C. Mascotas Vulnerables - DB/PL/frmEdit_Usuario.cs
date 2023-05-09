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
                mu.LlenarCBCiudad(cbCiudad);
            }
            else
            {
                idActual = txtID.Text;
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
            if (!ValoresVaciosUsuario())
            {
                RecuperarInformacion();
                if (mu.AgregarUsuario(usuario))
                {
                    MessageBox.Show("El USUARIO " + usuario.usu_id + " se AGREGO correctamente", "Usuario Agregado");

                }
                else
                {
                    MessageBox.Show("NO se pudo ingresar la informacion del usuario", "Error al ingresar usuario");
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
                txtEstado.Text = a.Rows[0]["pa_nombre"].ToString();//impriir estado

            }
        }

        private void cmdModificar_Click(object sender, EventArgs e)
        {
            if (!ValoresVaciosUsuario())
            {
                RecuperarInformacion();
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
    }
}
