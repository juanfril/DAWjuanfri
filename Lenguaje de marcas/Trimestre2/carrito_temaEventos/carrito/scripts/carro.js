'use strict';

(function(){
    //copiar artículo seleccionado
    function getCopia (articulo){
        let copia = document.getElementById(articulo).cloneNode(true);
        copia.id = 'c' + copia.id;
        copia.lastElementChild.style.display = 'none';
        copia.style.cursor = 'default';
    }
    //insertar el botón para sacar del carro
    function insertarEnlaceBorrado(copia){
        copia.id = 'c' + itemCopia.id;
        let enlaceBorrado = document.createElement('a');
        enlaceBorrado.href = '#';
        enlaceBorrado.setAttribute( 'class', 'delete');
        enlaceBorrado.onclick = borrarArticulosCarro;
        copia.insertBefore(enlaceBorrado, copia.children[0]);
    }
    //añadir articulos al carrito
    function insertarCarrito (copia){
        let carrito = document.getElementById('cart_items');
        carrito.insertBefore(copia, carrito.children[0]);
    }
    //obtener el numero del stock pasado a número
    function getStock(articulo){  
        let precioArticulo = articulo.querySelector('.stock');
        let arrayStock = precioArticulo.textContent.split(' ');
        return parseInt(arrayStock[1]);
    }

    let articulo = document.querySelector('#i1');
    console.log(articulo);
    let prueba = getStock(articulo);
    //console.log(getStock(articulo));
    console.log(`Si todo sale bien tendré %o`, prueba);

})();