/* TABLA USUARIO */
CREATE TABLE USUARIO
(
	dni varchar(10),
	email VARCHAR(50),
	tipo VARCHAR(10) NOT NULL DEFAULT 'USUARIO',
	nombre VARCHAR(20) NOT NULL,
	apellido1 VARCHAR(20) NOT NULL,
	apellido2 VARCHAR(20),
	fecha_nacimiento DATE NOT NULL,
	fecha_alta DATE NOT NULL,
	contrasenya VARCHAR(300) NOT NULL,

	CONSTRAINT cp_cli_dni PRIMARY KEY(dni),
	CONSTRAINT chk_usu_tipo CHECK (tipo IN('USUARIO', 'ADMIN')) 
)

/* TABLA PROVINCIA */
CREATE TABLE PROVINCIA
(
  codigo INT,
  nombre VARCHAR(50) NOT NULL,
  
  CONSTRAINT cp_prov_codigo PRIMARY KEY(codigo)
)

/* TABLA LOCALIDAD */          
CREATE TABLE LOCALIDAD
(
  codigo INT,
  pueblo VARCHAR(50),
  provincia INT, 
  
  CONSTRAINT cp_local_codprov PRIMARY KEY(codigo, provincia), /* RESTRICCION DE IDENTIFICADOR */
  CONSTRAINT ca_local_provincia FOREIGN KEY(provincia) REFERENCES provincia
    ON DELETE CASCADE 
    ON UPDATE CASCADE 
)

/* TABLA DIRECCION_PEDIDO */
CREATE TABLE DIRECCION_PEDIDO
(
  dni VARCHAR(10),
  email VARCHAR(50),
  calle VARCHAR(100),
  cod_postal VARCHAR(5),
  codigo_local INT NOT NULL, /* RESTRICCION */
  provincia_local INT NOT NULL, /* RESTRICCION */
  
  CONSTRAINT cp_dirped_email PRIMARY KEY(dni),
  CONSTRAINT ca_dirped_cli_email FOREIGN KEY(dni) REFERENCES usuario
    ON DELETE CASCADE 
    ON UPDATE CASCADE,
  CONSTRAINT ca_dirped_local_localidad FOREIGN KEY(codigo_local, provincia_local) REFERENCES localidad
    ON DELETE CASCADE 
    ON UPDATE CASCADE
	)

/* TABLA VEHICULO */
CREATE TABLE VEHICULO
(
  codigo VARCHAR(10),
  nombre VARCHAR(10),
  descripcion TEXT,
  pvp DECIMAL(3,2),
  url_imagen VARCHAR(500),
  disponible BIT, /* si es 0 sera usuario , si es 1 , administrador*/
  
  CONSTRAINT cp_art_codigo PRIMARY KEY(codigo)
)

/* ESPECIALIZACION DE VEHICULO, CAMIONES */
CREATE TABLE CAMION
(
  vehiculo VARCHAR(10),

  CONSTRAINT cp_camiones_vehiculo PRIMARY KEY(vehiculo),
  CONSTRAINT ca_camiones_vehiculo FOREIGN KEY(vehiculo) REFERENCES vehiculo
    ON DELETE CASCADE
    ON UPDATE CASCADE
)

/* ESPECIALIZACION DE VEHICULO, MOTOS */
CREATE TABLE MOTO
(
  vehiculo VARCHAR(10),

  CONSTRAINT cp_motos_vehiculo PRIMARY KEY(vehiculo),
  CONSTRAINT ca_motos_vehiculo FOREIGN KEY(vehiculo) REFERENCES vehiculo
    ON DELETE CASCADE
    ON UPDATE CASCADE
)

/* ESPECIALIZACION DE VEHICULO, CARAVANAS */
CREATE TABLE CARAVANA
(
  vehiculo VARCHAR(10),

  CONSTRAINT cp_caravanas_vehiculo PRIMARY KEY(vehiculo),
  CONSTRAINT ca_caravanas_vehiculo FOREIGN KEY(vehiculo) REFERENCES vehiculo
    ON DELETE CASCADE
    ON UPDATE CASCADE
)

/* ESPECIALIZACION DE VEHICULO, COCHES */
CREATE TABLE COCHE
(
  vehiculo VARCHAR(10),

  CONSTRAINT cp_coches_vehiculo PRIMARY KEY(vehiculo),
  CONSTRAINT ca_coches_vehiculo FOREIGN KEY(vehiculo) REFERENCES vehiculo
    ON DELETE CASCADE
    ON UPDATE CASCADE
)

/* ESPECIALIZACION DE VEHICULO, CAMIONES */
CREATE TABLE FURGONETA
(
  vehiculo VARCHAR(10),

  CONSTRAINT cp_furgoneta_vehiculo PRIMARY KEY(vehiculo),
  CONSTRAINT ca_furgoneta_vehiculo FOREIGN KEY(vehiculo) REFERENCES vehiculo
    ON DELETE CASCADE
    ON UPDATE CASCADE
)


/* TABLA CESTA */
CREATE TABLE CESTA
(
  cliente VARCHAR(10),
  vehiculo VARCHAR(10),
  cantindad INT,
  fecha DATETIME,
  
  CONSTRAINT cp_cest_cliveh PRIMARY KEY (cliente, vehiculo),
  CONSTRAINT ca_cest_cliente FOREIGN KEY(cliente) REFERENCES usuario
    ON DELETE CASCADE
    ON UPDATE CASCADE,
  CONSTRAINT ca_cest_vehiculo FOREIGN KEY(vehiculo) REFERENCES vehiculo
    ON DELETE CASCADE
    ON UPDATE CASCADE 
)

/* TABLA PEDIDO */
CREATE TABLE PEDIDO
(
  num_pedido INT,
  fecha DATETIME NOT NULL,
  cliente VARCHAR(10) NOT NULL, /* RESTRICCION */ 
  
  CONSTRAINT cp_ped_numpedido PRIMARY KEY(num_pedido),
  CONSTRAINT ca_ped_cliente FOREIGN KEY(cliente) REFERENCES usuario
    ON DELETE CASCADE
    ON UPDATE CASCADE
)

/* TABLA LINPED */                        
CREATE TABLE LINPED
(
  linea INT,
  precio MONEY NOT NULL,
  cantidad INT,
  pedido INT,
  vehiculo VARCHAR(10) NOT NULL,
  
  CONSTRAINT cp_linp_linped PRIMARY KEY(linea, pedido), /* RESTRICCION DE IDENTIFICADOR */
  CONSTRAINT ca_linp_pedido FOREIGN KEY(pedido) REFERENCES pedido
    ON DELETE CASCADE
    ON UPDATE CASCADE,
  CONSTRAINT ca_linp_vehiculo FOREIGN KEY(vehiculo) REFERENCES vehiculo
    ON DELETE CASCADE
    ON UPDATE CASCADE
)
