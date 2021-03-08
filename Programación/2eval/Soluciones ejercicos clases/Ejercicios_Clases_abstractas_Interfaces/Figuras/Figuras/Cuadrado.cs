using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figuras
{
    class Cuadrado: IFiguraGeometrica
    {
        double lado;

        public Cuadrado(double lado)
        {
            this.lado = lado;
        }

        public double CalcularArea()
        {
            return lado * lado;
        }

        public double CalcularPerimetro()
        {
            return 4 * lado;
        }
    }
}
