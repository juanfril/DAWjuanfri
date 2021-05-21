#!/bin/bash

if [[ $# -lt 1 || ! $1 =~ ^[0-9]+$ ]]
then
  echo "Falta el primer parámetro o no es un número"
  exit 1
fi

echo "El programa continuaría..."
