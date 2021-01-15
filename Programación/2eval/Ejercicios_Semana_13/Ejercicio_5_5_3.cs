
// Ejercicio 5.5.3 - Crear una función EsPrimo que reciba un entero y devuelva un booleano indicando si el número es primo o no

using System;

public class Ejercicio_5_5_3
{
	// Función EsPrimo
	public static bool EsPrimo(int numero)
	{
		// Recorremos los posibles divisores desde el 2 hasta la mitad del número (no habrá más divisores pasada la mitad del número)
		for (int i = 2; i <= numero/2; i++)
		{
			if (numero % i == 0)
			{
				return false;
			}
		}
		return true;
	}
	
	// Programa principal
	public static void Main()
	{
		int numero;
		bool esPrimo;
		
		Console.WriteLine("Escribe un número:");
		numero = Convert.ToInt32(Console.ReadLine());
		esPrimo = EsPrimo(numero);
		if (esPrimo)
		{
			Console.WriteLine("El número introducido es primo");
		} else {
			Console.WriteLine("El número introducido no es primo");
		}
	}
}
