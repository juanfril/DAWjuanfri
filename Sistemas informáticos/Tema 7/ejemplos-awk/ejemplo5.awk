# Ejemplo de estructura condicional if
BEGIN { FS = ";" }
{
     if ($4 >= 100) {
         print "El producto "$3" es caro ("$4"€)"
     } else if ($4 >= 50) {
         print "El producto "$3" tiene un precio medio ("$4"€)"
     } else {
         print "El producto "$3" es barato ("$4"€)"
     }
}
