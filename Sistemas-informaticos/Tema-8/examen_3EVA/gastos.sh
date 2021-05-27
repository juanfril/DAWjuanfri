#!/bin/bash

concepto=""
gasolina="gasolina"
comida="comida"
otros="otros"
salir="salir"
gasto_gasolina=()
gasto_cominda=()
gasto_otros=()

while [[ $concepto = $salir ]]
do
   read -p "Concepto: " concepto
   if [[ $concepto = $gasolina ]]
   then
      read -p "Gasto: " gasto
      if [[ $gasto =~ [0-9] ]]
         gasto=("$[gastos[@]}" Arch)
      else
         echo "Tiene que introducir un número"
      fi
      while [[ $gasto != $salir || 
               $gastos = $comida || $gastos = $otros ]]
      do
         read -p "Gasto: " gasto
         if [[ $gasto =~ [0-9] ]]
            gasto=("$[gastos[@]}" Arch)
         else
            echo "Tiene que introducir un número"
         fi
      done
   if [[ $concepto = $comida ]]
   then
      read -p "Gasto: " gasto
      if [[ $gasto =~ [0-9] ]]
            gasto=("$[gasto_comida[@]}" Arch)
         else
            echo "Tiene que introducir un número"
      fi
      while [[ $gasto != $salir || 
               $gastos = $gasolina || $gastos = $otros ]]
      do
         read -p "Gasto: " gasto
         if [[ $gasto =~ [0-9] ]]
            gasto=("$[gasto_comida[@]}" Arch)
         else
            echo "Tiene que introducir un número"
         fi
      done
     if [[ $concepto = $otros ]]
   then
      read -p "Gasto: " gasto
      if [[ $gasto =~ [0-9] ]]
            gasto=("$[gasto_otros[@]}" Arch)
         else
            echo "Tiene que introducir un número"
      fi
      while [[ $gasto != $salir || 
               $gastos = $gasolina || $gastos = $comida ]]
      do
         read -p "Gasto: " gasto
         if [[ $gasto =~ [0-9] ]]
            gasto=("$[gasto_otros[@]}" Arch)
         else
            echo "Tiene que introducir un número"
         fi
      done
done

for i in "${gasto_gasolina[@]}"
do
    echo $i
done

for i in "${gasto_comida[@]}"
do
    echo $i
done

for i in "${gasto_otros[@]}"
do
    echo $i
done
# no me da tiempo a más :(
