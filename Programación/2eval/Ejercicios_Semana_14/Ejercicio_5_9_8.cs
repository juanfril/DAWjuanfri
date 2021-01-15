
// Ejercicio 5.9.8 - Función recursiva para obtener el M.C.D. de dos números con el algoritmo de Euclides

using System;

public class Ejercicio_5_9_8
{
	public static int MCD (int a, int b)
	{
		// Caso base: cuando el resto de dividir a entre b es 0, el MCD es b
		if (a%b == 0)
			return b;
		// Resto de casos: hallamos el resto de dividir a entre b y calculamos el MCD de b y el resto
		else
			return MCD(b, a%b);
	}
	
	public static void Main()
	{
		int a, b;		// Números para calcular el MCD
		int resultado;	// Resultado de calcular el MCD
		
		// Pedimos al usuario que introduzca los números
		Console.WriteLine("Introduce los números para calcular su MCD");
		a = Convert.ToInt32(Console.ReadLine());
		b = Convert.ToInt32(Console.ReadLine());
		
		// Calculamos y mostramos el resultado
		resultado = MCD(a, b);
		Console.WriteLine("El MCD es {0}", resultado);		
	}
}
