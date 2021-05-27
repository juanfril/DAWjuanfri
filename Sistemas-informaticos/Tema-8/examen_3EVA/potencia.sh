#!/bin/bash

resultado=$1

if [[ $1 -eq 0 ]]
then
   echo resultado
elif [[ $2 -lt 0 ]]
then
   echo "El segundo parámetro debe ser positivo"
else
   for (( i=1; i<$2; i++ ))
   do
      resultado=$(($1*$resultado))
   done
fi

echo "$resultado"


