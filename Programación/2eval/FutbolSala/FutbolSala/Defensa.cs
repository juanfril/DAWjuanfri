using System;

namespace FutbolSala
{
    class Defensa: Jugador
    {
        protected byte robarBalon;

        public byte RobarBalon
        {
            get => robarBalon;
            set
            {
                if (value > 0 && value < 11)
                    robarBalon = value;
                else
                    Console.WriteLine("La capacidad de robar el balón" +
                        " tiene que ser un número mayor 0 y menor de 10");
            }
        }

        public Defensa() : base()
        {
            robarBalon = 1;
        }

        public override string ToString()
        {
            return base.ToString() + ", " + RobarBalon +
                "% capacidad robar el balón";
        }
    }
}
