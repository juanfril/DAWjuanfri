#!/bin/bash
 
declare dir
 
if [[ $# -lt 1 ]]
then
    read -r -p "Ruta al directorio: " dir
else
    dir="$1"
fi

if [[ ! -d $dir ]]
then
    echo "ERROR: No es un directorio válido" 1>&2
    exit 1
fi

declare -i numDir=$(ls -l "$dir" | egrep "^d" | wc -l)
declare -i numFile=$(ls -l "$dir" | egrep "^-" | wc -l)

echo "El directorio tiene $numDir subdirectorios y $numFile archivos"
exit 0



