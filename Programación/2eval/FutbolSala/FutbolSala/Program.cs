using System;

namespace FutbolSala
{
    class Program
    {
        static void Main()
        {
            PedirDatosAuto generaEquipo1 = new PedirDatosAuto();
            Equipo local = generaEquipo1.CrearEquiposJugadores();

            PedirDatosAuto generaEquipo2 = new PedirDatosAuto();
            Equipo visitante = generaEquipo2.CrearEquiposJugadores();

            local.MostrarJugadores();
            Console.WriteLine();
            visitante.MostrarJugadores();
            Console.WriteLine();
            local.MostrarEstadisticas();

            foreach (var item in local.jugadores)
            {
                Console.WriteLine(item.GetType());
            }
            
        }
    }
}