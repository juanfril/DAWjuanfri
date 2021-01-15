
// Ejercicio 5.4.2 - Crear una función Menor que devuelva el menor de dos números pasados como parámetros

using System;

public class Ejercicio_5_4_2
{
	// Función Menor
	public static int Menor(int n1, int n2)
	{
		if (n1 < n2)
			return n1;
		else
			return n2;
		// También se podría poner return (n1 < n2)? n1 : n2;
	}
	
	// Programa principal
	public static void Main()
	{
		int n1, n2, menor;
		
		Console.WriteLine("Dime dos números:");
		n1 = Convert.ToInt32(Console.ReadLine());
		n2 = Convert.ToInt32(Console.ReadLine());
		menor = Menor(n1, n2);
		Console.WriteLine("El menor es {0}", menor);
	}
}
