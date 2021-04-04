using System;
using System.Collections.Generic;
using System.Reflection;

namespace TiendaInformatica
{
    class Catalogo
    {
        private SortedList<string, ProductoInformatico> catalogo;

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
            for (int i = 0; i < listaPropiedades.Length || correcto; i++)
            {
                string nombreAtributo = listaPropiedades[i].Name;
                string tipo = listaPropiedades.GetType().ToString();
                // Console.WriteLine(tipo);
                string valor = listaPropiedades[i].GetValue(producto).ToString();

                if (tipo.Equals("string") && !nombreAtributo.Equals("Codigo"))
                    correcto = Utilidades.ComprobarEntero(valor);
                else if (tipo.Equals("int"))
                    correcto = Utilidades.ComprobarEntero(valor);
                else if (tipo.Equals("float"))
                    correcto = Utilidades.ComprobarDecimal(valor);
                else if (tipo.Equals("string") && nombreAtributo.Equals("Codigo"))
                    correcto = Utilidades.ComprobarCodigo(valor, catalogo);
            }
        }
    }
}
