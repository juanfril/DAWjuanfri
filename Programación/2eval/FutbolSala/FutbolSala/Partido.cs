﻿using System;


namespace FutbolSala
{
    class Partido
    {
        private Equipo local = new Equipo();
        private Equipo visitante = new Equipo();
        public string modoJuego { get; set;  }
        public byte numeroJugadas { get; set; }

        public Partido (Equipo a, Equipo b)
        {
            local = a;
            visitante = b;
        }
        public void Jugada (byte turno)
        {
            while(numeroJugadas == 0)
            {
                int randomLocal = new Random().Next(0, 9);
                int randomVisitante = new Random().Next(0, 9);
                int capacidadDefensiva = 
                    visitante.jugadores[randomVisitante].CapacidadDefensiva();
                int capacidadAtacante =
                    visitante.jugadores[randomLocal].CapacidadAtacante(); ;

                if((randomLocal == 0 || randomLocal == 9) &&
                   (randomVisitante == 0 || randomVisitante == 9))
                {
                    numeroJugadas = numeroJugadas;
                }
                else
                {
                    if (capacidadDefensiva < capacidadAtacante)
                    {
                        Console.WriteLine("Jugador marcó gol");
                    }
                    else
                    {
                        Console.WriteLine("Jugador falló");
                    }
                }
            }
        }
    }
}
