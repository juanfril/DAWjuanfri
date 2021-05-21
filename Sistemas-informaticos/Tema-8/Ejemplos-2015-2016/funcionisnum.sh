#!/bin/bash

isNum() {
  [[ ! $1 ]] && return 1 # False!!
  [[ $1 =~ ^[0-9]+$ ]] # Depende de como se evalúe
}

read -p "Dime un número: " num
if isNum "$num"
then
  echo "$num es un número"
else
  echo "No es un número!"
fi

