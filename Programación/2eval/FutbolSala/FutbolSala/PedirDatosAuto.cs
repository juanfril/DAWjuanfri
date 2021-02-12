using System;

namespace FutbolSala
{
    class PedirDatosAuto
    {

        Equipo local = new Equipo();
        Portero portero = new Portero();
        Defensa defensa = new Defensa();
        Delantero delantero = new Delantero();
        private string[] nombresJugadores = { "Portero 1", "Defensa 1", 
            "Defensa 2", "Delantero 1", "Delantero 2", "Defensa 3", "Defensa 4",
            "Portero 2"};

        public Equipo CrearEquiposJugadores()
        {
            for (int i = 0; i < 10 ; i++)
            {
                int randomDorsal = new Random().Next(1, 15);
                int randomAltura = new Random().Next(120, 220);
                int randomAtaque = new Random().Next(1, 80);
                int randomDefensa = new Random().Next(1, 80);
                int randomEspecial = new Random().Next(1, 10);

                if (i == 0 || i == 9)
                {
                    local.jugadores[i].nombre = nombresJugadores[i];
                    local.jugadores[i].dorsal = (byte)randomDorsal;
                    local.jugadores[i].altura = (byte)randomAltura;
                    local.jugadores[i].defensa = (byte)randomDefensa;
                    local.jugadores[i].ataque = (byte)randomAtaque;
                    portero.pararTiro = (byte)randomEspecial;
                    local.jugadores[i] = portero;
                }

                else if ((i > 0 && i < 3) || (i > 4 && i < 7))
                {
                    local.jugadores[i].nombre = nombresJugadores[i];
                    local.jugadores[i].dorsal = (byte)randomDorsal;
                    local.jugadores[i].altura = (byte)randomAltura;
                    local.jugadores[i].defensa = (byte)randomDefensa;
                    local.jugadores[i].ataque = (byte)randomAtaque;
                    defensa.robarBalon = (byte)randomEspecial;
                    defensa.velocidad = (byte)randomEspecial;
                    local.jugadores[i] = defensa;
                }

                else
                {
                    local.jugadores[i].nombre = nombresJugadores[i];
                    delantero.dorsal = (byte)randomDorsal;
                    delantero.altura = (byte)randomAltura;
                    delantero.defensa = (byte)randomDefensa;
                    delantero.ataque = (byte)randomAtaque;
                    delantero.marcarGol = (byte)randomEspecial;
                    delantero.velocidad = (byte)randomEspecial;
                    local.jugadores[i] = delantero;
                }
            }
            return local;
        }
    }
}
