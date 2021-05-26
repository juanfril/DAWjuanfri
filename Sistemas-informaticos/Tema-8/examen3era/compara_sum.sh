#!/bin/bash

lineas=($(cat numeros.txt | cut -d ';' -f1,2))

for linea in ${lineas[@]}
do
   num1= `echo $linea | cut -d ';' -f1`
   num2= `echo $linea | cut -d ';' -f2`
   if [[ $num1 -gt $num2 ]]
   then
      echo "${num1} es mayor que ${num2}"
   elif [[ $num1 -lt $num2 ]]
   then
      echo "${num1} es menor que ${num2}"
   else
      echo "${num1} y ${num2} son iguales"
   fi
done
