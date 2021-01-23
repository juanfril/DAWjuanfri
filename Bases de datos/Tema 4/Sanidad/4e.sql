/*a) Dentro del esquema Empresa, diseñar una vista de nombre imp_glo_nom_dept que
muestre el importe global que cada departamento asume anualmente en concepto de
nómina de los empleados, y ordenado descendentemente por este importe.*/

create view imp_glo_nom_dept
as select sum(salario), dept_no from emp
where dept_no = dept_no;

#drop view imp_glo_nom_dept;