using System;

namespace FutbolSala
{
    abstract class Jugador
    {
        protected byte dorsal;
        protected string nombre;
        protected byte altura;
        protected byte defensa;
        protected byte ataque;
        protected int goles;

        public byte Dorsal
        {
            get => dorsal;
            set
            {
                if (value > 0 && value < 16)
                    dorsal = value;
                else
                    Console.WriteLine("El dorsal tiene que ser un" +
                        " número de 1 a 15");
            }
        }

        public string Nombre { get; set; }

        public byte Altura
        {
            get => altura;
            set
            {
                if (value > 119 && value < 221)
                    altura = value;
                else
                    Console.WriteLine("La altura tiene que ser un" +
                        " número mayor 120 y menor de 220");
            }
        }

        public byte Defensa
        {
            get => defensa;
            set
            {
                if (value > 0 && value < 80)
                    defensa = value;
                else
                    Console.WriteLine("El porcentaje de defensa tiene que ser un" +
                        " número mayor 0 y menor de 80");
            }
        }
            
        public byte Ataque
        {
            get => ataque;
            set
            {
                if (value > 0 && value < 80)
                    ataque = value;
                else
                    Console.WriteLine("El porcentaje de ataque tiene que ser un" +
                        " número mayor 0 y menor de 80");
            }
        }

        public Jugador()
        {
            dorsal = 1;
            nombre = "Genérico";
            altura = 121;
            defensa = 1;
            ataque = 1;
        }

        public override string ToString()
        {
            return dorsal + ". " + Nombre + ", " + altura + "cm, " +
                defensa + "% defensa " + ataque + "% ataque ";
        }

        public string MostrarResumen(string Nombre)
        {
            return dorsal + ". " + Nombre + ": " + goles +
                " gol";
        }
    }
}
