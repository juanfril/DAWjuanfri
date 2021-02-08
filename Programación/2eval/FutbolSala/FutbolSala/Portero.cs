using System;

namespace FutbolSala
{
    class Portero: Jugador
    {
        protected byte pararTiro;

        public byte PararTiro
        {
            get => pararTiro;
            set
            {
                if (value > 0 && value < 11)
                    pararTiro = value;
                else
                    Console.WriteLine("La capacidad de parar a un tiro a puerta" +
                        " tiene que ser un número mayor 0 y menor de 10");
            }
        }

        public Portero() : base()
        {
            pararTiro = 1;
        }

        public override string ToString()
        {
            return base.ToString() + ", " + PararTiro +
                "% capacidad de parar un tiro";
        }
    }
}
