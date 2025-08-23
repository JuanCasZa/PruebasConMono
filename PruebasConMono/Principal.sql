create database Negocio;

create table Principal 
(
	id int primary key,
	nombreProducto varchar(30),
	precioProducto decimal,
	fechaIngreso date,
	imagen image,
);

select * from Principal where 1 = 0;

insert into Principal (id , nombreProducto, precioProducto, fechaIngreso) values 
	(1, 'a', 2000, '2025-01-25'),
	(2, 'b', 3000, '2025-02-25'),
	(3, 'c', 4000, '2025-03-25'),
	(4, 'd', 5000, '2025-04-25'),
	(5, 'e', 6000, '2025-05-25'),
	(6, 'f', 7000, '2025-06-25')

select * from Principal

insert into Principal (id , nombreProducto, precioProducto, fechaIngreso) values 
	(7, 'g', 8000, '2025-07-25'),
	(8, 'h', 9000, '2025-08-25'),
	(9, 'i', 10000, '2025-09-25'),
	(10, 'j', 11000, '2025-10-25')

drop table Principal;