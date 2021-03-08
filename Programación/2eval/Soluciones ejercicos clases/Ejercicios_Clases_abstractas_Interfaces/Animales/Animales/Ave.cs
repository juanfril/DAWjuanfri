using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animales
{
    abstract class Ave: Animal
    {
        public Ave(string nombre): base(nombre)
        { }

        public abstract void Volar();
    }
}
