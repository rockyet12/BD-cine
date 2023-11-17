-- Active: 1700154813921@@127.0.0.1@3306
 drop database if exists cine;
create database cine;
use cine;

create table Sala(

idsala int auto_increment,
piso tinyint unsigned,
capacidad smallint unsigned,

primary key (idsala)

);

create table Genero(

idgenero tinyint unsigned auto_increment,
nombre char(20),

primary key (idgenero)

);


create table Cliente(

idcliente smallint unsigned auto_increment,
nombre varchar(15),
apellido varchar(20),
gmail varchar(30),
contra char(64),

primary key (idcliente),
unique (contra)

);
 
 create table Pelicula(
 
 idpelicula smallint unsigned auto_increment,
 idgenero tinyint unsigned,
 nombre varchar(45),
 lanzamiento date,

 primary key (idpelicula),
 foreign key(idgenero)
 references Genero(idgenero),
 unique (nombre)
 
 );
 
create table Proyeccion(
 
idproyeccion int auto_increment,
idsala int,
idpelicula smallint unsigned,
fechahora datetime,

primary key (idproyeccion),
foreign key (idsala)
references Sala(idsala),
foreign key (idpelicula)
references Pelicula(idpelicula)

 );
 
create table Entrada(
 
identrada int auto_increment,
idproyeccion int,
idcliente smallint unsigned,
precio decimal(6,2),

primary key (identrada,idproyeccion),
foreign key(idproyeccion)
references Proyeccion(idproyeccion),
foreign key(idcliente)
references Cliente(idcliente)
);
