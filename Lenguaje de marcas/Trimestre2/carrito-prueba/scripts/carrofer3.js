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

function InsertarMenosArticuloCarrito(copiaArticulo)//Boton menos de articulo copiado a la cesta
{   
    copiaArticulo.id="c"+copiaArticulo.id;
    var elemento=document.createElement('a');
    elemento.className="minus";
    elemento.onclick=RestarArticuloContador;
    copiaArticulo.prepend(elemento);
}

function RestarArticuloContador(event)//onclick boton menos
{
   
    var evento=event.currentTarget.parentNode.id;
    var ArticuloCarrito=document.getElementById(evento).getElementsByClassName("cantidad");
    var a=parseInt(ArticuloCarrito[0].value);
    
    if(a!=1)
    {
        a--
        ArticuloCarrito[0].value=a+"";

        //decremento contador unidades carrito
        var cantidad=document.getElementById("citem").value;
        cantidad--;
        document.getElementById("citem").value=cantidad+"";
        
        //cambia precio 
        var b=event.currentTarget.parentNode.querySelector(".price").textContent.split(" ");
        var cantidad=b[0];
        var ArrayPrecio = document.getElementById("cprice").value.split(" ");
        var cantidadCarrito = parseInt(ArrayPrecio[0]);
        var total=cantidadCarrito-cantidad;
        document.getElementById("cprice").value=total+" €"
        
        //aumento numero de stock de articulo    
        var split=event.currentTarget.parentNode.id.substring(1,3);
        var stockArticulo=document.getElementById(split);
        var stockclase=stockArticulo.querySelector(".stock");
        var stock=stockclase.textContent;
        var stocksplit=stock.split(" ");
        var stockTexto=stocksplit[0];
        var stockNumero=parseInt(stocksplit[1]);
        var stockTotal=stockNumero+1;
        stockArticulo.querySelector(".stock").textContent= stockTexto+" "+stockTotal;
    }
    else    
        borrarArticuloCarro(event);
    
}

function InsertarMasArticuloCarrito(copiaArticulo)//Boton mas de articulo copiado a la cesta
{   
    var elemento=document.createElement('a');
    elemento.className="add";
    elemento.onclick=SumarArticuloContador;
    copiaArticulo.prepend(elemento);
}

function SumarArticuloContador(event)//onclick boton mas
{
    var split=event.currentTarget.parentNode.id.substring(1,3);
    var stockArticulo=document.getElementById(split);
    var stockclase=stockArticulo.querySelector(".stock");
    var stock=stockclase.textContent;
    var stocksplit=stock.split(" ");
    var stockTexto=stocksplit[0];
    var stockNumero=parseInt(stocksplit[1]);
    var contaidadStockArticulo=stockNumero;

    if(contaidadStockArticulo!=0)
    {
        var evento=event.currentTarget.parentNode.id;
        var ArticuloCarrito=document.getElementById(evento).getElementsByClassName("cantidad");
        var a=parseInt(ArticuloCarrito[0].value);
        a++;
        ArticuloCarrito[0].value=a+"";

        //aumentar contador unidades carrito
        var cantidad=document.getElementById("citem").value;
        cantidad++;
        document.getElementById("citem").value=cantidad+"";

        //cambia precio 
        var b=event.currentTarget.parentNode.querySelector(".price").textContent.split(" ");
        var cantidad=parseInt(b[0]);
        var ArrayPrecio = document.getElementById("cprice").value.split(" ");
        var cantidadCarrito = parseInt(ArrayPrecio[0]);
        var total=cantidadCarrito+cantidad;
        document.getElementById("cprice").value=total+" €";

        //reduzco numero de stock de articulo    
        var stockTotal=stockNumero-1;
        stockArticulo.querySelector(".stock").textContent= stockTexto+" "+stockTotal;
    }
    else
    {
        var evento=event.currentTarget.parentNode.id;
        var hola=document.getElementById(evento).getElementsByClassName("cantidad").parentNode;
    }
}
function InsertarContadorArticuloCarrito(copiaArticulo)//Contador de articulos de cada tipo en la cesta
{   
    var elemento=document.createElement('input');
    elemento.className="cantidad";
    elemento.type="text";
    elemento.value="1";
    elemento.reandory="true";
    copiaArticulo.prepend(elemento);
}

function InsertarDeleteArticuloCarrito(copiaArticulo)//Boton delete de articulo copiado a la cesta
{   
    var elemento=document.createElement('a');
    elemento.className="delete";
    elemento.onclick=borrarArticuloCarro;
    copiaArticulo.prepend(elemento);
}

function borrarArticuloCarro(event)//Boton "x" borrado de los articulos copiados al carrito
{
    //decremento contador unidades carrito
    var cantidad=document.getElementById("citem").value;
    var Id=event.currentTarget.parentNode.id;
    var cantidadElementosContador=document.getElementById(Id).querySelector(".cantidad").value;
    console.log(cantidadElementosContador);
    var resta= cantidad-cantidadElementosContador;
    document.getElementById("citem").value=resta+"";
    
    //Borro articulo de la cesta
    var padre=document.getElementById("cart_items");
    var hijo=event.currentTarget.parentNode;
    padre.removeChild(hijo);
    
    //decremento cantidad total de dinero
    var b=hijo.querySelector(".price").textContent.split(" ");
    var cantidad=b[0];
    var ArrayPrecio = document.getElementById("cprice").value.split(" ");
    var cantidadCarrito = parseInt(ArrayPrecio[0]);
    var total=cantidadCarrito-(cantidad*cantidadElementosContador);
    document.getElementById("cprice").value=total+" €";
    
    //aumento numero de stock de articulo    
    var split=hijo.id.substring(1,3);
    var stockArticulo=document.getElementById(split);
    var stockclase=stockArticulo.querySelector(".stock");
    var stock=stockclase.textContent;
    var stocksplit=stock.split(" ");
    var stockTexto=stocksplit[0];
    var stockNumero=parseInt(stocksplit[1]);
    var stockTotal=stockNumero+parseInt(cantidadElementosContador);
    stockArticulo.querySelector(".stock").textContent= stockTexto+" "+stockTotal;

    //Si el carrito esta a o no muestra los botones
    if(document.getElementById("citem").value<=4)
    {
        document.getElementById("btn_next").style.display="none";
        document.getElementById("btn_prev").style.display="none";
    }
    if(document.getElementById("citem").value<=0)
    {
        document.getElementById("btn_clear").style.display="none";
        document.getElementById("btn_comprar").style.display="none"; 
    }
}

