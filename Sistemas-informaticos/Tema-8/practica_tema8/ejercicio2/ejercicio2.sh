#!/bin/bash

resetColor='\e[0m'
rojo='\e[0;31m'
amarillo='\e[0;33m'
verde='\e[0;32m'

read -p "Introduzca un nombre de usuario: " nombre
pass=`cat usuarios.txt | grep $nombre | cut -d ';' -f2`

if [ -z $pass ]
then
   read -s -p "Nuevo usuario. Introduzca contraseña: " contrasenya
   printf "%s;%s\n" $nombre `echo "$contrasenya" | sha256sum | cut -d " " -f1` >> usuarios.txt
   touch "${nombre}.txt"
else
   intentos=3
   while [ $intentos -ge 0 ]
   do
      read -s -p "Contraseña: " comp
      comprobar=`echo "$comp" | sha256sum | cut -d " " -f1`
      if [ $comprobar = $pass ]
      then
      	   clear
      	   intentos=-1
   	   echo "Bienvenido $nombre"
      else
   	   echo "Contraseña incorrecta"
   	   (( intentos-- ))
   	   if [ $intentos -eq 0 ]
   	   then
   	      echo "Has agotado los intentos"
   	      exit
   	   fi
      fi
   done	
fi
opcion=""
while [[ $opcion != "salir" ]]
do
   total=0
   cuenta=0
   clear
   echo "Escribe un usuario a valorar"
   for usuario in `cat usuarios.txt | cut -d ';' -f1`
   do
     echo "$usuario"
   done
   echo "Escribe \"salir\" para salir"
   read opcion
   modificar=`cat usuarios.txt | grep $opcion | cut -d ';' -f1`
   if [ -z $modificar ]
   then
      echo "No se ha encontrado ningún usuario con ese nombre"
   else
      read -p "Introduzca puntuación(1-10): " puntuacion
      if [[ ($puntuacion -gt 10) || ($puntuacion -lt 0) ]]
      then
         echo "La puntuación debe ser entre 0 y 10"
      else
         echo "$nombre;$puntuacion;`date +%d/%m/%Y`" >> ${modificar}.txt
         echo "Valoración añadida correctamente"
         for t in `cat ${modificar}.txt`
	 do
	   nom=`echo $t | cut -d ';' -f1`
	   punt=`echo $t | cut -d ';' -f2`
	   fech=`echo $t | cut -d ';' -f3`
	   (( total= $total+$punt ))
	   (( cuenta++ ))
	   if [[ ($punt -ge 1 && $punt -le 3) ]]
	   then
	      echo -e "${rojo}${nom}: ${punt}(${fech})${resetColor}"
	   elif [[ ($punt -ge 4 && $punt -le 6) ]]
	   then
	      echo -e "${amarillo}${nom}: ${punt}(${fech})${resetColor}"
	   elif [[ ($punt -ge 7 && $punt -le 10) ]]
	   then
	      echo -e "${verde}${nom}: ${punt}(${fech})${resetColor}"
	   fi
	 done
	 media=$(echo "scale=2; $total/$cuenta" | bc)
	 echo "Media: $media" 
         echo "Presione una tecla para continuar"
      fi
   fi
   read
done
      
      
      
      
      
      
      
      
