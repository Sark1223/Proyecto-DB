﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A.C.Mascotas_Vulnerables___DB.BLL
{
    internal class UsuarioBLL
    {
        /*
	usuario_id           tinyint NOT NULL,
    usu_apaterno         VARCHAR(30) NOT NULL,
    usu_amaterno         VARCHAR(30) NOT NULL,
    usu_nombre_s         VARCHAR(50) NOT NULL,
	usu_foto			 Image not null,
	usu_cargo            Varchar(24) not null,
	usu_contraseña           VARCHAR(15) NOT NULL,
    usu_rfc              VARCHAR(13) NOT NULL,
	usu_fecha_nacimiento DATE NOT NULL,
    usu_calle            VARCHAR(50) NOT NULL,
	usu_num_ext          VARCHAR(9) NOT NULL,
    usu_num_int          VARCHAR(8),
    usu_colonia          VARCHAR(100) NOT NULL,
    usu_cp               VARCHAR(6) NOT NULL,
	usu_Municipio           VARCHAR(50) NOT NULL,
	usu_Estado           VARCHAR(50) NOT NULL,
	usu_Pais            VARCHAR(50) NOT NULL,
    usu_telefono         NUMERiC(10,0) NOT NULL,
    usu_email            VARCHAR not null,
    usu_fecha_ingreso    DATE NOT NULL
);*/




        public int usu_id;
        public string usu_apaterno;
        public string usu_amaterno;
        public string usu_nombres;
        public byte[] usu_foto;
        public string usu_cargo;
        public string usu_contraseña;
        public string usu_rfc;
        public DateTime usu_fechana_nacimiento;//??????
        public string usu_calle;
        public string usu_noExte;
        public string usu_noInte;
        public string usu_colonia;
        public string usu_CP;
        public string usu_municipio;
        public string usu_Estado;
        public string usu_Pais;
        public string usu_Telefono;
        public string usu_eMail;
        public string usu_Fecha_ingreso;
    }
}
