'use strict';

(function(){
    let copia = document.getElementById('i1').cloneNode(true);
    copia.id = 'c' + copia.id;
    console.log(copia);

    copia.lastElementChild.style.display = 'none';

    copia.style.cursor = 'default';
    console.log(copia);
    
    let enlaceBorrado = document.createElement('a');
    enlaceBorrado.href = '#';
    enlaceBorrado.setAttribute( 'class', 'delete');
    copia.insertBefore(enlaceBorrado, copia.children[0]);

    let carrito = document.getElementById('cart_items');
    carrito.insertBefore(copia, carrito.children[0]);
    console.log(carrito);
})();