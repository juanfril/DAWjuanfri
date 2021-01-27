'use strict';
/**
 * Se pide una nota al usuario y se indica por consola si estás suspendido o aprobado
 */
let nota = Number(prompt("Introduzca la nota: "));

if (isNaN(nota) === true || nota < 0 || nota > 10)
    console.log("La nota tiene que ser un número entre 0 y 10");
else {
    if (nota < 5)
        console.log('suspendido');
    else
        console.log("Aprobado");
}