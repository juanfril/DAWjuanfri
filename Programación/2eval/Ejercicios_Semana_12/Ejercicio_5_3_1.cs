
// Ejercicio 5.3.1 - Crear una función DibujarCuadrado que reciba como parámetro la longitud del lado (en asteriscos) y lo dibuje, y probarla en un Main

using System;

public class Ejercicio_5_3_1
{
	// Función DibujarCuadrado
	public static void DibujarCuadrado(int lado)
	{
		for (int i = 0; i < lado; i++)
		{
			for (int j = 0; j < lado; j++)
			{
				Console.Write("*");
			}
			Console.WriteLine();
		}
	}
	
	// Programa principal
	public static void Main()
	{
		DibujarCuadrado(6);
	}
}
