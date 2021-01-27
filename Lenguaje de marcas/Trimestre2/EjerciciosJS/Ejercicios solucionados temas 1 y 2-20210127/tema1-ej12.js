'use strict';

let nombre = prompt("Introduce nombre: ");
let nombreInverso = '';

for (let i = 0;i < nombre.length;i++) {
    nombreInverso += nombre[(nombre.length-1)-i];
}

console.log(nombreInverso);