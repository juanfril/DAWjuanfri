#!/bin/bash

# if [[ $1 ]]
# then 
#   edad=$1
# else
#   read -p "Dime tu edad: " edad
# fi

[[ $1 ]] && edad=$1 || read -p "Dime tu edad: " edad

if [[ $edad -lt 18 ]]
then
  echo "Eres menor de edad"
else
  echo "Eres mayor de edad"
fi