using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A.C.Mascotas_Vulnerables___DB.BLL
{
    internal class HistorialBLL
    {
        /*CREATE TABLE HISTORIAL (
    historia_num          INTEGER NOT NULL,
    usuario_id            tinyint NOT NULL,
    cambio				  VARCHAR(100) not null,
    fecha                 DATE NOT NULL,
	hora				  Time not null
);*/

        public long historia_num;
        public int usuario_id;
        public string cambio;
        public DateTime fecha;
        public DateTime hora;


    }
}
