'use strict';

let nombre = prompt("Introduce nombre: ");
let nombreInverso = '';

for (let letra of nombre) {
    nombreInverso = letra + nombreInverso;
}

console.log(nombreInverso);