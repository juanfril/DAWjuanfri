function accion(){
    console.log('Está funcionando mi boton');
    var ancla = document.getElementsByClassName('navEnlace');
    for(var i = 0; i < ancla.length; i++){
        ancla[i].classList.toggle('desaparece');
    }
}
const mascota = {
    nombre: 'Tom',
    edad: 10,
    vivo: true
}
console.log(mascota)