// Ejercicio 5.3.5 - Usar la función EscribirRepetido para  DibujarRectangulo 

using System;

public class Ejercicio_5_3_2
{
	// Función EscribirRepetido
	public static void EscribirRepetido(int veces,char caracter)
	{
		for (int i = 0; i < veces; i++)
			{
				Console.Write(caracter);
			}
		}
		
	// Función DibujarRectangulo
	public static void DibujarRectangulo(int b,int h)
	{
		for (int i = 0; i < h; i++)
		{
			EscribirRepetido(b,'*');
			Console.WriteLine();
		}
	}
	
	// Programa principal
	public static void Main()
	{
		DibujarRectangulo(6,4);
	}
}
