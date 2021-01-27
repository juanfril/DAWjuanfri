'use strict';

/**
 * Igual que notas 1, pero pidiendo si quieres introducir otra nota antes de salir
 */

let respuesta;

do {
    let nota = Number(prompt("Introduzca la nota: "));

    if (isNaN(nota) === true || nota < 0 || nota > 10)
        console.log("La nota tiene que ser un número entre 0 y 10");
    else {
        if (nota < 5)
            console.log('suspendido');
        else
            console.log("Aprobado");
    }

    respuesta = confirm("¿Quieres introducir otra nota?");
} while(respuesta === true);

console.log("Adios...");