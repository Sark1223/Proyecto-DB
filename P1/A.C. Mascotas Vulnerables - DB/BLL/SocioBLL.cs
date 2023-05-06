using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A.C.Mascotas_Vulnerables___DB.BLL
{
    internal class SocioBLL
    {
        /*
         CREATE TABLE SOCIO (
    socio_id            SMALLINT NOT NULL,
    sc_apaterno         VARCHAR(50) NOT NULL,
    sc_amaterno         VARCHAR(50) NOT NULL,
    sc_nombre_s         VARCHAR(50) NOT NULL,
    sc_rfc              VARCHAR(14) NOT NULL,
    sc_calle            VARCHAR(50) NOT NULL,
    sc_num_ext          VARCHAR(9) NOT NULL,
	sc_num_int          VARCHAR(8),
    sc_colonia          VARCHAR(100) NOT NULL,
    sc_cp               VARCHAR(6) NOT NULL,
	sc_Municipio        VARCHAR(50) NOT NULL,
	sc_Estado           VARCHAR(50) NOT NULL,
	sc_Pais             VARCHAR(50) NOT NULL,
    sc_telefono         CHAR(10) NOT NULL,
    sc_telefono2        CHAR(10),
	sc_telefono3        CHAR(10),
    sc_email            VARCHAR(130),
    sc_fecha_nacimiento DATE NOT NULL,
    sc_fecha_ingreso    DATE NOT NULL,
    sc_tipo_presona      VARCHAR(6) NOT NULL,
    sc_estatus          VARCHAR(8) NOT NULL
);
         */

        public int sc_id;
        public string sc_apaterno;
        public string sc_amaterno;
        public string sc_nombre_s;
        public string sc_rfc;
        public string sc_calle;
        public string sc_num_ext;
        public string sc_num_int;
        public string sc_colonia;
        public string sc_cp;
        public string sc_Municipio;
        public string sc_Estado;
        public string sc_Pais;
        public char sc_telefono;
        public char sc_telefono2;
        public char sc_telefono3;
        public string sc_email;
        public DateTime sc_fecha_nacimiento;
        public DateTime sc_fecha_ingreso;
        public string sc_tipo_presona;
        public string sc_estatus;

    }
}
