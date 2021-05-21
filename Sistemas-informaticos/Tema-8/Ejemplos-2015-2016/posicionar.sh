#!/bin/bash

Color_Off='\e[0m'
On_Black='\e[40m'
On_Red='\e[41m'
On_Green='\e[42m'
On_Yellow='\e[43m'
On_Blue='\e[44m'
On_Purple='\e[45m'
On_Cyan='\e[46m'
On_White='\e[47m'

colores=($On_Blue $On_Red $On_Green $On_Purple)
colAct=1

filas=$(tput lines)
cols=$(tput cols)

if (( filas < 12 ))
then
  echo "La consola es demasiado pequeña"
  exit 1
fi

clear
echo -e "Tenemos $filas filas y $cols columnas."
echo -e -n "\033[3;1f"
letra="p"
while [[ $letra != "q" ]]
do
  read -n 1 -s letra
  case $letra in
  a)
    echo -e -n "\033[1D${colores[colAct]} \033[1D"
    ;;
  w)
    echo -e -n "\033[1A${colores[colAct]} \033[1D"
    ;;
  s)
    echo -e -n "\033[1B${colores[colAct]} \033[1D"
    ;;
  d)
    echo -e -n "\033[1C${colores[colAct]} \033[1D"
    ;;
  1) colAct=0;;  
  2) colAct=1;;
  3) colAct=2;;
  4) colAct=3;;
  c)
    echo -e -n "\033[1;1f${colores[colAct]}"
    for ((i=1; $i <= $filas; i++))
    do
      for ((j=1; $j <= $cols; j++))
      do
	echo -n " "
      done
    done
    echo -e -n "\033[1;1f"
    ;;
  esac
done
echo -e "$Color_Off"

