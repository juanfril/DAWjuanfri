
// Ejercicio 5.2.2 - Crear una función DibujarCuadrado3x3 que dibuje un cuadrado de 3x3 asteriscos, y probarla en un Main

using System;

public class Ejercicio_5_2_2
{
	// Función DibujarCuadrado3x3
	public static void DibujarCuadrado3x3()
	{
		for (int i = 0; i < 3; i++)
		{
			for (int j = 0; j < 3; j++)
			{
				Console.Write("*");
			}
			Console.WriteLine();
		}
	}
	
	// Programa principal
	public static void Main()
	{
		DibujarCuadrado3x3();
	}
}
