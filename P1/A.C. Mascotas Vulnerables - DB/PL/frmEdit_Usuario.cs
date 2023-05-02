using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.Layout;
using A.C.Mascotas_Vulnerables___DB.BLL;
using A.C.Mascotas_Vulnerables___DB.DAL;
using Image = System.Drawing.Image;

namespace A.C.Mascotas_Vulnerables___DB.PL
{
    public partial class frmEdit_Usuario : Form
    {
        public frmEdit_Usuario()
        {
            InitializeComponent();
        }

        UsuarioBLL usuario = new UsuarioBLL();
        UsuarioDAL mu = new UsuarioDAL();

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


        private void pbFoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog selectorImagen = new OpenFileDialog();
            selectorImagen.Title = "Seleccionar imagen";

            if (selectorImagen.ShowDialog() == DialogResult.OK)
            {
                pbFoto.SizeMode = PictureBoxSizeMode.StretchImage;
                pbFoto.Image = Image.FromStream(selectorImagen.OpenFile());

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
            usuario.usu_municipio = txtMunicipio.Text;
            usuario.usu_Estado = txtEstado.Text;
            usuario.usu_Pais = txtPais.Text;
            
        }
        
        private void cmdAgregar_Click(object sender, EventArgs e)
        {
            RecuperarInformacion();
            if (mu.AgregarUsuario(usuario))
            {
                MessageBox.Show("El USUARIO " + usuario.usu_id + "se AGREGO correctamente", "Usuario Agregado");

            }
            else
            {
                MessageBox.Show("NO se pudo ingresar la informacion del usuario", "Error al ingresar usuario");
            }
        }
    }
}
