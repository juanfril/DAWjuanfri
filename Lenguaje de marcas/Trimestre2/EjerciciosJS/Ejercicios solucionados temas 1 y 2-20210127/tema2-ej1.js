'use strict';

function calculaPrecioProducto(
    nombre="Producto genérico", precio=100, impuesto=21
) {
    nombre = String(nombre);
    precio = Number(precio);
    impuesto = Number(impuesto);

    if (isNaN(precio) === true || isNaN(impuesto))
        console.log("El precio y/o el impuesto no son válidos");
    else {
        console.log("Nombre producto: " + nombre + " " + (precio*(1+(impuesto/100))));
    }
}

calculaPrecioProducto();
calculaPrecioProducto('Pelota');
calculaPrecioProducto('cochecito', 10);
calculaPrecioProducto('muñeca', 12, 10);
calculaPrecioProducto('Camión', 'hola');
calculaPrecioProducto('Camión', 15, 'hola');