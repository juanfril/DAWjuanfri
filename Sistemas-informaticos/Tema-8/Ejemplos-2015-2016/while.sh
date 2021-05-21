#!/bin/bash

var=1
while [[ $var -le 10 ]]
do
  echo "$var"
  let var++
done