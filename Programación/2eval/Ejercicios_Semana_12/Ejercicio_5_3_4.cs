// Ejercicio 5.3.4 - Crear una función EscribirRepetido que reciba como parámetros un carácter y un número y repita ese carácter tantas veces como indique el número
using System;

public class Ejercicio_5_3_4
{
	// Función EscribirRepetido
	public static void EscribirRepetido(int veces,char caracter)
	{
		for (int i = 0; i < veces; i++)
			{
				Console.Write(caracter);
			}
		}
	
	// Programa principal
	public static void Main()
	{
		EscribirRepetido(4,'*');
	}
}
