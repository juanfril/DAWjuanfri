
// Ejercicio 5.9.6 - Función recursiva para invertir una cadena

using System;

public class Ejercicio_5_9_6
{
	public static string Invertir (string cadena)
	{
		// Caso base: La cadena tiene longitud 1
		if (cadena.Length==1)
			return cadena;
		// Resto de casos: pasamos el primer carácter al final y procesamos el resto de la subcadena
		else
			return Invertir(cadena.Substring(1,cadena.Length-1)) + cadena[0];
	}
	public static void Main()
	{
		string cadena;
		string resultado;
		
		//Pedimos la cadena
		Console.WriteLine("Introduce la cadena a invertir");
		cadena = Console.ReadLine();
		
		//LLamamos a la función
		resultado=Invertir(cadena);
		Console.WriteLine("El resultado es {0} ", resultado);		
	}
}
