using System;

class Program
{
    static void Main(string[] args)
    {
        Usuario usu1 = new Usuario("11122233A", "Nacho Iborra", "C/ CSharp, 11",
            "966112233", false);

        Console.WriteLine(usu1.GetNombre());
    }
}
