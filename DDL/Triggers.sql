#Segunda actividad

#Realizar un trigger que verifique que al momento de insertar una entrada, no sobrepase la cantidad de entradas vendidas
# para la capacidad de la sala correspondiente a la proyección,
# en ese caso no se debe permitir la operación y se tiene que mostrar la leyenda “Sala Llena”.

delimiter $
drop  trigger if exists CapacidadS $
create trigger CapacidadS  before insert on Entrada
for each row  
begin

declare cantidad_entradas int ;
declare Boletos int ;


select count(identrada) into cantidad_entradas
from Entrada
where idproyeccion = new.idproyeccion;


select s.capacidad  into  Boletos
from Proyeccion p
 natural join Sala  
where p.idproyeccion = new.idproyeccion;


if(capacidad = cantidad_entradas ) then
signal sqlstate '45000'
set message_text ="sala llena" ;
end if ;
 
end $

#Realizar un trigger para que cada vez que se da de alta una película nueva, se crea una proyección por cada sala
# y para la fecha y hora de creación.

delimiter $
drop trigger if exists Altas$
create  trigger Alta after insert on Pelicula
for each row
begin

insert into Proyeccion(idproyeccion,idsala,idpelicula ,fechahora)
select *, new.idpelicula, now()
from Sala
natural join Sala
where idpelicula = new.idpelicula;

end $ 
