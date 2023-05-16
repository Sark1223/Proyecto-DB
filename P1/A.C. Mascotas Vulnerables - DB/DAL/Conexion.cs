using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A.C.Mascotas_Vulnerables___DB.DAL
{
    internal class Conexion
    {
        //Conexion Santos Karla♥
        public string CadenaConexion = @"server = ANVORGUEZA\SQLEXPRESS; Initial Catalog = AC_MASCOTAS; Integrated Security = true";
        SqlConnection conexion;

        //////Conexion Villada Edwin
        //public string CadenaConexion = @"server = DESKTOP-BNMO14B; Initial Catalog = AC_MASCOTAS; Integrated Security = true";
        //SqlConnection conexion;

        ////Conexion Manuel Davila
        //public string CadenaConexion = @"server = LAPTOP-MANUEL\SQLEXPRESS; Initial Catalog = AC_MASCOTAS; Integrated Security = true";
        //SqlConnection conexion;




        //METODOS DE CONEXION
        public SqlConnection EstablecerConexion()
        {
            this.conexion = new SqlConnection(this.CadenaConexion);
            return this.conexion;
        }

        public DataSet EjecutarSentenciaConRetorno(SqlCommand comando)
        {
            DataSet DS = new DataSet();
            SqlDataAdapter adaptador = new SqlDataAdapter();

            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd = comando;
                cmd.Connection = EstablecerConexion();
                adaptador.SelectCommand = cmd;
                conexion.Open();
                adaptador.Fill(DS);
                conexion.Close();

                return DS;
            }
            catch
            {
                return DS;
            }
        }

        //Metodo para AGREGAR, ELIMINAR Y MODIFICAR
        public bool ejecutarComandoSinRetorno(SqlCommand Comandosql)
        {
            try
            {
                SqlCommand comando = Comandosql;
                comando.Connection = this.EstablecerConexion();
                conexion.Open();
                comando.ExecuteNonQuery();
                conexion.Close();
                return true;
            }
            catch 
            {
                return false;
            }
            
        }

        //METODOS COMBO BOX - COMPLEJO
        public void RellenarCB(ComboBox cb, string sentencia, string textoCB, int posicion)
        {
            SqlCommand cmd = new SqlCommand(sentencia);
            cmd.Connection = this.EstablecerConexion();
            conexion.Open();

            cb.Items.Clear();

            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                if (dr[posicion].ToString() != textoCB)
                {
                    cb.Items.Add(dr[posicion].ToString());
                }

            }
            conexion.Close();
            cb.Items.Insert(0, textoCB);
            cb.SelectedIndex = 0;
        }

        //METODOS COMBO BOX - COMPLEJO
        public void RellenarCB_Encargado(ComboBox cb, string sentencia, string textoCB)
        {
            SqlCommand cmd = new SqlCommand(sentencia);
            cmd.Connection = this.EstablecerConexion();
            conexion.Open();

            cb.Items.Clear();

            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                string nombreCompleto = $"{dr[0]} - {dr[1]} {dr[2]} {dr[3]}";  
                if (nombreCompleto != textoCB)
                {
                    cb.Items.Add(nombreCompleto.ToString());
                }

            }
            conexion.Close();
            cb.Items.Insert(0, textoCB);
            cb.SelectedIndex = 0;
        }

        //METODOS COMBO BOX - COMPLEJO
        public void RellenarCB_Periodo(ComboBox cb, string sentencia, string textoCB)
        {
            SqlCommand cmd = new SqlCommand(sentencia);
            cmd.Connection = this.EstablecerConexion();
            conexion.Open();

            cb.Items.Clear();

            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                /*CREATE TABLE PERIODO (
    periodo_año    Char(4) NOT NULL,
    periodo_num     CHAR(1) NOT NULL,
    periodo_inicio DATE,
    periodo_fin    DATE
);*/
                string periodo = $"{dr[0]} - {dr[1]}";
                if (periodo != textoCB)
                {
                    cb.Items.Add(periodo.ToString());
                }

            }
            conexion.Close();
            cb.Items.Insert(0, textoCB);
            cb.SelectedIndex = 0;
        }

        //Recuperar ID
        public string RetornarID(string sentencia)
        {
            SqlCommand cmd = new SqlCommand(sentencia);
            cmd.Connection = EstablecerConexion();
            cmd.Connection.Open();

            SqlDataReader dr = cmd.ExecuteReader();
            string id = "";

            while (dr.Read())
            {
                id = dr[0].ToString();
            }
            cmd.Connection.Close();
            return id;
        }//para el metodo modificar

        //Recuperar información del ID
        public DataTable InformacionID(string sentencia)
        {
            SqlCommand cmd = new SqlCommand(sentencia);
            cmd.Connection = EstablecerConexion();
            DataTable tb = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(sentencia, cmd.Connection);
            da.Fill(tb);
            return tb;
        }


        public bool BuscarEnTabla(string sentencia, string valor, string texto, int posicion, Control control, ErrorProvider error)
        {
            try
            {
                SqlCommand cmd = new SqlCommand(sentencia);
                cmd.Connection = EstablecerConexion();
                conexion.Open();

                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    if (dr[posicion].ToString() == valor)
                    {
                        return true;
                    }

                }
                conexion.Close();

                error.SetError(control, texto);
                return false;
            }
            catch
            {

                error.SetError(control, texto);
                return false;
            }

        }


        //Buscar valores en tabla
        public bool BuscarEnTabla_AGREGAR(string sentencia, string valor, int posicion)
        {
            try
            {
                SqlCommand cmd = new SqlCommand(sentencia);
                cmd.Connection = EstablecerConexion();
                conexion.Open();

                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    if (dr[posicion].ToString() == valor)
                    {
                        return false;
                    }

                }
                conexion.Close();
                return true;
            }
            catch
            {
                return false;
            }

        }

        public bool BuscarEnTabla_MODIFICAR(string sentencia, string valor, string valorCarga, Control control, ErrorProvider error)
        {
            //int vecesRepetido = 0;
            try
            {
                if (valor == valorCarga)
                {
                    return true;
                }
                else
                {
                    SqlCommand cmd = new SqlCommand(sentencia);
                    cmd.Connection = EstablecerConexion();
                    conexion.Open();

                    SqlDataReader dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {
                        if (dr[0].ToString() == valor)
                        {
                            error.SetError(control, "EL valor " + valor + " de  ya existe");
                            return false;
                        }

                    }
                    conexion.Close();
                    return true;
                }

            }
            catch
            {
                return false;
            }

        }


    }


}

