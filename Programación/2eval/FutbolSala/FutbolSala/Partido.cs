using System;


namespace FutbolSala
{
    class Partido
    {
        private Equipo local = new Equipo();
        private Equipo visitante = new Equipo();
        private byte numeroJugadas;
        private string modoJuego;
        public byte NumeroJugadas
        { 
            get => numeroJugadas;
            set => numeroJugadas = value;
        }
        public string ModoJuego
        {
            get => modoJuego;
            set => modoJuego = value;
        }

        public Partido (Equipo a, Equipo b)
        {
            local = a;
            visitante = b;
        }

        public void PartidoCompleto(Partido partido)
        {
            for (int i = 0; i < numeroJugadas; i++)
            {
                for (byte j = 1; j < 3; j++)
                {
                    partido.JugadaCompleta(j);
                }
            }
        }

        public void PartidoResumen(Partido partido)
        {
            for (int i = 0; i < numeroJugadas; i++)
            {
                for (byte j = 1; j < 3; j++)
                {
                    partido.JugadaResumen(j);
                }
            }
        }

        public void JugadaResumen(byte turno)
        {
            int randomLocal = new Random().Next(0, 9);
            int randomVisitante = new Random().Next(0, 9);
            int ramdomGol = new Random().Next(0, 100);
            int capacidadAtacanteVisitante =
                visitante.Jugadores[randomVisitante].CapacidadAtacante();
            int capacidadDefensivaVisitante =
                visitante.Jugadores[randomVisitante].CapacidadDefensiva();
            int capacidadAtacanteLocal =
                local.Jugadores[randomLocal].CapacidadAtacante();
            int capacidadDefensivaLocal =
                local.Jugadores[randomLocal].CapacidadDefensiva();

            switch (turno)
            {
                case 1:
                    if ((randomLocal == randomVisitante) &&
                        (randomVisitante == 0 || randomVisitante == 9))
                    {
                        NumeroJugadas = NumeroJugadas;
                    }
                    else
                    {
                        if (capacidadDefensivaVisitante < capacidadAtacanteLocal)
                        {
                            if (capacidadAtacanteLocal > ramdomGol)
                                local.Jugadores[randomLocal].Goles++;
                        }
                    }
                    break;

                case 2:
                    if ((randomLocal == randomVisitante) &&
                        (randomVisitante == 0 || randomVisitante == 9))
                    {
                        NumeroJugadas = NumeroJugadas;
                    }
                    else
                    {
                        if (capacidadDefensivaLocal < capacidadAtacanteVisitante)
                        {
                            if (capacidadAtacanteVisitante > ramdomGol)
                                visitante.Jugadores[randomVisitante].Goles++;
                        }
                    }
                    break;

                default:
                    Console.WriteLine("No entiendo la jugada");
                    break;
            }
        }
        public void JugadaCompleta (byte turno)
        {
            int randomLocal = new Random().Next(0, 9);
            int randomVisitante = new Random().Next(0, 9);
            int ramdomGol = new Random().Next(0, 100);
            int capacidadAtacanteVisitante =
                visitante.Jugadores[randomVisitante].CapacidadAtacante();
            int capacidadDefensivaVisitante = 
                visitante.Jugadores[randomVisitante].CapacidadDefensiva();
            int capacidadAtacanteLocal =
                local.Jugadores[randomLocal].CapacidadAtacante();
            int capacidadDefensivaLocal =
                local.Jugadores[randomLocal].CapacidadDefensiva();

            switch (turno)
            {
                case 1:
                    if ((randomLocal == randomVisitante) &&
                        (randomVisitante == 0 || randomVisitante == 9))
                    {
                        NumeroJugadas = NumeroJugadas;
                    }
                    else
                    {
                        if (capacidadDefensivaVisitante < capacidadAtacanteLocal)
                        {
                            if(capacidadAtacanteLocal > ramdomGol)
                            {
                                Console.WriteLine("Ataca {0}. Juega {1}." +
                                    " Tira a puerta. GOL!", local.NombreEquipo,
                                    local.Jugadores[randomLocal].Nombre);
                                    local.Jugadores[randomLocal].Goles++;
                            }
                            else
                            {
                                Console.WriteLine("Ataca {0}. Juega {1}." +
                                    " Tira a puerta. FALLA!", local.NombreEquipo,
                                    local.Jugadores[randomLocal].Nombre);
                            }
                        }
                        else
                        {
                            Console.WriteLine("Ataca {0}. Juega {1}. {2}" +
                                " Roba el balón", local.NombreEquipo,
                                local.Jugadores[randomLocal].Nombre,
                                visitante.Jugadores[randomVisitante].Nombre);
                        }
                    }
                    break;

                case 2:
                    if ((randomLocal == randomVisitante) &&
                        (randomVisitante == 0 || randomVisitante == 9))
                    {
                        NumeroJugadas = NumeroJugadas;
                    }
                    else
                    {
                        if (capacidadDefensivaLocal < capacidadAtacanteVisitante)
                        {
                            if (capacidadAtacanteVisitante > ramdomGol)
                            {
                                Console.WriteLine("Ataca {0}. Juega {1}." +
                                    " Tira a puerta. GOL!", visitante.NombreEquipo,
                                    visitante.Jugadores[randomVisitante].Nombre);
                                visitante.Jugadores[randomVisitante].Goles++;
                            }
                            else
                            {
                                Console.WriteLine("Ataca {0}. Juega {1}." +
                                    " Tira a puerta. FALLA!", visitante.NombreEquipo,
                                    visitante.Jugadores[randomVisitante].Nombre);
                            }
                        }
                        else
                        {
                            Console.WriteLine("Ataca {0}. Juega {1}. {2}" +
                                " Roba el balón", visitante.NombreEquipo,
                                visitante.Jugadores[randomVisitante].Nombre,
                                local.Jugadores[randomLocal].Nombre);
                        }
                    }
                    break;

                default:
                    Console.WriteLine("No entiendo la jugada");
                    break;
            }
        }
    }
}
