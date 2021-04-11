# Ejemplo de funciones y arrays (no trabaja con ningún fichero)
# Intercambia las posiciones en un array
function swapPosArray(array,pos,pos2) {
    aux = array[pos]
    array[pos] = array[pos2]
    array[pos2] = aux
}
BEGIN {
    a[0] = 5
    a[1] = 12
    a[2] = 50
    a[3] = 13
    swapPosArray(a,0,3)
    for(i in a) {
        print a[i]
    }
}

    
