# A partir del archivo letras.txt cuenta las veces que aparece cada letra y muestra el resultado ordeando alfabéticamente
# Aquí se practica el array asociativo (cada posición es una letra).
BEGIN { FS="," }
{
    for(i = 1; i <= NF; i++ ) {
        if($i in a == 0) {
            a[$i] = 0
        }
        
        a[$i]++
    }
}
END {
    asorti(a,orderedIndex)
    for(i in orderedIndex) {
        print orderedIndex[i],"=",a[orderedIndex[i]]
    }
}
