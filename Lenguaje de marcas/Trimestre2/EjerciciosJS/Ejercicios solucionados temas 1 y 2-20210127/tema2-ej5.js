'use strict';

let fecha = new Date();

let dia = fecha.getDate();
let mes = fecha.getMonth()+1;
let año = fecha.getFullYear();
let horas = fecha.getHours();
let minutos = fecha.getMinutes();
let segundos = fecha.getSeconds();

let strFecha = dia + '/' + mes + '/' + año + ' ' + horas + ':' + minutos + ':' + segundos;
console.log(strFecha);

let fechaLocal = fecha.toLocaleString('es-ES');
console.log(fechaLocal);
