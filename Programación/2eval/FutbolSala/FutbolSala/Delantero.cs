using System;

namespace FutbolSala
{
    class Delantero: Jugador
    {
        protected byte marcarGol;

        public byte MarcarGol
        {
            get => marcarGol;
            set
            {
                if (value > 0 && value < 11)
                    marcarGol = value;
                else
                    Console.WriteLine("La capacidad de robar el balón" +
                        " tiene que ser un número mayor 0 y menor de 10");
            }
        }

        public Delantero() : base()
        {
            marcarGol = 1;
        }

        public override string ToString()
        {
            return base.ToString() + ", " + MarcarGol +
                "% capacidad marcar gol";
        }
    }
}
