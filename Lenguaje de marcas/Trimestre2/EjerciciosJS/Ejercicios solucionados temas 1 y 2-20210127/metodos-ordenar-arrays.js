'use strict';

/* let numeros = [8, 15, 1, 7, 6];

function compare(a, b){
    return a - b;
}

console.log(`Array sin ordenar: ${numeros.join(', ')}`);
console.log(`Array ordenado como string: ${numeros.sort().join(', ')}`);
console.log(`Ordenando el array con función extra: ${numeros.sort(compare).join(', ')}`); */

/* una función dentro de los valores

let numbers = [8, 15, 1, 7, 6];

numbers.sort(function(a, b) {
  return a - b;
});

console.log(numbers); */

/* función anónima

let numbers = [ 8, 15, 1, 7, 6 ];
numbers.sort(function(a,b){return a - b});

console.log(numbers);*/

/* función flecha

var numbers = [ 40, 1, 5, 200 ];
numbers.sort((a,b)=>a-b);
console.log(numbers); */

/*ordenar items con caracteres no ASCII

let items = ['réservé', 'premier', 'cliché', 'communiqué', 'café', 'adieu'];
items.sort(function (a, b) {
  return a.localeCompare(b);
});*/
