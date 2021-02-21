using System;

namespace FutbolSala
{
    abstract class Jugador
    {
        private byte dorsal;
        private string nombre;
        private byte altura;
        private byte defensa;
        private byte ataque;
        private byte goles;

        public byte Dorsal
        {
            get => dorsal;
            set
            {
                
                if(value < 0 || value > 15)
                    Console.WriteLine("El dorsal debe ser un número" +
                        "del 1 al 15");
                else
                    dorsal = value;
            }
        }
        public string Nombre
        {
            get => nombre;
            set
            {
                if(string.IsNullOrEmpty(value))
                {
                    Console.WriteLine("No ha introducido ningún valor");
                }
                else
                {
                    nombre = value;
                }
            }
        }
        public byte Altura
        {
            get => altura;
            set
            {
                if (value < 120 || value > 220)
                    Console.WriteLine("La altura debe ser un número" +
                        "del 120 al 220");
                else
                    altura = value;
            }
        }
        public byte Defensa 
        {
            get => defensa;
            set
            {
                if (value < 0 || value > 80)
                    Console.WriteLine("El parámetro debe ser un número" +
                        "del 0 al 80");
                else
                    defensa = value;
            } 
        }
        public byte Ataque
        {
            get => ataque;
            set
            {
                if (value < 0 || value > 80)
                    Console.WriteLine("El parámetro debe ser un número" +
                        "del 0 al 80");
                else
                    ataque = value;
            }
        }
        public byte Goles { get; set; }

        public Jugador()
        {
            dorsal = 1;
            Nombre = "Generic";
            Altura = 120;
            Defensa = 1;
            Ataque = 1;
        }

        public Jugador(byte dorsal, string nombre, byte altura, byte defensa,
            byte ataque)
        {
            this.dorsal = dorsal;
            this.nombre = nombre;
            this.altura = altura;
            this.defensa = defensa;
            this.ataque = ataque;
        }
        public virtual int CapacidadDefensiva()
        {
            int capacidadDefensiva = defensa;
            return capacidadDefensiva;
        }
        public virtual int CapacidadAtacante()
        {
            int capacidadAtacante = ataque;
            return capacidadAtacante;
        }
        public string MostrarResumen()
        {
            return dorsal + ". " + nombre + ": " + goles +
                " gol";
        }

        public override string ToString()
        {
            return dorsal + ". " + nombre + ", " + altura + "cm, " +
                defensa + "% defensa " + ataque + "% ataque";
        }

    }
}
