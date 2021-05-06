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
				if(!empty($_POST['nombre']) && !empty($_POST['desde']) &&
				!empty($_POST['hasta'])){

					$encontrados = array_filter($articulos, function($e){
						$posicion = stripos($e['nombre'], trim($_POST['nombre']));
						return
						$posicion !== false &&
						$e['precio'] >= $_POST['desde'] &&
						$e['precio'] <= $_POST['hasta'];
					});
					ocultar($articulos, $encontrados);
				} else{
					for ($i=0; $i < count($articulos); $i++) { 
						$articulos[$i]['activo'] = true;
					}
				}
			}
			function ocultar(&$articulos, $encontrados){
				if(empty($encontrados)){
					echo '<p style="color:red">No se encontraron artículos</p>';
				}else {
					foreach ($encontrados as $encontrado => $valor) { 
						$clave = array_search($valor, $articulos);

						if($clave != null){
							$articulos[$clave]['activo'] = true;
						}
					}
				}
			}
			function getArticulos(){
				$articulos = [];

				$con = @ new mysqli('localhost', 'root', '');
				if($con->connect_error)
					die('Error de conexión: ' . $con->connect_error);

				$con->select_db('carrito');
				if ($con->errno !== 0)
					die('Error al seleccionar la BBDD: ' . $con->error);

				$resultado = $con->query("SELECT * FROM articulos");

				while ($registro = $resultado->fetch_array()){
					$articulos[] = [
						'id' => $registro['id'],
						'title' => $registro['nombre'],
						'price' => $registro['precio'],
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