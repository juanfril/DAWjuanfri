'use strict';

function existeEnArray(valor, array) {
    let posicion = -1;
    for (let i = 0;i < array.length && posicion === -1;i++) {
        if (array[i] === valor)
            posicion = i;
    }

    return posicion;
}

function sonPares(array) {
    let encontradoImpar = false;
    for (let i = 0;i < array.length && !encontradoImpar;i++) {
        if (array[i]%2 !== 0)
            encontradoImpar = true;
    }

    return !encontradoImpar;
}

function algunoPar(array) {
    let encontradoPar = false;
    for (let i = 0;i < array.length && !encontradoPar;i++) {
        if (array[i]%2 === 0)
            encontradoPar = true;
    }

    return encontradoPar;
}