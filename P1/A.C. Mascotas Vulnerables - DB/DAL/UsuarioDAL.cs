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
    internal class UsuarioDAL
    {
        Conexion conexion = new Conexion();

        public UsuarioDAL()
        {
            conexion = new Conexion();
        }

        public DataSet MostrarUsuarios()
        {
            SqlCommand comandoSQL = new SqlCommand("Select usuario_id as ID, usu_apaterno as A_Paterno, usu_amaterno as A_Materno, " +
                "usu_nombre_s as 'Nombre(s)', usu_cargo as Cargo, usu_contraseña as Contraseña, usu_rfc as RFC, usu_fecha_nacimiento as Fecha_Nacimiento, " +
                "usu_telefono as Telefono, usu_email as Correo from USUARIO where usu_estatus = 'Activo'");
            return conexion.EjecutarSentenciaConRetorno(comandoSQL);
        }

        public DataSet Buscar(string valor)
        {
            SqlCommand comandoSQL = new SqlCommand($"Select usuario_id as ID, usu_apaterno as A_Paterno, usu_amaterno as A_Materno, " +
                "usu_nombre_s as 'Nombre(s)', usu_cargo as Cargo, usu_contraseña as Contraseña, usu_rfc as RFC, usu_fecha_nacimiento as Fecha_Nacimiento, " +
                $"usu_telefono as Telefono, usu_email as Correo from USUARIO where usu_estatus = 'Activo'" +
                $"where (usu_nombre_s like '%{valor}%') or (usuario_id like '%{valor}%') or (usu_apaterno like '%{valor}%')");
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
                           "ciudad_id," +
                           "usu_telefono," +
                           "usu_email," +
                           "usu_fecha_ingreso," +
                           "usu_estatus)" +
        "values(@id,@apaterno,@amaterno,@nombres,@foto,@cargo,@contraseña, @rfc," +
        "@nacimiento,@calle,@exterior,@interior,@colonia,@cp,@ciudad,@telefono,@email,@ingreso, @estatus)");
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
                agregar.Parameters.AddWithValue("ciudad", usuario.ciudad_id);
                agregar.Parameters.AddWithValue("telefono", usuario.usu_Telefono);
                agregar.Parameters.AddWithValue("email", usuario.usu_eMail);
                agregar.Parameters.AddWithValue("ingreso", usuario.usu_Fecha_ingreso);
                agregar.Parameters.AddWithValue("estatus", usuario.usu_estatus);

                conexion.ejecutarComandoSinRetorno(agregar);
            }
            return true;

        }

        //METODOS Usuario
        public bool ModificarUsuario(UsuarioBLL usuario, string idAnterior)
        {
            SqlCommand modificar = new SqlCommand(
        "Update USUARIO set usuario_id = @id," +
                           "usu_apaterno = @apaterno," +
                           "usu_amaterno = @amaterno," +
                           "usu_nombre_s = @nombres," +
                           "usu_foto = @foto," +
                           "usu_cargo = @cargo," +
                           "usu_contraseña = @contraseña," +
                           "usu_rfc = @rfc," +
                           "usu_fecha_nacimiento = @nacimiento," +
                           "usu_calle = @calle," +
                           "usu_num_ext = @exterior," +
                           "usu_num_int = @interior," +
                           "usu_colonia = @colonia," +
                           "usu_cp = @cp," +
                           "ciudad_id = @ciudad," +
                           "usu_telefono = @telefono," +
                           "usu_email = @email," +
                           "usu_fecha_ingreso = @ingreso," +
                           "usu_estatus = @estatus " +
                           "WHERE usuario_id = " + idAnterior);
            {
                modificar.Parameters.AddWithValue("id", usuario.usu_id);
                modificar.Parameters.AddWithValue("apaterno", usuario.usu_apaterno);
                modificar.Parameters.AddWithValue("amaterno", usuario.usu_amaterno);
                modificar.Parameters.AddWithValue("nombres", usuario.usu_nombres);
                modificar.Parameters.AddWithValue("foto", usuario.usu_foto);
                modificar.Parameters.AddWithValue("cargo", usuario.usu_cargo);
                modificar.Parameters.AddWithValue("contraseña", usuario.usu_contraseña);
                modificar.Parameters.AddWithValue("rfc", usuario.usu_rfc);
                modificar.Parameters.AddWithValue("nacimiento", usuario.usu_fechana_nacimiento);
                modificar.Parameters.AddWithValue("calle", usuario.usu_calle);
                modificar.Parameters.AddWithValue("exterior", usuario.usu_noExte);
                modificar.Parameters.AddWithValue("interior", usuario.usu_noInte);
                modificar.Parameters.AddWithValue("colonia", usuario.usu_colonia);
                modificar.Parameters.AddWithValue("cp", usuario.usu_CP);
                modificar.Parameters.AddWithValue("ciudad", usuario.ciudad_id);
                modificar.Parameters.AddWithValue("telefono", usuario.usu_Telefono);
                modificar.Parameters.AddWithValue("email", usuario.usu_eMail);
                modificar.Parameters.AddWithValue("ingreso", usuario.usu_Fecha_ingreso);
                modificar.Parameters.AddWithValue("estatus", usuario.usu_estatus);

                conexion.ejecutarComandoSinRetorno(modificar);
            }
            return true;

        }

        public void EliminarUsuario(string valorid)
        {
            SqlCommand comandoSQL = new SqlCommand($"Update USUARIO set usu_estatus = 'inactivo' where usuario_id = {valorid}");
            conexion.EjecutarSentenciaConRetorno(comandoSQL);
        }
        
    }
}
