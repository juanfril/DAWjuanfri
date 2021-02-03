class Persona{

    constructor(nombre, apellido, edad){
        this.nombre = nombre
        this.apellido = apellido
        this.edad = edad

        this.datos = `Me llamo ${nombre} ${apellido} y tengo ${edad} años`
    }
    saludar(){
        return console.log(`Hola, me llamo ${this.nombre} ${this.apellido} y tengo ${this.edad} años`)
    }
}

const juan = new Persona('Juan Fco', 'Losa Márquez', 39);
const cristina = new Persona('Cristina', 'Narro Ibernón', 37);

//console.log(juan.saludar()); al ponerle a la función console.log, ya no hace falta ponerlo
juan.saludar();
console.log(juan.datos);
cristina.saludar();
console.log(cristina.datos);
