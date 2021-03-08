using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figuras
{
    class Program
    {
        static void Main(string[] args)
        {
            IFiguraGeometrica[] figuras = new IFiguraGeometrica[4];
            figuras[0] = new Cuadrado(10);
            figuras[1] = new Cuadrado(2.5);
            figuras[2] = new Circulo(5);
            figuras[3] = new Circulo(3.25);

            foreach(IFiguraGeometrica f in figuras)
            {
                Console.WriteLine("Area: {0:N2}, Perímetro: {1:N2}", f.CalcularArea(), f.CalcularPerimetro());
            }
        }
    }
}
