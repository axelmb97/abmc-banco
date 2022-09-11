CREATE DATABASE CLIENTES_BANCO
GO
USE CLIENTES_BANCO
GO 
CREATE TABLE T_CLIENTES(
	id_cliente int identity(1,1),
	nombre varchar(50),
	apellido varchar(50),
	dni int,
	CONSTRAINT pk_clientes PRIMARY KEY (id_cliente)
)
CREATE TABLE T_TIPOS_CUENTAS(
	id_tipo_cuenta int identity(1,1),
	nombre varchar(20),
	CONSTRAINT pk_tipos_cuentas PRIMARY KEY (id_tipo_cuenta)
)
CREATE TABLE T_CUENTAS(
	id_cliente int,
	cbu varchar(25),
	saldo decimal(20,2),
	id_tipo_cuenta int,
	ultimo_mov varchar(50),
	activo bit,
	CONSTRAINT pk_cuentas PRIMARY KEY (cbu,id_cliente),
	CONSTRAINT fk_cuentas_clientes FOREIGN KEY (id_cliente)
		REFERENCES T_CLIENTES (id_cliente),
	CONSTRAINT fk_cuentas_tipos_cuentas FOREIGN KEY (id_tipo_cuenta)
		REFERENCES T_TIPOS_CUENTAS (id_tipo_cuenta)
)
GO
insert into T_TIPOS_CUENTAS(nombre) values('CAJA DE AHORRO PESOS'),
									('CAJA DE AHORRO EN ME'),
									('CUENTA CORRIENTE'),
									('CUENTA SUELDO')
insert into T_CLIENTES(nombre,apellido,dni) 
	values ('Axel','Bordon',40814775),
			('Alberto','Gonzalez',36954782),
			('Juana','Alvarez',45862489),
			('Lucas','Herrera',23546987),
			('Jagger','Bordon',46897351),
			('Carmen','Aguero',36459872)

insert into T_CUENTAS(id_cliente,cbu,saldo,id_tipo_cuenta,ultimo_mov,activo) 
	VALUES(1,'364851024006870349350',8000,2,'RETIRO','true'),
		(2,'800034965744893156247',1200,3,'DEPOSITO','true'),
		(3,'3468001245563214789721',36479,4,'RETIRO','true'),
		(4,'123654987500326559874',3696,2,'DEPOSITO','true'),
		(5,'159468744653120054601',15236,3,'TRASFERENCIA','true'),
		(5,'648903216487945201634',56482,4,'DEPOSITO','true'),
		(6,'444659873215648000123',56482,4,'DEPOSITO','true'),
		(6,'1236654796548231564875',69874,1,'TRANSFERENCIA','true')
GO
CREATE PROCEDURE DATOS_CLIENTES
	@tipoCuenta int = 1
AS
SELECT c.id_cliente,C.nombre,apellido,dni
	FROM T_CLIENTES C, T_CUENTAS CU
	WHERE C.id_cliente = CU.id_cliente 
		and id_tipo_cuenta = @tipoCuenta
	order by 2,3
GO
CREATE PROCEDURE TIPOS_CUENTAS
AS SELECT * FROM T_TIPOS_CUENTAS
GO
CREATE PROCEDURE SP_INSERTAR_MAESTRO_CLIENTE
	@nombre varchar(50),
	@apellido varchar(50),
	@dni int,
	@NewID int output
as
BEGIN
	INSERT INTO T_CLIENTES(nombre,apellido,dni) VALUES(@nombre,@apellido,@dni);
	SET @NewId = SCOPE_IDENTITY();
END
GO
CREATE PROCEDURE SP_INSERTAR_DETALLE_CUENTA
	@idCliente int,
	@cbu varchar(25),
	@saldo decimal(20,2),
	@idTipoCuenta int,
	@ultimoMov varchar(50),
	@activo bit
AS
BEGIN
	INSERT INTO T_CUENTAS(id_cliente,cbu,saldo,id_tipo_cuenta,ultimo_mov,activo)
		VALUES(@idCliente,@cbu,@saldo,@idTipoCuenta,@ultimoMov,@activo);
END
GO
CREATE PROCEDURE SP_BAJA_LOGICA_CUENTA
	@idCliente int,
	@cbu  varchar(25)
AS
BEGIN
	UPDATE T_CUENTAS 
		SET activo = 0
		where id_cliente = @idCliente and cbu = @cbu  
END
go
CREATE PROCEDURE SP_CLIENTES
as
SELECT id_cliente,apellido,nombre
	FROM T_CLIENTES 
	
go
CREATE PROCEDURE SP_CLIENTES_Y_CUENTAS
	@idCLiente int
AS
SELECT c.id_cliente,cu.cbu,cu.saldo,tc.id_tipo_cuenta,tc.nombre,cu.ultimo_mov,cu.activo
	FROM T_CLIENTES C, T_CUENTAS CU,T_TIPOS_CUENTAS tc
	WHERE C.id_cliente = CU.id_cliente  and cu.id_tipo_cuenta = tc.id_tipo_cuenta
	and cu.id_cliente = @idCliente
	and activo = 1
GO
CREATE PROCEDURE SP_REPORTE_CLIENTES_SALDOS
	@monto decimal(12,2) = 0 
AS
select  apellido + ' ' + nombre 'Cliente',SUM((
	case 
	WHEN id_tipo_cuenta = 2 THEN saldo * 144
	ELSE saldo
	END)) 'Total'
	from t_cuentas cu
	join T_CLIENTES c on c.id_cliente = cu.id_cliente
	where activo = 1
	group by apellido + ' ' + nombre
	having SUM((
	case 
	WHEN id_tipo_cuenta = 2 THEN saldo * 144
	ELSE saldo
	END)) >= @monto
GO
CREATE PROCEDURE SP_CLIENTES_CON_ME
AS
select  apellido + ' ' + nombre 'Cliente', saldo 'Total'
	from T_CLIENTES c
	join T_CUENTAS cu on c.id_cliente = cu.id_cliente
	where id_tipo_cuenta = 2

--select * from T_CUENTAS order by id_cliente
--select * from T_CUENTAS order by id_cliente

--select apellido + ' ' + nombre 'Cliente',SUM((
--	case 
--	WHEN id_tipo_cuenta = 2 THEN saldo * 144
--	ELSE saldo
--	END)) 'Total'
--	from t_cuentas cu
--	join T_CLIENTES c on c.id_cliente = cu.id_cliente
--	group by apellido + ' ' + nombre


--use master
--go
--drop database clientes_banco

