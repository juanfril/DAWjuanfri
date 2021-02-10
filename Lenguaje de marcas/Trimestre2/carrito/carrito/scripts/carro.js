'use strict';

(function(){
    let copia = document.getElementById('i1').cloneNode(true);
    //copia.setAttribute('id', 'c' + copia.id)
    copia.id = 'c' + copia.id;
    copia.style.display = 'none';
    copia.style.cursor = 'default';
    console.log(copia);

    copia.appendChild()
    
    let enlaceBorrado = document.createElement('a');
    enlaceBorrado.href = '#';
    enlaceBorrado.setAttribute( 'class', 'delete');
    //copia.appendChild(enlaceBorrado);
    //elemento_padre.insertBefore(nuevo_nodo,nodo_de_referencia);
    //document.getElementById('padre').getElementsByTagName('p')[1];
    //let nodoPadre = document.getElementById('i1');
    let nodoReferencia = document.querySelector('#ci1 img');
    console.log(nodoReferencia);
    copia.insertBefore(enlaceBorrado, nodoReferencia);
})();