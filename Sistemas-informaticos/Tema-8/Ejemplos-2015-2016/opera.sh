#!/bin/bash

read -p "Primer número: " n1
read -p "Segundo número: " n2

read -p "Operación (sumar/restar): " op

if [[ $op = "sumar" ]]
then
	echo "Resultado: $(expr $n1 + $n2)"
elif [[ $op = "restar" ]]
then
	echo "Resultado: $(expr $n1 - $n2)"
else
	echo "Operación incorrecta"
fi
