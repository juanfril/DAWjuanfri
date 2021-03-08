using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animales
{
    class Pato: Ave
    {
        public Pato(string nombre): base(nombre)
        { }

        public override void Hablar()
        {
            Console.WriteLine("Cuac cuac!");
        }

        public override void Volar()
        {
            Console.WriteLine("Estoy volando");
        }
    }
}
