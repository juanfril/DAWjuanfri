#!/bin/bash

echo -e "\e[0;37m\e[44mHola que tal?\e[0m"
echo "Yo estoy bien"

Color_Off='\e[0m'
Red='\e[0;31m'
Green='\e[0;32m'
Purple='\e[0;35m'
Blue='\e[0;34m'
colores=("$Red" "$Green" "$Purple" "$Blue")
for((i=0; i< 10; i++))
do
  ((pos=$RANDOM%${#colores[@]}))
  echo -e "${colores[$pos]}Hola mundo"
done
echo -e "$Color_Off"

