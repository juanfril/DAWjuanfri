'use strict'

(function(){
    let copia = document.getElementById('i1').cloneNode(true);
    copia.id = 'c' + copia.id;
    //console.log(copia);

    copia.lastElementChild.style.display = 'none';
    copia.style.cursor = 'default';
   
    let enlaceBorrado = document.createElement('a');
    enlaceBorrado.href = '#';
    enlaceBorrado.setAttribute( 'class', 'delete');
    copia.insertBefore(enlaceBorrado, copia.children[0]); //insertar enlace en copia

    let carrito = document.getElementById('cart_items');
    carrito.insertBefore(copia, carrito.children[0]);
    //console.log(carrito);

    let stock = 10;
    let stockPrimerArticulo = document.querySelector('#i1').lastElementChild;
    stockPrimerArticulo.textContent = 'stock ' + (--stock);
    if(stock < 1)
        stockPrimerArticulo.setAttribute('class', 'agotado');

    let numeroCompras = document.getElementById('citem');
    //numeroCompras.setAttribute('value', '1');
    ++numeroCompras.value;

    let precio = 20 + ' €';
    let precioArticulo = document.querySelector('#i1 .price')
    console.log(precioArticulo);
    precioArticulo.textContent = precio;
    let totalCompra = document.getElementById('cprice');
    totalCompra.value = precio;
})();