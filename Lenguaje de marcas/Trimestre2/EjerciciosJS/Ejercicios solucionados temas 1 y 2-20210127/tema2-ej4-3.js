'use strict';

function sustituyeTexto(texto, textoASustituir, textoSustitucion) {
    return texto.replace(textoASustituir, textoSustitucion);
}

console.log(sustituyeTexto("Me gustan los perros", "perros", "gatos"));