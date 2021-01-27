'use strict';

let tasaConversion=-1;

console.log("Tipos de conversión:")
console.log("1. Euro - dolar");
console.log("2. Euro - Libra");
console.log("3. Euro - Yen");

let tipoConversion = prompt("Introduce el tipo de conversión:");

switch(tipoConversion) {
    case "1":
        tasaConversion = 1.1;
        break;
    case "2":
        tasaConversion = 0.8;
        break;
    case "3":
        tasaConversion = 0.7;
        break;
    default:
        console.log("El tipo de conversión va de 1 a 3");
}

if (tasaConversion !== -1) {
    let importe = Number(prompt("Introduzca el importe"));
    if (isNaN(importe)) {
        console.log("El importe tiene que ser un número");
    }
    else {
        console.log("Resultado: " + (importe * tasaConversion));
    }
}
    