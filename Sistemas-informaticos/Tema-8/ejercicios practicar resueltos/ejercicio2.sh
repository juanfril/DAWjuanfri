#!/bin/bash

# Comprobamos que hemos recibido los 3 parámetros
if [[ $# -lt 3 ]]
then
  echo "$0: El programa necesita 3 parámetros." >&2
  exit 1
fi

#Otra forma de comprobar que recibe 3 parámetros 
[[ $# -lt 3 ]] && { echo "$0: El programa necesita 3 parámetros." >&2; exit 1; } 


# Otra forma de comprobar que los 3 parámetros son numéricos con un bucle (recomendado)
for param in "$@"
do
  if [[ ! $param =~ ^[0-9]+$ ]]
  then
    echo "$0: El parámetro '$param' no es numérico." >&2
    exit 1
  fi
done

# Mostramos la secuencia de números de $1 a $3, omitiendo $2
for (( i = $1; i <= $3; i++ ))
do
  if [[ $i -ne $2 ]]
  then
    printf "$i "
  fi
done

echo # Salto de línea para terminar

# Otra forma de hacer el mismo bucle para mostrar los números
for i in $(seq $1 $3)
do
  [[ $i -ne $2 ]] && printf "$i "
done

echo # Salto de línea para terminar

exit 0
