using System;

namespace FutbolSala
{
    class GestionEquipo
    {
        private const byte PORTERO = 0;
        private const byte DEFENSA = 1;
        private const byte DELANTERO = 2;

        // Metodo AUXILIAR: Solicita dato tipo int entre valores min y max
        private static int PedirNumero(string mensaje, int min, int max)
        {
            bool error;
            int resultado;

            do
            {
                error = false;
                Console.Write(mensaje + " ");
                if (!Int32.TryParse(Console.ReadLine(), out resultado) ||
                    resultado < min || resultado > max)
                {
                    error = true;
                    Console.WriteLine("ERROR: Debe introducir valores válidos");
                }
            } while (error);

            return resultado;
        }

        private static string PedirCadenaNoVacia(string mensaje)
		{
            bool error;
            string texto;

            do
			{
                error = false;
                Console.Write(mensaje + " ");
                texto = Console.ReadLine();
                if (String.IsNullOrEmpty(texto))
                {
                    error = true;
                    Console.WriteLine("ERROR: No se puede dejar vacio el dato solicitado");
				}
			} while (error);

			return texto;
		}

		public static Equipo CrearEquipo(int n)
        {
            byte altura = 0;
            int defensa = 0, ataque = 0;
            int capacidadParar, capacidadRobar, capacapacidadMarcar, velocidad;
            string nombre="";
            Equipo equipo;

			equipo = new Equipo(PedirCadenaNoVacia("Nombre del equipo "+ n + ":"));

            for (byte i = 0; i < Constants.MAX_JUGADORES; i++)
            {
                Console.WriteLine("{0} {1}", i+1, Constants.TipoJugador[TipoJugador(i)]);
                PedirDatosJugador(ref nombre, ref altura, ref defensa, ref ataque);
                switch (TipoJugador(i))
                {
                    case PORTERO:
                        capacidadParar = PedirNumero("Capacidad de parar (0-10)", 0, 10);
                        equipo.Jugadores[i] = new Portero(i, nombre, altura,
                            defensa, ataque, capacidadParar);
                        break;
                    case DEFENSA:
                        capacidadRobar = PedirNumero("Capacidad de robar (0-10)", 0, 10);
                        velocidad = PedirNumero("Velocidad (0-10)", 0, 10);
                        equipo.Jugadores[i] = new Defensa(i, nombre, altura,
                            defensa, ataque, capacidadRobar, velocidad);
                        break;
                    case DELANTERO:
                        capacapacidadMarcar = PedirNumero("Capacidad de marcar (0-10)", 0, 10);
                        velocidad = PedirNumero("Velocidad (0-10)", 0, 10);
                        equipo.Jugadores[i] = new Delantero(i, nombre, altura,
                            defensa, ataque, capacapacidadMarcar, velocidad);
                        break;
                }
                Console.WriteLine();
            }

            /* Código para pruebas, para rellenar rápidamente los equipos
             * comentando el bucle for anterior y poniendo este en su lugar

            for (byte i = 0; i < Constants.MAX_JUGADORES; i++)
            {
                switch (TipoJugador(i))
                {
                    case PORTERO:
                        equipo.Jugadores[i] = new Portero(i, "Portero-"+i, 180, 70, 5, 7);
                        break;
                    case DEFENSA:
                        equipo.Jugadores[i] = new Defensa(i, "Defensa-"+i, 180, 65, 30, 4, 6);
                        break;
                    case DELANTERO:
                        equipo.Jugadores[i] = new Delantero(i, "Delantero-"+i, 180, 25, 70, 3, 7);
                        break;
                }
            }
            */

            return equipo;
		}

        // Método AUXILIAR para pedir los datos comunes a todos los jugadores
        private static void PedirDatosJugador(ref string nombre, ref byte altura,
            ref int defensa, ref int ataque)
        {
//            dorsal = Convert.ToByte(PedirNumero("Dorsal (0-15):", 0, 15));
            nombre = PedirCadenaNoVacia("Nombre del jugador:");
            altura = Convert.ToByte(PedirNumero("Altura (120-220):", 120, 220));
            defensa = PedirNumero("Defensa (0-80)", 0, 80);
            ataque = PedirNumero("Ataque (0-80)", 0, 80);
        }

        // Método AUXILIAR para determinar el tipo de jugador, según la posición
        private static byte TipoJugador(int posicion)
        {
            byte tipo;
            switch (posicion)
            {
                case 0:
                case 9:
                    tipo = PORTERO;
                    break;
                case 1:
                case 2:
                case 5:
                case 6:
                    tipo = DEFENSA;
                    break;
                case 3:
                case 4:
                case 7:
                case 8:
                    tipo = DELANTERO;
                    break;
                default:
                    tipo = 0;
                    break;
            }
            return tipo;
        }
    }
}
