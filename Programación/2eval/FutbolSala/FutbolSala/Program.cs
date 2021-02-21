/*
Losa Márquez, Juan Fco.
Practica Evaluable Tema 6
Apartado 1 si
Apartado 2
Apartado 3
Apartado 4
 */

using System;

namespace FutbolSala
{
    class Program
    {
        static void Main(String[] args)
        {
            /*PedirDatosAuto generaEquipo1 = new PedirDatosAuto();
            Equipo local = generaEquipo1.CrearEquipoLocal();

            PedirDatosAuto generaEquipo2 = new PedirDatosAuto();
            Equipo visitante = generaEquipo2.CrearEquipoVisitante();

            /*Equipo local = PedirDatos.PedirEquipo();
            Equipo visitante = PedirDatos.PedirEquipo();*/

            Equipo local = new Equipo();
            Equipo visitante = new Equipo();

            Partido p1 = new Partido(local, visitante);
            p1.NumeroJugadas = 10;
            for (int i = 0; i < p1.NumeroJugadas; i++)
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