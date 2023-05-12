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
    public partial class frmEdit_Socios : Form
    {
        public frmEdit_Socios()
        {
            InitializeComponent();
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

        private void cmdAgregar_Click(object sender, EventArgs e)
        {
            if (!ValoresVaciosUsuario())
            {
                RecuperarInformacion();
                if (socioDAL.AgregarSocio(socio))
                {
                    MessageBox.Show("El SOCIO " + socio.sc_id + " se AGREGO correctamente", "Socio Agregado");

                }
                else
                {
                    MessageBox.Show("NO se pudo ingresar la informacion del socio", "Error al ingresar socio");
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

        
    }
}
