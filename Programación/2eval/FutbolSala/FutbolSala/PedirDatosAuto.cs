using System;

namespace FutbolSala
{
    class PedirDatosAuto
    {
        public Equipo CrearEquipoLocal()
        {
            Equipo local = new Equipo();
            Portero portero = new Portero();
            Defensa defensa = new Defensa();
            Delantero delantero = new Delantero();

            string[] nombresJugadores = {"Portero 1", "Defensa 1",
                "Defensa 2", "Delantero 1", "Delantero 2", "Defensa 3", "Defensa 4",
                "Delantero 3", "Delantero 4", "Portero 2"};

        
            for (int i = 0; i < 10 ; i++)
            {
                int randomDorsal = new Random().Next(1, 15);
                int randomAltura = new Random().Next(120, 220);
                int randomAtaque = new Random().Next(1, 80);
                int randomDefensa = new Random().Next(1, 80);
                int randomEspecial = new Random().Next(1, 10);

                if (i == 0 || i == 9)
                {
                    portero.Nombre = nombresJugadores[i];
                    portero.Dorsal = (byte)randomDorsal;
                    portero.Altura = (byte)randomAltura;
                    portero.Defensa = (byte)randomDefensa;
                    portero.Ataque = (byte)randomAtaque;
                    portero.PararTiro = (byte)randomEspecial;
                    local.Jugadores[i] = portero;
                }

                else if ((i > 0 && i < 3) || (i > 4 && i < 7))
                {
                    defensa.Nombre = nombresJugadores[i];
                    defensa.Dorsal = (byte)randomDorsal;
                    defensa.Altura = (byte)randomAltura;
                    defensa.Defensa = (byte)randomDefensa;
                    defensa.Ataque = (byte)randomAtaque;
                    defensa.RobarBalon = (byte)randomEspecial;
                    defensa.Velocidad = (byte)randomEspecial;
                    local.Jugadores[i] = defensa;
                }

                else
                {
                    delantero.Nombre = nombresJugadores[i];
                    delantero.Dorsal = (byte)randomDorsal;
                    delantero.Altura = (byte)randomAltura;
                    delantero.Defensa = (byte)randomDefensa;
                    delantero.Ataque = (byte)randomAtaque;
                    delantero.MarcarGol = (byte)randomEspecial;
                    delantero.Velocidad = (byte)randomEspecial;
                    local.Jugadores[i] = delantero;
                }
            }
            return local;
        }

        public Equipo CrearEquipoVisitante()
        {
            Equipo visitante = new Equipo();
            Portero portero = new Portero();
            Defensa defensa = new Defensa();
            Delantero delantero = new Delantero();
                    string[] nombresJugadores = { "Golkeeper 1", "Defense 1",
                        "Defense 2", "Forward 1", "Forward 2", "Defense 3", "Defense 4",
                        "Forward 3", "Forward 4", "Golkeeper 2"};


            for (int i = 0; i < 10; i++)
            {
                int randomDorsal = new Random().Next(1, 15);
                int randomAltura = new Random().Next(120, 220);
                int randomAtaque = new Random().Next(1, 80);
                int randomDefensa = new Random().Next(1, 80);
                int randomEspecial = new Random().Next(1, 10);

                if (i == 0 || i == 9)
                {
                    portero.Nombre = nombresJugadores[i];
                    portero.Dorsal = (byte)randomDorsal;
                    portero.Altura = (byte)randomAltura;
                    portero.Defensa = (byte)randomDefensa;
                    portero.Ataque = (byte)randomAtaque;
                    portero.PararTiro = (byte)randomEspecial;
                    visitante.Jugadores[i] = portero;
                }

                else if ((i > 0 && i < 3) || (i > 4 && i < 7))
                {
                    defensa.Nombre = nombresJugadores[i];
                    defensa.Dorsal = (byte)randomDorsal;
                    defensa.Altura = (byte)randomAltura;
                    defensa.Defensa = (byte)randomDefensa;
                    defensa.Ataque = (byte)randomAtaque;
                    defensa.RobarBalon = (byte)randomEspecial;
                    defensa.Velocidad = (byte)randomEspecial;
                    visitante.Jugadores[i] = defensa;
                }

                else
                {
                    delantero.Nombre = nombresJugadores[i];
                    delantero.Dorsal = (byte)randomDorsal;
                    delantero.Altura = (byte)randomAltura;
                    delantero.Defensa = (byte)randomDefensa;
                    delantero.Ataque = (byte)randomAtaque;
                    delantero.MarcarGol = (byte)randomEspecial;
                    delantero.Velocidad = (byte)randomEspecial;
                    visitante.Jugadores[i] = delantero;
                }
            }
            return visitante;
        }
    }
}
