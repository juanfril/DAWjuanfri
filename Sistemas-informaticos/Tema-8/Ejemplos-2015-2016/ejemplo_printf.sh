#!/bin/bash

nombres=("Producto 1" "Producto con nombre muy largo" "Otro producto")
precios=("233,32" "14,234" "1253")
unidades=(4 7 12)

printf "%-20s %-9s %-8s\n" "Nombre" "Precio U." "Unidades"
for((i=0;i<${#nombres[@]};i++))
do
  printf "%-20.20s %8.2f€ %8d\n" "${nombres[$i]}" "${precios[$i]}" "${unidades[$i]}" 
done

exit 0

