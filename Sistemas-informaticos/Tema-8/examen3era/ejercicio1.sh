#!/bin/bash

if [[ $1 =~ ^[a-z]+[a-z.]+[a-z]+.[a-z]{2,4}$ ]]
   then
      echo "El dominio es correcto";
   else
      echo "El dominio no es correcto";
   fi
