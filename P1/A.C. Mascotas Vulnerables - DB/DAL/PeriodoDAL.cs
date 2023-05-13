using A.C.Mascotas_Vulnerables___DB.PL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A.C.Mascotas_Vulnerables___DB.DAL
{
    internal class PeriodoDAL
    {
        Conexion conexion = new Conexion();

        public PeriodoDAL()
        {
            conexion = new Conexion();
        }

        public DataSet MostrarPeriodos()
        {
            SqlCommand comandoSQL = new SqlCommand("Select * from PERIODO");
            return conexion.EjecutarSentenciaConRetorno(comandoSQL);
        }

        public bool AgregarPeriodo(PeriodoBLL periodo)
        {
            SqlCommand agregar = new SqlCommand(
            "insert into PERIODO(periodo_año," +
                             "periodo_num," +
                             "periodo_inicio," +
                             "periodo_fin)" +
            "values(@periodo_año,@periodo_num,@periodo_inicio,@periodo_fin)");
            {
                agregar.Parameters.AddWithValue("periodo_año", periodo.periodo_año);
                agregar.Parameters.AddWithValue("periodo_num", periodo.periodo_num);
                agregar.Parameters.AddWithValue("periodo_inicio", periodo.periodo_inicio);
                agregar.Parameters.AddWithValue("periodo_fin", periodo.periodo_fin);
            }

            conexion.ejecutarComandoSinRetorno(agregar);

            return true;
        }

        /*CREATE TABLE PERIODO (
    periodo_año    Char(4) NOT NULL,
    periodo_num     CHAR(1) NOT NULL,
    periodo_inicio DATE,
    periodo_fin    DATE
);
*/

        public bool ModificarPeriodo(PeriodoBLL periodo, string periodoaño, string periodoNum)
        {
            SqlCommand modificar = new SqlCommand(
            "Update PERIODO set periodo_año = @periodo_año," +
                             "periodo_num = @periodo_num," +
                             "periodo_inicio = @periodo_inicio," +
                             "periodo_fin = @periodo_fin " +
                             $"WHERE periodo_año = {periodoaño} and periodo_num ={periodoNum}" );
            {
                modificar.Parameters.AddWithValue("periodo_año", periodo.periodo_año);
                modificar.Parameters.AddWithValue("periodo_num", periodo.periodo_num);
                modificar.Parameters.AddWithValue("periodo_inicio", periodo.periodo_inicio);
                modificar.Parameters.AddWithValue("periodo_fin", periodo.periodo_fin);
            }

            conexion.ejecutarComandoSinRetorno(modificar);

            return true;
        }
    }
}
