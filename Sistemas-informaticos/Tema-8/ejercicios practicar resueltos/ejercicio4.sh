#!/bin/bash

PREFIJO="192.168.1."

for ip in ${PREFIJO}{1..254}
do
    linea=$(ping -c 1 -W 1 $ip | grep "1 received")
    if [[ $linea ]]
    then
        echo "$ip está activo"
    else
        echo "$ip no responde"
    fi
done
