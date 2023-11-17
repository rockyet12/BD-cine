##Primera actividad
delimiter $$
drop procedure if exists altaProyeccion $$
create procedure altaProyeccion(unidsala smallint unsigned, unidpelicula smallint unsigned,unfecha_hora datetime)
begin

insert into Proyeccion( idsala,idpelicula,fecha_hora)
values(unidsala,unidpelicula, unfecha_hora);

end $$

delimiter $
drop procedure if exists altaPelicula $
create procedure altaPelicula( unidgenero char(15), unnombre varchar(45), unlanzamiento date)
begin

insert into Pelicula(idgenero,  nombre, lanzamiento)
values(unidgenero,unnombre,unlanzamiento);

end $

delimiter $
drop procedure if exists altaGenero $
create procedure altaGenero(unnombre varchar(20))
begin

insert into Genero (nombre)
values(unnombre);

end $

delimiter $
drop procedure if exists altaSala $
create procedure altaSala( unpiso tinyint unsigned, uncapacidad smallint unsigned )
begin

insert into Sala(piso,capacidad)
values(unpiso,uncapacidad);

end $

#Se pide hacer el SP ‘registrarCliente’ que reciba los datos del cliente.
#Es importante guardar encriptada la contraseña del cliente usando SHA256.
delimiter $
drop procedure if exists altaregistrarCliente$
create procedure altaregistrarCliente( unnombre varchar(15), unapellido varchar(20),unemail varchar(30), uncontra char(64) )
begin

insert into Cliente(nombre, apellido,email,contra)
values(unnombre,unapellido,unemail,sha1(uncontra));

end $

 
 #Primera actividad.
 
 #Se pide hacer los SP para dar de alta todas las entidades (menos Entrada y Cliente) con el prefijo ‘alta’.

delimiter !

drop procedure if exists altaSala !
create procedure altaSala( unpiso smallint unsigned,uncapacidad smallint unsigned)
begin

insert into Sala(piso,capacidad)
values(unpiso,uncapacidad );
 
end !

delimiter !
drop procedure if exists altaGenero !
create procedure altaGenero(unnombre char(20))

begin

insert into Genero(nombre)
values(unnombre);

end !

delimiter !
drop procedure if exists altaPelicula !
create procedure altaPelicula( unidgenero tinyint unsigned, unnombre varchar(45), unlanzamiento date)
begin

insert into Pelicula( idgenero, nombre, lanzamiento)
values( unidgenero, unnombre, unlanzamiento);

end !

delimiter !
 drop procedure if exists altaProyeccion !
 create procedure altaProyeccion (unidsala int, unidpelicula smallint unsigned, unfechahora datetime)
 begin
 
 insert into Proyeccion(idsala,idpelicula,fechahora)
values (unidsala,unidpelicula,unfechahora);
       
 end !

#Se pide hacer el SP ‘registrarCliente’ que reciba los datos del cliente.
#Es importante guardar encriptada la contraseña del cliente usando SHA256.

delimiter !
drop procedure if exists altaregistrarCliente !
create procedure altaregistrarCliente (unnombre varchar(15), unapellido varchar(20), ungmail varchar(30), uncontra char(64))
begin

insert into Cliente(nombre, apellido , gmail, contra)
Values (unnombre, unapellido, ungmail, sha2(uncontra, 256));
 
end !


#Se pide hacer el SP ‘venderEntrada’ que reciba por parámetro el id de la función, valor e identificación del cliente.
#Pensar en cómo hacer para darle valores consecutivos desde 1 al número de entrada por función.


delimiter $
drop procedure if exists altavenderEntrada $
create procedure altavenderEntrada (unidproyeccion int,unidcliente int, unprecio decimal)
begin

declare entradasV int;
 
select count(idproyeccion)  into entradasV
from Entrada
where idproyeccion = unidproyeccion;

insert into Entrada(idproyeccion, idcliente, precio)
values (entradasV +1,unidproyeccion, unidcliente, unprecio);
       

end $

#Realizar el SP ‘top10’ que reciba por parámetro 2 fechas, el SP tiene que devolver identificador
#y nombre de la película y la cantidad de entradas vendidas para la misma entre las 2 fechas.
#Ordenar por cantidad de entradas de mayor a menor.

delimiter !

drop procedure  if exists top10 !
create procedure top10(unfechaInicio date,unfechaFin date )
begin

select count(identradas),nombre
from Pelicula
    natural join Proyeccion
    natural join Entrada
where  idpelicula = unidpelicula
and fechahora between unfechaInicio  and unfechaFin
limit 10;

end !

#Realizar el SF llamado ‘RecaudacionPara’ que reciba por parámetro un identificador de película y 2 fechas,
#la función tiene que retornar la recaudación de la película entre esas 2 fechas.
delimiter $
drop function if exists RecaudacionPara $
create function RecaudacionPara(unidpelicula int, unfechaC date, unfechaF date ) returns decimal reads sql data
begin

declare ganancia decimal;
select sum(e.precio) into ganancia
from entrada
natural join proyeccion pr
where entrada between fechaC and fechaF;
return ganancia;

end $
