Create DataBase AgendaElectronica
Use AgendaElectronica

drop table Contactos
Create Table Contactos (nombre varchar(50), apellido varchar(50), correo varchar(50),telefono bigint, celular bigint primary key, nota varchar(50), foto image)
insert into Contactos (nombre,apellido,telefono,celular) values ('Michael','Mora',5555555,3138963828)
insert into Contactos (nombre,celular) values ('Michael',3138963827)
select * from Contactos

insert into Contactos (nombre) values ('Alex') from celular = 3138963828

/* Procedimieto agredar contacto*/
drop procedure ae_Insertar_Contacto

Create Procedure ae_Insertar_Contacto 
@nombre varchar(50), 
@apellido varchar(50), 
@correo varchar(50),
@telefono bigint, 
@celular bigint,
@nota varchar(50),
@foto image
as
Insert Into Contactos (
nombre, 
apellido, 
correo,
telefono, 
celular,
nota,
foto) values (
@nombre, 
@apellido, 
@correo,
@telefono, 
@celular,
@nota,
@foto)

exec ae_Insertar_Contacto 'Alex','Daza','alex.',1111111, 31323442735, 'esto es una nota' 


drop procedure ae_Borrar_Contacto
/* Procedimieto borrar contacto*/
Create Procedure ae_Borrar_Contacto
@nombre varchar(50),
@celular bigint 
as
delete from Contactos where celular = @celular

drop procedure ae_Actualizar_Contacto
/*Procedimiento actualizar contacto*/
Create Procedure ae_Actualizar_Contacto
@nombre varchar(50), 
@apellido varchar(50), 
@correo varchar(50),
@telefono bigint, 
@nota varchar(50),
@foto image,
@celular bigint

as
update Contactos set nombre = @nombre, apellido = @apellido, correo = @correo, 
telefono = @telefono, nota = @nota, foto = @foto where celular = @celular

exec ae_Actualizar_Contacto 'Alex', 'Mora', 'lucky', 123, 'Esto es una nota', 'a', 1111111111 
select * from Contactos