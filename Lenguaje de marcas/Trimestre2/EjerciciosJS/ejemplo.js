let letras = ['T', 'R', 'W', 'A', 'G', 'M', 'Y', 'F', 'P',
    'D', 'X', 'B', 'N', 'J', 'Z', 'S', 'Q', 'V', 'H', 'L',
    'C', 'K', 'E', 'T'];
let dni;
let letraComprobar;
let letraIntroducida;
dni = prompt('Introduzca DNI sin letra');
letraIntroducida = prompt('Introduzca la letra').toUpperCase();

if (dni > 10000000 && dni < 99999999){
    letraComprobar = dni % 23;
    letraComprobar = letras[letraComprobar];
}
else{
    console.log('Debe especificar un DNI válido');
}
if(letraComprobar == letraIntroducida){
    console.log('La letra introducida es correcta');
}
else{
    console.log('La letra introducida no es correcta');
}