using System;
using System.Collections.Generic;
using System.Text;

namespace TiendaInformatica
{
    class Componentes : ProductoInformatico
    {
        private string nombre, descripcion;

        public Componentes() : base()
        {
            nombre = "ninguno";
            descripcion = "Sin descripción";
        }

        public string Nombre { get; set; }
        public string Descripcion { get; set; }

        public override string ToString()
        {
            return "Nombre: " + Nombre + " |Descripción : " + Descripcion + base.ToString();
        }
    }
}
