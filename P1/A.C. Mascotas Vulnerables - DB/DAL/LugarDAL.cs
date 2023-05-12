using A.C.Mascotas_Vulnerables___DB.PL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A.C.Mascotas_Vulnerables___DB.DAL
{
    internal class LugarDAL
    {
        Conexion conexion = new Conexion();

        public LugarDAL()
        {
            conexion = new Conexion();
        }


        /*CREATE TABLE CIUDAD (
    ciudad_id        INTEGER NOT NULL,
    ci_nombre        VARCHAR(50),
    estado_id INTEGER NOT NULL
);*/
        /*CREATE TABLE PAIS (
    pais_id   INTEGER NOT NULL,
    pa_nombre VARCHAR(50)
);*/

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


        //METODOS PAIS -------------------------------------------------------------------
        public DataSet MostrarPaises()
        {
            SqlCommand comandoSQL = new SqlCommand("Select * from PAIS");
            return conexion.EjecutarSentenciaConRetorno(comandoSQL);
        }

        public bool AgregarPais(PaisBLL pais)
        {
            SqlCommand agregar = new SqlCommand(
            "insert into PAIS(pais_id," +
                             "pa_nombre)" +
            "values(@pais_id,@pa_nombre)");
            {
                agregar.Parameters.AddWithValue("pais_id", pais.pais_id);
                agregar.Parameters.AddWithValue("pa_nombre", pais.pa_nombre);
            }

            conexion.ejecutarComandoSinRetorno(agregar);
            
            return true;
        }

        public bool ModificarPais(PaisBLL pais, string idAnterior)
        {
            SqlCommand modificar = new SqlCommand(
            "Update PAIS set pais_id = @pais_id," +
                             "pa_nombre = @pa_nombre " +
                             "WHERE pais_id = " + idAnterior);
            {
                modificar.Parameters.AddWithValue("pais_id", pais.pais_id);
                modificar.Parameters.AddWithValue("pa_nombre", pais.pa_nombre);
            }

            conexion.ejecutarComandoSinRetorno(modificar);

            return true;
        }

        /*CREATE TABLE ESTADO (
    estado_id    INTEGER NOT NULL,
    est_nombre   VARCHAR(50),
    pais_id INTEGER NOT NULL
);
*/
        //METODOS ESTADO -------------------------------------------------------------------
        public DataSet MostrarEstados()
        {
            SqlCommand comandoSQL = new SqlCommand("Select * from ESTADO");
            return conexion.EjecutarSentenciaConRetorno(comandoSQL);
        }

        public bool AgregarEstado(EstadoBLL estado)
        {
            SqlCommand agregar = new SqlCommand(
            "insert into ESTADO(estado_id," +
                             "est_nombre," +
                             "pais_id)" +
            "values(@estado_id,@est_nombre,@pais_id)");
            {
                agregar.Parameters.AddWithValue("estado_id", estado.estado_id);
                agregar.Parameters.AddWithValue("est_nombre", estado.est_nombre);
                agregar.Parameters.AddWithValue("pais_id", estado.pais_id);
            }

            conexion.ejecutarComandoSinRetorno(agregar);

            return true;
        }

        public bool ModificarEstado(EstadoBLL estado, string idAnterior)
        {
            SqlCommand modificar = new SqlCommand(
            "Update ESTADO set estado_id = @estado_id, " +
                             "est_nombre = @est_nombre, " +
                             "pais_id = @pais_id " +
                             "WHERE estado_id = " + idAnterior);
            {
                modificar.Parameters.AddWithValue("estado_id", estado.estado_id);
                modificar.Parameters.AddWithValue("est_nombre", estado.est_nombre);
                modificar.Parameters.AddWithValue("pais_id", estado.pais_id);
            }

            conexion.ejecutarComandoSinRetorno(modificar);

            return true;
        }

        public void LlenarCBPais(ComboBox cbCiudad)
        {
            conexion.RellenarCB(cbCiudad, "SELECT * FROM PAIS", "- SELECCIONE PAIS -", 1);
        }


        /*CREATE TABLE CIUDAD (
    ciudad_id        INTEGER NOT NULL,
    ci_nombre        VARCHAR(50),
    estado_id INTEGER NOT NULL
);*/

        //METODOS CIUDAD -------------------------------------------------------------------
        public DataSet MostrarCiudad()
        {
            SqlCommand comandoSQL = new SqlCommand("Select * from CIUDAD");
            return conexion.EjecutarSentenciaConRetorno(comandoSQL);
        }

        public bool AgregarCiudad(CiudadBLL ciudad)
        {
            SqlCommand agregar = new SqlCommand(
            "insert into CIUDAD(ciudad_id," +
                             "ci_nombre," +
                             "estado_id)" +
            "values(@ciudad_id,@ci_nombre,@estado_id)");
            {
                agregar.Parameters.AddWithValue("ciudad_id", ciudad.ciudad_id);
                agregar.Parameters.AddWithValue("ci_nombre", ciudad.ciudad_nombre);
                agregar.Parameters.AddWithValue("estado_id", ciudad.estado_id);
            }

            conexion.ejecutarComandoSinRetorno(agregar);

            return true;
        }

        public bool ModificarCiudad(CiudadBLL ciudad, string idAnterior)
        {
            SqlCommand modificar = new SqlCommand(
            "Update ESTADO set ciudad_id = @ciudad_id," +
                             "ci_nombre = @ci_nombre," +
                             "estado_id = @estado_id " +
                             "WHERE ciudad_id = " + idAnterior);
            {
                modificar.Parameters.AddWithValue("ciudad_id", ciudad.ciudad_id);
                modificar.Parameters.AddWithValue("ci_nombre", ciudad.ciudad_nombre);
                modificar.Parameters.AddWithValue("estado_id", ciudad.estado_id);
            }

            conexion.ejecutarComandoSinRetorno(modificar);

            return true;
        }

        public void LlenarCBEstado(ComboBox cbCiudad)
        {
            conexion.RellenarCB(cbCiudad, "SELECT * FROM ESTADO", "- SELECCIONE ESTADO -", 1);
        }


    }
}
