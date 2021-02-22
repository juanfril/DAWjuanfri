using System;

namespace FutbolSala
{
    class PedirDatos
    {
        public static string PedirEquipo()
        {
            Console.Clear();

            string nombre = "";
            do
            {
                Console.WriteLine("Introduzca un nombre para el equipo");
                nombre = Console.ReadLine();

            } while (string.IsNullOrEmpty(nombre));

            return nombre;
        }

        public static Portero PedirPortero()
        {
            Console.Clear();

            bool correcto = false;
            byte pruebaNumero;
            string pruebaNombre;
            Portero portero = new Portero();

            do
            {
                Console.WriteLine("Introduce nombre para portero");
                pruebaNombre = Console.ReadLine();

                if (string.IsNullOrEmpty(pruebaNombre))
                    Console.WriteLine("Introduzca nombre válido");
                else
                {
                    portero.Nombre = pruebaNombre;
                    correcto = true;
                }

            } while (!correcto);

            correcto = false;

            do
            {
                Console.WriteLine("Introduce un dorsal para el jugador");
                correcto = Byte.TryParse(Console.ReadLine(), out pruebaNumero);
                if (correcto)
                {
                    if (pruebaNumero < 0 || pruebaNumero > 15)
                    {
                        Console.WriteLine("El dorsal debe ser un número" +
                            "del 1 al 15");
                        correcto = false;
                    }
                    else
                    {
                        portero.Dorsal = pruebaNumero;
                        correcto = true;
                    }
                }
                else
                    Console.WriteLine("El valor introducido es incorrecto");

            } while (!correcto);

            correcto = false;

            do
            {
                Console.WriteLine("Introduce altura para el jugador");
                correcto = Byte.TryParse(Console.ReadLine(), out pruebaNumero);
                if (correcto)
                {
                    if (pruebaNumero < 120 || pruebaNumero > 220)
                    {
                        Console.WriteLine("La altura debe ser un número" +
                            "del 120 al 220");
                        correcto = false;
                    }
                    else
                    {
                        portero.Altura = pruebaNumero;
                        correcto = true;
                    }
                }
                else
                    Console.WriteLine("El valor introducido es incorrecto");
            } while (!correcto);

            correcto = false;

            do
            {
                Console.WriteLine("Introduce capacidad defensiva" +
                    " para el jugador");
                correcto = Byte.TryParse(Console.ReadLine(), out pruebaNumero);
                if (correcto)
                {
                    if (pruebaNumero < 1 || pruebaNumero > 80)
                    {
                        Console.WriteLine("La defensa debe ser un número" +
                            "del 1 al 80");
                        correcto = false;
                    }
                    else
                    {
                        portero.Defensa = pruebaNumero;
                        correcto = true;
                    }
                }
                else
                    Console.WriteLine("El valor introducido es incorrecto");

            } while (!correcto);

            correcto = false;

            do
            {
                Console.WriteLine("Introduce capacidad atacante " +
                    "para el jugador");
                correcto = Byte.TryParse(Console.ReadLine(), out pruebaNumero);
                if (correcto)
                {
                    if (pruebaNumero < 1 || pruebaNumero > 80)
                    {
                        Console.WriteLine("El ataque debe ser un número" +
                            "del 1 al 80");
                        correcto = false;
                    }
                    else
                    {
                        portero.Ataque = pruebaNumero;
                        correcto = true;
                    }
                }
                else
                    Console.WriteLine("El valor introducido es incorrecto");

            } while (!correcto);

            correcto = false;

            do
            {
                Console.WriteLine("Introduce capacidad de parar " +
                    "tiros a puerta para el jugador");
                correcto = Byte.TryParse(Console.ReadLine(), out pruebaNumero);
                if (correcto)
                {
                    if (pruebaNumero < 1 || pruebaNumero > 10)
                    {
                        Console.WriteLine("La capacidad de parar un tiro a puerta" +
                            " debe ser un número del 1 al 10");
                        correcto = false;
                    }
                    else
                    {
                        portero.PararTiro = pruebaNumero;
                        correcto = true;
                    }
                }
                else
                    Console.WriteLine("El valor introducido es incorrecto");

            } while (!correcto);

            return portero;
        }
        public static Defensa PedirDefensa()
        {
            Console.Clear();

            bool correcto = false;
            byte pruebaNumero;
            string pruebaNombre;
            Defensa defensa = new Defensa();

            do
            {
                Console.WriteLine("Introduce nombre para el defensa");
                pruebaNombre = Console.ReadLine();

                if (string.IsNullOrEmpty(pruebaNombre))
                    Console.WriteLine("Introduzca nombre válido");
                else
                {
                    defensa.Nombre = pruebaNombre;
                    correcto = true;
                }

            } while (!correcto);

            correcto = false;

            do
            {
                Console.WriteLine("Introduce un dorsal para el jugador");
                correcto = Byte.TryParse(Console.ReadLine(), out pruebaNumero);
                if (correcto)
                {
                    if (pruebaNumero < 0 || pruebaNumero > 15)
                    {
                        Console.WriteLine("El dorsal debe ser un número" +
                           "del 1 al 15");
                        correcto = false;
                    }
                    else
                    {
                        defensa.Dorsal = pruebaNumero;
                        correcto = true;
                    }
                }
                else
                    Console.WriteLine("El valor introducido es incorrecto");

            } while (!correcto);

            correcto = false;

            do
            {
                Console.WriteLine("Introduce altura para el jugador");
                correcto = Byte.TryParse(Console.ReadLine(), out pruebaNumero);
                if (correcto)
                {
                    if (pruebaNumero < 120 || pruebaNumero > 220)
                    {
                        Console.WriteLine("La altura debe ser un número" +
                            "del 120 al 220");
                        correcto = false;
                    }
                    else
                    {
                        defensa.Altura = pruebaNumero;
                        correcto = true;
                    }
                }
                else
                    Console.WriteLine("El valor introducido es incorrecto");
            } while (!correcto);

            correcto = false;

            do
            {
                Console.WriteLine("Introduce capacidad defensiva" +
                    " para el jugador");
                correcto = Byte.TryParse(Console.ReadLine(), out pruebaNumero);
                if (correcto)
                {
                    if (pruebaNumero < 1 || pruebaNumero > 80)
                    {
                        Console.WriteLine("La defensa debe ser un número" +
                            "del 1 al 80");
                        correcto = false;
                    }
                    else
                    {
                        defensa.Defensa = pruebaNumero;
                        correcto = true;
                    }
                }
                else
                    Console.WriteLine("El valor introducido es incorrecto");

            } while (!correcto);

            correcto = false;

            do
            {
                Console.WriteLine("Introduce capacidad atacante " +
                    "para el jugador");
                correcto = Byte.TryParse(Console.ReadLine(), out pruebaNumero);
                if (correcto)
                {
                    if (pruebaNumero < 1 || pruebaNumero > 80)
                    {
                        Console.WriteLine("El ataque debe ser un número" +
                            "del 1 al 80");
                        correcto = false;
                    }
                    else
                    {
                        defensa.Ataque = pruebaNumero;
                        correcto = true;
                    }
                }
                else
                    Console.WriteLine("El valor introducido es incorrecto");

            } while (!correcto);

            correcto = false;

            do
            {
                Console.WriteLine("Introduce capacidad de robar " +
                    "el balón para el jugador");
                correcto = Byte.TryParse(Console.ReadLine(), out pruebaNumero);
                if (correcto)
                {
                    if (pruebaNumero < 1 || pruebaNumero > 10)
                    {
                        Console.WriteLine("La capacidad de robar el balón" +
                           " debe ser un número del 1 al 10");
                        correcto = false;
                    }
                    else
                    {
                        defensa.RobarBalon = pruebaNumero;
                        correcto = true;
                    }
                }
                else
                    Console.WriteLine("El valor introducido es incorrecto");

            } while (!correcto);

            correcto = false;

            do
            {
                Console.WriteLine("Introduce velocidad para el jugador");
                correcto = Byte.TryParse(Console.ReadLine(), out pruebaNumero);
                if (correcto)
                {
                    if (pruebaNumero < 1 || pruebaNumero > 10)
                    {
                        Console.WriteLine("La velocidad debe ser un número" +
                            " del 1 al 10");
                        correcto = false;
                    }
                    else
                    {
                        defensa.Velocidad = pruebaNumero;
                        correcto = true;
                    }
                }
                else
                    Console.WriteLine("El valor introducido es incorrecto");

            } while (!correcto);

            return defensa;
        }

