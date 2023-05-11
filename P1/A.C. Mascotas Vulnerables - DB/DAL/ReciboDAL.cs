using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using A.C.Mascotas_Vulnerables___DB.BLL;

namespace A.C.Mascotas_Vulnerables___DB.DAL
{
    internal class ReciboDAL
    {
        Conexion conexion = new Conexion();
        public ReciboDAL()
        {
            conexion = new Conexion();
        }
        //METODOS Socio
        public bool AgregarRecibo(ReciboBLL recibo)
        {
            SqlCommand agregar = new SqlCommand(
        "insert into RECIBO(rec_folio," +
                           "rec_fecha," +
                           "rec_monto," +
                           "rec_mto_escrito," +
                           "rec_firma_asistente," +
                           "rec_firma_administrativo)" +

        "values(@folio,@fecha,@monto,@mtoescrito,@firmaasistente,@firmaadministrativo)");
            {
                agregar.Parameters.AddWithValue("folio", recibo.rec_folio);
                agregar.Parameters.AddWithValue("fecha", recibo.rec_fecha);
                agregar.Parameters.AddWithValue("monto", recibo.rec_monto);
                agregar.Parameters.AddWithValue("mtoescrito", recibo.rec_mto_escrito);
                agregar.Parameters.AddWithValue("firmaasistente", recibo.rec_firma_asistente);
                agregar.Parameters.AddWithValue("firmaadministrativo", recibo.rec_firma_administrativo);


                conexion.ejecutarComandoSinRetorno(agregar);
            }
            return true;

        }

        public DataSet MostratRecibo()
        {
            SqlCommand comandoSQL = new SqlCommand("Select * from RECIBO");
            return conexion.EjecutarSentenciaConRetorno(comandoSQL);
        }

        public void LlenarCBEncargado2(ComboBox cbEncargado)
        {
            conexion.RellenarCB(cbEncargado, "SELECT * FROM USUARIO", "- SELECCIONE ENCARGADO -", 1);
        }

        public DataSet Buscar(string valor)
        {
            SqlCommand comandoSQL = new SqlCommand($"Select * from USUARIO where (usu_nombre_s like '%{valor}%') or (usuario_id like '%{valor}%')");
            return conexion.EjecutarSentenciaConRetorno(comandoSQL);
        }
    }
}
