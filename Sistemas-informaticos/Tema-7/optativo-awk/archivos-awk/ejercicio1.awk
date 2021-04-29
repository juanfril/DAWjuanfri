BEGIN{
  FILENAME = "movimientos.txt"
  FS = ";"
  cuenta = 0
  intereses = 0
}{
  if ($2 ~ /INGRESO/){
    cuenta = cuenta + $3
    print $1" -> "$2" de "$3". Saldo: "cuenta"€"
  }
  else if ($2 ~ /RETIRADA/){
    cuenta = cuenta - $3
    print $1" -> "$2" de "$3". Saldo: "cuenta"€"
  }
  else {
    intereses = cuenta * 0.025
    cuenta = cuenta + intereses
    print "Cobro de intereses de "intereses"€ ("intereses"). Saldo: "cuenta"€"
  }
}
