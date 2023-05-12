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
   1 socio_id            SMALLINT NOT NULL,
   2 sc_apaterno         VARCHAR(50) NOT NULL,
   3 sc_amaterno         VARCHAR(50) NOT NULL,
   4 sc_nombre_s         VARCHAR(50) NOT NULL,
   5 sc_rfc              VARCHAR(14) NOT NULL,
6    sc_calle            VARCHAR(50) NOT NULL,
7    sc_num_ext          VARCHAR(9) NOT NULL,
8	sc_num_int          VARCHAR(8),
9    sc_colonia          VARCHAR(100) NOT NULL,
10    sc_cp               VARCHAR(6) NOT NULL,
11	ciudad_id            INTEGER NOT NULL,
 12   sc_telefono         CHAR(10) NOT NULL,
13    sc_telefono2        CHAR(10),
14	sc_telefono3        CHAR(10),
15    sc_email            VARCHAR(130),
16    sc_fecha_nacimiento DATE NOT NULL,
17    sc_fecha_ingreso    DATE NOT NULL,
18    sc_tipo_presona      VARCHAR(6) NOT NULL,
19    sc_estatus          VARCHAR(8) NOT NULL
);
         */

        public int sc_id;
        public string sc_apaterno;
        public string sc_amaterno;
        public string sc_nombre_s;
        public string sc_rfc;
        public string sc_calle;
        public int sc_num_ext;
        public string sc_num_int;
        public string sc_colonia;
        public string sc_cp;
        public int ciudad_id;
        public string sc_telefono;
        public string sc_telefono2;
        public string sc_telefono3;
        public string sc_email;
        public DateTime sc_fecha_nacimiento;
        public DateTime sc_fecha_ingreso;
        public string sc_tipo_presona;
        public string sc_estatus;

    }
}
