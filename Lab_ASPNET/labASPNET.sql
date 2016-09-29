use BD_B43939

CREATE TABLE CLIENTE(
	cedula		char(9) primary key,
	nombre		char(20) not null,
	apellido1	char(30) not null,
	apellido2	char(30),
	correo		varchar(30),
	direccion	varchar(50)
)

CREATE TABLE TELEFONO(
	cedulaCliente	char(9) foreign key references CLIENTE(cedula),
	numero			char(8),
	primary key		(cedulaCliente, numero)
)

CREATE TABLE CUENTA(
	cedulaCliente	char(9) foreign key references CLIENTE(cedula),
	tipo			varchar(20),
	numero			varchar(20),
	primary key		(cedulaCliente, numero)
)

ALTER TABLE CLIENTE
ADD id nvarchar(128) foreign key references AspNetUsers(Id)
