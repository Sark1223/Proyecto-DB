using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using A.C.Mascotas_Vulnerables___DB.PL;
using A.C.Mascotas_Vulnerables___DB.BLL;

namespace A.C.Mascotas_Vulnerables___DB.DAL
{
    internal class HistorialDAL
    {
        Conexion conexion = new Conexion();
        public HistorialDAL()
        {
            conexion = new Conexion();
        }
        /*CREATE TABLE HISTORIAL (
    historia_num          INTEGER NOT NULL,
    usuario_id            tinyint NOT NULL,
    cambio				  VARCHAR(100) not null,
    fecha                 DATE NOT NULL,
	hora				  Time not null
);*/
        public DataSet Buscar(string valor)
        {
            SqlCommand comandoSQL = new SqlCommand($"Select * HISTORIAL " +
                $"where (usuario_id like '%{valor}%') or (fecha like '%{valor}%')");
            return conexion.EjecutarSentenciaConRetorno(comandoSQL);
        }

        public DataSet MostrarTabla()
        {
            SqlCommand comandoSQL = new SqlCommand($"Select * from HISTORIAL");
            return conexion.EjecutarSentenciaConRetorno(comandoSQL);
        }

        public bool AgregarModificacion(HistorialBLL historial)
        {
            SqlCommand agregar = new SqlCommand(
            "insert into HISTORIAL(historia_num," +
                             "usuario_id," +
                             "cambio," +
                             "fecha," +
                             "hora)" +
            "values(@historia_num,@usuario_id,@cambio,@fecha,@hora)");
            {
                agregar.Parameters.AddWithValue("historia_num", historial.historia_num);
                agregar.Parameters.AddWithValue("usuario_id", historial.usuario_id);
                agregar.Parameters.AddWithValue("cambio", historial.cambio);
                agregar.Parameters.AddWithValue("fecha", historial.fecha);
                agregar.Parameters.AddWithValue("hora", historial.hora);
            }

            return conexion.ejecutarComandoSinRetorno(agregar);
        }

        public int RetornarUltimaModificacion()
        {
            string comandoSQL = "Select MAX(historia_num) from HISTORIAL";

            return conexion.ValorMaximoEntero(comandoSQL);
        }
    }
}
