using System;
using System.Collections;
using System.Collections.Generic;

namespace TiendaInformatica
{
    class Catalogo
    {
        private SortedList<string, ProductoInformatico> catalogo;

        public Catalogo()
        {
            catalogo = new SortedList<string, ProductoInformatico>();
        }

        public void NuevoProducto(ProductoInformatico producto)
        {
            if(producto.isInstanceOf(Componentes))
        }
    }
}
