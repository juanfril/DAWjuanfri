'use strict';

(function(){
    function getStock(Stock){  //Consigue el numero del stock
       
        let arrayStocks = Stock.split(" ");
        return parseInt(arrayStocks[arrayStocks.length-1]);
    }

    function getTextoStock(articulo){ //Consigue el texto del stock

        let stock = articulo.querySelector(".stock")
        return stock.textContent;
    }

    function setStock(articulo,numStock){ //Cambia la cantidad de stock cada articulo 
    
        let stock = articulo.querySelector(".stock");
        let strStock = stock.textContent;

        let indiceUltimoEspacio = strStock.lastIndexOf(" ");
        let txInicial = strStock.substring(0,indiceUltimoEspacio + 1);
        stock.textContent = txInicial + numStock;
    }

    function removeStock(copiaArticulo){ //Borra la etiqueta stock de la copia del artic.
    
        let stock = copiaArticulo.querySelector(".stock");
        stock.parentNode.removeChild(stock);// le dice al padre que borre al hijo
    }

    function totalDineroCarrito(articulo){ //aumenta precio carrito
      
        let PreArticulo = articulo.querySelector(".price");
        let PrecioArticuloText = PreArticulo.textContent;
        let split = PrecioArticuloText.split(" ");
        let numero = parseInt(split[0]); 
        
        let ArrayPrecio = document.getElementById("cprice").value.split(" ");
        let cantidadCarrito = parseInt(ArrayPrecio[0]);
        
        let total = cantidadCarrito+numero;
        document.getElementById("cprice").value=total+" €";
    }

    function totalUnidadesCarrtio(){ //aumenta unidades carrito
    
        let cantidad = document.getElementById("citem").value;
        cantidad++;
        document.getElementById("citem").value=cantidad+"";    
    }

    function InsertarDeleteArticuloCarrito(copiaArticulo){
       
        copiaArticulo.id = "c" + copiaArticulo.id;
        let elemento = document.createElement('a');
        elemento.className = "delete";
        elemento.onclick = borrarArticuloCarro;
        copiaArticulo.prepend(elemento);
    }

    function borrarArticuloCarro(event){
    
        //Borro articulo de la cesta
        let padre = document.getElementById("cart_items");
        let hijo = event.currentTarget.parentNode;
        padre.removeChild(hijo);
        
        //decremento contador unidades carrito
        let cantidad = document.getElementById("citem").value;
        cantidad--;
        document.getElementById("citem").value = cantidad + "";
        
        //decremento cantidad total de dinero
        let b = hijo.querySelector(".price").textContent.split(" ");
        let cantidad = b[0];
        
        let ArrayPrecio = document.getElementById("cprice").value.split(" ");
        let cantidadCarrito = parseInt(ArrayPrecio[0]);
        
        let total = cantidadCarrito-cantidad;
        document.getElementById("cprice").value = total+" €";
        
        //aumento numero de stock de articulo    
        let split = hijo.id.substring(1,3);
        let stockArticulo = document.getElementById(split);
        let stockclase = stockArticulo.querySelector(".stock");
        let stock = stockclase.textContent;
        let stocksplit = stock.split(" ");
        let stockTexto = stocksplit[0];
        let stockNumero = parseInt(stocksplit[1]);
        let stockTotal = stockNumero+1;
        stockArticulo.querySelector(".stock").textContent= stockTexto + " " + stockTotal;
        
        //Si el carrito esta a o no muestra los botones
        if(document.getElementById("citem").value <= 4){
        
            document.getElementById("btn_next").style.display = "none";
            document.getElementById("btn_prev").style.display = "none";
        }
        if(document.getElementById("citem").value <= 0){
        
            document.getElementById("btn_clear").style.display = "none";
            document.getElementById("btn_comprar").style.display = "none"; 
        }
    }

    function onMueveteDerecha(){ //boton mueve a la derecha
    
        
        if(document.getElementById("citem").value > 4){
            
            let divMovible = document.getElementById("cart_items");
            let posicion = parseInt(divMovible.style.left);
            console.log(posicion);
            
            if(posicion != 0){
            
                posicion += 120;

                divMovible.style.left = posicion + "px";
            }      
        }
    }

    function onMueveteIzquierda(){ //boton mueve a la izquierda
        
        if(document.getElementById("citem").value > 4){

            let divMovible = document.getElementById("cart_items");
            let posicion = parseInt(divMovible.style.left);
            console.log(posicion);
            
            posicion -= 120;

            divMovible.style.left = posicion + "px";
        }
    }

    function onVaciarCarro(){ // boton vacia carrito
    
        let contador = 0;
        let h = document.getElementById("citem").value;
        
        while(contador < h){
        
            //borra cada hijo
            let padre = document.getElementById("cart_items");
            let hijo = document.getElementById("cart_items").firstChild;
            padre.removeChild(hijo);
            
            contador++;
            
            //decrementa cantidad articulos en carrito
            let cantidad = document.getElementById("citem").value;
            cantidad--;
            document.getElementById("citem").value = cantidad;
            
            //Pone a cero precio total carrito
            document.getElementById("cprice").value = "0 €";
            
            //aumenta el stock de los articulos
            let id=hijo;
            let split=hijo.id.substring(1, 3);
            let stockArticulo=document.getElementById(split);
            let stockclase=stockArticulo.querySelector(".stock");
            let stock=stockclase.textContent;
            let stocksplit=stock.split(" ");
            let stockTexto=stocksplit[0];
            let stockNumero=parseInt(stocksplit[1]);
            let stockTotal=stockNumero + 1;
            stockArticulo.querySelector(".stock").textContent= stockTexto + " " + stockTotal;
        }
        //Si el carrito esta a o no muestra los botones
        if(document.getElementById("citem").value == 0){
        
            document.getElementById("btn_next").style.display = "none";
            document.getElementById("btn_prev").style.display = "none";
            document.getElementById("btn_clear").style.display = "none";
            document.getElementById("btn_comprar").style.display = "none"; 
        }
    }


    function articulodbclick(event){
    
        let articulo = event.currentTarget;    
        let strStock = getTextoStock(articulo);
        let numStock = getStock(strStock);
        
        if(numStock > 0){
        
            numStock--;
        
            totalDineroCarrito(articulo);

            totalUnidadesCarrtio();

            setStock(articulo, numStock);

            let copiaArticulo = articulo.cloneNode(true);
            
            InsertarDeleteArticuloCarrito(copiaArticulo);
            
            removeStock(copiaArticulo);

            let carrito = document.getElementById('cart_items');
            
            carrito.prepend(copiaArticulo);
            
            if(document.getElementById("citem").value != 0){
            
                let BotonMueveDerecha = document.getElementById("btn_next");
                let BotonMuevIzquierda = document.getElementById("btn_prev");
                let BotonVaciarCarro = document.getElementById("btn_clear");

                BotonMueveDerecha.addEventListener("click", onMueveteDerecha);
                BotonMuevIzquierda.addEventListener("click", onMueveteIzquierda);
                BotonVaciarCarro.addEventListener("click", onVaciarCarro); 
            }

            //si la cantidad de artiulos en el carrito es superior a 4 se pone un width de 5000px
            if(document.getElementById("citem").value > 4){
            
                document.getElementById("cart_items").style.left = "0px";
                document.getElementById("cart_items").style.width = "5000px";
            }

            //Si el carrito tiene un articulo se activan los botoenes de comprar y vaciar
            if(document.getElementById("citem").value >= 1){
                
                    document.getElementById("btn_clear").style.display = null;
                    document.getElementById("btn_comprar").style.display = null;  
                }

            //si el carrito tiene mas de cuatro obejetos se activan los botones de  mover
            if(document.getElementById("citem").value > 4){
                
                    document.getElementById("btn_next").style.display = null;
                    document.getElementById("btn_prev").style.display = null;  
                }

            /*if(numStock === 0)//NO VA BIEN
            {
                var articulo1=articulo.getElementsByClassName("stock");
            // var cambioStock=articulo1.class="HOLAAAAAAAAAAA"
                console.log(articulo1);
            }*/

            return false;
        }   
    }
        
    window.onload = function (){
    
        let articulos = document.getElementsByClassName('item');

        for (let i = 0; i < articulos.length; i++){
        
            articulos[i].ondblclick = articulodbclick; 
        }
        
        if(document.getElementById("citem").value == 0){
        
            document.getElementById("btn_next").style.display = "none";
            document.getElementById("btn_prev").style.display = "none";
            document.getElementById("btn_clear").style.display = "none";
            document.getElementById("btn_comprar").style.display = "none"; 
        }

    };
})();