#!/bin/bash

set -f;OLDIFS=$IFS;IFS=$'\n'
lineas=($(cat productos.txt))
set +f;IFS=$OLDIFS

for linea in "${lineas[@]}"
do
  echo $linea
done
