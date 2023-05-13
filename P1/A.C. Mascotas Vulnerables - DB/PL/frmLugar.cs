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

        bool error = true;

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

        //Validar el ID del pais
        private void txtPaisID_TextChanged(object sender, EventArgs e)
        {
            error = false;

            //ciclo para recorrer caracter por caracter 
            foreach (char caracter in txtPaisID.Text)
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
                error1.SetError(txtPaisID, "No se admiten letras ni espacios en blanco\nIngrese números solamente");
            }
            else
            {
                error1.SetError(txtPaisID, "");
            }
        }

        private void txtPaisID_Validated(object sender, EventArgs e)
        {
            error1.SetError(txtPaisID, "");
        }

        private void txtPaisID_Validating(object sender, CancelEventArgs e)
        {
            ValidarNumeros(txtPaisID, error1, e);
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

        //Validaciones de nombre pais
        private void txtNombrePais_TextChanged(object sender, EventArgs e)
        {
            int espacio = 0;
            error = false;

            //ciclo para recorrer caracter por caracter 
            foreach (char caracter in txtNombrePais.Text)
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
                    if (espacio == txtNombrePais.TextLength)
                    {
                        error = true;
                        break;
                    }
                }
            }
            if (error)
            {
                error1.SetError(txtNombrePais, "No se admiten números ni espacios en blanco\nIngrese letras solamente");
            }
            else
            {
                error1.SetError(txtNombrePais, "");
            }
        }

        private void txtNombrePais_Validated(object sender, EventArgs e)
        {
            error1.SetError(txtNombrePais, "");
        }

        private void txtNombrePais_Validating(object sender, CancelEventArgs e)
        {
            ValidarLetrasEspacios(txtNombrePais, error1, e);
        }

        //Validaciones de estado id
        private void txtEstadoID_TextChanged(object sender, EventArgs e)
        {
            int espacio = 0;
            error = false;

            //ciclo para recorrer caracter por caracter 
            foreach (char caracter in txtEstadoID.Text)
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
                    if (espacio == txtEstadoID.TextLength)
                    {
                        error = true;
                        break;
                    }
                }
            }
            if (error)
            {
                error1.SetError(txtEstadoID, "No se admiten números ni espacios en blanco\nIngrese letras solamente");
            }
            else
            {
                error1.SetError(txtEstadoID, "");
            }
        }

        private void txtEstadoID_Validating(object sender, CancelEventArgs e)
        {
            ValidarLetrasEspacios(txtEstadoID, error1, e);
        }

        private void txtEstadoID_Validated(object sender, EventArgs e)
        {
            error1.SetError(txtEstadoID, "");
        }

        //Validar la ciudad id 
        private void txtCiudadID_TextChanged(object sender, EventArgs e)
        {
            int espacio = 0;
            error = false;

            //ciclo para recorrer caracter por caracter 
            foreach (char caracter in txtCiudadID.Text)
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
                    if (espacio == txtCiudadID.TextLength)
                    {
                        error = true;
                        break;
                    }
                }
            }
            if (error)
            {
                error1.SetError(txtCiudadID, "No se admiten números ni espacios en blanco\nIngrese letras solamente");
            }
            else
            {
                error1.SetError(txtCiudadID, "");
            }
        }

        private void txtCiudadID_Validating(object sender, CancelEventArgs e)
        {
            ValidarLetrasEspacios(txtCiudadID, error1, e);
        }

        private void txtCiudadID_Validated(object sender, EventArgs e)
        {
            error1.SetError(txtEstadoID, "");
        }

        //Validaciones del nombre de la ciudad
        private void txtNombreCiudad_TextChanged(object sender, EventArgs e)
        {
            int espacio = 0;
            error = false;

            //ciclo para recorrer caracter por caracter 
            foreach (char caracter in txtNombreCiudad.Text)
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
                    if (espacio == txtNombreCiudad.TextLength)
                    {
                        error = true;
                        break;
                    }
                }
            }
            if (error)
            {
                error1.SetError(txtNombreCiudad, "No se admiten números ni espacios en blanco\nIngrese letras solamente");
            }
            else
            {
                error1.SetError(txtNombreCiudad, "");
            }
        }

        private void txtNombreCiudad_Validated(object sender, EventArgs e)
        {
            error1.SetError(txtNombreCiudad, "");
        }

        private void txtNombreCiudad_Validating(object sender, CancelEventArgs e)
        {
            ValidarLetrasEspacios(txtNombreCiudad, error1, e);
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
