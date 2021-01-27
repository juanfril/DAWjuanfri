create database aprendiendo;
use aprendiendo;
create table usuario(
id_usuario int unsigned primary key,
nombre varchar (50) not null unique,
fecha_renovacion date not null,
mes_caducidad tinyint (2) unsigned check ( mes_caducidad > 0 and mes_caducidad < 13),
anyo_caducidad year check ( anyo_caducidad > 2021),
genero enum ('M', 'F') not null,
tipo_usuario enum ('gratis', 'pago') not null default 'gratis');