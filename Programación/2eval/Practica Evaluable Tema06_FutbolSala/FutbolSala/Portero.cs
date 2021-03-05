using System;

/*
 * Subtipo de jugador: Portero
 */

namespace FutbolSala
{
    class Portero : Jugador
    {
        private int capacidadParar;

        public int CapacidadParar
        {
            get => capacidadParar;
            set
            {
                if (value >= 0 && value <= 10)
                    capacidadParar = value;
            }
        }

        public Portero(byte dorsal, string nombre, byte altura, int defensa, int ataque, int capacidadParar)
            : base(dorsal, nombre, altura, defensa, ataque)
        {
            this.capacidadParar = capacidadParar;
        }

        // Metodo (override) CapacidadDefensa
        public override int CapacidadDefensa()
        {
            return base.CapacidadDefensa() + capacidadParar;
        }

        // Metodo (override) CapacidadAtaque
        public override int CapacidadAtaque()
        {
            return base.CapacidadAtaque();
        }

        // Metodo (override) ToString
        public override string ToString()
        {
            return base.ToString() + ", capacidad de parar: " + capacidadParar;
        }

    }
}
