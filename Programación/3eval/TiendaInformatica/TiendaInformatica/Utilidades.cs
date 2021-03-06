﻿using System;
using System.Collections.Generic;

namespace TiendaInformatica
{
    class Utilidades
    {
        public static bool ComprobarCadena(string texto)
        {
            bool correcto = true;

            if (String.IsNullOrEmpty(texto))
            {
                correcto = false;
            }

            return correcto;
        }
        public static bool ComprobarEntero(string texto)
        {
            bool correcto = false;
            int numero;

            if (int.TryParse(texto, out numero) || numero >= 0)
                correcto = true;

            return correcto;
        }
        public static bool ComprobarDecimal(string texto)
        {
            bool correcto = false;
            float numero;

            if (Single.TryParse(texto, out numero) || numero >= 0)
                correcto = true;

            return correcto;
        }
        public static bool ComprobarCodigo(string texto,
            SortedList<string, ProductoInformatico> catalogo)
        {
            bool correcto = true;

                if (String.IsNullOrEmpty(texto) || catalogo.ContainsKey(texto))
                    correcto = false;
            
            return correcto;
        }
        public static void Pausa()
        {
            Console.WriteLine("\nPresione una tecla para continuar");
            Console.ReadKey();
        }
    }
}
