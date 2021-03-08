using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animales
{
    class Gato : Animal
    {
        public Gato(string nombre) : base(nombre)
        {
        }

        public override void Hablar()
        {
            Console.WriteLine("Miau!");
        }
    }
}
