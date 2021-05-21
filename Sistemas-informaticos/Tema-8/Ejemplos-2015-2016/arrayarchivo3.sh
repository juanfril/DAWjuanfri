#!/bin/bash

total=0
set -f; OLDIFS=$IFS; IFS=';'
while read nombre precio
do
   echo "$nombre -> ${precio}€"
   ((total+=precio))
done < "productos.txt"
set +f; IFS=$OLDIFS;

echo "Total: ${total}€"