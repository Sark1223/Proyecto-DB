using A.C.Mascotas_Vulnerables___DB.DAL;
using A.C.Mascotas_Vulnerables___DB.PL;
using BunifuAnimatorNS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A.C.Mascotas_Vulnerables___DB
{
    public partial class InicioSesion : Form
    {
        public InicioSesion()
        {
            InitializeComponent();
        }

        //Objetos de clase
        frmMenu_Principal menu = new frmMenu_Principal();
        InicioSesionDaL inicioDAL = new InicioSesionDaL();
        frmNuevaAportacion nuevaAportacion = new frmNuevaAportacion();
        frmAportacion aportacion = new frmAportacion();

        private void InicioSesion_Load(object sender, EventArgs e)
        {
            lblBienvenido.Parent = pbInicio;
            lblBienvenido.BackColor = Color.Transparent;
        }

        private void cmdCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cmdIniciar_Click(object sender, EventArgs e)
        {
            //bool usuario = ;
            //bool contraseña = inicioDAL.BuscarUsuario(txtUsuario.Text, txtUsuario, error);
            //, txtId_platillo.Text, 0, txtId_platillo, error

            if (inicioDAL.BuscarUsuario(txtUsuario.Text, txtUsuario, error)/*usuario && contraseña*/)
            {
                DataTable tb = inicioDAL.InformacionID($"Select usu_apaterno, usu_amaterno, usu_nombre_s, usu_foto, usu_cargo, usu_contraseña From USUARIO WHERE usuario_id = {txtUsuario.Text}");

                string contraseña = tb.Rows[0]["usu_contraseña"].ToString();

                if (contraseña == txtContraseña.Text)
                {
                    error.SetError(txtContraseña, "");
                    menu.txtPuesto.Text = tb.Rows[0]["usu_cargo"].ToString();
                    menu.txtUsuario.Text = txtUsuario.Text + " " + tb.Rows[0]["usu_apaterno"].ToString();
                    
                    nuevaAportacion.txtEncargado1.Text = tb.Rows[0]["usu_apaterno"].ToString() + " " + tb.Rows[0]["usu_amaterno"].ToString() + " " + tb.Rows[0]["usu_nombre_s"].ToString();

                    //aportacion.ObtenerObjetoNuevaAportacion(nuevaAportacion);
                    
                    menu.ObtenerObjetoAportacion(aportacion, nuevaAportacion);
                    
                    //Obtener el arreglo de Bytes 
                    byte[] img = (byte[])tb.Rows[0]["usu_foto"];
                    //Convertir el arreglo a imagen
                    System.IO.MemoryStream ms = new System.IO.MemoryStream(img);
                    menu.pbUsuario.Image = Image.FromStream(ms);

                    this.Hide();
                    menu.ShowDialog();
                    this.Show();
                }
                else
                {
                    error.SetError(txtContraseña, "La contraseña no coinside con el usuario.");
                }
               
            }
            //else
            //{

            //}

        }
    }
}
