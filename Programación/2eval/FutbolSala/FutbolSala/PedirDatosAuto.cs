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
            
            for (int i = 0; i < 10 ; i++)
            {
                int randomDorsal = new Random().Next(1, 15);
                int randomAltura = new Random().Next(120, 220);
                int randomAtaque = new Random().Next(1, 80);
                int randomDefensa = new Random().Next(1, 80);
                int randomNombre = new Random().Next(1, 16);
                int randomEspecial = new Random().Next(1, 10);

                if (i == 0 || i == 9)
                {
                    portero.nombre = nombresJugadores[randomNombre];
                    portero.dorsal = (byte)randomDorsal;
                    portero.altura = (byte)randomAltura;
                    portero.defensa = (byte)randomDefensa;
                    portero.ataque = (byte)randomAtaque;
                    portero.pararTiro = (byte)randomEspecial;
                }

                else if ((i > 0 && i < 3) || (i > 4 && i < 7))
                {
                    defensa.nombre = nombresJugadores[randomNombre];
                    defensa.dorsal = (byte)randomDorsal;
                    defensa.altura = (byte)randomAltura;
                    defensa.defensa = (byte)randomDefensa;
                    defensa.ataque = (byte)randomAtaque;
                    defensa.robarBalon = (byte)randomEspecial;
                    defensa.velocidad = (byte)randomEspecial;
                }

                else
                {
                    delantero.nombre = nombresJugadores[randomNombre];
                    delantero.dorsal = (byte)randomDorsal;
                    delantero.altura = (byte)randomAltura;
                    delantero.defensa = (byte)randomDefensa;
                    delantero.ataque = (byte)randomAtaque;
                    delantero.marcarGol = (byte)randomEspecial;
                    delantero.velocidad = (byte)randomEspecial;
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
