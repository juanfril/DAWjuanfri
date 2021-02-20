using System;

namespace FutbolSala
{
    abstract class Jugador
    {
        public byte Dorsal
        {
            get => Dorsal;
            set
            {
                if (value < 0 || value > 15)
                    Console.WriteLine("El dorsal debe ser un número" +
                        "del 1 al 15");
                else
                    Dorsal = value;
            }
        }
        public string Nombre
        {
            get => Nombre;
            set
            {
                try
                {
                    Nombre = value;
                }
                catch (Exception)
                {
                    Console.WriteLine("El valor introducido no es correcto");
                }
            }
        }
        public byte Altura
        {
            get => Altura;
            set
            {
                if (value < 120 || value > 220)
                    Console.WriteLine("La altura debe ser un número" +
                        "del 120 al 220");
                else
                    Altura = value;
            }
        }
        public byte Defensa 
        {
            get => Defensa;
            set
            {
                if (value < 0 || value > 80)
                    Console.WriteLine("El parámetro debe ser un número" +
                        "del 0 al 80");
                else
                    Defensa = value;
            } 
        }
        public byte Ataque
        {
            get => Ataque;
            set
            {
                if (value < 0 || value > 80)
                    Console.WriteLine("El parámetro debe ser un número" +
                        "del 0 al 80");
                else
                    Ataque = value;
            }
        }
        public byte Goles { get; set; }

        public Jugador()
        {
            Dorsal = 1;
            Nombre = "Generic";
            Altura = 120;
            Defensa = 1;
            Ataque = 1;
        }

        public Jugador(byte dorsal, string nombre, byte altura, byte defensa,
            byte ataque)
        {
            this.Dorsal = dorsal;
            this.Nombre = nombre;
            this.Altura = altura;
            this.Defensa = defensa;
            this.Ataque = ataque;
        }
        public virtual int CapacidadDefensiva()
        {
            int capacidadDefensiva = Defensa;
            return capacidadDefensiva;
        }
        public virtual int CapacidadAtacante()
        {
            int capacidadAtacante = Ataque;
            return capacidadAtacante;
        }
        public string MostrarResumen()
        {
            return Dorsal + ". " + this.Nombre + ": " + Goles +
                " gol";
        }

        public override string ToString()
        {
            return Dorsal + ". " + Nombre + ", " + Altura + "cm, " +
                Defensa + "% defensa " + Ataque + "% ataque";
        }

    }
}
