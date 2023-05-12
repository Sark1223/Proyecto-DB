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
    internal class SocioDAL
    {
        Conexion conexion = new Conexion();
        public SocioDAL()
        {
            conexion = new Conexion();
        }
        public DataSet Buscar(string valor)
        {
            SqlCommand comandoSQL = new SqlCommand($"Select * from SOCIO " +
                $"where (socio_id like '%{valor}%') or (sc_apaterno like '%{valor}%') or (sc_nombre_s like '%{valor}%')");
            return conexion.EjecutarSentenciaConRetorno(comandoSQL);
        }

        public void LlenarCBCiudad(ComboBox cbCiudad)
        {
            conexion.RellenarCB(cbCiudad, "SELECT * FROM CIUDAD", "- SELECCIONE CIUDAD -", 1);
        }

        //Obtener el ID del registro
        public string ObtenerID(string Sentencia)
        {
            return conexion.RetornarID(Sentencia);
        }

        //Obtener la informacion del registro con ID conocido
        public DataTable InformacionID(string sentencia)
        {
            return conexion.InformacionID(sentencia);
        }

        //METODOS Socio
        public bool AgregarSocio(SocioBLL socio)
        {
            SqlCommand agregar = new SqlCommand(
        "insert into SOCIO(socio_id, " +
                           "sc_apaterno, " +
                           "sc_amaterno, " +
                           "sc_nombre_s, " +
                           "sc_rfc, " +
                           "sc_calle, " +
                           "sc_num_ext, " +
                           "sc_num_int, " +
                           "sc_colonia, " +
                           "sc_cp, " +
                           "ciudad_id, " +
                           "sc_telefono, " +
                           "sc_telefono2, " +
                           "sc_telefono3, " +
                           "sc_email, " +
                           "sc_fecha_nacimiento, " +
                           "sc_fecha_ingreso, " +
                           "sc_tipo_presona, " +
                           "sc_estatus)" +

        "values(@id,@apaterno,@amaterno,@nombres,@rfc,@calle,@exterior, @interior," +
        "@colonia,@cp,@ciudad,@telefono,@telefono2, @telefono3," +
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
                agregar.Parameters.AddWithValue("ciudad", socio.ciudad_id);
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

        public bool ModificarSocio(SocioBLL socio, string idAnterior)
        {
            SqlCommand modificar = new SqlCommand(
        "Update SOCIO set socio_id = @id," +
                           "sc_apaterno = @apaterno," +
                           "sc_amaterno = @amaterno," +
                           "sc_nombre_s = @nombres," +
                           "sc_rfc = @rfc," +
                           "sc_calle = @calle," +
                           "sc_num_ext = @exterior," +
                           "sc_num_int = @interior," +
                           "sc_colonia = @colonia," +
                           "sc_cp = @cp," +
                           "ciudad_id = @ciudad," +
                           "sc_telefono = @telefono," +
                           "sc_telefono2 = @telefono2," +
                           "sc_telefono3 = @telefono3," +
                           "sc_email = @email," +
                           "sc_fecha_nacimiento = @nacimiento," +
                           "sc_fecha_ingreso = @ingreso," +
                           "sc_tipo_presona = @tipodepersona ," +
                           "sc_estatus = @estatus " +
                           "WHERE socio_id = " + idAnterior);
            {
                modificar.Parameters.AddWithValue("id", socio.sc_id);
                modificar.Parameters.AddWithValue("apaterno", socio.sc_apaterno);
                modificar.Parameters.AddWithValue("amaterno", socio.sc_amaterno);
                modificar.Parameters.AddWithValue("nombres", socio.sc_nombre_s);
                modificar.Parameters.AddWithValue("rfc", socio.sc_rfc);
                modificar.Parameters.AddWithValue("calle", socio.sc_calle);
                modificar.Parameters.AddWithValue("exterior", socio.sc_num_ext);
                modificar.Parameters.AddWithValue("interior", socio.sc_num_int);
                modificar.Parameters.AddWithValue("colonia", socio.sc_colonia);
                modificar.Parameters.AddWithValue("cp", socio.sc_cp);
                modificar.Parameters.AddWithValue("ciudad", socio.ciudad_id);
                modificar.Parameters.AddWithValue("telefono", socio.sc_telefono);
                modificar.Parameters.AddWithValue("telefono2", socio.sc_telefono2);
                modificar.Parameters.AddWithValue("telefono3", socio.sc_telefono3);
                modificar.Parameters.AddWithValue("email", socio.sc_email);
                modificar.Parameters.AddWithValue("nacimiento", socio.sc_fecha_nacimiento);
                modificar.Parameters.AddWithValue("ingreso", socio.sc_fecha_ingreso);
                modificar.Parameters.AddWithValue("tipodepersona", socio.sc_tipo_presona);
                modificar.Parameters.AddWithValue("estatus", socio.sc_estatus);


                conexion.ejecutarComandoSinRetorno(modificar);
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
