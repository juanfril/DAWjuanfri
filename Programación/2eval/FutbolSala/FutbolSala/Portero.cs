using System;

namespace FutbolSala
{
    class Portero: Jugador
    {
        public byte pararTiro { get; set; }

        public Portero() : base()
        {
            pararTiro = 1;
        }

        public override string ToString()
        {
            return base.ToString() + ", " + pararTiro +
                "% capacidad de parar un tiro";
        }
    }
}
