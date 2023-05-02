using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using A.C.Mascotas_Vulnerables___DB.BLL;

namespace A.C.Mascotas_Vulnerables___DB.DAL
{
    internal class UsuarioDAL
    {
        Conexion conexion = new Conexion();

        public UsuarioDAL()
        {
            conexion = new Conexion();
        }

        //METODOS Usuario
        public bool AgregarUsuario(UsuarioBLL usuario)
        {
            SqlCommand agregar = new SqlCommand(
        "insert into USUARIO(usuario_id," +
                           "usu_apaterno," +
                           "usu_amaterno," +
                           "usu_nombre_s," +
                           "usu_foto," +
                           "usu_cargo," +
                           "usu_contraseña," +
                           "usu_rfc," +
                           "usu_fecha_nacimiento," +
                           "usu_calle," +
                           "usu_num_ext," +
                           "usu_num_int," +
                           "usu_colonia," +
                           "usu_cp," +
                           "usu_Municipio," +
                           "usu_Estado," +
                           "usu_Pais," +
                           "usu_telefono," +
                           "usu_email," +
                           "usu_fecha_ingreso)" +
        "values(@id,@apaterno,@amaterno,@nombres,@foto,@cargo,@contraseña, @rfc," +
        "@nacimiento,@calle,@exterior,@interior,@colonia,@cp,@municipio, @estado," +
        "@pais,@telefono,@email,@ingreso)");
            {
                agregar.Parameters.AddWithValue("id", usuario.usu_id);
                agregar.Parameters.AddWithValue("apaterno", usuario.usu_apaterno);
                agregar.Parameters.AddWithValue("amaterno", usuario.usu_amaterno);
                agregar.Parameters.AddWithValue("nombres", usuario.usu_nombres);
                agregar.Parameters.AddWithValue("foto", usuario.usu_foto);
                agregar.Parameters.AddWithValue("cargo", usuario.usu_cargo);
                agregar.Parameters.AddWithValue("contraseña", usuario.usu_contraseña);
                agregar.Parameters.AddWithValue("rfc", usuario.usu_rfc);
                agregar.Parameters.AddWithValue("nacimiento", usuario.usu_fechana_nacimiento);
                agregar.Parameters.AddWithValue("calle", usuario.usu_calle);
                agregar.Parameters.AddWithValue("exterior", usuario.usu_noExte);
                agregar.Parameters.AddWithValue("interior", usuario.usu_noInte);
                agregar.Parameters.AddWithValue("colonia", usuario.usu_colonia);
                agregar.Parameters.AddWithValue("cp", usuario.usu_CP);
                agregar.Parameters.AddWithValue("municipio", usuario.usu_municipio);
                agregar.Parameters.AddWithValue("estado", usuario.usu_Estado);
                agregar.Parameters.AddWithValue("pais", usuario.usu_Pais);
                agregar.Parameters.AddWithValue("telefono", usuario.usu_Telefono);
                agregar.Parameters.AddWithValue("email", usuario.usu_eMail);
                agregar.Parameters.AddWithValue("ingreso", usuario.usu_Fecha_ingreso);

                conexion.ejecutarComandoSinRetorno(agregar);
            }
            return true;

        }
    }
}
