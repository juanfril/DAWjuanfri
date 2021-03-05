using System;

namespace FutbolSala
{
    class Defensa: Jugador
    {
        private byte robarBalon;
        private byte velocidad;
        public byte RobarBalon
        {
            get => robarBalon;
            set
            {
                if (value < 0 || value > 10)
                    Console.WriteLine("El parámetro debe ser un número" +
                        "del 0 al 10");
                else
                {
                    try
                    {
                        robarBalon = value;
                    }
                    catch
                    {
                        Console.WriteLine("Valor introducido incorrecto");
                    }
                }
            }
        }
        public byte Velocidad
        {
            get => Velocidad;
            set
            {
                if (value < 0 || value > 10)
                    Console.WriteLine("El parámetro debe ser un número" +
                        "del 0 al 10");
                else
                {
                    try
                    {
                        velocidad = value;
                    }
                    catch
                    {
                        Console.WriteLine("Valor introducido incorrecto");
                    }
                }
            }
        }

        public Defensa() :base()
        {
            robarBalon = 1;
            velocidad = 1;
        }

        public Defensa(byte dorsal, string nombre, byte altura, byte defensa,
            byte ataque, byte robarBalon, byte velocidad) : base(dorsal, nombre,
                altura, defensa, ataque)
        {
            this.robarBalon = robarBalon;
            this.velocidad = velocidad;
        }

        public override int CapacidadDefensiva()
        {
            return base.CapacidadDefensiva() + velocidad + robarBalon;
        }

        public override int CapacidadAtacante()
        {
            return base.CapacidadAtacante() + velocidad;
        }
        public override string ToString()
        {
            return base.ToString() + ", " + robarBalon +
                "% capacidad robar el balón, " + velocidad +
                "% velocidad";
        }
    }
}
