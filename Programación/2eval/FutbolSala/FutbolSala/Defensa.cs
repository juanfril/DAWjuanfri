using System;

namespace FutbolSala
{
    class Defensa: Jugador
    {
        public byte robarBalon { get; set; }
        public byte velocidad { get; set; }
        public Defensa() : base()
        {
            robarBalon = 1;
            velocidad = 1;
        }

        public override string ToString()
        {
            return base.ToString() + ", " + robarBalon +
                "% capacidad robar el balón, " + velocidad +
                "% velocidad";
        }
    }
}
