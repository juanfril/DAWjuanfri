using System;

namespace FutbolSala
{
    /*
     * La clase Partido gestiona dos equipos y sus jugadas alternas
     */
    class Partido
    {
        // Generador de números aleatorios para las jugadas
        // Se define estático para no repetir siempre los mismos números
        public static Random random = new Random();

        // Equipos que conforman el partido
        private Equipo equipo1, equipo2;

        // Constructor
        public Partido(Equipo eq1, Equipo eq2)
        {
            equipo1 = eq1;
            equipo2 = eq2;
        }

        // Realiza una jugada entre jugador de ataque contra jugador de defensa
        private string Jugar(Jugador atacante, Jugador defensor)
        {
            string resultado = "";
            if (atacante.CapacidadAtaque() > defensor.CapacidadDefensa())
            {
                resultado += "Tira a puerta. ";
                if (random.Next(0, 100) <= atacante.CapacidadAtaque())
                {
                    atacante.Goles++;
                    resultado += "Gol!";
                }
                else
                {
                    resultado += "Falla!";
                }
            }
            else
            {
                resultado += "Roba " + defensor.Nombre + ".";
            }
            return resultado;
        }


        // Método auxiliar para elegir aleatoriamente al atacante y defensor de cada equipo
        private void ElegirJugadores(byte equipoAtacante, out Jugador atacante, out Jugador defensor)
        {
            // Se elige la posición de los jugadores aleatoriamente
            int jugadorAtaque;
            int jugadorDefensa = random.Next(0, Constants.MAX_JUGADORES);

            // Evita que se enfrenten 2 porteros
            if (jugadorDefensa == 0 || jugadorDefensa == (Constants.MAX_JUGADORES - 1))
            {
                jugadorAtaque = random.Next(1, Constants.MAX_JUGADORES - 2);
            }
            else
                jugadorAtaque = random.Next(0, Constants.MAX_JUGADORES - 1);

            // Se establece el atacante y defensor para esa posición, según el equipo que ataca y defiende
            if (equipoAtacante == 1)
            {
                atacante = equipo1.Jugadores[jugadorAtaque];
                defensor = equipo2.Jugadores[jugadorDefensa];
            }
            else
            {
                atacante = equipo2.Jugadores[jugadorDefensa];
                defensor = equipo1.Jugadores[jugadorAtaque];
            }
        }


        // Método Jugada, que se encarga de la lógica de cada jugada alterna
        public string Jugada(byte equipoAtacante)
        {
            Jugador atacante, defensor;
            string resultado="";

            // Establecer el turno
            resultado = "Ataca " + (equipoAtacante == 1 ? equipo1.Nombre : equipo2.Nombre) + ". ";

            // Elegir jugador atacante y su defensor
            ElegirJugadores(equipoAtacante, out atacante, out defensor);
            resultado += "Juega " + atacante.Nombre + ". ";

            resultado += Jugar(atacante, defensor);

            return resultado;
        }
    }
}
