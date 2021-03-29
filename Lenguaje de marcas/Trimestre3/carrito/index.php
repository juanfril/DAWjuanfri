<?php
	$articulos = array(
		array(
			'nombre' => 'Camiseta 1',
			'url' => 'img/camiseta1.jpg',
			'descripcion' => 'descripcion i1',
			'precio' => 20,
			'stock' => 10,
			'activo' => true
		),
		array(
			'nombre' => 'Reloj 2',
			'url' => 'img/reloj2.jpg',
			'descripcion' => 'descripcion i2',
			'precio' => 24,
			'stock' => 10,
			'activo' => true
		),
		array(
			'nombre' => 'Camiseta 3',
			'url' => 'img/camiseta3.jpg',
			'descripcion' => 'descripcion i3',
			'precio' => 18,
			'stock' => 10,
			'activo' => true
		),
		array(
			'nombre' => 'Reloj 4',
			'url' => 'img/reloj4.jpg',
			'descripcion' => 'descripcion i4',
			'precio' => 30,
			'stock' => 10,
			'activo' => true
		),
		array(
			'nombre' => 'Reloj 5',
			'url' => 'img/reloj5.jpg',
			'descripcion' => 'descripcion i5',
			'precio' => 28,
			'stock' => 10,
			'activo' => true
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
			foreach($articulos as $articulo){

				if($articulo['activo']){
					echo
						"<div class='item' id='i1'>
							<img src='$articulo['url']' alt='articulo['descripcion']'>
							<label class='title'>$articulo['nombre']</label>
							<label class='price'>$articulo['precio'] €</label>
							<label class='stock'>Stock $articulo['stock']</label>
						</div>";
				}
			}
		?>
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
	</div>
	<script src="./scripts/carro.js"></script>
</body>
</html>
