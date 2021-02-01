using System;

class Perro
{
    public string Nombre { get; set; }

    public Perro() : this("Max")
    {
    }

    public Perro(string nombre)
    {
        this.Nombre = nombre;
    }

    public virtual void Ladrar()
    {
        Console.WriteLine("Guau!");
    }

    public override string ToString()
    {
        return "Soy un perro y me llamo " + Nombre;
    }
}
