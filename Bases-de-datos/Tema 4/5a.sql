#a) Que en eliminar un pedido, se eliminen todas las líneas de detalle del pedido.
alter table detalle drop foreign key ped_num;

alter table detalle add foreign key (ped_num)
references pedido (ped_num)
on delete cascade;