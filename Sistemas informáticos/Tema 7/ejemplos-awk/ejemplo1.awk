# A partir de pedido.txt, imprime por pantalla el precio total de 
# los productos que pertenecen a la categoría Componentes
BEGIN {
    FS = ";"
    total = 0
}

$2 ~ /Componentes/ {
    total += $4 * $5
}

END {
    print "Precio total categoría 'componentes': " total "€"
}
