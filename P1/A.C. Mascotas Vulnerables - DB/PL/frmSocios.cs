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
    public partial class frmSocios : Form
    {
        public frmSocios()
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

        //Objetos de formas
        frmEdit_Socios edit_Socios = new frmEdit_Socios();
        SocioDAL socio = new SocioDAL();

        private void cmdAgregarUsuario_Click(object sender, EventArgs e)
        {
            edit_Socios.cbTipoPSocio.Items.Clear();
            edit_Socios.cbTipoPSocio.Items.Insert(0, "- SELECCIONE  -");
            edit_Socios.cbTipoPSocio.Items.Insert(1, "Fisica");
            edit_Socios.cbTipoPSocio.Items.Insert(2, "Moral");
            edit_Socios.cbTipoPSocio.SelectedIndex = 0;

            edit_Socios.cbEstadoSocio.Items.Clear();
            edit_Socios.cbEstadoSocio.Items.Insert(0, "- SELECCIONE  -");
            edit_Socios.cbEstadoSocio.Items.Insert(1, "Activo");
            edit_Socios.cbEstadoSocio.Items.Insert(2, "Inactivo");
            edit_Socios.cbEstadoSocio.SelectedIndex = 0;

            edit_Socios.lblTitle.Text = "AGREGAR NUEVO SOCIO";
            edit_Socios.ShowDialog();
            dgvSocios.DataSource = socio.MostratSocios().Tables[0];
        }

        private void cmdCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dgvSocios_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            edit_Socios.lblTitle.Text = "MODIFICAR SOCIO";

            //Llenar Combo Box
            edit_Socios.cbTipoPSocio.Items.Clear();
            edit_Socios.cbTipoPSocio.Items.Insert(0, "- SELECCIONE  -");
            edit_Socios.cbTipoPSocio.Items.Insert(1, "Fisica");
            edit_Socios.cbTipoPSocio.Items.Insert(2, "Moral");
            edit_Socios.cbTipoPSocio.SelectedIndex = 0;

            edit_Socios.cbEstadoSocio.Items.Clear();
            edit_Socios.cbEstadoSocio.Items.Insert(0, "- SELECCIONE  -");
            edit_Socios.cbEstadoSocio.Items.Insert(1, "Activo");
            edit_Socios.cbEstadoSocio.Items.Insert(2, "Inactivo");
            edit_Socios.cbEstadoSocio.SelectedIndex = 0;

            //OBTENER INFORMACION DEL PLATILLO -----------------------------------------------------------
            {
                int indice = e.RowIndex;

                //Obtener toda la informacion por medio de plato_id 
                DataTable tb = socio.InformacionID($"Select * from SOCIO WHERE socio_id = {dgvSocios.Rows[indice].Cells[0].Value}");
                //Mostrar ID
                edit_Socios.txtSocioID.Text = tb.Rows[0]["socio_id"].ToString();
                //Nombre 
                edit_Socios.txtApellidoPSocio.Text = tb.Rows[0]["sc_apaterno"].ToString();
                edit_Socios.txtApellidoMSocio.Text = tb.Rows[0]["sc_amaterno"].ToString();
                edit_Socios.txtNombreSocio.Text = tb.Rows[0]["sc_nombre_s"].ToString();

                //Datos personales
                edit_Socios.lblRfcSocio.Text = tb.Rows[0]["sc_rfc"].ToString();
                edit_Socios.txtTelefonoPSocio.Text = tb.Rows[0]["sc_telefono"].ToString();
                edit_Socios.txtTelefono2Socio.Text = tb.Rows[0]["sc_telefono2"].ToString();
                edit_Socios.txtTelefono3Socio.Text = tb.Rows[0]["sc_telefono3"].ToString();
                edit_Socios.txtCorreoSocio.Text = tb.Rows[0]["sc_email"].ToString();
                edit_Socios.dpFechaNSocio.Value = (DateTime)tb.Rows[0]["sc_fecha_nacimiento"];
                edit_Socios.dpFechaISocio.Value = (DateTime)tb.Rows[0]["sc_fecha_ingreso"];


                //direccion
                edit_Socios.txtCalleSocio.Text = tb.Rows[0]["sc_calle"].ToString();
                edit_Socios.txtNoExtSocio.Text = tb.Rows[0]["sc_num_ext"].ToString();
                edit_Socios.txtNoIntSocio.Text = tb.Rows[0]["sc_num_int"].ToString();
                edit_Socios.txtColoniaSocio.Text = tb.Rows[0]["sc_colonia"].ToString();
                edit_Socios.txtCpSocio.Text = tb.Rows[0]["sc_cp"].ToString();

                socio.LlenarCBCiudad(edit_Socios.cbCiudad);

                //Recuperar de tabla id de ciudad
                string idCiudad = tb.Rows[0]["ciudad_id"].ToString();
                bool bandera = false;
                int i = 0;
                //Info Ciudad
                {
                    DataTable t = socio.InformacionID($"Select ci_nombre, estado_id From CIUDAD WHERE ciudad_id = '{idCiudad}'");


                    //Imprimir ciudad
                   
                    while (bandera == false)
                    {
                        edit_Socios.cbCiudad.SelectedIndex = i;
                        if (edit_Socios.cbCiudad.SelectedItem.ToString() == t.Rows[0]["ci_nombre"].ToString())
                        {
                            bandera = true;
                        }
                        i++;
                    }

                    //Recuperar informacion del ESTADO
                    t = socio.InformacionID($"Select est_nombre, pais_id From ESTADO WHERE estado_id = {t.Rows[0]["estado_id"]}");
                    edit_Socios.txtEstado.Text = t.Rows[0]["est_nombre"].ToString();//impriir estado

                    //Recuperar informacion del PAIS
                    t = socio.InformacionID($"Select pa_nombre From PAIS WHERE pais_id = {t.Rows[0]["pais_id"]}");
                    edit_Socios.txtPais.Text = t.Rows[0]["pa_nombre"].ToString();//impriir estado
                }

                //Tipo de persona
                 bandera = false;
                 i = 0;
                while (bandera == false)
                {
                    edit_Socios.cbTipoPSocio.SelectedIndex = i;
                    if (edit_Socios.cbTipoPSocio.SelectedItem.ToString() == tb.Rows[0]["sc_tipo_presona"].ToString())
                    {
                        bandera = true;
                    }
                    i++;
                }

                //Estatus del Socio
                bandera = false;
                i = 0;
                while (bandera == false)
                {
                    edit_Socios.cbEstadoSocio.SelectedIndex = i;
                    if (edit_Socios.cbEstadoSocio.SelectedItem.ToString() == tb.Rows[0]["sc_estatus"].ToString())
                    {
                        bandera = true;
                    }
                    i++;
                }

                edit_Socios.ShowDialog();
                dgvSocios.DataSource = socio.MostratSocios().Tables[0];
            }
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

        private void cmdBuscar_Click(object sender, EventArgs e)
        {
            dgvSocios.DataSource = socio.Buscar(txtBuscar.Text).Tables[0];
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
