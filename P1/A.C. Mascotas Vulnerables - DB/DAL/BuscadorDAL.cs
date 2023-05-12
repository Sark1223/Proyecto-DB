using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A.C.Mascotas_Vulnerables___DB.DAL
{
    internal class BuscadorDAL
    {
        Conexion conexion = new Conexion();
        public BuscadorDAL()
        {
            conexion = new Conexion();
        }

        public DataSet Buscar(string valor)
        {
            SqlCommand comandoSQL = new SqlCommand($"Select socio_id, sc_apaterno, sc_amaterno, sc_nombre_s from SOCIO " +
                $"where (socio_id like '%{valor}%') or (sc_apaterno like '%{valor}%') or (sc_nombre_s like '%{valor}%') where sc_estatus = 'Activo' ");
            return conexion.EjecutarSentenciaConRetorno(comandoSQL);
        }

        public DataSet MostrarTabla()
        {
            SqlCommand comandoSQL = new SqlCommand($"Select socio_id, sc_apaterno, sc_amaterno, sc_nombre_s from SOCIO where sc_estatus = 'Activo' ");
            return conexion.EjecutarSentenciaConRetorno(comandoSQL);
        }
    }
}
