using A.C.Mascotas_Vulnerables___DB.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A.C.Mascotas_Vulnerables___DB.PL
{
    public partial class frmLugar : Form
    {
        public frmLugar()
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

        private void frmLugar_Load(object sender, EventArgs e)
        {
            lugar.LlenarCBPais(cbPais);
            lugar.LlenarCBEstado(cbEstado);
            dgvCiudad.DataSource = lugar.MostrarCiudad().Tables[0];
            dgvEstado.DataSource = lugar.MostrarEstados().Tables[0];
            dgvPais.DataSource = lugar.MostrarPaises().Tables[0];

            LimpiarPais();
            LimpiarEstado();
            LimpiarCiudad();

            modifiCiudad = false; modifiEstado = false;  modifiPais = false;
        }

        //Objetos de forma
        PaisBLL pais = new PaisBLL();
        EstadoBLL estado = new EstadoBLL();
        CiudadBLL ciudad = new CiudadBLL();

        //Objetos de Clases
        LugarDAL lugar = new LugarDAL();

        //Variables auxiliares 
        bool modifiCiudad, modifiEstado, modifiPais;
        string idActPais,  idActEstado, idActCiudad;

        //METODOS DE PAIS ------------------------------------------------------------
        private void RecuperarInformacionPais()
        {
            pais.pais_id = int.Parse(txtPaisID.Text);
            pais.pa_nombre = txtNombrePais.Text;
        }

        public void LimpiarPais()
        {
            txtPaisID.Clear();
            txtNombrePais.Clear();
        }

        private void btnAgregarPais_Click(object sender, EventArgs e)
        {
            RecuperarInformacionPais();
            if (lugar.AgregarPais(pais))
            {
                MessageBox.Show("El PAIS " + pais.pais_id + " se AGREGO correctamente", "Pais Agregado");
                lugar.LlenarCBPais(cbPais);
                dgvPais.DataSource = lugar.MostrarPaises().Tables[0];
                LimpiarPais();
            }
            else
            {
                MessageBox.Show("NO se pudo ingresar la informacion del pais", "Error al ingresar pais");
            }
        }

        private void ModificarPais(object sender, DataGridViewCellMouseEventArgs e)
        {
            {
                int indice = e.RowIndex;
                idActPais = dgvPais.Rows[indice].Cells[0].Value.ToString();
                //Obtener toda la informacion por medio de plato_id 
                DataTable tb = lugDAL.InformacionID($"Select * from PAIS WHERE pais_id = {idActPais}");
                //Mostrar ID
                txtPaisID.Text = tb.Rows[0]["pais_id"].ToString();
                //Nombre del plato
                txtNombrePais.Text = tb.Rows[0]["pa_nombre"].ToString();

                modifiPais = true;
            }

        }

        private void cmdModificarPais_Click(object sender, EventArgs e)
        {
            if (modifiPais)
            {
                RecuperarInformacionPais();
                if (lugar.ModificarPais(pais,idActPais))
                {
                    MessageBox.Show("El PAIS " + pais.pais_id + " se MODIFICO correctamente", "Pais Modificado");
                    lugar.LlenarCBPais(cbPais);
                    dgvPais.DataSource = lugar.MostrarPaises().Tables[0];
                    LimpiarPais();
                    modifiPais = false;
                }
                else
                {
                    MessageBox.Show("NO se pudo modificar la informacion del pais", "Error al momdificar pais");
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar primero un registro para modificarlo", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        //METODOS DE ESTADO ------------------------------------------------------------
        private void RecuperarInformacionEstado()
        {
            estado.estado_id = int.Parse(txtEstadoID.Text);
            estado.est_nombre = txtNombreEstado.Text;
            //estado.estado_id = int.Parse(txtNombreEstado.Text);
        }

        public void LimpiarEstado()
        {
            txtEstadoID.Clear();
            txtNombreEstado.Clear();
            cbPais.SelectedIndex = 0;
        }

        private void btnAgregarEstado_Click(object sender, EventArgs e)
        {
            RecuperarInformacionEstado();
            if (lugar.AgregarEstado(estado))
            {
                MessageBox.Show("El ESTADO " + estado.est_nombre + " se AGREGO correctamente", "Estado Agregado");
                lugar.LlenarCBEstado(cbEstado);
                dgvEstado.DataSource = lugar.MostrarEstados().Tables[0];
                LimpiarEstado();
            }
            else
            {
                MessageBox.Show("NO se pudo ingresar la informacion del estado", "Error al ingresar estado");
            }
        }

        private void cbPais_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbPais.SelectedIndex > 0)
            {

                //Recuperar informacion de de la tabla CIUDAD
                string id = lugar.ObtenerID($"Select pais_id From PAIS WHERE pa_nombre ='{cbPais.Text}'");

                //Reccuperar el id del nombre de la ciudad
                estado.pais_id = int.Parse(id);//guardarlo
            }
        }
        private void ModificarEstado(object sender, DataGridViewCellMouseEventArgs e)
        {
            {
                int indice = e.RowIndex;
                idActEstado = dgvEstado.Rows[indice].Cells[0].Value.ToString();

                //Obtener toda la informacion por medio de Estado id 
                DataTable tb = lugDAL.InformacionID($"Select * from ESTADO WHERE estado_id = {idActEstado}");

                //Mostrar ID
                txtEstadoID.Text = tb.Rows[0]["estado_id"].ToString();
                //Nombre del Estado
                txtNombreEstado.Text = tb.Rows[0]["est_nombre"].ToString();


                //Obtener Pais
                string idPais = tb.Rows[0]["pais_id"].ToString();

                DataTable t = lugDAL.InformacionID($"Select pa_nombre From PAIS WHERE pais_id = {idPais}");


                //Imprimir ciudad
                bool bandera = false;
                int i = 0;
                while (bandera == false)
                {
                    cbPais.SelectedIndex = i;
                    if (cbPais.SelectedItem.ToString() == t.Rows[0]["pa_nombre"].ToString())
                    {
                        bandera = true;
                    }
                    i++;
                }

                modifiEstado = true;

            }

        }

        private void cmdModificarEstado_Click(object sender, EventArgs e)
        {
            if (modifiEstado)
            {
                RecuperarInformacionEstado();
                if (lugar.ModificarEstado(estado, idActEstado))
                {
                    MessageBox.Show("El ESTADO " + estado.estado_id + " se MODIFICO correctamente", "Estado Modificado");
                    lugar.LlenarCBEstado(cbEstado);
                    dgvEstado.DataSource = lugar.MostrarEstados().Tables[0];
                    LimpiarEstado();
                    modifiEstado = false;
                }
                else
                {
                    MessageBox.Show("NO se pudo modificar la informacion del estado", "Error al momdificar estado");
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar primero un registro para modificarlo", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        //METODOS DE CIUDAD ------------------------------------------------------------
        private void RecuperarInformacionCiudad()
        {
            ciudad.ciudad_id = int.Parse(txtCiudadID.Text);
            ciudad.ciudad_nombre = txtNombreCiudad.Text;
            //estado.estado_id = int.Parse(txtNombreEstado.Text);
        }

        public void LimpiarCiudad()
        {
            txtCiudadID.Clear();
            txtNombreCiudad.Clear();
            cbEstado.SelectedIndex = 0;
        }

        private void btnAgregarCiudad_Click(object sender, EventArgs e)
        {
            RecuperarInformacionCiudad();
            if (lugar.AgregarCiudad(ciudad))
            {
                MessageBox.Show("La CIUDAD " + ciudad.ciudad_nombre + " se AGREGO correctamente", "Ciudad Agregado");
                dgvCiudad.DataSource = lugar.MostrarCiudad().Tables[0];
                LimpiarCiudad();
            }
            else
            {
                MessageBox.Show("NO se pudo ingresar la informacion del ciudad", "Error al ingresar ciudad");
            }
        }


        private void cbEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbEstado.SelectedIndex > 0)
            {

                //Recuperar informacion de de la tabla CIUDAD
                string id = lugar.ObtenerID($"Select estado_id From ESTADO WHERE est_nombre = '{cbEstado.Text}'");

                //Reccuperar el id del nombre de la ciudad
                ciudad.estado_id = int.Parse(id);//guardarlo
            }
        }

        LugarDAL lugDAL = new LugarDAL();


        private void ModificarCiudad(object sender, DataGridViewCellMouseEventArgs e)
        {
            {
                int indice =  e.RowIndex;

                idActCiudad = dgvCiudad.Rows[indice].Cells[0].Value.ToString();
                //Obtener toda la informacion por medio de la Ciudad 
                DataTable tb = lugDAL.InformacionID($"Select * from CIUDAD WHERE ciudad_id = {idActCiudad}");
                //Mostrar ID
                txtCiudadID.Text = tb.Rows[0]["ciudad_id"].ToString();
                //Nombre del plato
                txtNombreCiudad.Text = tb.Rows[0]["ci_nombre"].ToString();


                //Obtener Estado
                string idEstado = tb.Rows[0]["estado_id"].ToString();

                DataTable t = lugDAL.InformacionID($"Select est_nombre From ESTADO WHERE estado_id = {idEstado}");


                //Imprimir ciudad
                bool bandera = false;
                int i = 0;
                while (bandera == false)
                {
                    cbEstado.SelectedIndex = i;
                    if (cbEstado.SelectedItem.ToString() == t.Rows[0]["est_nombre"].ToString())
                    {
                        bandera = true;
                    }
                    i++;
                }

                modifiCiudad = true;
            }

        }

        private void cmdModificarCiudad_Click(object sender, EventArgs e)
        {
            if (modifiCiudad)
            {
                RecuperarInformacionCiudad();
                if (lugar.ModificarCiudad(ciudad, idActCiudad))
                {
                    MessageBox.Show("La CIUDAD " + ciudad.ciudad_id + " se MODIFICO correctamente", "Ciudad Modificada");
                    dgvCiudad.DataSource = lugar.MostrarCiudad().Tables[0];
                    LimpiarCiudad();
                    modifiCiudad = false;
                }
                else
                {
                    MessageBox.Show("NO se pudo modificar la informacion de la ciudad", "Error al modificar ciudad");
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar primero un registro para modificarlo", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Close();
        }

    }

    public class CiudadBLL
    {
        public int ciudad_id;
        public string ciudad_nombre;
        public int estado_id;
    }

    public class EstadoBLL
    {

        public int estado_id;
        public string est_nombre;
        public int pais_id;
    }

    public class PaisBLL
    {
        public int pais_id;
        public string pa_nombre;
    }
}
