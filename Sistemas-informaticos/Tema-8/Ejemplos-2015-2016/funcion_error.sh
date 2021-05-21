#!/bin/bash

muestraError() {
  echo -e "\e[0;31m$1\e[0m" >&2
}

read -p "Dime un número positivo: " num
if (( $num < 0))
then
  muestraError "El número no es correcto."
else
  echo "OK"
fi
