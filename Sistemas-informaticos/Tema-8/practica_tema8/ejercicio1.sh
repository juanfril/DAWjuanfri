#!/bin/bash

pausa()
{
   echo -e "Presiona una tecla para continuar"
   read
}

opcion=11

while ! [[ $opcion -eq 0 ]]
do
  clear

  cat<<END
 - Menu de mantenimiento de usuarios -
   _________________________________
    1. Mostrar usuarios del sistema
    2. Mostrar grupos del sistema
    3. Crear un usuario
    4. Crear un grupo
    5. Eliminar un usuario
    6. Eliminar un grupo
    7. Mostrar grupos primario y secundario de un usuario
    8. Mostrar usuarios de un grupo
    9. Mostrar registro actividad
    0. Salir
    
END
   
   read -p "Elija una opción: " opcion
   
   case $opcion in
      1)
         echo "Has elegido la opción 1"
         lineas=($(cat /etc/passwd | cut -d ':' -f1,3))
         for linea in ${lineas[@]}
         do
            usuario=`echo $linea | cut -d ':' -f1`
            id=`echo $linea | cut -d ':' -f2`
            if [[ $id -ge 1000 ]]
            then
               echo "${usuario} : ${id}"
            fi
         done
         pausa
         ;;
      2)
         echo "Has elegido la opción 2"
         echo "Has elegido la opción 1"
         lineas=($(cat /etc/group | cut -d ':' -f1,3))
         for linea in ${lineas[@]}
         do
            grupo=`echo $linea | cut -d ':' -f1`
            id=`echo $linea | cut -d ':' -f2`
            if [[ $id -ge 1000 ]]
            then
               echo "${grupo} : ${id}"
            fi
         done
         pausa
         ;;
      3)
         echo "Has elegido la opción 3"
	 read -p "Nombre del usuario a crear: " usuario
	 sudo adduser $usuario
         ;;
      4)
         echo "Has elegido la opción 4"
 	 read -p "Nombre del grupo a crear: " grupo
	 sudo addgroup $grupo
	 pausa
         ;;
      5)
         echo "Has elegido la opción 5"
	 read -p "Nombre del usuario a eliminar: " usuario
	 sudo deluser $usuario
	 pausa
         ;;
      6)
         echo "Has elegido la opción 6"
	 read -p "Nombre del grupo a eliminar: " grupo
	 sudo delgroup $group
	 pausa
         ;;
      7)
         echo "Has elegido la opción 7"
	 read -p "Indique el usuario: " usuario
	 usuarioGroups=(`groups $usuario 2> /dev/null | cut -d ':' -f2`)
	 if [ -z $usuarioGroups ]
	 then
	    echo "El usuario no existe"
	 else
	    echo "Los grupos del usuario son ${usuarioGroups[*]}"
	 fi
	 pausa
         ;;
      8)
         echo "Has elegido la opción 8"
	 read -p "Indique el grupo: " grupo
	 
	 grupoTemp=`cat /etc/group | grep -w ^$grupo | cut -d ':' -f1`
	 usuarioTemp=`cat /etc/passwd | grep -w ^$grupo | cut -d ':' -f1`
	 if ! [ -z $grupotemp ]
	 then
	    echo "$grupo no existe"
	 elif [ -z $usuarioTemp ]
	 then
	    usuarios=`cat /etc/group | grep -w ^$grupo | cut -d ':' -f4`
	    if ! [ -z $usuarios ]
	    then
	       echo "No hay usuarios de ese grupo $grupo"
	    fi
	 elif [ $grupoTemp = $usuarioTemp ]
	 then
	    usuarios=`cat /etc/passwd | grep -w ^$grupo | cut -d ':' -f4`
	    echo "Los usuarios del grupo $grupo son: $usuarioTemp $usuarios"
	 fi
	 pausa
         ;;
      9)
         echo "Has elegido la opción 9"
         echo "Usuario a controlar"
	 read usuario
	 numeroProcesos=(`ps -u $usuario | wc -l`)
	 (( numeroProcesos-- ));
 	 numeroFicheros=(`find/home/$usuario -type f 2>/dev/null | wc -l`)
	 echo "$usuario `date+"%Y-%m-%d"` $numeroProcesos 	 $numeroFicheros" >> /var/log/actividadUsuarios
         pausa
         ;;
      0)
         echo "Hasta la próxima"
         ;;
      *)
         echo -e "Opción no válida\nPresiona una tecla para continuar"
         read
         ;;
      esac
done
