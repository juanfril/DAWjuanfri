using System;

namespace FutbolSala
{
    class Program
    {
        static void Main(string[] args)
        {
            Portero j1 = new Portero();

            j1.Nombre = "Portero";
            Console.WriteLine(j1.ToString());
            Console.WriteLine(j1.MostrarResumen("Portero"));

            Console.WriteLine();

            Defensa j2 = new Defensa();
            j2.Nombre = "Defensa";
            Console.WriteLine(j2.ToString());
            Console.WriteLine(j2.MostrarResumen("Defensa"));

            Console.WriteLine();

            Delantero j3 = new Delantero();
            j3.Nombre = "Delantero";
            Console.WriteLine(j3.ToString());
            Console.WriteLine(j3.MostrarResumen("Delantero"));
        }
    }
}
