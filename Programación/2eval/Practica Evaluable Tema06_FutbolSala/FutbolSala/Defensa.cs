using System;

/*
 * Subtipo de jugador: Defensa
 */

namespace FutbolSala
{
    class Defensa : Jugador
    {
        private int capacidadRobar;
        private int velocidad;

        public int CapacidadRobar
        {
            get => capacidadRobar;
            set
            {
                if (value >= 0 && value <= 10)
                    capacidadRobar = value;
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

        public Defensa(byte dorsal, string nombre, byte altura, int defensa, int ataque, int capacidadParar, int velocidad)
            : base(dorsal, nombre, altura, defensa, ataque)
        {
            this.capacidadRobar = capacidadParar;
            this.velocidad = velocidad;
        }

        // Metodo (override) CapacidadDefensa
        public override int CapacidadDefensa()
        {
            return base.CapacidadDefensa() + capacidadRobar + velocidad;
        }

        // Metodo (override) CapacidadAtaque
        public override int CapacidadAtaque()
        {
            return base.CapacidadAtaque() + velocidad;
        }

        // Metodo (override) ToString
        public override string ToString()
        {
            return base.ToString() + ", robo de balón: " + capacidadRobar + ", velocidad: " + velocidad;
        }

    }
}
