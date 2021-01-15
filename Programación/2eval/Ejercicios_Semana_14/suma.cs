
// Ejercicio 5.11.1 - Programa que calcula la suma de los números que recibe como parámetros (en el Main)

using System;

public class Ejercicio_5_11_1
{
	public static void Main(string[] args)
	{
		if (args.Length == 0)
		{
			Console.WriteLine("No hay suficientes datos");
			Environment.Exit(1);
		} else if (args.Length == 1) {
			Console.WriteLine(args[0]);
		} else {
			Console.WriteLine(Convert.ToInt32(args[0]) + Convert.ToInt32(args[1]));
		}
	}
}
