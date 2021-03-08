using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animales
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal[] animales = new Animal[5];

            animales[0] = new Perro("Bobby");
            animales[1] = new Gato("Isidoro");
            animales[2] = new Pato("Lucas");
            animales[3] = new Gallina("Caponata");
            animales[4] = new Pato("Donald");

            foreach(Animal a in animales)
            {
                a.Hablar();
            }

            Console.WriteLine();

            Ave[] aves = new Ave[3];
            aves[0] = new Gallina("Josefina");
            aves[1] = new Pato("Gilito");
            aves[2] = new Pato("Feo");

            foreach(Ave a in aves)
            {
                a.Volar();
            }
        }
    }
}
