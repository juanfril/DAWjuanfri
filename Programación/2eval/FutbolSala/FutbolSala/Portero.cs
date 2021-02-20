using System;

namespace FutbolSala
{
    class Portero: Jugador
    {
        public byte PararTiro
        {
            get => PararTiro;
            set
            {
                if (value < 0 || value > 10)
                    Console.WriteLine("El parámetro debe ser un número" +
                        "del 0 al 10");
                else
                    Defensa = value;
            }
        }

        public Portero() :base()
        {
            PararTiro = 1;
        }

        public Portero(byte dorsal, string nombre, byte altura, byte defensa,
            byte ataque, byte pararTiro) : base(dorsal, nombre, altura, defensa,
            ataque)
        {
            this.PararTiro = pararTiro;
        }

        public override int CapacidadDefensiva()
        {
            int capacidadDefensiva = PararTiro + Defensa;

            return capacidadDefensiva;
        }
        
        public override string ToString()
        {
            return base.ToString() + ", " + PararTiro +
                "% capacidad de parar un tiro";
        }
    }
}
