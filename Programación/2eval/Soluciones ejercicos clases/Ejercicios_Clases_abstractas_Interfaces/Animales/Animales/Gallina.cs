using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animales
{
    class Gallina : Ave
    {
        public Gallina(string nombre) : base(nombre)
        { }

        public override void Hablar()
        {
            Console.WriteLine("Coc coc!");
        }

        public override void Volar()
        {
            Console.WriteLine("Soy un ave pero no puedo volar!");
        }
    }
}
