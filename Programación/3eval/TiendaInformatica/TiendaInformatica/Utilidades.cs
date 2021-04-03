using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace TiendaInformatica
{
    class Utilidades
    {
        public static bool ComprobarCadena(string texto)
        {
            bool error = false;

            if (String.IsNullOrEmpty(texto))
                error = true;

            return error;
        }
        public static bool ComprobarNumero(int numero)
        {
            bool error = false;

            if (numero <= 0)
                error = true;

            return error;
        }
        public static bool ComprobarCodigo(string texto, SortedList catalogo)
        {
            bool error = false;

            if (catalogo.ContainsKey(texto))
                error = true;

            return error;
        }
    }
}
