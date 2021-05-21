#!/bin/bash

 #echo "Menú de la aplicación"
 #echo -e "\t1.Opción 1"
 #echo -e "\t2.Opción 2"
 #echo -e "\t3.Opción 3"

num=32

cat<<END
Menú de la aplicación
  1. Opción 1
  2. Opción 2
  3. Opción 3
END
  
read -p "Elige una opción: " opcion
echo "Has elegido la opción $opcion"
