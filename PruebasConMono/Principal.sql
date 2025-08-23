create database Negocio;

create table Principal 
(
	id int primary key,
	nombreProducto varchar(30),
	precioProducto decimal,
	informacionProducto varchar(60),
	categoriaProducto varchar(15),
	stock int,
	fechaIngreso date,
	fechaVencimiento date,
	imagen image,
	proveedor varchar(30)
);

select * from Principal where 1 = 0;

insert into Principal (id , precioProducto, informacionProducto, categoriaProducto, stock, fechaIngreso, fechaVencimiento, proveedor) values 
	(1, 2000, '', '', 10, '2025-01-25', '2025-12-30', 'Exito'),
	(2, 2000, '', '', 10, '2025-01-25', '2025-12-30', 'Exito'),
	(3, 2000, '', '', 10, '2025-01-25', '2025-12-30', 'Exito'),
	(4, 2000, '', '', 10, '2025-01-25', '2025-12-30', 'Exito'),
	(5, 2000, '', '', 10, '2025-01-25', '2025-12-30', 'Exito'),
	(6, 2000, '', '', 10, '2025-01-25', '2025-12-30', 'Exito')