        public static Delantero PedirDelantero()
        {
            Console.Clear();

            bool correcto = false;
            byte pruebaNumero;
            string pruebaNombre;
            Delantero delantero = new Delantero();

            do
            {
                Console.WriteLine("Introduce nombre para el delantero");
                pruebaNombre = Console.ReadLine();

                if (string.IsNullOrEmpty(pruebaNombre))
                    Console.WriteLine("Introduzca nombre válido");
                else
                {
                    delantero.Nombre = pruebaNombre;
                    correcto = true;
                }

            } while (!correcto);

            correcto = false;

            do
            {
                Console.WriteLine("Introduce un dorsal para el jugador");
                correcto = Byte.TryParse(Console.ReadLine(), out pruebaNumero);
                if (correcto)
                {
                    if (pruebaNumero < 0 || pruebaNumero > 15)
                    {
                        Console.WriteLine("El dorsal debe ser un número" +
                           "del 1 al 15");
                        correcto = false;
                    }
                    else
                    {
                        delantero.Dorsal = pruebaNumero;
                        correcto = true;
                    }
                }
                else
                    Console.WriteLine("El valor introducido es incorrecto");

            } while (!correcto);

            correcto = false;

            do
            {
                Console.WriteLine("Introduce altura para el jugador");
                correcto = Byte.TryParse(Console.ReadLine(), out pruebaNumero);
                if (correcto)
                {
                    if (pruebaNumero < 120 || pruebaNumero > 220)
                    {
                        Console.WriteLine("La altura debe ser un número" +
                            "del 120 al 220");
                        correcto = false;
                    }
                    else
                    {
                        delantero.Altura = pruebaNumero;
                        correcto = true;
                    }
                }
                else
                    Console.WriteLine("El valor introducido es incorrecto");
            } while (!correcto);

            correcto = false;

            do
            {
                Console.WriteLine("Introduce capacidad defensiva" +
                    " para el jugador");
                correcto = Byte.TryParse(Console.ReadLine(), out pruebaNumero);
                if (correcto)
                {
                    if (pruebaNumero < 1 || pruebaNumero > 80)
                    {
                        Console.WriteLine("La defensa debe ser un número" +
                           "del 1 al 80");
                        correcto = false;
                    }
                    else
                    {
                        delantero.Defensa = pruebaNumero;
                        correcto = true;
                    }
                }
                else
                    Console.WriteLine("El valor introducido es incorrecto");

            } while (!correcto);

            correcto = false;

            do
            {
                Console.WriteLine("Introduce capacidad atacante " +
                    "para el jugador");
                correcto = Byte.TryParse(Console.ReadLine(), out pruebaNumero);
                if (correcto)
                {
                    if (pruebaNumero < 1 || pruebaNumero > 80)
                    {
                        Console.WriteLine("El ataque debe ser un número" +
                           "del 1 al 80");
                        correcto = false;
                    }
                    else
                    {
                        delantero.Ataque = pruebaNumero;
                        correcto = true;
                    }
                }
                else
                    Console.WriteLine("El valor introducido es incorrecto");

            } while (!correcto);

            correcto = false;

            do
            {
                Console.WriteLine("Introduce capacidad de marcar " +
                    "gol para el jugador");
                correcto = Byte.TryParse(Console.ReadLine(), out pruebaNumero);
                if (correcto)
                {
                    if (pruebaNumero < 1 || pruebaNumero > 10)
                    {
                        Console.WriteLine("La capacidad de marcar gol" +
                           " debe ser un número del 1 al 10");
                        correcto = false;
                    }
                    else
                    {
                        delantero.MarcarGol = pruebaNumero;
                        correcto = true;
                    }
                }
                else
                    Console.WriteLine("El valor introducido es incorrecto");

            } while (!correcto);

            correcto = false;

            do
            {
                Console.WriteLine("Introduce velocidad para el jugador");
                correcto = Byte.TryParse(Console.ReadLine(), out pruebaNumero);
                if (correcto)
                {
                    if (pruebaNumero < 1 || pruebaNumero > 10)
                    {
                        Console.WriteLine("La velocidad debe ser un número" +
                            " del 1 al 10");
                        correcto = false;
                    }
                    else
                    {
                        delantero.Velocidad = pruebaNumero;
                        correcto = true;
                    }
                }
                else
                    Console.WriteLine("El valor introducido es incorrecto");

            } while (!correcto);

            return delantero;
        }
    }
}
