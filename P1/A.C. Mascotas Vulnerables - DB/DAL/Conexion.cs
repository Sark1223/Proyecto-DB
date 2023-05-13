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
        public void ejecutarComandoSinRetorno(SqlCommand Comandosql)
        {
            SqlCommand comando = Comandosql;
            comando.Connection = this.EstablecerConexion();
            conexion.Open();
            comando.ExecuteNonQuery();
            conexion.Close();
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
    }


}

