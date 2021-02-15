using System;

namespace FutbolSala
{
    class Program
    {
        static void Main()
        {
            PedirDatosAuto generaEquipo1 = new PedirDatosAuto();
            Equipo local = generaEquipo1.CrearEquipoLocal();

            PedirDatosAuto generaEquipo2 = new PedirDatosAuto();
            Equipo visitante = generaEquipo2.CrearEquipoVisitante();

            Partido p1 = new Partido(local, visitante);
            p1.numeroJugadas = PedirDatos.PedirNumeroJugadas();
            for (int i = 0; i < p1.numeroJugadas; i++)
            {
                for (byte j = 1; j < 3; j++)
                {
                    p1.Jugada(j);
                }
            }

            Console.WriteLine();
            local.MostrarEstadisticas();
            Console.WriteLine();
            visitante.MostrarEstadisticas();
        }
    }
}