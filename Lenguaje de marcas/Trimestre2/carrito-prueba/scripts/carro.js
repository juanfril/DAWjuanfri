'use strict';

(function(){
    //Ejercicio 1
    //1
    let color = Array.from(document.getElementsByClassName('item'));
    for (const key of color) {
        key.style.background = '#cecece';   
    }

    //2
    let borderCards = document.getElementById('cart_items');
    borderCards.style.border = '4px solid black';

    //3
    let borderImages = Array.from(document.getElementsByTagName('img'));
    borderImages.forEach(nodo => {
        nodo.style.border = '1px solid blue';
    });    

    //4
    let subraya = document.querySelectorAll('.item label');
    subraya.forEach(nodo => {
        nodo.style.textDecoration = 'underline';
    });

    //5
    let botonesRojos = document.querySelectorAll('#cart_container button');
    botonesRojos.forEach(nodo => {
        nodo.style.color = 'red';
    });

    /*6 Pon la fuente de color blanco (color:white) a todos los <label> que estén adyacentes a otro
    <label> y estén dentro de un elemento de la clase item.*/
    let precioBlanco = document.querySelectorAll('.item label + label');
    precioBlanco.forEach(nodo => {
        nodo.style.color = 'white';
    });

    //7 Pon el fondo de color amarillo a todos los <div> que estén vacíos.
    let fondoAmarillo = document.querySelectorAll('div:empty');
    fondoAmarillo.forEach(nodo => {
        nodo.style.backgroundColor = 'yellow';
    });

    //8 Pon el fondo de color rojo al primer y último elemento de la clase item. Se podría con una línea?
    let fondoRojo1 = document.querySelector('.item:first-child');
    fondoRojo1.style.backgroundColor = 'red';

    let fondoRojo2 = document.querySelector('.item:last-child');
    fondoRojo2.style.backgroundColor = 'red';

    //9 Pon el borde de color verde (border-color:green) a las imágenes de camisetas.
    let camisetasBorde = document.querySelectorAll('img[src*="camiseta"]');
    camisetasBorde.forEach(nodo => {
        nodo.style.border = '1px solid green';
    });

    //10 Pon la fuente de color verde (color:green) a todos los <input> de la página
    let inputVerde = document.querySelectorAll('input');
    inputVerde.forEach(nodo => {
        nodo.style.color = 'green';
    });

    /*11 COMPLICADO: Pon la fuente de color verde (color:green) a todos los elementos que
    contengan en el texto el símbolo €*/
    let euroVerde = document.querySelectorAll('label');
    console.log(euroVerde);
    euroVerde.forEach(node => {
        if(node.includes('€'))
            node.style.color = 'green';
    });

})();