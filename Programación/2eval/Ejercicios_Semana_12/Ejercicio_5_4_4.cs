// Ejercicio 5.4.4 - Función Inicial que devuelve el primer carácter de una cadena pasada como parámetro

using System;

public class Ejercicio_5_4_4
{
	// Función Inicial
	public static char Inicial(string s)
	{
		return s[0];
	}	
		
	
	// Programa principal
	public static void Main()
	{
		string frase;
		Console.Write("Escriba una frase: ");
		frase= Console.ReadLine();
		Console.WriteLine("La primera letra de la frase es: {0}",Inicial(frase));
	}
}
