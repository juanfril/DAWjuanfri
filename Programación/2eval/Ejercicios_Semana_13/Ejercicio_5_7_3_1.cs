
// Ejercicio 5.7.3.1 - Crear una función Iniciales que reciba un texto (compuesto por dos palabras, como un nombre y apellido) y dos variables de salida, y guarde en ellas las iniciales de cada palabra

using System;

public class Ejercicio_5_7_3_1
{
	// Función Iniciales. Recibe un nombre y dos variables de salida para almacenar las iniciales
	// Vamos a suponer que se recibe un nombre correcto (nombre + apellido)
	public static void Iniciales (string nombre, out char inicial1, out char inicial2)
	{
		string[] partes = nombre.Split(' ');
		inicial1 = partes[0][0];
		inicial2 = partes[1][0];
	}
	
	// Programa principal
	public static void Main()
	{
		string nombre;
		char ini1, ini2;
		
		Console.WriteLine("Dime tu nombre:");
		nombre = Console.ReadLine();
		Iniciales(nombre, out ini1, out ini2);
		Console.WriteLine("Tus iniciales son {0}.{1}.", ini1, ini2);
	}
}
