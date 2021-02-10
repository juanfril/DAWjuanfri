using System;

namespace FutbolSala
{
    class PedirDatosAuto
    {

        Equipo local = new Equipo();
        Portero portero = new Portero();
        Defensa defensa = new Defensa();
        Delantero delantero = new Delantero();
        private string[] nombresJugadores = { "Oliver Atom", "Oliver Hutton", 
            "Taro Misaki", "Tom Misaki", "Tom Becker", "Eddie", "Carter",
            "David Newman", "Jacobo", "Timoty", "Vance", "Tim", "Paul Diamond",
            "Andy", "Bruce Harper", "Bob Denver", "Alan Crocker", "Bart" };

        public Equipo CrearEquiposJugadores()
        {
            
            for (int i = 0; i < 10; i++)
            {
                int randomDorsal = new Random().Next(1, 15);
                int randomAltura = new Random().Next(120, 220);
                int randomPorcentaje = new Random().Next(1, 80);
                int randomNombre = new Random().Next(1, 16);

                if (i == 0 || i == 9)
                {
                    portero.Nombre = nombresJugadores[randomNombre];
                    portero.Dorsal = (byte)randomDorsal;
                    portero.Altura = (byte)randomAltura;
                    portero.Defensa = (byte)randomPorcentaje;
                    portero.Ataque = (byte)randomPorcentaje;
                }

                else if ((i > 0 && i < 3) || (i > 4 && i < 7))
                {
                    defensa.Nombre = nombresJugadores[randomNombre];
                    defensa.Dorsal = (byte)randomDorsal;
                    defensa.Altura = (byte)randomAltura;
                    defensa.Defensa = (byte)randomPorcentaje;
                    defensa.Ataque = (byte)randomPorcentaje;
                }

                else
                {
                    delantero.Nombre = nombresJugadores[randomNombre];
                    delantero.Dorsal = (byte)randomDorsal;
                    delantero.Altura = (byte)randomAltura;
                    delantero.Defensa = (byte)randomPorcentaje;
                    delantero.Ataque = (byte)randomPorcentaje;
                }

                if (i == 0 || i == 9)
                    local.jugadores[i] = portero;
                else if ((i > 0 && i < 3) || (i > 4 && i < 7))
                    local.jugadores[i] = defensa;
                else
                    local.jugadores[i] = delantero;
            }
            return local;
        }
    }
}
