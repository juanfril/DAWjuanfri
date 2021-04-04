using System;
using System.Collections.Generic;
using System.Text;

namespace TiendaInformatica
{
    class Perifericos : ProductoInformatico
    {
        private string nombre, conexion;

        public Perifericos() :base()
        {
            nombre = "ninguno";
            conexion = "indefinida";
        }

        public string Nombre { get; set; }
        public string Conexion { get; set; }

        public override string ToString()
        {
            return "Nombre: " + Nombre + " |Conexión: " + Conexion + base.ToString();
        }
    }
}
