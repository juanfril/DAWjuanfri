using System;

namespace FutbolSala
{
    class Delantero: Jugador
    {
        public byte marcarGol { get; set; }
        public byte velocidad { get; set; }
        public Delantero() : base()
        {
            marcarGol = 1;
            velocidad = 1;
        }

        public override int CapacidadDefensiva()
        {
            int capacidadDefensiva = defensa + velocidad;

            return capacidadDefensiva;
        }

        public override int CapacidadAtacante()
        {
            int capacidadAtacante = ataque + velocidad + marcarGol;

            return capacidadAtacante;
        }
        public override string ToString()
        {
            return base.ToString() + ", " + marcarGol +
                "% capacidad marcar gol, " + velocidad +
                "% velocidad"; ;
        }
    }
}
