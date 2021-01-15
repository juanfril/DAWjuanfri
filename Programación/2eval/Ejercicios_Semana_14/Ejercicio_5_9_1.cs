
// Ejercicio 5.9.1 - Función recursiva para calcular la potencia de un número elevado a otro

using System;

public class Ejercicio_5_9_1
{
	public static int Potencia (int a, int b)
	{
		// Caso base: cuando el exponente es 0, la potencia es 1
		if (b == 0)
			return 1;
		// Resto de casos: multiplicamos por a y reducimos el exponente, hasta que llegue a 0
		else
			return a * Potencia(a, b-1);
	}
	
	public static void Main()
	{
		int a, b;		// Base y exponente
		int p;			// Resultado de la potencia
		
		// Pedimos al usuario que introduzca la base y exponente
		Console.WriteLine("Introduce la base y el exponente para calcular la potencia");
		a = Convert.ToInt32(Console.ReadLine());
		b = Convert.ToInt32(Console.ReadLine());
		
		// Calculamos la potencia y la mostramos
		p = Potencia(a, b);
		Console.WriteLine("La potencia {0}^{1} es {2}", a, b, p);		
	}
}
