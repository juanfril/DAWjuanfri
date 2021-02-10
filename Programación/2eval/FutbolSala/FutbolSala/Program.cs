using System;

namespace FutbolSala
{
    class Program
    {
        static void Main()
        {
            PedirDatosAuto generaEquipo = new PedirDatosAuto();
            Equipo equipo1 = generaEquipo.CrearEquiposJugadores();
            Equipo equipo2 = generaEquipo.CrearEquiposJugadores();

            equipo1.MostrarJugadores();
        }
    }
}
