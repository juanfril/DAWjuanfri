"use strict";

function getStock(Stock)  //Consigue el numero del stock
{   
    var arrayStocks = Stock.split(" ");
    return parseInt(arrayStocks[arrayStocks.length-1]);
}

function getTextoStock(articulo) //Consigue el texto del stock
{
    var stock = articulo.querySelector(".stock")
    return stock.textContent;
}

function setStock(articulo,numStock)//Cambia la cantidad de stock cada articulo 
{
    var stock = articulo.querySelector(".stock");
    var strStock=stock.textContent;

    var indiceUltimoEspacio =strStock.lastIndexOf(" ");
    var txInicial = strStock.substring(0,indiceUltimoEspacio+1);
    stock.textContent = txInicial+numStock;
}

function removeStock(copiaArticulo)//Borra la etiqueta stock de la copia del artic.
{
    var stock = copiaArticulo.querySelector(".stock");
    stock.parentNode.removeChild(stock);// le dice al padre que borre al hijo
}

function totalDineroCarrito(articulo)//aumenta precio carrito
{  
    var PreArticulo=articulo.querySelector(".price");
    var PrecioArticuloText=PreArticulo.textContent;
    var split=PrecioArticuloText.split(" ");
    var numero=parseInt(split[0]); 
    
    var ArrayPrecio = document.getElementById("cprice").value.split(" ");
    var cantidadCarrito = parseInt(ArrayPrecio[0]);
    
    var total=cantidadCarrito+numero;
    document.getElementById("cprice").value=total+" €";
}

function totalUnidadesCarrtio()//aumenta unidades carrito
{
    var cantidad=document.getElementById("citem").value;
    cantidad++;
    document.getElementById("citem").value=cantidad+"";    
}

function InsertarDeleteArticuloCarrito(copiaArticulo)
{   
    copiaArticulo.id="c"+copiaArticulo.id;
    var elemento=document.createElement('img');
    elemento.src="img/delete.png";
    copiaArticulo.prepend(elemento);
}

function borrarArticuloCarro(event)
{
    //Borro articulo de la cesta
    var padre=document.getElementById("cart_items");
    var articulo=event.currentTarget.getElementsByClassName("item");
    var arrayArticulos=articulo[0];
    padre.removeChild(arrayArticulos);
    
    //decremento contador unidades carrito
    var cantidad=document.getElementById("citem").value;
    cantidad--;
    document.getElementById("citem").value=cantidad+"";
    
    //decremento cantidad total de dinero
    var a= arrayArticulos;
    var b=a.querySelector(".price").textContent.split(" ");
    var cantidad=b[0];
    
    var ArrayPrecio = document.getElementById("cprice").value.split(" ");
    var cantidadCarrito = parseInt(ArrayPrecio[0]);
    
    var total=cantidadCarrito-cantidad;
    document.getElementById("cprice").value=total+" €";
}

function articulodbclick(event) 
{
    var articulo = event.currentTarget;    
    var strStock = getTextoStock(articulo);
    var numStock=getStock(strStock);
    
    if(numStock>0)
    {
        numStock--;
    
        totalDineroCarrito(articulo);

        totalUnidadesCarrtio();

        setStock(articulo,numStock);

        var copiaArticulo = articulo.cloneNode(true);
        
        InsertarDeleteArticuloCarrito(copiaArticulo);
           
        removeStock(copiaArticulo);

        var carrito = document.getElementById('cart_items');
        
        carrito.prepend(copiaArticulo);

        return false;
    }   
}
    
window.onload = function () 
{
    var articulos = document.getElementsByClassName('item');
    var articuloscarrito = document.getElementsByClassName('back');

    for (var i = 0; i < articulos.length; i++) 
    {
        articulos[i].ondblclick = articulodbclick; 
    }
    for (var i = 0; i < articuloscarrito.length; i++) 
    {
        articuloscarrito[i].addEventListener("click",borrarArticuloCarro); 
    }
};