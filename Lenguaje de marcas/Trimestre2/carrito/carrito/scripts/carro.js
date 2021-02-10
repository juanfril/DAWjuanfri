'use strict';

(function(){
    let copia = document.getElementById('i1').cloneNode(true);
    //copia.setAttribute('id', 'c' + copia.id)
    copia.id = 'c' + copia.id;
    console.log(copia);
    copia.style.display = 'none';
    copia.style.cursor = 'default';

    let enlaceBorrado = document.createElement('a');
    enlaceBorrado.setAttribute('href', '#');
    enlaceBorrado.setAttribute('class', 'delete');
    console.log(enlaceBorrado);
    copia.appendChild(enlaceBorrado);
})();