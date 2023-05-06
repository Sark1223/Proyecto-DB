using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using A.C.Mascotas_Vulnerables___DB.BLL;

namespace A.C.Mascotas_Vulnerables___DB.DAL
{
    internal class SocioDAL
    {
        Conexion conexion = new Conexion();
        public SocioDAL()
        {
            conexion = new Conexion();
        }
        //METODOS Socio
        public bool AgregarUsuario(SocioBLL socio)
        {
            SqlCommand agregar = new SqlCommand(
        "insert into SOCIO(socio_id," +
                           "sc_apaterno," +
                           "sc_amaterno," +
                           "sc_nombre_s," +
                           "sc_rfc," +
                           "sc_calle," +
                           "sc_num_ext," +
                           "sc_num_int," +
                           "sc_colonia," +
                           "sc_cp," +
                           "sc_Municipio," +
                           "sc_Estado," +
                           "sc_Pais," +
                           "sc_telefono," +
                           "sc_telefono2," +
                           "sc_telefono3," +
                           "sc_email," +
                           "sc_fecha_nacimiento," +
                           "sc_fecha_ingreso," +
                           "sc_tipo_presona" +
                           "sc_estatus)" +

        "values(@id,@apaterno,@amaterno,@nombres,@rfc,@calle,@exterior, @interior," +
        "@colonia,@cp,@municipio,@estado,@pais,@telefono,@telefono2, @telefono3," +
        "@email,@nacimiento,@ingreso,@tipodepersona,@estatus)");
            {
                agregar.Parameters.AddWithValue("id", socio.sc_id);
                agregar.Parameters.AddWithValue("apaterno", socio.sc_apaterno);
                agregar.Parameters.AddWithValue("amaterno", socio.sc_amaterno);
                agregar.Parameters.AddWithValue("nombres", socio.sc_nombre_s);
                agregar.Parameters.AddWithValue("rfc", socio.sc_rfc);
                agregar.Parameters.AddWithValue("calle", socio.sc_calle);
                agregar.Parameters.AddWithValue("exterior", socio.sc_num_ext);
                agregar.Parameters.AddWithValue("interior", socio.sc_num_int);
                agregar.Parameters.AddWithValue("colonia", socio.sc_colonia);
                agregar.Parameters.AddWithValue("cp", socio.sc_cp);
                agregar.Parameters.AddWithValue("municipio", socio.sc_Municipio);
                agregar.Parameters.AddWithValue("estado", socio.sc_Estado);
                agregar.Parameters.AddWithValue("pais", socio.sc_Pais);
                agregar.Parameters.AddWithValue("telefono", socio.sc_telefono);
                agregar.Parameters.AddWithValue("telefono2", socio.sc_telefono2);
                agregar.Parameters.AddWithValue("telefono3", socio.sc_telefono3);
                agregar.Parameters.AddWithValue("email", socio.sc_email);
                agregar.Parameters.AddWithValue("nacimiento", socio.sc_fecha_nacimiento);
                agregar.Parameters.AddWithValue("ingreso", socio.sc_fecha_ingreso);
                agregar.Parameters.AddWithValue("tipodepersona", socio.sc_tipo_presona);
                agregar.Parameters.AddWithValue("estatus", socio.sc_estatus);


                conexion.ejecutarComandoSinRetorno(agregar);
            }
            return true;

        }
        public DataSet MostratSocios()
        {
            SqlCommand comandoSQL = new SqlCommand("Select * from SOCIO");
            return conexion.EjecutarSentenciaConRetorno(comandoSQL);
        }
    }
}
