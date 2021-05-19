<?php

    $con = @ new mysqli('localhost', 'root', '');
				if($con->connect_error)
					die('Error de conexión: ' . $con->connect_error);

				$con->select_db('carrito');
				if ($con->errno !== 0)
					die('Error al seleccionar la BBDD: ' . $con->error);

    if ($_SERVER['REQUEST_METHOD'] === 'POST') {
        if(empty($_POST['nombre']) && empty($_POST['imagen']) && empty($_POST['descripcion']) &&
            empty($_POST['stock']) && empty($_POST['activo'])){

            echo '<p>Debe rellenar todos los campos</p>
                    <p>Pulse el botón atrás en el navegador</p>';
        }else{
            if ($_FILES['imagen']['type'] !== 'image/jpeg'){
                echo 'Error: No se trata de un fichero .JPG';
                exit();
            }
            if ($_FILES['imagen']['error'] !== UPLOAD_ERR_OK){
                showError();
                exit();
            }
            if (is_uploaded_file($_FILES['imagen']['tmp_name']) === false){
                echo 'Error: posible ataque. Nombre: '.$_FILES['imagen']['name'];
                exit();
            }
            $imagen = getNombreImagen();
            echo $imagen;
            if (!move_uploaded_file($_FILES['imagen']['tmp_name'], $imagen)){
                echo 'Error: No se puede mover el fichero a su destino';
            }
            //imagescale($imagen, 100, 100, IMG_BILINEAR_FIXED); no funciona

            $nombre = $_POST['nombre'];
            $descripcion = $_POST['descripcion'];
            $precio = $_POST['precio'];
            $stock = $_POST['stock'];
            $activo = $_POST['activo'];
            //debug($nombre, $descripcion, $imagen, $precio, $stock, $activo);
            
            $con->query("INSERT INTO articulos (nombre, precio, stock, imagen, descripcion, activo)
            VALUES ('$nombre', $precio, $stock, '$imagen', '$descripcion', $activo)");
            
            header("location: index.php");
        }

    }
    function debug($nombre, $descripcion, $imagen, $precio, $stock, $activo){
        echo "<p>$nombre</p>
                <p>$descripcion</p>
                <p>$precio</p>
                <p>$stock</p>
                <p>$activo</p>";
    }
    function showError(){
        echo 'Error: ';
        switch ($_FILES['imagen']['error']){
            case UPLOAD_ERR_INI_SIZE:
            case UPLOAD_ERR_FORM_SIZE:
                echo 'El fichero es demasiado grande';
                break;
            case UPLOAD_ERR_PARTIAL:
                echo 'El fichero no se ha podido subir entero';
                break;
            case UPLOAD_ERR_NO_FILE:
                echo 'No se ha podido subir el fichero';
                break;
            default:
                echo 'Error indeterminado.';
        }
    }
    function getNombreImagen(){
    $nombre = './img/'.$_FILES['imagen']['name'];

    return $nombre;
    }
    $con->close();
?>

<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link rel="stylesheet" title="normal" href="css/carro.css" type="text/css" media="screen" >
    <title>Agregar artículos</title>
</head>
<body>
    <div id="form_container">
        <form id="form_enviar" action="<?= $_SERVER["PHP_SELF"]; ?>" method="post"
            enctype="multipart/form-data">

            <label for="nombre">Introducir nombre</label>
            <input type="text" name="nombre" value="">

            <label for="imagen">Introducir imagen a subir</label>
            <input type="file" name="imagen" value="">

            <label for="descripcion">Introducir descripción</label>
            <input type="text" name="descripcion" value="">

            <label for="precio">Introducir precio</label>
            <input type="number" name="precio" value="">

            <label for="stock">Introducir stock</label>
            <input type="number" name="stock" value="">
            
            <label for="activo">Activo</label>
            <p>Si</p>
            <input type="radio" name="activo" value="1">
            <p>No</p>
            <input type="radio" name="activo" value="0">

            <input type="submit" value="Enviar">
        </form>
        <a href="index.php">Volver a carrito</a>
    </div>
</body>
</html>