using A.C.Mascotas_Vulnerables___DB.BLL;
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

        frmSocios frmSocios = new frmSocios();
        frmEdit_Socios edit_Socios = new frmEdit_Socios();
        frmUsuarios frmUsuarios = new frmUsuarios();
        frmEdit_Usuario edit_Usuario = new frmEdit_Usuario();
        frmPeriodo edit_Periodo = new frmPeriodo();
        frmLugar lugar = new frmLugar();
        frmEstadoRecibo estadoRecibo = new frmEstadoRecibo();

        HistorialDAL historialDAL = new HistorialDAL();
        HistorialBLL historial = new HistorialBLL();

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
                DataTable tb = inicioDAL.InformacionID($"Select usuario_id,usu_apaterno, usu_amaterno, usu_nombre_s, usu_foto, usu_cargo, usu_contraseña From USUARIO WHERE usuario_id = {txtUsuario.Text}");

                string contraseña = tb.Rows[0]["usu_contraseña"].ToString();

                if (contraseña == txtContraseña.Text)
                {
                    error.SetError(txtContraseña, "");
                    string cargo = tb.Rows[0]["usu_cargo"].ToString();
                    menu.txtPuesto.Text = cargo;
                    menu.txtUsuario.Text = txtUsuario.Text + " " + tb.Rows[0]["usu_apaterno"].ToString();
                    
                    if (cargo == "Administrador")
                    {
                        nuevaAportacion.cmdAgregarEstatus.Tag = "si";
                    }
                    else
                    {
                        nuevaAportacion.cmdAgregarEstatus.Tag = "no";
                    }

                    nuevaAportacion.txtEncargado1.Text = txtUsuario.Text +" "+ tb.Rows[0]["usu_apaterno"].ToString() + " " + tb.Rows[0]["usu_amaterno"].ToString() + " " + tb.Rows[0]["usu_nombre_s"].ToString();

                    nuevaAportacion.idSocio = txtUsuario.Text; 
                    edit_Socios.usuario_id = int.Parse(txtUsuario.Text);
                    edit_Usuario.usuario_id = int.Parse(txtUsuario.Text);
                    edit_Periodo.usuario_id = int.Parse(txtUsuario.Text);
                    lugar.usuario_id = int.Parse(txtUsuario.Text);
                    estadoRecibo.usuario_id= int.Parse(txtUsuario.Text);
                    //aportacion.ObtenerObjetoNuevaAportacion(nuevaAportacion);

                    menu.ObtenerObjetoAportacion(aportacion, nuevaAportacion,lugar,edit_Periodo,edit_Socios,edit_Usuario,estadoRecibo);
                    
                    //Obtener el arreglo de Bytes 
                    byte[] img = (byte[])tb.Rows[0]["usu_foto"];
                    //Convertir el arreglo a imagen
                    System.IO.MemoryStream ms = new System.IO.MemoryStream(img);
                    menu.pbUsuario.Image = Image.FromStream(ms);

                    /*/*CREATE TABLE HISTORIAL (
    historia_num          INTEGER NOT NULL,
    usuario_id            tinyint NOT NULL,
    cambio				  VARCHAR(100) not null,
    fecha                 DATE NOT NULL,
	hora				  Time not null
);*/
                    int num = 1 + historialDAL.RetornarUltimaModificacion();
                    historial.historia_num = num;
                    historial.usuario_id = int.Parse(txtUsuario.Text);
                    historial.cambio = "Inicio de sesion";

                    DateTime date = DateTime.Today;
                    DateTime time = DateTime.Now;

                    historial.fecha = date;
                    historial.hora = time;

                    historialDAL.AgregarModificacion(historial);

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
