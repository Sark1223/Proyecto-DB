using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using A.C.Mascotas_Vulnerables___DB.BLL;
using A.C.Mascotas_Vulnerables___DB.PL;

namespace A.C.Mascotas_Vulnerables___DB.DAL
{
    internal class AportacionDAL
    {
        Conexion conexion = new Conexion();

        public AportacionDAL()
        {
            conexion = new Conexion();
        }

        //LLENAR COMBO BOX ----------------------------------------
        public void LlenaCBPeriodo(ComboBox cbCiudad)
        {
            conexion.RellenarCB_Periodo(cbCiudad, "SELECT * FROM PERIODO", "- PERIODO -");
        }
        public void LlenarCB_Estatus(ComboBox cbCiudad)
        {
            conexion.RellenarCB(cbCiudad, "SELECT * FROM ESTATUS_RECIBO", "- ESTATUS -", 0);
        }
        public void LlenarCBEncargado2(ComboBox cbEncargado)
        {
            conexion.RellenarCB_Encargado(cbEncargado, "SELECT * FROM USUARIO", "- SELECCIONE ENCARGADO -");
        }

        //Cargar valores en tabla------------------
        public DataSet MostrarRecibos()
        {
            SqlCommand comandoSQL = new SqlCommand("Select * from RECIBO");
            return conexion.EjecutarSentenciaConRetorno(comandoSQL);
        }
        public DataSet Buscar(string valor)
        {
            SqlCommand comandoSQL = new SqlCommand($"Select * from USUARIO where (usu_nombre_s like '%{valor}%') or (usuario_id like '%{valor}%')");
            return conexion.EjecutarSentenciaConRetorno(comandoSQL);
        }


        //Obtener informacion de ID´s----------------
        public string ObtenerID(string Sentencia)
        {
            return conexion.RetornarID(Sentencia);
        }
        public DataTable InformacionID(string sentencia)
        {
            return conexion.InformacionID(sentencia);
        }
        public string SepararValores(string seleccion, byte pos)
        {
            string[] palabraClave = seleccion.Split();

            return palabraClave[pos];
        }
        public bool ValidarID(string valor, string valorCarga, Control control, ErrorProvider error)
        {
            return conexion.BuscarEnTabla_MODIFICAR("select rec_folio from RECIBO", valor, valorCarga, control, error);
        }


        //METODOS Socio
        public bool AgregarRecibo(ReciboBLL recibo)
        {
            SqlCommand agregar = new SqlCommand(
            "insert into RECIBO(rec_folio," +
                       "rec_fecha," +
                       "usuario_id," +
                       "socio_id," +
                       "rec_monto," +
                       "rec_mto_escrito," +
                       "estatus_id," +
                       "periodo_año," +
                       "periodo_num," +
                       "rec_firma_asistente," +
                       "rec_firma_administrativo)" +

            "values(@rec_folio, @rec_fecha, @usuario_id, @socio_id, @rec_monto, @rec_mto_escrito,@estatus_id," +
            "@periodo_año,@periodo_num,@rec_firma_asistente,@rec_firma_administrativo)");
            {
                agregar.Parameters.AddWithValue("rec_folio", recibo.rec_folio);
                agregar.Parameters.AddWithValue("rec_fecha", recibo.rec_fecha);
                agregar.Parameters.AddWithValue("usuario_id", recibo.usuario_id);
                agregar.Parameters.AddWithValue("socio_id", recibo.socio_id);
                agregar.Parameters.AddWithValue("rec_monto", recibo.rec_monto);
                agregar.Parameters.AddWithValue("rec_mto_escrito", recibo.rec_mto_escrito);
                agregar.Parameters.AddWithValue("estatus_id", recibo.estatus_id);
                agregar.Parameters.AddWithValue("periodo_año", recibo.periodo_año);
                agregar.Parameters.AddWithValue("periodo_num", recibo.periodo_num);
                agregar.Parameters.AddWithValue("rec_firma_asistente", recibo.rec_firma_asistente);
                agregar.Parameters.AddWithValue("rec_firma_administrativo", recibo.rec_firma_administrativo);

            }
            return conexion.ejecutarComandoSinRetorno(agregar);


        }

        public bool Modificar(ReciboBLL recibo, string folio)
        {
            SqlCommand modificar = new SqlCommand($"Update RECIBO set estatus_id = @estatus_id where rec_folio = {folio}");
            modificar.Parameters.AddWithValue("estatus_id", recibo.estatus_id);
            return conexion.ejecutarComandoSinRetorno(modificar);
        }


        //METODOS ESTATUS ------------------------------------------------------
        public bool AgregarEstatus(EstatusBLL estatus)
        {
            /*CREATE TABLE ESTATUS_RECIBO (
    estatus_id   char(2) NOT NULL,
    estatus_descripcion VARCHAR(30) NOT NULL UNIQUE
);*/
            SqlCommand agregar = new SqlCommand(
            "insert into ESTATUS_RECIBO(estatus_id," +
                             "estatus_descripcion)" +
            "values(@estatus_id,@estatus_descripcion)");
            {
                agregar.Parameters.AddWithValue("estatus_id", estatus.estatus_id);
                agregar.Parameters.AddWithValue("estatus_descripcion", estatus.estatus_descripcion);
            }

            return conexion.ejecutarComandoSinRetorno(agregar);
        }

        public bool ModificarEstatus(EstatusBLL estatus, string idAnterior)
        {
            SqlCommand modificar = new SqlCommand(
            "Update ESTATUS_RECIBO set estatus_id = @estatus_id," +
                             "estatus_descripcion = @estatus_descripcion " +
                             "WHERE estatus_id = " + idAnterior);
            {
                modificar.Parameters.AddWithValue("estatus_id", estatus.estatus_id);
                modificar.Parameters.AddWithValue("estatus_descripcion", estatus.estatus_descripcion);
            }

            return conexion.ejecutarComandoSinRetorno(modificar);
        }

        public DataSet MostrarEstatus()
        {
            SqlCommand comandoSQL = new SqlCommand("Select * from ESTATUS_RECIBO");
            return conexion.EjecutarSentenciaConRetorno(comandoSQL);
        }

    }
}
