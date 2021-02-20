using System;

namespace FutbolSala
{
    class Delantero: Jugador
    {
        public byte MarcarGol
        {
            get => MarcarGol;
            set
            {
                if (value < 0 || value > 10)
                    Console.WriteLine("El parámetro debe ser un número" +
                        "del 0 al 10");
                else
                    MarcarGol = value;
            }
        }
        public byte Velocidad
        {
            get => Velocidad;
            set
            {
                if (value < 0 || value > 10)
                    Console.WriteLine("El parámetro debe ser un número" +
                        "del 0 al 10");
                else
                    Velocidad = value;
            }
        }

        public Delantero() : base()
        {
            MarcarGol = 1;
            Velocidad = 1;
        }

        public Delantero(byte dorsal, string nombre, byte altura, byte defensa,
            byte ataque, byte marcarGol, byte velocidad) : base(dorsal, nombre,
                altura, defensa, ataque)
        {
            this.MarcarGol = marcarGol;
            this.Velocidad = velocidad;
        }

        public override int CapacidadDefensiva()
        {
            int capacidadDefensiva = Defensa + Velocidad;

            return capacidadDefensiva;
        }

        public override int CapacidadAtacante()
        {
            int capacidadAtacante = Ataque + Velocidad + MarcarGol;

            return capacidadAtacante;
        }
        public override string ToString()
        {
            return base.ToString() + ", " + MarcarGol +
                "% capacidad marcar gol, " + Velocidad +
                "% velocidad"; ;
        }
    }
}
