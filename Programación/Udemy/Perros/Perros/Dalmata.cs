using System;

class Dalmata : Perro
{
    public Dalmata(string nombre) : base(nombre)
    {
    }

    public override void Ladrar()
    {
        base.Ladrar();
        Console.WriteLine("Auuuuu!");
    }

    public override string ToString()
    {
        return "Soy un dálmata y me llamo " + Nombre;
    }
}
