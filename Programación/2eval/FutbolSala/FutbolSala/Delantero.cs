using System;

namespace FutbolSala
{
    class Delantero: Jugador
    {
        private byte marcarGol;
        private byte velocidad;

        public byte MarcarGol
        {
            get => marcarGol;
            set
            {
                if (value < 0 || value > 10)
                    Console.WriteLine("El parámetro debe ser un número" +
                        "del 1 al 10");
                else
                {
                    try
                    {
                        marcarGol = value;
                    }
                    catch(Exception)
                    {
                        Console.WriteLine("Valor introducido incorrecto");
                    }
                }
            }
        }
        public byte Velocidad
        {
            get => velocidad;
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

        public Delantero() : base()
        {
            marcarGol = 1;
            velocidad = 1;
        }

        public Delantero(byte dorsal, string nombre, byte altura, byte defensa,
            byte ataque, byte marcarGol, byte velocidad) : base(dorsal, nombre,
                altura, defensa, ataque)
        {
            this.marcarGol = marcarGol;
            this.velocidad = velocidad;
        }

        public override int CapacidadDefensiva()
        {
            return base.CapacidadDefensiva() + velocidad;
        }

        public override int CapacidadAtacante()
        {
            return base.CapacidadAtacante() + velocidad + marcarGol;
        }
        public override string ToString()
        {
            return base.ToString() + ", " + marcarGol +
                "% capacidad marcar gol, " + velocidad +
                "% velocidad"; ;
        }
    }
}
