IF OBJECT_ID('PERSONAS') IS NOT NULL
	DROP TABLE PERSONAS

CREATE TABLE PERSONAS (
	Id int primary key,
	Nombre varchar(30),
	Apellido varchar(30),
	Genero varchar(10)
);

INSERT INTO PERSONAS (Id, Nombre, Apellido, Genero) VALUES
	(123, 'Juan', 'Vallejo', 'Masculino'),
	(124, 'Maria', 'Mejia', 'Femenino'),
	(125, 'Pedro', 'Zuluaga', 'Masculino');

SELECT * FROM PERSONAS;

INSERT INTO PERSONAS (Id, Nombre, Apellido, Genero) VALUES
	(126, 'Pedro', 'Zuluaga', 'Masculino');