/*
Losa Márquez, Juan Fco.
Practica Evaluable Tema 6
Apartado 1 si
Apartado 2 si ; pero sin modulizar el método Jugada
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
            string modoJuego = "";
            byte numeroJugadas;

            if (!args[0].ToUpper().Equals("R") || !args[0].ToUpper().Equals("C"))
                Console.WriteLine("Tiene que elegir el modo de juego");
            else
                modoJuego = args[0];

            if (Byte.TryParse(args[1], out numeroJugadas))
            {
                if(numeroJugadas < 10 || numeroJugadas > 30)
                    Console.WriteLine("Tiene que elegir un número del 10 al 30");
                else
                    Console.WriteLine("Ha elegido {0} jugadas", numeroJugadas);
            }
            else
                Console.WriteLine("No ha introducido un valor correcto");

            if((numeroJugadas > 10 && numeroJugadas < 31) &&
                !string.IsNullOrEmpty(modoJuego))
            {
                Equipo local = new Equipo();
                Equipo visitante = new Equipo();

                local.NombreEquipo = PedirDatos.PedirEquipo();
                for (int i = 0; i < 10; i++)
                {
                    if (i == 0 || i == 9)
                        local.Jugadores[i] = PedirDatos.PedirPortero();
                    else if ((i > 0 && i < 3) || (i > 4 && i < 7))
                        local.Jugadores[i] = PedirDatos.PedirDefensa();
                    else
                        local.Jugadores[i] = PedirDatos.PedirDelantero();

                }

                visitante.NombreEquipo = PedirDatos.PedirEquipo();
                for (int i = 0; i < 10; i++)
                {
                    if (i == 0 || i == 9)
                        visitante.Jugadores[i] = PedirDatos.PedirPortero();
                    else if ((i > 0 && i < 3) || (i > 4 && i < 7))
                        visitante.Jugadores[i] = PedirDatos.PedirDefensa();
                    else
                        visitante.Jugadores[i] = PedirDatos.PedirDelantero();
                }

                Partido partido = new Partido(local, visitante);
                partido.ModoJuego = modoJuego;
                partido.NumeroJugadas = numeroJugadas;

                if (modoJuego.ToUpper().Equals("C"))
                {
                    partido.PartidoCompleto(partido);
                    local.MostrarEstadisticas();
                    visitante.MostrarEstadisticas();
                }
            }
            else
                Console.WriteLine("Vuelva a intentarlo");

            Console.ReadKey();

            //Modo automático
            /*PedirDatosAuto generaEquipo1 = new PedirDatosAuto();
            Equipo local = generaEquipo1.CrearEquipoLocal();
            local.NombreEquipo = "Local";

            PedirDatosAuto generaEquipo2 = new PedirDatosAuto();
            Equipo visitante = generaEquipo2.CrearEquipoVisitante();
            visitante.NombreEquipo = "Visitante";

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
            visitante.MostrarEstadisticas();*/
        }
    }
}