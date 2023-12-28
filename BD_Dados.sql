-- Crear una base de datos llamada "BD_Dados"
CREATE DATABASE BD_Dados;
GO
IF EXISTS (SELECT 1 FROM sys.databases WHERE name = 'BD_Dados')
BEGIN  
    DROP DATABASE BD_Dados;
END
-- Utilizar la base de datos recién creada
USE BD_Dados;
GO

-- Crear una tabla llamada "usuario" con sus atributos
CREATE TABLE Usuario (
    id INT identity(1,1) PRIMARY KEY,
    nombre VARCHAR (50),
	puntaje INT
);
GO

-- Agregar una tabla para representar los lanzamientos
CREATE TABLE Lanzamiento (
    id INT IDENTITY(1,1) PRIMARY KEY,
    fechaLanzamiento DATETIME,
    usuarioId INT,
    FOREIGN KEY (usuarioId) REFERENCES Usuario(id)
);
GO

-- Agregar una tabla para representar los tipos de dados disponibles
CREATE TABLE TipoDado (
    id INT IDENTITY(1,1) PRIMARY KEY,
    nombre VARCHAR(50) UNIQUE
);
go

CREATE TABLE Dado (
	id INT identity(1,1) PRIMARY KEY,
	nombre VARCHAR (50),
    numeroCaras INT,
	caraObtenida INT,
	lanzamientoId INT,
	tipoDadoId INT,
	FOREIGN KEY (lanzamientoId) REFERENCES Lanzamiento(id),
	FOREIGN KEY (tipoDadoId) REFERENCES TipoDado(id)
);
go
-- Insertar algunos tipos de dados predefinidos
INSERT INTO TipoDado (nombre) VALUES ('normal'), ('octaedro'), ('decaedro'), ('dodecaedro');
go

SELECT * FROM TipoDado
go
--------------------------MOSTRAR USUARIOS
create proc MostrarUsuarios
as
select * from usuario
go

--------------------------MOSTRAR DIRECCIONES ÍP
create proc MostrarDireccionesIP
as
select * from listaIP
go
--------------------------INSERTAR 
create proc InsertarUsuario
@status VARCHAR(20),
@fecha DATE,
@nombre VARCHAR(50),
@direccion VARCHAR(100),
@departamento VARCHAR(50),
@telefono INT
as
insert into usuario values (@status,@fecha,@nombre,@direccion,@departamento,@telefono)
go
------------------------ELIMINAR
create proc EliminarUsuario
@id_eliminar int
as
delete from usuario where int_id=@id_eliminar
go
------------------EDITAR Usuario
create proc EditarUsuario

@id int,
@status VARCHAR(40),
@fecha DATE,
@nombre VARCHAR(40),
@direccion VARCHAR(40),
@departamento VARCHAR(40),
@telefono INT

as
update usuario set 

str_status=@status,
dat_fecha=@fecha,
str_nombre=@nombre,
str_direccion=@direccion,
str_departamento=@departamento,
int_telefono=@telefono

where int_id=@id
go

CREATE TABLE listaIP (
    str_ip VARCHAR (50) PRIMARY KEY
);

select * from listaIP
