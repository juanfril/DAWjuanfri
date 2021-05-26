#!/bin/bash
pausa(){
   echo -e "Presiona una tecla para continuar"
   read
}

mostrarMenu(){
   clear

  cat<<END
 - Menu de ayuda sobre comandos   -
   _________________________________
    1. Insertar comandos y descripcion
    2. Listar comandos existentes
    3. Buscar descripcion de un comando
    4. Borrar comando
    0. Salir
    
END
}

ordenarLista(){
   sort -fho comandos.txt comandos.txt
}

comprobarComando(){
   valor=0
   comando=`cat comandos.txt | grep ^$1 | cut -d ';' -f1`
   
   if [[ -z $comando ]]
   then
      return "El comando no existe"
   else
      return $comando
   fi
}

listarComandos(){
   cat comandos.txt | cut -d ';' -f1
}

buscarDescripcion(){
   desc=`cat comandos.txt | grep ^[$1] | cut -d ';' -f2`
   if [[ -z $desc ]]
   then
      return -1
   else
      return 1
   fi
}

borrarComando(){
   comando= comprobarComando $1
   if ! [[ -z $comando ]]
   then
      sed -i '/$1/ d' comandos.txt
   fi
}

if [[ -f comandos.txt ]]
then
   touch comandos.txt
fi
opcion=5

while ! [[ $opcion -eq 0 ]]
do
   mostrarMenu

   read -p "Elija una opción: " opcion
   
   case $opcion in
      1)
         ordenarLista
         read -p "Escriba el comando: " comando
         comando= comprobarComando $comando
         if [[ -z $comando ]]
         then
            echo "El comando ya existe"
         else
            read -p "Escriba descripción del comando: " desc
         echo "$comando;$descripcion" > comandos.txt
         pausa
         ;;
      2)
         echo "Has elegido la opción 2"
         
         pausa
         ;;
      3)
         echo "Has elegido la opción 3"
	 
         ;;
      4)
         echo "Has elegido la opción 4"
 	 
	 sudo addgroup $grupo
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
