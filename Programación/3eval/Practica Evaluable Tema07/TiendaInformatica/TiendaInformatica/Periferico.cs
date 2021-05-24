using System;

namespace TiendaInformatica
{
    /*
     * Subtipo de producto informático: periféricos, con su información específica adicional
     */ 
    class Periferico : ProductoInformatico
    {
        private string nombre;
        private string conexion;

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
        public string Conexion
        {
            get
            {
                return conexion;
            }
            set
            {
                conexion = value;
            }
        }

        public Periferico(string codigo, string marca, string modelo, float precio, string nombre, string conexion)
        : base(codigo, marca, modelo, precio)
        {
            Nombre = nombre;
            Conexion = conexion;
        }

        public override void Mostrar()
        {
            base.Mostrar();
            Console.Write(" | " + Nombre + " | " + Conexion);
        }

    }
}
