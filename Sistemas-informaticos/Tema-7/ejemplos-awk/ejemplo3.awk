# Mostrar datos con printf de forma simple
BEGIN {
    FS = ";"
    print "Producto           Cantidad   Precio U.  Total"
    print "----------------------------------------------"
}

{ printf "%s  %d  %.2f€ %.2f€\n", $3, $5, $4, $5*$4 }
