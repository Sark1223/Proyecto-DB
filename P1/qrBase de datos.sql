cREATE DATABASE AC_MASCOTAS;

USE AC_MASCOTAS;

-- ENTIDADES DE DIRECCION --------------------------------------------------------------------

CREATE TABLE PAIS (
    pais_id   INTEGER NOT NULL,
    pa_nombre VARCHAR(50)
);

ALTER TABLE pais ADD CONSTRAINT pais_pk PRIMARY KEY ( pais_id );

CREATE TABLE ESTADO (
    estado_id    INTEGER NOT NULL,
    est_nombre   VARCHAR(50),
    pais_id INTEGER NOT NULL
);

ALTER TABLE ESTADO ADD CONSTRAINT estado_pk PRIMARY KEY ( estado_id );

ALTER TABLE ESTADO
    ADD CONSTRAINT estado_pais_fk FOREIGN KEY ( pais_id )
        REFERENCES pais ( pais_id );

CREATE TABLE CIUDAD (
    ciudad_id        INTEGER NOT NULL,
    ci_nombre        VARCHAR(50),
    estado_id INTEGER NOT NULL
);

ALTER TABLE CIUDAD ADD CONSTRAINT ciudad_pk PRIMARY KEY ( ciudad_id );

ALTER TABLE ciudad
    ADD CONSTRAINT ciudad_estado_fk FOREIGN KEY ( estado_id )
        REFERENCES estado ( estado_id );

-- TABLAS INDEPENDIENTES ------------------------------------------------------------------

CREATE TABLE ESTATUS_RECIBO (
    estatus_id   char(2) NOT NULL,
    estatus_descripcion VARCHAR(30) NOT NULL UNIQUE
);

ALTER TABLE ESTATUS_RECIBO ADD CONSTRAINT ESTATUS_RECIBO_pk PRIMARY KEY ( estatus_id );

CREATE TABLE PERIODO (
    periodo_año    Char(4) NOT NULL,
    periodo_num     CHAR(1) NOT NULL,
    periodo_inicio DATE,
    periodo_fin    DATE
);

ALTER TABLE PERIODO ADD CONSTRAINT periodo_pk PRIMARY KEY ( periodo_año,
                                                            periodo_num );


--TABLAS DEPENDIENTES----------------------------------------------------------------------------
CREATE TABLE USUARIO (
    usuario_id           tinyint NOT NULL,
    usu_apaterno         VARCHAR(30) NOT NULL,
    usu_amaterno         VARCHAR(30) NOT NULL,
    usu_nombre_s         VARCHAR(50) NOT NULL,
    usu_foto			 Image not null,
    usu_cargo            Varchar(24) not null,
    usu_contraseña       VARCHAR(15) NOT NULL,
    usu_rfc              VARCHAR(13) NOT NULL,
    usu_fecha_nacimiento DATE NOT NULL,
    usu_calle            VARCHAR(50) NOT NULL,
    usu_num_ext          VARCHAR(9) NOT NULL,
    usu_num_int          VARCHAR(8),
    usu_colonia          VARCHAR(100) NOT NULL,
    usu_cp               VARCHAR(6) NOT NULL,
	ciudad_id            INTEGER NOT NULL,
    usu_telefono         NUMERiC(10,0) NOT NULL,
    usu_email            VARCHAR(130) not null,
    usu_fecha_ingreso    DATE NOT NULL,
	usu_estatus          VARCHAR(8) NOT NULL
);

ALTER TABLE USUARIO ADD CONSTRAINT usuario_pk PRIMARY KEY ( usuario_id );

ALTER TABLE usuario
    ADD CONSTRAINT usuario_ciudad_fk FOREIGN KEY ( ciudad_id )
        REFERENCES CIUDAD ( ciudad_id );


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
	ciudad_id            INTEGER NOT NULL,
    sc_telefono         CHAR(10) NOT NULL,
    sc_telefono2        CHAR(10),
	sc_telefono3        CHAR(10),
    sc_email            VARCHAR(130),
    sc_fecha_nacimiento DATE NOT NULL,
    sc_fecha_ingreso    DATE NOT NULL,
    sc_tipo_presona      VARCHAR(6) NOT NULL,
    sc_estatus          VARCHAR(8) NOT NULL
);

ALTER TABLE socio ADD CONSTRAINT socio_pk PRIMARY KEY ( socio_id );

ALTER TABLE SOCIO
    ADD CONSTRAINT SICIO_ciudad_fk FOREIGN KEY ( ciudad_id )
        REFERENCES CIUDAD ( ciudad_id );


CREATE TABLE HISTORIAL (
    historia_num          INTEGER NOT NULL,
    usuario_id            tinyint NOT NULL,
    cambio				  VARCHAR(100) not null,
    fecha                 DATE NOT NULL,
	hora				  Time not null
);

ALTER TABLE HISTORIAL ADD CONSTRAINT historial_pk PRIMARY KEY ( historia_num );

ALTER TABLE HISTORIAL
    ADD CONSTRAINT historial_usuario_fk FOREIGN KEY ( usuario_id )
        REFERENCES USUARIO ( usuario_id );


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

ALTER TABLE recibo ADD CONSTRAINT recibo_pk PRIMARY KEY ( rec_folio );

ALTER TABLE recibo
    ADD CONSTRAINT recibo_estatus_fk FOREIGN KEY ( estatus_id )
        REFERENCES ESTATUS_RECIBO ( estatus_id );

ALTER TABLE recibo
    ADD CONSTRAINT recibo_periodo_fk FOREIGN KEY ( periodo_año,
                                                   periodo_num )
        REFERENCES PERIODO ( periodo_año,
                             periodo_num );

ALTER TABLE recibo
    ADD CONSTRAINT recibo_socio_fk FOREIGN KEY ( socio_id )
        REFERENCES SOCIO ( socio_id );

ALTER TABLE recibo
    ADD CONSTRAINT recibo_usuario_fk FOREIGN KEY ( usuario_id )
        REFERENCES USUARIO ( usuario_id );

