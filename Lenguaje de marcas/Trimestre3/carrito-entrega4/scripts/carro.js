'use strict';

(function(){
    let carrito = document.getElementById('cart_items'),
        style = window.getComputedStyle(carrito, ''),
        rectArticulo = 120,
        desplazamiento = 50,
        ancho = parseInt(style.width),
        articulosCarrito = carrito.children.length,
        rectCarritoInicial = carrito.getBoundingClientRect(),
        colores = setInterval(timer, 1000);

    const timer = () =>
        carrito.style.background = (carrito.style.background == 'yellow')
             ? 'red' 
             : 'yellow';
    
    const comprobarCarritoVacio = () => {
        if(!carrito.firstChild)
            colores = setInterval(timer, 1000);
        else
            clearInterval(colores);
    }    
    //copiar artículo seleccionado
    const getCopia = articulo => {
        let copia = articulo.cloneNode(true);
        copia.id = 'c' + copia.id;
        copia.lastElementChild.style.display = 'none';
        copia.style.cursor = 'default';
        insertarEnlaceBorrado(copia);
        return copia;
    }
    //insertar el botón para sacar del carro
    const insertarEnlaceBorrado = copia => {
        let enlaceBorrado = document.createElement('a');
        enlaceBorrado.href = '#';
        enlaceBorrado.setAttribute( 'class', 'delete');
        enlaceBorrado.onclick = borrarArticuloCarro;
        copia.insertBefore(enlaceBorrado, copia.children[0]);
    }
    //Sacar del carrito los artículos
    const borrarArticuloCarro = event => {
        //borrar artículo
        let hijo = this.parentNode;
        carrito.removeChild(hijo);
        //aumento numero de stock de articulo    
        let split = hijo.id.substring(2,4);
        let articuloOriginal = document.getElementById(split);
        setStock(articuloOriginal, 1);
        //resto cantidad total artículos
        setCantidadArticulos(-1);
        //resto precio artículo al total
        setDescontarPrecioTotal(articuloOriginal);
        //Disminuyo el ancho si hay menos de 4 artículos
        disminuirAncho();
        //Activar / Desactivar colores
        comprobarCarritoVacio();

        controlCarrito();
    }
    //añadir articulos al carrito
    const insertarCarrito = articulo => {
        let copia = getCopia(articulo);
        carrito.insertBefore(copia, carrito.children[0]);
        setStock(articulo, -1);
        setCantidadArticulos(1);
        setAgregarPrecioTotal(articulo);
        comprobarCarritoVacio();
    }
    //conseguir stock
    const getStock = articulo => {
        let precioArticulo = articulo.lastElementChild;
        let arrayStock = precioArticulo.textContent.split(' ');
        return arrayStock;
    }
    //Selecciona el stock del artículo lo convierte a entero y cambia el valor
    const setStock = (articulo, valor) => {  
        let precioArticulo = articulo.lastElementChild;
        let arrayStock = getStock(articulo);
        arrayStock[1] = parseInt(arrayStock[1]) + valor;
        precioArticulo.textContent = arrayStock[0] + ' ' + arrayStock[1];
        if(parseInt(arrayStock[1]) == 0){
            agotadoStock(articulo.lastElementChild);
        }
        else
            articulo.lastElementChild.setAttribute('class', 'stock')
    }
    //añade la clase agotado
    const agotadoStock = articulo => articulo.setAttribute('class', 'agotado');

    //modificar cantidad artículos según valor dado
    const setCantidadArticulos = valor => {
        let cantidad = document.querySelector('#citem')
        cantidad.value = parseInt(cantidad.value) + valor;
    }
    //conseguir precio producto
    const getPrecio = articulo => {
        let precioArticulo = articulo.querySelector('.price');
        let arrayPrecio = precioArticulo.textContent.split(' ');
        //console.log(arrayPrecio);
        return parseInt(arrayPrecio[0]);
    }
    //agregar precio del carrito
    const setAgregarPrecioTotal = articulo => {
        let precioArticulo = getPrecio(articulo);
        let costePedido = document.querySelector('#cprice');
        costePedido.value = parseInt(costePedido.value) + precioArticulo + ' €';
    }
    //descontar precio del carrito
    const setDescontarPrecioTotal = articulo => {
        let precioArticulo = getPrecio(articulo);
        let costePedido = document.querySelector('#cprice');
        costePedido.value = parseInt(costePedido.value) - precioArticulo + ' €';
    }
    //añadir al carrito con escucha
    const articuloDbClick = event => {
        let articulo = event.currentTarget;
        let stock = getStock(articulo);
        if(parseInt(stock[1]) > 0)
            insertarCarrito(articulo);
        else
            alert('No se pueden añadir artículos sin stock');
        aumentarAncho();
    }
    //Vaciar el carrito
    const vaciarOnClick = event => {
        let enlaces = document.querySelectorAll('#cart_items .delete');
        enlaces.forEach(element => element.onclick());
        controlCarrito();
    }
    //Comprobar si hay más de 4 artículos
    const aumentarAncho = () => {
        articulosCarrito = carrito.children.length;
        if(articulosCarrito > 4){
            ancho = ancho + rectArticulo;
            carrito.style.width = ancho.toString() + 'px'
        }
    }
    //Disminuir tamaño carrito
    const disminuirAncho = () => {
        articulosCarrito = carrito.children.length;
        let style = window.getComputedStyle(carrito, '');
        let ancho = parseInt(style.width);
        if(articulosCarrito > 3){
            carrito.style.width = (ancho - rectArticulo) + 'px'
        }
        controlCarrito();
    }
    //Función para que el carrito se mueva hacia la izquierda
    const mueveIzquierda = event => {
        articulosCarrito = carrito.children.length;
        if(articulosCarrito > 4){
            let style = window.getComputedStyle(carrito, '');
            let left = parseInt(style.left);
            carrito.style.left = (left + desplazamiento) + 'px';
        }
        controlCarrito();
    }
    //Función para que el carrito se mueva hacia la derecha
    const mueveDerecha = event => {
        articulosCarrito = carrito.children.length;
        if(articulosCarrito > 4){
            let style = window.getComputedStyle(carrito, '');
            let left = parseInt(style.left);
            carrito.style.left = (left - desplazamiento) + 'px';
        }
        controlCarrito();        
    }
    const controlCarrito = () =>{
        let rectCarrito = carrito.getBoundingClientRect();
        if(rectCarrito.left > rectCarritoInicial.left)
            carrito.style.left = '0px'
        if(rectCarrito.right < rectCarritoInicial.right)
            carrito.style.left = -(rectCarrito.width - rectCarritoInicial.width) + 'px';
    }
    window.onload = () => {
        //añadir a todos los artículos dbclick
        let articulos = document.getElementsByClassName('item');
        articulos.forEach(art => art.ondblclick = articuloDbClick);
        //Añadir click a vaciar carrito
        let vaciar = document.getElementById('btn_clear');
        vaciar.onclick = vaciarOnClick;
        //Añadir botón izq click
        let botonIzq = document.getElementById('btn_prev');
        botonIzq.onclick = mueveIzquierda;
        //Añadir botón der click
        let botonDer = document.getElementById('btn_next');
        botonDer.onclick = mueveDerecha;
    };
})();