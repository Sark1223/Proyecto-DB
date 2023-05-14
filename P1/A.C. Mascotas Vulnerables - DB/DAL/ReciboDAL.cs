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
        public bool BuscarEnTabla_Agregar(string sentencia, string valor, int posicion, Control control, ErrorProvider error)
        {
            try
            {
                SqlCommand cmd = new SqlCommand(sentencia);
                cmd.Connection = conexion.EstablecerConexion();

                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    if (dr[posicion].ToString() == valor)
                    {
                        error.SetError(control, "EL valor " + valor + " de  ya existe");
                        return false;
                    }

                }
                return true;
            }
            catch
            {
                return false;
            }
        }
        
        public void ReciboIDAuto(string sentencia)
        {
            string proid ;
            SqlCommand cmd = new SqlCommand(sentencia);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                int id = int.Parse(dr[0].ToString()) + 1;
                proid=id.ToString("0");

            }
            else if (Convert.IsDBNull(dr))
            {
                proid = ("1");
            }
            else
            {
                proid = ("1");
            }
            
        }

        //METODOS Socio
        public bool AgregarRecibo(ReciboBLL recibo)
        {
            ReciboIDAuto("SELECT rec_folio FROM RECIBO order by rec_folio DESC");
            try
            {
                //verifica si ya existe un socio con el mismo ID
                if (!BuscarEnTabla_Agregar("SELECT rec_folio FROM RECIBO WHERE rec_folio = @folio", recibo.rec_folio.ToString(), 0, null, null))
                {
                    return false;
                }
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
            catch
            {
                return false;
            }

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
