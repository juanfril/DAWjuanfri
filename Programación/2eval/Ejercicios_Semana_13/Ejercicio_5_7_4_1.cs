
// Ejercicio 5.7.4.1 - Programa que pide la edad tantas veces como sea necesario, hasta introducir un valor numérico aceptable

using System;

public class Ejercicio_5_7_4_1
{
	// Programa principal
	public static void Main()
	{
		// Para almacenar la edad, utilizamos un dato tipo byte, que es el que más se aproxima.
		byte edad;
		
		// Asumimos que una edad mayor de 150 no es razonable
		do
		{
			Console.WriteLine("Dime tu edad:");
		}
		while (!Byte.TryParse(Console.ReadLine(), out edad) || edad > 150);
		
		Console.WriteLine("Tienes {0} años", edad);
	}
}
