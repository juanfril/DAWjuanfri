#!/bin/bash

sort -fho decimales.txt decimales.txt

echo "El menor número es:"
echo "`head -n1 decimales.txt`"

echo "El mayor número es:"
echo "`tail -n1 decimales.txt`"

count=0;
total=0; 

for i in $( cat decimales.txt )
   do 
     total=$(echo $total+$i | bc )
     ((count++))
   done
echo "La media es de:"
echo "scale=2; $total / $count" | bc

