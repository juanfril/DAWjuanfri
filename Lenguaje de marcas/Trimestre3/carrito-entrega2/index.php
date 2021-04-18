<?php
	$articulos = array(
		array(
			'nombre' => 'Camiseta 1',
			'url' => 'img/camiseta1.jpg',
			'descripcion' => 'descripcion i1',
			'precio' => 20,
			'stock' => 10,
			'activo' => false
		),
		array(
			'nombre' => 'Reloj 2',
			'url' => 'img/reloj2.jpg',
			'descripcion' => 'descripcion i2',
			'precio' => 24,
			'stock' => 10,
			'activo' => false
		),
		array(
			'nombre' => 'Camiseta 3',
			'url' => 'img/camiseta3.jpg',
			'descripcion' => 'descripcion i3',
			'precio' => 18,
			'stock' => 10,
			'activo' => false
		),
		array(
			'nombre' => 'Reloj 4',
			'url' => 'img/reloj4.jpg',
			'descripcion' => 'descripcion i4',
			'precio' => 30,
			'stock' => 10,
			'activo' => false
		),
		array(
			'nombre' => 'Reloj 5',
			'url' => 'img/reloj5.jpg',
			'descripcion' => 'descripcion i5',
			'precio' => 28,
			'stock' => 10,
			'activo' => false
		),
		array(
			'nombre' => 'Camiseta 6',
			'url' => 'img/camiseta6.jpg',
			'descripcion' => 'descripcion i6',
			'precio' => 15,
			'stock' => 10,
			'activo' => false
		),
	)
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
					
					/* echo 'post: <br>', var_dump($_POST);
					echo '<br> encontrado: <br>'; */
					//en principio no hace falta porque al input le he puesto tipo número
					/* if(!is_numeric($_POST['desde']))
						$_POST['desde'] = 0;
					else if(!is_numeric($_POST['hasta']))
						$_POST['hasta'] = 0; */

					$encontrados = array_filter($articulos, function($e){
						$posicion = stripos($e['nombre'], trim($_POST['nombre']));
						return
						$posicion !== false &&
						$e['precio'] >= $_POST['desde'] &&
						$e['precio'] <= $_POST['hasta'];
					});
					/* var_dump($encontrados);
					echo '<p>artículos:</p>';
					var_dump($articulos); */
					ocultar($articulos, $encontrados);
				} else{
					/* echo '<p style="color:red">Tiene que rellenar todos los campos</p>'; */
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
				echo
				"<label for='nombre'>Buscar por nombre</label>
				<input type='text' name='nombre' value='$_POST[nombre]'>
				<label for='desde'>Precio desde</label>
				<input type='number' name='desde' value='$_POST[desde]'>
				<label for='hasta'>Precio hasta</label>
				<input type='number' name='hasta' value='$_POST[hasta]'>
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