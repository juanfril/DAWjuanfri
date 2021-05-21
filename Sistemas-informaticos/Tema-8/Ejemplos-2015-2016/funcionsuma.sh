#!/bin/bash

suma() {
  echo "Resultado: $(($1 + $2))"
}

sumaTodo() {
  total=0
  for (( i=1;i<=$#;i++ ))
  do
    ((total+=${!i}))
  done
  
  echo "Resultado: $total"
}

suma 4 7
sumaTodo 3 5 6 8 4 8 5 8
