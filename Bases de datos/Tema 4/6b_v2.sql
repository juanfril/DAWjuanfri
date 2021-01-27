<<<<<<< HEAD
create view enfermos_no_ingresados
as select * from enfermo e
where e.inscripción 
not in (select inscripcion from ingresos);

select * from enfermos_no_ingresados;
=======
/*b) Diseñar una vista de nombre enfermos_no_ingresados que muestre los enfermos
del sistema hospitalario no ingresados en la actualidad.*/

>>>>>>> 1861402f8d65d34aa88946de0b27c1681371a331
