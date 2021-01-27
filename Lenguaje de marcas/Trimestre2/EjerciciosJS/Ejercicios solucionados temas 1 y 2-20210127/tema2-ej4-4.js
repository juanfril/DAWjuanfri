'use strict';

function cambiaExtension(nombreFichero) {
    let fichero = nombreFichero.substring(0, nombreFichero.indexOf("."));
    return fichero + ".bak";
}

console.log(cambiaExtension("imagen.jpg"));