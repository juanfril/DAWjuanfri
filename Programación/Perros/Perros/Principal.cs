using System;

class Principal
{
    static void Main(string[] args)
    {
        Perro[] perros = new Perro[3];

        perros[0] = new Perro();
        perros[1] = new Dalmata("Thor");
        perros[2] = new Perro("Rocky");

        foreach(Perro p in perros)
        {
            //p.Ladrar();
            Console.WriteLine(p);
        }
    }
}
