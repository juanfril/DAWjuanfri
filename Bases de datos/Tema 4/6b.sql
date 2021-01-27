create view enfermos_no_ingresados
as select * from enfermo e
where e.inscripción 
not in (select inscripcion from ingresos);

select * from enfermos_no_ingresados;