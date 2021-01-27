'use strict';

let tipoConversion;
let importe;
let resultado
const conVersionEuro = 1.2;
const conVersionLibra = 0.8;
const conVersionYen = 1.5;
let tipoConversionOk, importeOk;

do {

    console.log("1. euro - dolar");
    console.log("2. euro - libra");
    console.log("3. euro - yen");

    do { 
        tipoConversion = Number(prompt("Selecciona el tipo de conversión: "));

        if (!isNaN(tipoConversion) && tipoConversion >= 1 && tipoConversion <= 3)
            tipoConversionOk = true;
        else
            tipoConversionOk = false;
    } while (tipoConversionOk === false);

    do {
        importe = Number(prompt("Introduce el importe: "));

        if (!isNaN(importe))
            importeOk = true;
        else
            importeOk = false;
    } while (importeOk === false);

    switch(tipoConversion) {
        case 1:
            resultado = importe * conVersionEuro;
            break;
        case 2:
            resultado = importe * conVersionLibra;
            break;
        case 3:
            resultado = importe * conVersionYen;
            break;
        default:
            resultado = -1;
            break;
    }

    console.log("Resultado: " + resultado);
} while(confirm("¿Quieres realizar otra conversión?") === true);
