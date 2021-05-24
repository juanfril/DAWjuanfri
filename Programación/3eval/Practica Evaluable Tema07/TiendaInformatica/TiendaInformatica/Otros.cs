using System;

namespace TiendaInformatica
{
    /*
     * Subtipo de producto informático: otros productos
     */ 
    class Otros: ProductoInformatico
    {
        private string nombre;
        private string descripcion;

        public string Nombre
        {
            get
            {
                return nombre;
            }
            set
            {
                nombre = value;
            }
        }
        public string Descripcion
        {
            get
            {
                return descripcion;
            }
            set
            {
                descripcion = value;
            }
        }

        public Otros(string codigo, string marca, string modelo, float precio, string nombre, string descripcion)
        : base(codigo, marca, modelo, precio)
        {
            Nombre = nombre;
            Descripcion = descripcion;
        }

        public override void Mostrar()
        {
            base.Mostrar();
            Console.Write(" | " + Nombre + " | " + Descripcion);
        }
    }
}
