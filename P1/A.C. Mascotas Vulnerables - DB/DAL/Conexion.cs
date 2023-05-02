using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A.C.Mascotas_Vulnerables___DB.DAL
{
    internal class Conexion
    {
        //Conexion Santos Karla♥
        public string CadenaConexion = @"server = ANVORGUEZA\SQLEXPRESS; Initial Catalog = AC_MASCOTAS; Integrated Security = true";
        SqlConnection conexion;

        ////Conexion Villada Edwin
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
    }
}
