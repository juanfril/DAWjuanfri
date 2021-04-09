# Ejemplo que cambia el separador de elementos y de línea en print (pedido.txt)
BEGIN {
    FS = ";" # Separador de campos en el fichero (pedido.txt)
    ORS = "\n--------\n" # Después de cada print se añadirá esto
    OFS = "-" # La coma añadirá un guion en print
}

{
    print "producto ",$3," Total: "($4 * $5)
}
