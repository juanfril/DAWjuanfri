'use strict';

(function(){
    let carrito = document.getElementById('cart_items');
    let style = window.getComputedStyle(carrito, '')
    let rectArticulo = 120;
    let desplazamiento = 50;
    let posicion = parseInt(style.left);
    let ancho = parseInt(style.width);
    let articulosCarrito = carrito.children.length;
    let rectCarritoInicial = carrito.getBoundingClientRect();
    let rectCarritoWidth = rectCarritoInicial.width;
    let colores = setInterval(timer, 1000);

    function timer(){
        carrito.style.background = 
            carrito.style.background == 'yellow' ? 'red' : 'yellow';
    }
    function comprobarCarritoVacio(){
        if(!carrito.firstChild)
            colores = setInterval(timer, 1000);
        else
            clearInterval(colores);
    }    
    //copiar artículo seleccionado
    function getCopia (articulo){
        let copia = articulo.cloneNode(true);
        copia.id = 'c' + copia.id;
        copia.lastElementChild.style.display = 'none';
        copia.style.cursor = 'default';
        insertarEnlaceBorrado(copia)
        return copia;
    }
    //insertar el botón para sacar del carro
    function insertarEnlaceBorrado(copia){
        copia.id = 'c' + copia.id;
        let enlaceBorrado = document.createElement('a');
        enlaceBorrado.href = '#';
        enlaceBorrado.setAttribute( 'class', 'delete');
        enlaceBorrado.onclick = borrarArticuloCarro;
        copia.insertBefore(enlaceBorrado, copia.children[0]);
    }
    //Sacar del carrito los artículos
    function borrarArticuloCarro(event){
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
    }
    //añadir articulos al carrito
    function insertarCarrito (articulo){
        let copia = getCopia(articulo);
        carrito.insertBefore(copia, carrito.children[0]);
        setStock(articulo, -1);
        setCantidadArticulos(1);
        setAgregarPrecioTotal(articulo);
        comprobarCarritoVacio();
    }
    //conseguir stock
    function getStock(articulo){
        let precioArticulo = articulo.lastElementChild;
        let arrayStock = precioArticulo.textContent.split(' ');
        return arrayStock;
    }
    //Selecciona el stock del artículo lo convierte a entero y cambia el valor
    function setStock(articulo, valor){  
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
    function agotadoStock(articulo){
        articulo.setAttribute('class', 'agotado');
    }
    //modificar cantidad artículos según valor dado
    function setCantidadArticulos(valor){
        let cantidad = document.querySelector('#citem')
        cantidad.value = parseInt(cantidad.value) + valor;
    }
    //conseguir precio producto
    function getPrecio(articulo){
        let precioArticulo = articulo.querySelector('.price');
        let arrayPrecio = precioArticulo.textContent.split(' ');
        //console.log(arrayPrecio);
        return parseInt(arrayPrecio[0]);
    }
    //agregar precio del carrito
    function setAgregarPrecioTotal(articulo){
        let precioArticulo = getPrecio(articulo);
        let costePedido = document.querySelector('#cprice');
        costePedido.value = parseInt(costePedido.value) + precioArticulo + ' €';
    }
    //descontar precio del carrito
    function setDescontarPrecioTotal(articulo){
        let precioArticulo = getPrecio(articulo);
        let costePedido = document.querySelector('#cprice');
        costePedido.value = parseInt(costePedido.value) - precioArticulo + ' €';
    }
    //añadir al carrito con escucha
    function articuloDbClick(event){
        let articulo = event.currentTarget;
        let stock = getStock(articulo);
        if(parseInt(stock[1]) > 0)
            insertarCarrito(articulo);
        else
            alert('No se pueden añadir artículos sin stock');
        aumentarAncho();
    }
    //Vaciar el carrito
    function vaciarOnClick(event){
        let enlaces = document.querySelectorAll('#cart_items .delete');
        enlaces.forEach(element => {
           element.onclick();
        });
    }
    //Comprobar si hay más de 4 artículos
    function aumentarAncho() {
        articulosCarrito = carrito.children.length;
        if(articulosCarrito > 4){
            ancho = ancho + rectArticulo;
            carrito.style.width = ancho.toString() + 'px'
        }
    }
    //Disminuir tamaño carrito
    function disminuirAncho() {
        articulosCarrito = carrito.children.length;
        let rectCarrito = carrito.getBoundingClientRect();
        rectCarritoWidth = rectCarrito.width;
        if(articulosCarrito > 4){
            ancho = ancho - rectArticulo;
            carrito.style.width = ancho.toString() + 'px'
        }
        else{
            if(posicion < 0)
                carrito.style.left = '0px'
            else
                carrito.style.left = -(rectCarritoWidth - rectCarritoInicial.width) + 'px';
        }
    }
    //Función para que el carrito se mueva hacia la izquierda
    function mueveIzquierda(event) {
        if(posicion < 0){
            posicion = posicion + desplazamiento;
            carrito.style.left = posicion.toString() + 'px';
        }
    }
    //Función para que el carrito se mueva hacia la derecha
    function mueveDerecha(event) {
        articulosCarrito = carrito.children.length;
        let rectCarrito = carrito.getBoundingClientRect();
        rectCarritoWidth = rectCarrito.width;
        console.log(rectCarritoInicial);
        console.log(rectCarritoWidth);
        console.log(carrito.style.left);

        if(posicion > -(rectArticulo * (articulosCarrito - 4))){
            posicion = posicion - desplazamiento;
            carrito.style.left = posicion.toString() + 'px';
        }
        else
            carrito.style.left = -(rectCarritoWidth - rectCarritoInicial.width);
    }
    window.onload = function (){
        //añadir a todos los artículos dbclick
        let articulos = document.getElementsByClassName('item');
        for (let i = 0; i < articulos.length; i++){
            articulos[i].ondblclick = articuloDbClick; 
        }
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