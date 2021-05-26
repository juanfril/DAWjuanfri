using System;

namespace TiendaInformatica
{
    /*
     * Subtipo de producto informático: ordenadores portátiles, con su información específica
     */ 
    class Portatil: ProductoInformatico
    {
        private float pantalla;
        private short ram;
        private short disco;

        public float Pantalla
        {
            get
            {
                return pantalla;
            }
            set
            {
                pantalla = value;
            }
        }
        public short Ram
        {
            get
            {
                return ram;
            }
            set
            {
                ram = value;
            }
        }
        public short Disco
        {
            get
            {
                return disco;
            }
            set
            {
                disco = value;
            }
        }

        public Portatil(string codigo, string marca, string modelo, float precio, float pantalla, short ram, short disco)
        : base(codigo, marca, modelo, precio)
        {
            Pantalla = pantalla;
            Ram = ram;
            Disco = disco;
        }

        public override void Mostrar()
        {
            base.Mostrar();
            Console.Write(" | " + Pantalla + " | " + Ram + " |  " + Disco);
        }

    }
}
