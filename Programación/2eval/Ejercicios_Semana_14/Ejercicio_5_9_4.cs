
// Ejercicio 5.9.4 - Función recursiva para calcular la suma de los elementos de un vector

using System;

public class Ejercicio_5_9_4
{
	public static int SumaVector (int[] v,int desde, int hasta)
	{
		// Caso base: Cuando llegamos al último elemento del vector
		if (desde==hasta)
			return v[desde];
		// Resto de casos: la suma de todos los elementos posteriores y en el que estamos
		else
			return SumaVector(v,desde+1,hasta) + v[desde];
	}
	public static void Main()
	{
		int[] v;			
		int n;
		int r;
		
		Console.WriteLine("Introduce el número de elementos del vector");
		n = Convert.ToInt32(Console.ReadLine());
		v=new int[n];
		// Pedimos al usuario que introduzca el vector
		for(int i=0;i<n;i++)
		{
			Console.WriteLine("Introduce el elemento {0}",i);
			v[i] = Convert.ToInt32(Console.ReadLine());
		}
		// Calculamos y mostramos
		r = SumaVector(v,0,n-1);
		Console.WriteLine("El resultado es {0} ", r);		
	}
}
