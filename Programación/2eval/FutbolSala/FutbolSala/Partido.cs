using System;


namespace FutbolSala
{
    class Partido
    {
        private Equipo local = new Equipo();
        private Equipo visitante = new Equipo();
        public string modoJuego { get; set; }
        public byte numeroJugadas { get; set; }

        public Partido (Equipo a, Equipo b)
        {
            local = a;
            visitante = b;
        }
        public void Jugada (byte turno)
        {
            int randomLocal = new Random().Next(0, 9);
            int randomVisitante = new Random().Next(0, 9);
            int ramdomGol = new Random().Next(0, 100);
            int capacidadAtacanteVisitante =
                visitante.jugadores[randomVisitante].CapacidadAtacante();
            int capacidadDefensivaVisitante = 
                visitante.jugadores[randomVisitante].CapacidadDefensiva();
            int capacidadAtacanteLocal =
                local.jugadores[randomLocal].CapacidadAtacante();
            int capacidadDefensivaLocal =
                local.jugadores[randomLocal].CapacidadDefensiva();

            switch (turno)
            {
                case 1:
                    if ((randomLocal == randomVisitante) &&
                        (randomVisitante == 0 || randomVisitante == 9))
                    {
                        numeroJugadas = numeroJugadas;
                    }
                    else
                    {
                        if (capacidadDefensivaVisitante < capacidadAtacanteLocal)
                        {
                            if(capacidadAtacanteLocal > ramdomGol)
                            {
                                Console.WriteLine("Ataca {0}. Juega {1}. Tira a puerta. GOL!",
                                    local.nombreEquipo,
                                    local.jugadores[randomLocal].nombre);
                                    local.jugadores[randomLocal].goles++;
                            }
                            else
                            {
                                Console.WriteLine("Ataca {0}. Juega {1}. Tira a puerta. FALLA!",
                                    local.nombreEquipo,
                                    local.jugadores[randomLocal].nombre);
                            }
                        }
                        else
                        {
                            Console.WriteLine("Ataca {0}. Juega {1}. {2} Roba el balón",
                                local.nombreEquipo,
                                local.jugadores[randomLocal].nombre,
                                visitante.jugadores[randomVisitante].nombre);
                        }
                    }
                    break;

                case 2:
                    if ((randomLocal == randomVisitante) &&
                        (randomVisitante == 0 || randomVisitante == 9))
                    {
                        numeroJugadas = numeroJugadas;
                    }
                    if (capacidadDefensivaLocal < capacidadAtacanteVisitante)
                    {
                        if (capacidadAtacanteVisitante > ramdomGol)
                        {
                            Console.WriteLine("Ataca {0}. Juega {1}. Tira a puerta. GOL!",
                                visitante.nombreEquipo,
                                visitante.jugadores[randomVisitante].nombre);
                                visitante.jugadores[randomVisitante].goles++;
                        }
                        else
                        {
                            Console.WriteLine("Ataca {0}. Juega {1}. Tira a puerta. FALLA!",
                                visitante.nombreEquipo,
                                visitante.jugadores[randomVisitante].nombre);
                        }
                    }
                    else
                    {
                        Console.WriteLine("Ataca {0}. Juega {1}. {2} Roba el balón",
                            visitante.nombreEquipo,
                            visitante.jugadores[randomVisitante].nombre,
                            local.jugadores[randomLocal].nombre);
                    }
                    break;

                default:
                    Console.WriteLine("No entiendo la jugada");
                    break;
            }
        }
    }
}
