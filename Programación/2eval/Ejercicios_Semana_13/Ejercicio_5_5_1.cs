
// Ejercicio 5.5.1 - Crear una función PedirEntero que reciba como parámetro el texto a mostrar al usuario y el límite inferior y superior del entero que éste debe introducir, y repetirle que lo introduzca hasta que ponga un número correcto

using System;

public class Ejercicio_5_5_1
{
	// Función PedirEntero
	public static int PedirEntero(string texto, int min, int max)
	{
		int numero = 0;
		do
		{
			Console.WriteLine(texto);
			// Utilizamos excepciones para evitar que el usuario ponga otra cosa que no sea un número
			try
			{
				numero = Convert.ToInt32(Console.ReadLine());
			} catch (Exception e) {
				Console.WriteLine("Error al introducir el número: {0}", e.Message);
			}
		} while (numero < min || numero > max);
		
		return numero;
	}
	
	// Programa principal
	public static void Main()
	{
		int anyo = PedirEntero("Introduce un año entre 1800 y 2100", 1800, 2100);
		Console.WriteLine("Has introducido el año {0}", anyo);
	}
}
