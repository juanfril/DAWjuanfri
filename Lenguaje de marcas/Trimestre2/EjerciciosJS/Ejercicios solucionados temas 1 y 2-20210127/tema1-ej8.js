'use strict';

let radio = Math.floor(Math.random() * 50) + 1;
let diametro = 2 * radio;
let perimetro = 2 * Math.PI * radio;
let area = Math.PI * Math.pow(radio, 2);

console.log("radio: " + radio);
console.log("diametro: " + diametro);
console.log("perimetro: " + perimetro);
console.log("area: " + area);