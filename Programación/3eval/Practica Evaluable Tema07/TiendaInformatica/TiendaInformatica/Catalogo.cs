using System;
using System.Collections;
using System.Collections.Generic;

namespace TiendaInformatica
{
    /*
     * Clase para almacenar el catálogo de productos informáticos de la tienda (en un diccionario clasificado por código de producto)
     */ 
    class Catalogo
    {
        private Dictionary<string, ProductoInformatico> productos;

        public Dictionary<string, ProductoInformatico> Productos 
        {
            get
            {
                return productos;
            }
        }

        public Catalogo()
        {
            productos = new Dictionary<string, ProductoInformatico>();
        }

        public bool NuevoProducto(ProductoInformatico producto)
        {
            bool ok = false;

            if ((producto.Modelo.Trim() != "") && (producto.Codigo.Trim() != "") && (producto.Marca.Trim() != "")
                && (producto.Precio > 0) && (!productos.ContainsKey(producto.Codigo)))
            {
                if(producto.GetType().ToString() == "TiendaInformatica.Periferico")
                {
                    if((((Periferico)producto).Nombre.Trim() != "") && (((Periferico)producto).Conexion.Trim() != ""))
                    {
                        ok = true;
                    }
                }else if(producto.GetType().ToString() == "TiendaInformatica.Portatil")
                {
                    if ((((Portatil)producto).Pantalla > 0) && (((Portatil)producto).Ram > 0) && (((Portatil)producto).Disco > 0))
                    {
                        ok = true;
                    }
                }else if (producto.GetType().ToString() == "TiendaInformatica.Otros")
                {
                    if ((((Otros)producto).Nombre.Trim() != "") && (((Otros)producto).Descripcion.Trim() != ""))
                    {
                        ok = true;
                    }
                }
            }
            
            if (ok)
                productos.Add(producto.Codigo, producto);

            return ok;
        }

        public bool EliminarProducto(string codigo)
        {
            bool ok = false;

            if (productos.ContainsKey(codigo)) 
            {
                productos.Remove(codigo);
                ok = true;
            }
            return ok;
        }

        public ProductoInformatico ObtenerProducto(string codigo)
        {
            ProductoInformatico p = null;

            if (productos.ContainsKey(codigo))
            {
                p = productos[codigo];
            }

            return p;

        }    
        
        public void ListarCatalogo()
        {
            IDictionaryEnumerator miEnumerador = productos.GetEnumerator();

            // Podemos optar por un listado simple de los productos, siempre y cuando el método "Mostrar" saque la información lo suficientemente clara
            while (miEnumerador.MoveNext())
            {
                ((ProductoInformatico)miEnumerador.Value).Mostrar();
                Console.WriteLine();
            }

            /*
            
            //Otra opción es catalogar por categorías (primero mostrar los periféricos, por ejemplo, luego los portátiles y luego el resto)
            //Esta opción requeriría un bucle for anidado, para recorrerse una vez por cada categoría. Lo dejamos aquí comentado:

            // Categorías de productos
            string[] categorias = {"Periferico", "Portatil", "Otros"};

            for (int i = 0; i < categorias.Length; i++)
            {
                Console.WriteLine(categorias[i] + "\n\n");

                IDictionaryEnumerator miEnumerador = productos.GetEnumerator();

                // Podemos optar por un listado simple de los productos, siempre y cuando el método "Mostrar" saque la información lo suficientemente clara
                while (miEnumerador.MoveNext())
                {
                    if (((ProductoInformatico)miEnumerador.Value).GetType().ToString() == "TiendaInformatica." + categorias[i])
                    {
                        ((ProductoInformatico)miEnumerador.Value).Mostrar();
                        Console.WriteLine();
                    }
                }
            }

            */

        }

        public float CalcularTotal(List<string> lista)
        {
            float precioTotal = 0.0f;
            ProductoInformatico producto;

            for (int i = 0; i< lista.Count; i++)
            {
                producto = ObtenerProducto(lista[i]);

                if (!(producto == null))
                {
                    precioTotal += producto.Precio;
                }
            }
            
            return precioTotal;
        
        }
    }
}
