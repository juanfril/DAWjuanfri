#!/bin/bash

declare palabra=""
declare traduccion

while [[ $palabra != "q" ]]
do
    read -r -p "Dime una palabra (q para salir): " palabra
    if [[ $palabra != "q" ]]
    then
        traduccion=$(cat traducciones.txt | grep "$palabra;" | cut -d ";" -f 2)
        
        if [[ $traduccion ]]
        then
            echo "'$palabra' en inglés es '$traduccion'"
        else
            echo "Traducción no encontrada"
        fi
    fi
done
