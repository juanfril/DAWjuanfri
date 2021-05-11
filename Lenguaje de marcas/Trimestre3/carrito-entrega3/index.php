<?php
	$articulos = getArticulos();
?>

<!DOCTYPE html>
<html lang="es">
<head>
	<title>Carro de la compra con Javascript</title>
	<meta charset="utf-8">
	<link rel="stylesheet" title="normal" href="css/carro.css" type="text/css" media="screen" >
</head>
<body>
	<div id="item_container">
		<?php
			if ($_SERVER['REQUEST_METHOD'] === 'POST') {
				$nombre = empty($_POST['nombre']) ? '%' : $_POST['nombre'];
				$desde = empty($_POST['desde']) ? 0 : $_POST['desde'];
				$hasta = empty($_POST['hasta']) ? 100 : $_POST['hasta'];

				
				ocultar($nombre, $desde, $hasta);
			}
			function ocultar($nombre, $desde, $hasta){
				$con = @ new mysqli('localhost', 'usuario1', '123');
					if($con->connect_error)
						die('Error de conexión: ' . $con->connect_error);

					$con->select_db('carrito');
					if ($con->errno !== 0)
						die('Error al seleccionar la BBDD: ' . $con->error);

					$con->query("UPDATE articulos SET activo = 0");
					$con->query("UPDATE articulos SET activo = 1 
									WHERE LOWER(nombre) like '%$nombre%' and
									precio >= $desde and precio <= $hasta");
				$con->close();
			}
			
			function getArticulos(){
				$articulos = [];

				$con = @ new mysqli('localhost', 'usuario1', '123');
				if($con->connect_error)
					die('Error de conexión: ' . $con->connect_error);

				$con->select_db('carrito');
				if ($con->errno !== 0)
					die('Error al seleccionar la BBDD: ' . $con->error);

				$resultado = $con->query("SELECT * FROM articulos");

				while ($registro = $resultado->fetch_array()){
					$articulos[] = [
						'id' => $registro['id'],
						'nombre' => $registro['nombre'],
						'precio' => $registro['precio'],
						'stock' => $registro['stock'],
						'url' => $registro['ruta_imagen'],
						'descripcion' => $registro['descripcion'],
						'activo' => $registro['activo']
					];
				}

				$con->close();

				return $articulos;
			}
			
			function cargarArticulos($articulos){
				$contadorId = 1;
				
				foreach($articulos as $articulo){
					
					if($articulo["activo"]){
						echo
						"<div class='item' id='i$contadorId'>
						<img src='$articulo[url]' alt='$articulo[descripcion]'>
						<label class='title'>$articulo[nombre]</label>
						<label class='price'>$articulo[precio] €</label>
						<label class='stock'>Stock $articulo[stock]</label>
						</div>";
					}
					$contadorId++;
				}
			}
			cargarArticulos($articulos);
			function cargarFormulario(){
				$nombre = empty($_POST['nombre']) ? '' : $_POST['nombre'];
				$desde = empty($_POST['desde']) ? '' : $_POST['desde'];
				$hasta = empty($_POST['hasta']) ? '' : $_POST['hasta'];
				echo
				"<label for='nombre'>Buscar por nombre</label>
				<input type='text' name='nombre' value='$nombre'>
				<label for='desde'>Precio desde</label>
				<input type='number' name='desde' value='$desde'>
				<label for='hasta'>Precio hasta</label>
				<input type='number' name='hasta' value='$hasta'>
				<input type='submit' value='Enviar'>";
			}
		?>
		<div class= "clear"></div>
	</div>
	<div id="cart_container">
		<div id="cart_title">
			<span>Carrito</span>
			<div class="clear"></div>
		</div>
		<div id="cart_toolbar">
			<div id="cart_items" class="back"></div>
		</div>
		<div id="navigate">
			<div id="nav_left">
				<button id="btn_comprar" title="Confirma la compra de los artículos">Comprar</button>
				<button id="btn_prev" title="Desplaza el carrito hacia la izquierda">&lt;</button>
				<button id="btn_next" title="Desplaza el carrito hacia la derecha">&gt;</button>
				<button id="btn_clear" title="Vacia el carrito">Vaciar</button>
			</div>
			<div id="nav_right">
				<span class="sptext">
					<label>Compras </label><input id="citem" value="0" readonly title="Número de productos comprados">
				</span>
				<span class="sptext">
					<label>Precio </label><input id="cprice" value="0 €" readonly  title="Precio total de los productos comprados">
				</span>
			</div>
			<div class="clear"></div>
		</div>
		<div id = "form_enviar">
			<form action="<?= $_SERVER["PHP_SELF"]; ?>" method="post">
				<?php
					cargarFormulario();
				?>
			</form>
		</div>
	</div>
	<script src="./scripts/carro.js"></script>
</body>
</html>