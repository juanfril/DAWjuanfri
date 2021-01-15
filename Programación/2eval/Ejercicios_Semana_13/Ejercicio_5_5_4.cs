// Ejercicio 5.5.4 - Función ContarLetra que devuelve el número de veces que está una letra pasada por parámetro en la frase pasada también por parámetro

using System;

public class Ejercicio_5_5_4
{
	// Función ContarLetra
	public static int ContarLetra(char c, string s)
	{
		int contador=0;
		for (int i=0; i<s.Length; i++)
		{
			if (s[i]==c) contador++;
		}
		return contador;
	}	
		
	
	// Programa principal
	public static void Main()
	{
		string frase;
		char letra;
		Console.Write("Escriba una frase: ");
		frase= Console.ReadLine();
		Console.Write("Escriba una letra: ");
		letra= Convert.ToChar(Console.ReadLine());
		Console.WriteLine("La letra {0} se repite {1} veces",letra, ContarLetra(letra,frase));
	}
}
