/*Aumentar el sueldo de todos los empleados sanitarios con los siguientes
porcentajes:
5% a todos los empleados del turno de mañana o tarde
7% a los empleados del turno de noche*/

SET SQL_SAFE_UPDATES = 0;
UPDATE plantilla SET salario = salario * 1.05 WHERE turno = 'M' or turno = 'T';
UPDATE plantilla SET salario = salario * 1.07 WHERE turno = 'N';
SET SQL_SAFE_UPDATES = 1;