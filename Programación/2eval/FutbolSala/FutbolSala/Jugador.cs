using System;

namespace FutbolSala
{
    abstract class Jugador
    {
        public byte dorsal { get; set; }
        public string nombre { get; set; }
        public byte altura { get; set; }
        public byte defensa { get; set; }
        public byte ataque { get; set; }
        public byte goles { get; set; }

        public Jugador()
        {
            dorsal = 1;
            nombre = "Genérico";
            altura = 121;
            defensa = 1;
            ataque = 1;
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

        public override string ToString()
        {
            return dorsal + ". " + nombre + ", " + altura + "cm, " +
                defensa + "% defensa " + ataque + "% ataque";
        }

        public string MostrarResumen(string Nombre)
        {
            return dorsal + ". " + Nombre + ": " + goles +
                " gol";
        }
    }
}
