using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A.C.Mascotas_Vulnerables___DB.DAL
{
    internal class InicioSesionDaL
    {
        Conexion conexion = new Conexion();

        public InicioSesionDaL()
        {
            conexion = new Conexion();
        }

        ////Buscar valores en tabla
        //public bool BuscarUsuario(string sentencia, string valor, int posicion, Control control, ErrorProvider error)
        //{
        //    try
        //    {
        //        SqlCommand cmd = new SqlCommand(sentencia);
        //        cmd.Connection = EstablecerConexion();
        //        conexion.Open();

        //        SqlDataReader dr = cmd.ExecuteReader();
        //        while (dr.Read())
        //        {
        //            if (dr[posicion].ToString() == valor)
        //            {
        //                error.SetError(control, "EL valor " + valor + " de  ya existe");
        //                return false;
        //            }

        //        }
        //        conexion.Close();
        //        return true;
        //    }
        //    catch
        //    {
        //        return false;
        //    }

        //}
    }
}
