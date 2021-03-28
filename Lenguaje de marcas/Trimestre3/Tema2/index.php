<?php
    $nombre = " /cristina narro ibernon   ";
    $nombreModificado = ltrim($nombre); //Quita espacios principio
    $nombreModificado = rtrim($nombreModificado); //Quita espacios del final
    $nombreModificado = str_replace("/", "", $nombreModificado);
    $nombrePrimeraMayuscula = ucfirst($nombreModificado); //Pone la primera en mayúsculas
    $nombreMayuscula = strtoupper($nombreModificado); //Todas mayúsculas
    $nombrePrimeraPalabra = ucwords($nombreModificado); //La primera letra de cada palabra
    $longitudString = strlen($nombreModificado); //longitud del String
    $primeraLetra = stripos($nombreMayuscula, "a"); //posicion de la primera letra buscada
    $ultimaLetra = strripos($nombreMayuscula, "a"); //posicion de la última letra buscada
    $numeroVeces = substr_count(strtoupper($nombreModificado), "A");//Cuenta cuantas veces
    $nombreSinO = str_ireplace("o", "0", $nombrePrimeraPalabra);
?>

<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Juan Fco. Losa</title>
</head>
<body>
    <?php
        $mensaje = "<p>Bienvenido: $nombre</p>";
        echo $mensaje;
        $mensajeModificado = "<p>Bienvenido: $nombreModificado</p>";
        echo $mensajeModificado;
        $mensaje2 = "<p>Bienvenido: $nombrePrimeraMayuscula</p>";
        echo $mensaje2;
        $mensaje3 = "<p>Bienvenido: $nombreMayuscula</p>";
        echo $mensaje3;
        $mensaje4 = "<p>Bienvenido: $nombrePrimeraPalabra</p>";
        echo $mensaje4;
        echo "<p>$longitudString</p>";
        echo "<p>$primeraLetra</p>";
        echo "<p>$ultimaLetra</p>";
        echo "<p>$numeroVeces</p>";
        $mensaje5 = "<p>Bienvenido: $nombreSinO</p>";
        echo $mensaje5;
    ?>
</body>
</html>