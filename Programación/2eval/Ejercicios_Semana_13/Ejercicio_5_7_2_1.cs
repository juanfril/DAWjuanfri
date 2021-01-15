
// Ejercicio 5.7.2.1 - Crear una función Intercambiar que reciba como parámetro dos números y les intercambie el valor

using System;

public class Ejercicio_5_7_2_1
{
	// Función Intercambiar. Recibe dos números pasados por referencia para poder intercambiar su valor
	public static void Intercambiar (ref int n1, ref int n2)
	{
		int auxiliar = n1;
		n1 = n2;
		n2 = auxiliar;
	}
	
	// Programa principal
	public static void Main()
	{
		int n1 = 2, n2 = 6;
		Console.WriteLine("ANTES: n1 = {0}, n2 = {1}", n1, n2);
		Intercambiar(ref n1, ref n2);
		Console.WriteLine("DESPUES: n1 = {0}, n2 = {1}", n1, n2);
	}
}
