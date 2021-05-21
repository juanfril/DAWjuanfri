#!/bin/bash

echo "Número de parámetros: $#"
echo "Parámetros recibidos: $@"

for((i=1;$i<=$#;i++))
do
  echo "Parámetro $i: ${!i}"
done