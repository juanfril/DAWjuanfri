using System;
using System.Collections.Generic;
using System.Text;

namespace TiendaInformatica
{
    class Portatiles : ProductoInformatico
    {
        private float tamanyoPantalla;
        private int ram, discoDuro;

        public Portatiles() : base()
        {
            tamanyoPantalla = 0.00f;
            ram = 0;
            discoDuro = 0;
        }

        public float TamanyoPantalla { get; set; }
        public int Ram { get; set; }
        public int DiscoDuro { get; set; }

        public override string ToString()
        {
            return base.ToString() + " |Tamaño de pantalla: " + TamanyoPantalla + 
                " |Ram instalada: " + Ram + " GB |Disco duro: " + DiscoDuro + " GB";
        }
    }
}
