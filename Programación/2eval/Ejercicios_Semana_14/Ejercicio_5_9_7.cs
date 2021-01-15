
// Ejercicio 5.9.7 - Función recursiva para calcular si un texto es palíndromo o no

using System;

public class Ejercicio_5_9_7
{
	// Función para ver si es palíndromo. Asumimos que el texto que se le pasa viene ya correctamente procesado para su tratamiento (sin espacios, ni mayúsculas ni otros datos discordantes)
	public static bool EsPalindromo (string texto)
	{
		// Caso base: cuando el texto es de cero o un carácter, es palíndromo
		if (texto.Length <= 1)
			return true;
		// Resto de casos: Comparamos los extremos y reducimos la cadena
		else
		{
			return (texto[0] == texto[texto.Length-1]) && EsPalindromo(texto.Substring(1, texto.Length-2));
		}
	}
	
	public static void Main()
	{
		string texto;		// texto a analizar
		
		// Pedimos al usuario que introduzca el texto
		Console.WriteLine("Introduce el texto a analizar");
		texto = Console.ReadLine();
		// Aquí podríamos pasar todo el texto a minúsculas o mayúsculas, quitar espacios y 
        // símbolos extraños, pero por simplificar el programa vamos a suponer que está ya todo procesado.
		
		// Vemos si es palíndromo
		if (EsPalindromo(texto))
		{
			Console.WriteLine("Es palíndromo");
		} else {
			Console.WriteLine("No es palíndromo");
		}
	}
}
