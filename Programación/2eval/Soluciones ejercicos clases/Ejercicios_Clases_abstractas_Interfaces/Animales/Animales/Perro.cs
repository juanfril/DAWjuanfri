using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animales
{
    class Perro: Animal
    {
        public Perro(string nombre): base(nombre)
        {
        }

        public override void Hablar()
        {
            Console.WriteLine("Guau!");
        }
    }
}
