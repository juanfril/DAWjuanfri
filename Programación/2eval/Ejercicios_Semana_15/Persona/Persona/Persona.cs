using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persona
{
    class Persona
    {
        string nombre;

        public void SetNombre(string n)
        {
            nombre = n;
        }

        public void Saludar()
        {
            Console.WriteLine("Hola, soy " + nombre);
        }
    }
}
