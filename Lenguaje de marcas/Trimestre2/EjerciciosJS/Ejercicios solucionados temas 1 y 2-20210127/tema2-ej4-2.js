'use strict';

function sustituyeCadenas(cadena, cadenaAEliminar) {
    cadena = cadena.toUpperCase();
    cadenaAEliminar = cadenaAEliminar.toUpperCase();
    let continuar = true;
    let resultado;
    do {
        resultado = cadena.replace(cadenaAEliminar, '');
        if (resultado === cadena)
            continuar = false;
        else
            cadena = resultado;
    }while (continuar === true);

    return resultado;
}

let resultado = sustituyeCadenas('Me gustan LOS perros', 'o');
console.log(resultado);