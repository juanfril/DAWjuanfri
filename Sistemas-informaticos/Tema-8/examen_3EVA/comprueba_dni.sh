#!/bin/bash

letras="T R W A G M Y F P D X B N J Z S Q V H L C K E"

arr=($letras)
#echo ${1}-${arr[$n]}

lineas=`cat dnis.txt | cut -d ';' -f2`

for linea in ${lineas[@]}
do
  archivo=`echo ${linea: -1}`
  #echo "archivo $archivo"
  sinLetra=`echo $linea | sed 's/.$//g'`
  #echo "sinLetra $sinLetra"
  n=$(($sinLetra%23))
  #echo "n $n"
  correcta=`echo ${arr[$n]}`
  #echo "correcta $correcta"
     
   if [[ ${correcta} = ${archivo} ]]
   then
      echo "$linea es correcto"
   else
      echo "$linea no es correcta, debería ser $correcta"
   fi
done

