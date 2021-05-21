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

filas=$(tput lines)
cols=$(tput cols)

colores=($On_Black $On_Blue $On_Red $On_Green $On_Purple $On_Yellow $On_Cyan $On_White)

while ((1))
do
  
  echo -e -n "\033[1;1f"
  for ((i=1; $i <= $filas; i++))
  do
    for ((j=1; $j <= $cols; j++))
    do
      ((colAct=$RANDOM%${#colores[@]}))
      echo -e -n "${colores[colAct]} "
    done
  done
  sleep 0.2
done