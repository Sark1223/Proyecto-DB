using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A.C.Mascotas_Vulnerables___DB.BLL
{
    internal class ReciboBLL
    {
        /*
         CREATE TABLE RECIBO (
    rec_folio				 INTEGER NOT NULL,
    rec_fecha                DATE NOT NULL,
	---FK -USUARIO ADMIN
    usuario_id				 tinyint NOT NULL,
	--FK -SOCIO
    socio_id				 SMALLINT NOT NULL,
    rec_monto                NUMeric(11, 2) NOT NULL,
    rec_mto_escrito          VARCHAR(130) NOT NULL,
	---FK ESTATUS DEL RECIBO
    estatus_id				 char(2) NOT NULL,
	---FK PERIODO
    periodo_año				 Char(4) NOT NULL,
    periodo_num				 CHAR(1) NOT NULL,
    rec_firma_asistente      VARCHAR(150) NOT NULL,
    rec_firma_administrativo VARCHAR(150) NOT NULL
);
         */
        public int rec_folio;
        public DateTime rec_fecha;
        public double rec_monto;
        public string rec_mto_escrito;
        public string rec_firma_asistente;
        public string rec_firma_administrativo;

    }
}
