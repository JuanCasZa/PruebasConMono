IF OBJECT_ID('PERSONAS') IS NOT NULL
	DROP TABLE PERSONAS

CREATE TABLE PERSONAS (
	Id int primary key,
	Nombre varchar(30),
	Apellido varchar(30),
	Genero varchar(10)
);