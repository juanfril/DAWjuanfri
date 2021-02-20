using System;


namespace FutbolSala
{
    class Partido
    {
        private Equipo Local = new Equipo();
        private Equipo Visitante = new Equipo();
        public string ModoJuego { get; set; }
        public byte NumeroJugadas { get; set; }

        public Partido (Equipo a, Equipo b)
        {
            Local = a;
            Visitante = b;
        }
        public void Jugada (byte turno)
        {
            int randomLocal = new Random().Next(0, 9);
            int randomVisitante = new Random().Next(0, 9);
            int ramdomGol = new Random().Next(0, 100);
            int capacidadAtacanteVisitante =
                Visitante.Jugadores[randomVisitante].CapacidadAtacante();
            int capacidadDefensivaVisitante = 
                Visitante.Jugadores[randomVisitante].CapacidadDefensiva();
            int capacidadAtacanteLocal =
                Local.Jugadores[randomLocal].CapacidadAtacante();
            int capacidadDefensivaLocal =
                Local.Jugadores[randomLocal].CapacidadDefensiva();

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
                                    " Tira a puerta. GOL!", Local.NombreEquipo,
                                    Local.Jugadores[randomLocal].Nombre);
                                    Local.Jugadores[randomLocal].Goles++;
                            }
                            else
                            {
                                Console.WriteLine("Ataca {0}. Juega {1}." +
                                    " Tira a puerta. FALLA!", Local.NombreEquipo,
                                    Local.Jugadores[randomLocal].Nombre);
                            }
                        }
                        else
                        {
                            Console.WriteLine("Ataca {0}. Juega {1}. {2}" +
                                " Roba el balón", Local.NombreEquipo,
                                Local.Jugadores[randomLocal].Nombre,
                                Visitante.Jugadores[randomVisitante].Nombre);
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
                                    " Tira a puerta. GOL!", Visitante.NombreEquipo,
                                    Visitante.Jugadores[randomVisitante].Nombre);
                                Visitante.Jugadores[randomVisitante].Goles++;
                            }
                            else
                            {
                                Console.WriteLine("Ataca {0}. Juega {1}." +
                                    " Tira a puerta. FALLA!", Visitante.NombreEquipo,
                                    Visitante.Jugadores[randomVisitante].Nombre);
                            }
                        }
                        else
                        {
                            Console.WriteLine("Ataca {0}. Juega {1}. {2}" +
                                " Roba el balón", Visitante.NombreEquipo,
                                Visitante.Jugadores[randomVisitante].Nombre,
                                Local.Jugadores[randomLocal].Nombre);
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
