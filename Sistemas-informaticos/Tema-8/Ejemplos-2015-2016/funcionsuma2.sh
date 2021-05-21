#!/bin/bash

suma() {
  local n1="$1"
  local n2="$2"
  ((resultado=$1+$2))
}

suma 3 8
echo $n1 # No lo muestra. Local!
echo $n2 # No lo muestra. Local!
echo $resultado
