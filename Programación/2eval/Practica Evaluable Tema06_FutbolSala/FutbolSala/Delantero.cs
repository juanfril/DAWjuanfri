using System;

/*
 * Subtipo de jugador: Delantero
 */

namespace FutbolSala
{
    class Delantero : Jugador
    {
        private int capacidadMarcar;
        private int velocidad;

        public int CapacidadMarcar
        {
            get => capacidadMarcar;
            set
            {
                if (value >= 0 && value <= 10)
                    capacidadMarcar = value;
            }
        }

        public int Velocidad
        {
            get => velocidad;
            set
            {
                if (value >= 0 && value <= 10)
                    velocidad = value;
            }
        }

        public Delantero(byte dorsal, string nombre, byte altura, int defensa, int ataque, int capacidadMarcar, int velocidad)
            : base(dorsal, nombre, altura, defensa, ataque)
        {
            this.capacidadMarcar = capacidadMarcar;
            this.velocidad = velocidad;
        }

        // Metodo (override) CapacidadDefensa
        public override int CapacidadDefensa()
        {
            return base.CapacidadDefensa() + velocidad;
        }

        // Metodo (override) CapacidadAtaque
        public override int CapacidadAtaque()
        {
            return base.CapacidadAtaque() + capacidadMarcar + velocidad;
        }

        // Metodo (override) ToString
        public override string ToString()
        {
            return base.ToString() + ", marcar gol: " + capacidadMarcar + ", velocidad: " + velocidad;
        }

    }
}
