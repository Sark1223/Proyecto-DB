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
    public partial class frmUsuarios : Form
    {
        public frmUsuarios()
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

        frmEdit_Usuario eusuario = new frmEdit_Usuario();
        UsuarioDAL usuDAL = new UsuarioDAL();

        private void cmdAgregarUsuario_Click(object sender, EventArgs e)
        {
            eusuario.cbCargo.Items.Clear();
            eusuario.cbCargo.Items.Insert(0, "- SELECCIONE CARGO -");
            eusuario.cbCargo.Items.Insert(1, "Administrador");
            eusuario.cbCargo.Items.Insert(2, "Asistente administrativo");
            eusuario.cbCargo.SelectedIndex = 0;
            eusuario.lblTitle.Text = "AGREGAR USUARIO";
            eusuario.ShowDialog();
            dgvUsuarios.DataSource = usuDAL.MostrarUsuarios().Tables[0];
        }

        private void cmdCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Modificar(object sender, DataGridViewCellMouseEventArgs e)
        {
            /*CREATE TABLE USUARIO (
    usuario_id           tinyint NOT NULL,
    usu_apaterno         VARCHAR(30) NOT NULL,
    usu_amaterno         VARCHAR(30) NOT NULL,
    usu_nombre_s         VARCHAR(50) NOT NULL,
    usu_foto			 Image not null,
    usu_cargo            Varchar(24) not null,
    usu_contraseña       VARCHAR(15) NOT NULL,
    usu_rfc              VARCHAR(13) NOT NULL,
    usu_fecha_nacimiento DATE NOT NULL,
    usu_calle            VARCHAR(50) NOT NULL,
    usu_num_ext          VARCHAR(9) NOT NULL,
    usu_num_int          VARCHAR(8),
    usu_colonia          VARCHAR(100) NOT NULL,
    usu_cp               VARCHAR(6) NOT NULL,
	ciudad_id            INTEGER NOT NULL,
    usu_telefono         NUMERiC(10,0) NOT NULL,
    usu_email            VARCHAR(130) not null,
    usu_fecha_ingreso    DATE NOT NULL*/
            //AGREGAR USUARIO
            //Modificar encabezado
            eusuario.lblTitle.Text = "MODIFICAR USUARIO";

            //OBTENER INFORMACION DEL USUARIO -----------------------------------------------------------
            {
                int indice = e.RowIndex;

                //Obtener toda la informacion por medio de usuario_id 
                DataTable tb = usuDAL.InformacionID($"Select * from USUARIO WHERE usuario_id = {dgvUsuarios.Rows[indice].Cells[0].Value}");
                //Mostrar ID
                eusuario.txtID.Text = tb.Rows[0]["usuario_id"].ToString();
                //Nombre 
                eusuario.txtApaterno.Text = tb.Rows[0]["usu_apaterno"].ToString();
                eusuario.txtAmaterno.Text = tb.Rows[0]["usu_amaterno"].ToString();
                eusuario.txtNombre.Text = tb.Rows[0]["usu_nombre_s"].ToString();

                //Obtener el arreglo de Bytes 
                byte[] img = (byte[])tb.Rows[0]["usu_foto"];
                //Convertir el arreglo a imagen
                System.IO.MemoryStream ms = new System.IO.MemoryStream(img);
                eusuario.lblAgregarFoto.Visible = false;
                eusuario.pbFoto.SizeMode = PictureBoxSizeMode.Zoom;
                eusuario.pbFoto.Image = Image.FromStream(ms);

                //Dificultad
                bool bandera = false;
                int i = 0;
                eusuario.cbCargo.Items.Clear();
                eusuario.cbCargo.Items.Insert(0, "- SELECCIONE CARGO -");
                eusuario.cbCargo.Items.Insert(1, "Administrador");
                eusuario.cbCargo.Items.Insert(2, "Asistente administrativo");

                while (bandera == false)
                {
                    eusuario.cbCargo.SelectedIndex = i;
                    if (eusuario.cbCargo.SelectedItem.ToString().ToLower() == tb.Rows[0]["usu_cargo"].ToString().ToLower())
                    {
                        bandera = true;
                    }
                    i++;
                }

                eusuario.txtContraseña.Text = tb.Rows[0]["usu_contraseña"].ToString();
                eusuario.txtrfc.Text = tb.Rows[0]["usu_rfc"].ToString();
                eusuario.dtNacimiento.Value = (DateTime)tb.Rows[0]["usu_fecha_nacimiento"];
                

                eusuario.txtCalle.Text = tb.Rows[0]["usu_calle"].ToString();
                eusuario.txtExterior.Text = tb.Rows[0]["usu_num_ext"].ToString();
                eusuario.txtInterior.Text = tb.Rows[0]["usu_num_int"].ToString();
                eusuario.txtColonia.Text = tb.Rows[0]["usu_colonia"].ToString();
                eusuario.txtcp.Text = tb.Rows[0]["usu_cp"].ToString();

                usuDAL.LlenarCBCiudad(eusuario.cbCiudad);
                //Recuperar de tabla id de ciudad
                string idCiudad = tb.Rows[0]["ciudad_id"].ToString();
                //Info Ciudad
                {
                    DataTable t = usuDAL.InformacionID($"Select ci_nombre, estado_id From CIUDAD WHERE ciudad_id = '{idCiudad}'");


                    //Imprimir ciudad
                    bandera = false;
                    i = 0;
                    while (bandera == false)
                    {
                        eusuario.cbCiudad.SelectedIndex = i;
                        if (eusuario.cbCiudad.SelectedItem.ToString() == t.Rows[0]["ci_nombre"].ToString())
                        {
                            bandera = true;
                        }
                        i++;
                    }

                    //Recuperar informacion del ESTADO
                    t = usuDAL.InformacionID($"Select est_nombre, pais_id From ESTADO WHERE estado_id = {t.Rows[0]["estado_id"]}");
                    eusuario.txtEstado.Text = t.Rows[0]["est_nombre"].ToString();//impriir estado

                    //Recuperar informacion del PAIS
                    t = usuDAL.InformacionID($"Select pa_nombre From PAIS WHERE pais_id = {t.Rows[0]["pais_id"]}");
                    eusuario.txtPais.Text = t.Rows[0]["pa_nombre"].ToString();//impriir estado
                }

                eusuario.txttelefono.Text = tb.Rows[0]["usu_telefono"].ToString();
                eusuario.txtCorreo.Text = tb.Rows[0]["usu_email"].ToString();
                eusuario.dtIngreso.Value = (DateTime)tb.Rows[0]["usu_fecha_ingreso"];

                eusuario.ShowDialog();
                dgvUsuarios.DataSource = usuDAL.MostrarUsuarios().Tables[0];
            }
        }

        private void cmdBuscar_Click(object sender, EventArgs e)
        {
            dgvUsuarios.DataSource = usuDAL.Buscar(txtBuscar.Text).Tables[0];
        }
        bool error = false;

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
    }
}
