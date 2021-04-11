# Mostrar datos con printf con salida formateada (ancho fijo por cada campo)
BEGIN {
    FS = ";"
    print "Producto           Cantidad   Precio U.    Total"
    print "-------------------------------------------------"
}

{ printf "%-18s %8d %10.2f€ %8.2f€\n", $3, $5, $4, $5*$4 }
