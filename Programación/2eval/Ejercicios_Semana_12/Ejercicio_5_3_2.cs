// Ejercicio 5.3.2 - Crear una función DibujarRectangulo que reciba como parámetros la base y la altura y lo dibuje, y probarla en un Main

using System;

public class Ejercicio_5_3_2
{
	// Función DibujarRectangulo
	public static void DibujarRectangulo(int b,int h)
	{
		for (int i = 0; i < h; i++)
		{
			for (int j = 0; j < b; j++)
			{
				Console.Write("*");
			}
			Console.WriteLine();
		}
	}
	
	// Programa principal
	public static void Main()
	{
		DibujarRectangulo(6,4);
	}
}
