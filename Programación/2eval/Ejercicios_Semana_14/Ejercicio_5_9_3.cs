
// Ejercicio 5.9.3 - Función recursiva para calcular un número de la serie de Fibonacci

using System;

public class Ejercicio_5_9_3
{
	public static int Fibonacci (int a)
	{
		// Caso base: el primer y segundo elemento son 1
		if (a == 1 || a == 2)
			return 1;
		// Resto de casos: la suma de los 2 elementos anteriores
		else
			return Fibonacci(a-1) + Fibonacci(a-2);
	}
	
	public static void Main()
	{
		int a;		//numero introducido
		int f;		//resultado de Fibonacci
		
		// Pedimos al usuario que introduzca el número
		Console.WriteLine("Introduce el elemento a calcular");
		a = Convert.ToInt32(Console.ReadLine());
		
		// Calculamos y mostramos
		f = Fibonacci(a);
		Console.WriteLine("El elemento {0} de Fibonacci es {1} ", a, f);		
	}
}
