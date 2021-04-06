using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;

namespace TiendaInformatica
{
    class Catalogo
    {
        private SortedList<string, ProductoInformatico> catalogo;
        private IEnumerator<KeyValuePair<string, ProductoInformatico>> catalogoEnumerador;

        public Catalogo()
        {
            catalogo = new SortedList<string, ProductoInformatico>();
        }

        public bool NuevoProducto(ProductoInformatico producto)
        {
            bool correcto = true;
            string tipoProducto = producto.GetType().ToString();

            if (tipoProducto.Equals("TiendaInformatica.Componentes"))
            {
                PropertyInfo[] listaComponentes = typeof(Componentes).GetProperties();
                ComprobarParametros(listaComponentes, ref correcto, producto);
            }
            else if (tipoProducto.Equals("TiendaInformatica.Portatiles"))
            {
                PropertyInfo[] listaPortatiles = typeof(Portatiles).GetProperties();
                ComprobarParametros(listaPortatiles, ref correcto, producto);

            }
            else
            {
                PropertyInfo[] listaPerifericos = typeof(Perifericos).GetProperties();
                ComprobarParametros(listaPerifericos, ref correcto, producto);
            }

            if (correcto)
                catalogo.Add(producto.Codigo, producto);

            return correcto;
        }
        private void ComprobarParametros(PropertyInfo[] listaPropiedades, ref bool correcto,
            ProductoInformatico producto)
        {
            for (int i = 0; i < listaPropiedades.Length && correcto; i++)
            {
                string nombreAtributo = listaPropiedades[i].Name;
                //Type tipo = listaPropiedades[i].GetType();
                //Console.WriteLine(tipo.DeclaringType);
                string valor = listaPropiedades[i].GetValue(producto).ToString();

                if (nombreAtributo.Equals("Nombre") || nombreAtributo.Equals("Marca") ||
                    nombreAtributo.Equals("Modelo") || nombreAtributo.Equals("Descripcion") ||
                    nombreAtributo.Equals("Conexion"))
                {
                    correcto = Utilidades.ComprobarCadena(valor);
                }
                else if (nombreAtributo.Equals("Ram") || nombreAtributo.Equals("DiscoDuro"))
                {
                    correcto = Utilidades.ComprobarEntero(valor);
                }
                else if (nombreAtributo.Equals("Precio") || nombreAtributo.Equals("TamanyoPantalla"))
                    correcto = Utilidades.ComprobarDecimal(valor);
                else if (nombreAtributo.Equals("Codigo"))
                    correcto = Utilidades.ComprobarCodigo(valor, catalogo);
            }
        }

        public void ListarCatalogo()
        {
            catalogoEnumerador = catalogo.GetEnumerator();

            if (!catalogoEnumerador.MoveNext())
            {
                Console.WriteLine("Nada que mostrar");
                Console.ReadKey();
            }
            else
            {
                catalogoEnumerador.Reset();
                while (catalogoEnumerador.MoveNext())
                {
                    Console.WriteLine(catalogoEnumerador.Current.Value);
                    Console.WriteLine();
                }
                Console.ReadKey();
            }
        }

        public bool EliminarProducto(string codigo)
        {
            bool eliminado = false;

            if (catalogo.ContainsKey(codigo))
            {
                catalogo.Remove(codigo);
                eliminado = true;
            }

            return eliminado;
        }

        public ProductoInformatico ObtenerProducto(string codigo)
        {
            string codigoVuelta = null;

            foreach (KeyValuePair<string, ProductoInformatico> key in catalogo)
            {
                if (catalogo.ContainsKey(codigo))
                    codigoVuelta = key.Key;
            }

            return catalogo[codigoVuelta];
        } 

        public float CalcularTotal(List<string> listaCarro)
        {
            float total = 0;

            foreach (string s in listaCarro)
            {
                if (catalogo.ContainsKey(s))
                {
                    total += catalogo[s].Precio;
                    Console.WriteLine(catalogo[s]);
                }
            }

            return total;
        }
    }
}
