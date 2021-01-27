alter table pedido drop foreign key cliente_cod;

alter table pedido add foreign key (cliente_cod)
references cliente (cliente_cod)
on delete cascade;