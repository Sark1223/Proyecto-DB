using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
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

        public bool BuscarUsuario(string valor, Control control, ErrorProvider error)
        {
            return conexion.BuscarEnTabla("SELECT usuario_id FROM USUARIO", valor, $"El usuario {valor} no existe",
                                          0, control, error);
        }

        public DataTable InformacionID(string sentencia)
        {
            return conexion.InformacionID(sentencia);
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
