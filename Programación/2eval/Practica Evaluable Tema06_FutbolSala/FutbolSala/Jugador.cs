using System;

namespace FutbolSala
{
    class Jugador
    {
        byte dorsal;
        string nombre;
        byte altura;
        int defensa;
        int ataque;
        int goles;

        // Propiedades públicas para acceder a los atributos privados

        public byte Dorsal
        {
            get
            {
                return dorsal;
            }
            set
            {
                if (value >= 0 && value <= 15)
                    dorsal = value;
            }
        }

        public string Nombre { get => nombre; set => nombre = value; }

        public byte Altura
        {
            get
            {
                return altura;
            }
            set
            {
                if (value >= 120 && value <= 220)
                    altura = value;
            }
        }

        public int Defensa
        {
            get => defensa;
            set
            {
                if (value >= 0 && value <= 80)
                    defensa = value;
            }
        }

        public int Ataque
        {
            get => ataque;
            set
            {
                if (value >= 0 && value <= 80)
                    ataque = value;
            }
        }

        public int Goles { get => goles; set => goles = value; }

        public Jugador(byte dorsal, string nombre, byte altura, int defensa, int ataque)
        {
            this.dorsal = dorsal;
            this.nombre = nombre;
            this.altura = altura;
            this.defensa = defensa;
            this.ataque = ataque;
            this.goles = 0;
        }

        public virtual int CapacidadDefensa()
        {
            return defensa;
        }

        public virtual int CapacidadAtaque()
        {
            return ataque;
        }

        public override string ToString()
        {
            return (dorsal+1) + ". " + GetType().Name + ". " + nombre + ", " + altura + " cm, " + defensa + " % defensa, " + ataque + " % ataque";
        }

        public string MostrarResumen()
        {
            return (dorsal+1) + ". " + nombre + " (" + GetType().Name + "): " + goles + (goles == 1 ? " gol" : " goles");
        }
    }
}
