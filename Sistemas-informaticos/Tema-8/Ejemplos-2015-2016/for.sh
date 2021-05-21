#!/bin/bash

for ((i=0; $i < 10; i++))
do
  echo "$((i+1))"
done

echo "--------------------"

for num in $(seq 1 1.5 10)
do
  echo $num
done