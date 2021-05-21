#!/bin/bash

while read linea
do
    if [[ $linea =~ ^[0-9]{2}/[0-9]{2}/[0-9]{4}$ ]] # Exp. reg. de la fecha
    then
        printf "Dia: %s, Mes: %s, Año: %s\n" "${linea:0:2}" "${linea:3:2}" "${linea:6}"
    else
        echo "La cadena '$linea' no es una fecha, y tiene una longitud de ${#linea} caracteres"
    fi
done < "fechas.txt"
