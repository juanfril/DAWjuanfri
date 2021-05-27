#!/bin/bash

num=5
factor=1
echo "Resultado factorial:"
while [ $num -gt 1 ]
do
  factor=$((factor * num))  #factor = factor * num
  num=$((num - 1))  #num = num - 1
done
echo $factor