function onMueveteDerecha()// boton mueve a la derecha
{
    
    if(document.getElementById("citem").value>4)
    {
        
        var divMovible = document.getElementById("cart_items");
        var posicion = parseInt(divMovible.style.left);
        
        if(posicion!=0)
        {
            posicion += 120;
            divMovible.style.left = posicion + "px";
        }      
    }
}

function onMueveteIzquierda() //boton mueve a la izquierda
{
    
    if(document.getElementById("citem").value>4)
    {
        var divMovible = document.getElementById("cart_items");
        var posicion = parseInt(divMovible.style.left);

        posicion -= 120;
        divMovible.style.left = posicion + "px";
    }
}

function onVaciarCarro()// boton vacia carrito
{
    var contador=0;
    var h=document.getElementById("citem").value;
    
    while(contador<h)
    {
        //borra cada hijo
        var padre=document.getElementById("cart_items");
        var hijo=document.getElementById("cart_items").firstChild;
        padre.removeChild(hijo);
        
        contador++;
        
        //decrementa cantidad articulos en carrito
        var cantidad=document.getElementById("citem").value;
        cantidad--;
        document.getElementById("citem").value=0;
        
        //Pone a cero precio total carrito
        document.getElementById("cprice").value="0 €";
        
        //aumenta el stock de los articulos
        var id=hijo;
        var split=hijo.id.substring(1,3);
        var stockArticulo=document.getElementById(split);
        var stockclase=stockArticulo.querySelector(".stock");
        var stock=stockclase.textContent;
        var stocksplit=stock.split(" ");
        var stockTexto=stocksplit[0];
        var stockNumero=parseInt(stocksplit[1]);
        stockArticulo.querySelector(".stock").textContent= "Stock 10";
    }
    //Si el carrito esta a o no muestra los botones
    if(document.getElementById("citem").value==0)
    {
        document.getElementById("btn_next").style.display="none";
        document.getElementById("btn_prev").style.display="none";
        document.getElementById("btn_clear").style.display="none";
        document.getElementById("btn_comprar").style.display="none"; 
    }
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
        
        InsertarMenosArticuloCarrito(copiaArticulo);
        InsertarMasArticuloCarrito(copiaArticulo);
        InsertarContadorArticuloCarrito(copiaArticulo)
        InsertarDeleteArticuloCarrito(copiaArticulo);
        removeStock(copiaArticulo);
        
        //Copia los articulos al carrito
        var carrito = document.getElementById('cart_items');  
        var arrayCopiaArticulos=document.getElementById("cart_items").getElementsByClassName("item");
        var cantidad=arrayCopiaArticulos.length;
        var IdCopauaArticulo=copiaArticulo.id;
        var count=0;
        
        if(cantidad===0)
        {
            carrito.prepend(copiaArticulo);
            
        }
        else
        {
            for(var i=0;i<cantidad;i++)
            {
                if(arrayCopiaArticulos[i].id===IdCopauaArticulo)
                {
                    count++;
                } 
            }
            if(count===0)
            {
                carrito.prepend(copiaArticulo);
            }
        }
                
        count=0;
        
        
        if(document.getElementById("citem").value!=0)
        {
            var BotonMueveDerecha = document.getElementById("btn_next");
            var BotonMuevIzquierda = document.getElementById("btn_prev");
            var BotonVaciarCarro = document.getElementById("btn_clear");

            BotonMueveDerecha.addEventListener("click",onMueveteDerecha);
            BotonMuevIzquierda.addEventListener("click",onMueveteIzquierda);
            BotonVaciarCarro.addEventListener("click",onVaciarCarro); 
        }

        //si la cantidad de artiulos en el carrito es superior a 4 se pone un width de 5000px
        if(document.getElementById("citem").value>4)
        {
            document.getElementById("cart_items").style.left="0px";
            document.getElementById("cart_items").style.width="5000px";
            
        }
        //Si el carrito tiene un articulo se activan los botoenes de comprar y vaciar
       if(document.getElementById("citem").value>=1)
        {
            document.getElementById("btn_clear").style.display=null;
            document.getElementById("btn_comprar").style.display=null;  
        }

        //si el carrito tiene mas de cuatro obejetos se activan los botones de  mover
       if(document.getElementById("citem").value>4)
        {    
            document.getElementById("btn_next").style.display=null;
            document.getElementById("btn_prev").style.display=null;  
        }
        return false;
    }
}
    
window.onload = function () 
{
    var articulos = document.getElementsByClassName('item');

    for (var i = 0; i < articulos.length; i++) 
    {
        articulos[i].ondblclick = articulodbclick; 
    }
    
    if(document.getElementById("citem").value==0)
    {
        document.getElementById("btn_next").style.display="none";
        document.getElementById("btn_prev").style.display="none";
        document.getElementById("btn_clear").style.display="none";
        document.getElementById("btn_comprar").style.display="none"; 
    }
};