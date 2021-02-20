using System;

namespace FutbolSala
{
    class Defensa: Jugador
    {
        public byte RobarBalon
        {
            get => RobarBalon;
            set
            {
                if (value < 0 || value > 10)
                    Console.WriteLine("El parámetro debe ser un número" +
                        "del 0 al 10");
                else
                    RobarBalon = value;
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

        public Defensa() :base()
        {
            RobarBalon = 1;
            Velocidad = 1;
        }

        public Defensa(byte dorsal, string nombre, byte altura, byte defensa,
            byte ataque, byte robarBalon, byte velocidad) : base(dorsal, nombre,
                altura, defensa, ataque)
        {
            this.RobarBalon = robarBalon;
            this.Velocidad = velocidad;
        }

        public override int CapacidadDefensiva()
        {
            int capacidadDefensiva = Defensa + Velocidad + RobarBalon;

            return capacidadDefensiva;
        }

        public override int CapacidadAtacante()
        {
            int capacidadAtacante = Ataque + Velocidad;

            return capacidadAtacante;
        }
        public override string ToString()
        {
            return base.ToString() + ", " + RobarBalon +
                "% capacidad robar el balón, " + Velocidad +
                "% velocidad";
        }
    }
}
