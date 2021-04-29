BEGIN{
  FS = ";"
  meses = 0
  cuota = 0
  interes_mes = 0
  print "   Nombre       Importe  Años   Cuota Mes       Total"
  print "-----------------------------------------------------"
}{
  interes_mes = ($4/12)/100
  meses = $3 * 12
  cuota = $2/((1-(1+interes_mes)^-meses)/interes_mes)
  printf "%9s %12d€ %5d %10.2f€ %10.2f€\n",
    $1, $2, $3, cuota, cuota*meses
}
