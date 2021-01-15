// Ejercicio 5.4.1 - Función Cubo que calcula el cubo de un número real pasado por parámetro

using System;

public class Ejercicio_5_4_1
{
	// Función Cubo
	public static float Cubo(float n)
	{
		return n*n*n;
	}	
		
	
	// Programa principal
	public static void Main()
	{
		float num;
		Console.Write("Escriba un número: ");
		num= Convert.ToSingle(Console.ReadLine());
		Console.WriteLine("El cubo de {0} es {1}",num,Cubo(num));
	}
}
