using System;

namespace FutbolSala
{
    class Portero: Jugador
    {
        private byte pararTiro;
        public byte PararTiro
        {
            get => pararTiro;
            set
            {
                if (value < 0 || value > 10)
                    Console.WriteLine("El parámetro debe ser un número" +
                        "del 0 al 10");
                else
                {
                    try
                    {
                        pararTiro = value;
                    }
                    catch
                    {
                        Console.WriteLine("Valor introducido incorrecto");
                    }
                }
            }
        }

        public Portero() :base()
        {
            pararTiro = 1;
        }

        public Portero(byte dorsal, string nombre, byte altura, byte defensa,
            byte ataque, byte pararTiro) : base(dorsal, nombre, altura, defensa,
            ataque)
        {
            this.pararTiro = pararTiro;
        }
        public override int CapacidadAtacante()
        {
            return base.CapacidadAtacante();
        }

        public override int CapacidadDefensiva()
        {
            return base.CapacidadDefensiva() + pararTiro;
        }
        
        public override string ToString()
        {
            return base.ToString() + ", " + pararTiro +
                "% capacidad de parar un tiro";
        }
    }
}
