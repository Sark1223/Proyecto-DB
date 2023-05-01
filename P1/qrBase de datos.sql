cREATE DATABASE AC_MASCOTAS;

USE AC_MASCOTAS;

CREATE TABLE estatus (
    id_estatus   VARCHAR(4) NOT NULL,
    tipo_estatus VARCHAR(40) NOT NULL
);

ALTER TABLE estatus ADD CONSTRAINT estatus_pk PRIMARY KEY ( id_estatus );

CREATE TABLE tipo (
    id_tipo      VARCHAR(4) NOT NULL,
    persona_tipo VARCHAR(30) NOT NULL
);

ALTER TABLE tipo ADD CONSTRAINT tipo_pk PRIMARY KEY ( id_tipo );

CREATE TABLE roll (
    id_roll     VARCHAR(4) NOT NULL,
    nombre_roll VARCHAR(50) NOT NULL
);

ALTER TABLE roll ADD CONSTRAINT roll_pk PRIMARY KEY ( id_roll );

CREATE TABLE socio (
    socio_id            VARCHAR(7) NOT NULL,
    sc_apaterno         VARCHAR(50) NOT NULL,
    sc_amaterno         VARCHAR(50) NOT NULL,
    sc_nombre_s         VARCHAR(50) NOT NULL,
    sc_rfc              VARCHAR(14 ) NOT NULL,
    sc_calle            VARCHAR(50 ) NOT NULL,
    sc_num_int          VARCHAR(8),
    sc_num_ext          VARCHAR(9) NOT NULL,
    sc_colonia          VARCHAR(50)  NOT NULL,
    sc_ciudad           VARCHAR(50) NOT NULL,
    sc_cp               NUMERIC(5) NOT NULL,
    sc_lada             VARCHAR(4) NOT NULL,
    sc_telefono         NUMERIC(10) NOT NULL,
    sc_telefono2        NUMERIC(10),
    sc_extension        NUMERIC NOT NULL,
    sc_email            VARCHAR(100),
    sc_fecha_nacimiento DATE NOT NULL,
    sc_fecha_ingreso    DATE NOT NULL,
    tipo_id_tipo        VARCHAR(4) NOT NULL,
    sc_estatus          VARCHAR(9) NOT NULL
);

ALTER TABLE socio ADD CONSTRAINT socio_pk PRIMARY KEY ( socio_id );

ALTER TABLE socio
    ADD CONSTRAINT socio_tipo_fk FOREIGN KEY ( tipo_id_tipo )
        REFERENCES tipo ( id_tipo );

CREATE TABLE periodo (
    periodo_clave  VARCHAR(20 ) NOT NULL,
    periodo_nombre VARCHAR(20) NOT NULL,
    periodo_inicio DATE NOT NULL,
    periodo_fin    DATE NOT NULL
);

ALTER TABLE periodo ADD CONSTRAINT periodo_pk PRIMARY KEY ( periodo_clave );

CREATE TABLE usuario (
    usuario_id           VARCHAR(13) NOT NULL,
    usu_apaterno         VARCHAR(30) NOT NULL,
    usu_amaterno         VARCHAR(30 ) NOT NULL,
    usu_nombre_s      VARCHAR(50) NOT NULL,
    usu_rfc              VARCHAR(16 ) NOT NULL,
    usu_calle            VARCHAR(100 ) NOT NULL,
    usu_num_int          VARCHAR(5 ),
    usu_num_ext          SMALLINT NOT NULL,
    usu_colonia          VARCHAR(100 ) NOT NULL,
    usu_ciudad           VARCHAR(100 ) NOT NULL,
    usu_cp               VARCHAR(6 ) NOT NULL,
    usu_lada             SMALLINT NOT NULL,
    usu_telefono         NUMERIC(5,0) NOT NULL,
    usu_email            VARCHAR (50)  NOT NULL,
    usu_fecha_nacimiento DATE NOT NULL,
    usu_fecha_ingreso    DATE NOT NULL,
    roll_id_roll         VARCHAR(4) NOT NULL,
    contraseña           VARCHAR(15) NOT NULL
);

ALTER TABLE usuario ADD CONSTRAINT usuario_pk PRIMARY KEY ( usuario_id );

ALTER TABLE usuario
    ADD CONSTRAINT usuario_roll_fk FOREIGN KEY ( roll_id_roll )
        REFERENCES roll ( id_roll );

CREATE TABLE recibo (
    rec_id_folio             VARCHAR(10 ) NOT NULL,
    rec_fecha                DATE NOT NULL,
    usuario_usuario_id       VARCHAR(13) NOT NULL,
    socio_socio_id           VARCHAR(7 ) NOT NULL,
    rec_monto                NUMERic(11, 2) NOT NULL,
    rec_mto_escrito          VARCHAR(100) NOT NULL,
    estatus_id_estatus       VARCHAR(4) NOT NULL,
    periodo_periodo_clave    VARCHAR(20 ) NOT NULL,
    rec_firma_asistente      VARCHAR(150 ) NOT NULL,
    rec_firma_administrativo VARCHAR(150 ) NOT NULL,
    sc_apaterno              VARCHAR(50) NOT NULL,
    sc_amaterno              VARCHAR(50) NOT NULL,
    "SC_NOMBRE(S)"           VARCHAR(50) NOT NULL,
    sc_rfc                   VARCHAR(16 ) NOT NULL,
    aa_apaterno              VARCHAR(30) NOT NULL,
    aa_amaterno              VARCHAR(30 ) NOT NULL,
    "AA_NOMBRE(S)"           VARCHAR(50) NOT NULL
);

ALTER TABLE recibo ADD CONSTRAINT recibo_pk PRIMARY KEY ( rec_id_folio );

ALTER TABLE recibo
    ADD CONSTRAINT recibo_estatus_fk FOREIGN KEY ( estatus_id_estatus )
        REFERENCES estatus ( id_estatus );

ALTER TABLE recibo
    ADD CONSTRAINT recibo_periodo_fk FOREIGN KEY ( periodo_periodo_clave )
        REFERENCES periodo ( periodo_clave );

ALTER TABLE recibo
    ADD CONSTRAINT recibo_socio_fk FOREIGN KEY ( socio_socio_id )
        REFERENCES socio ( socio_id );

ALTER TABLE recibo
    ADD CONSTRAINT recibo_usuario_fk FOREIGN KEY ( usuario_usuario_id )
        REFERENCES usuario ( usuario_id );

CREATE TABLE historial (
    fecha              DATE NOT NULL,
    usuario_usuario_id NUMBER NOT NULL,
    cambio             VARCHAR2(100)
);

ALTER TABLE historial ADD CONSTRAINT historial_pk PRIMARY KEY ( fecha );

ALTER TABLE historial
    ADD CONSTRAINT historial_usuario_fk FOREIGN KEY ( usuario_usuario_id )
        REFERENCES usuario ( usuario_id );