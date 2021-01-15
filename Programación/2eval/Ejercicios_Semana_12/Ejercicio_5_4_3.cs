// Ejercicio 5.4.3 - Función Signo que informa del signo del número real recibido como parámetro

using System;

public class Ejercicio_5_4_3
{
	// Función Signo
	public static float Signo(float n)
	{
		if (n<0) 
			return -1;
		else if (n>0)
			return 1;
		else
			return 0;
	}	
		
	
	// Programa principal
	public static void Main()
	{
		float num;
		Console.Write("Escriba un número: ");
		num= Convert.ToSingle(Console.ReadLine());
		if (Signo(num)==-1) Console.WriteLine("El número es negativo");
		else if (Signo(num)==1) Console.WriteLine("El número es positivo");
		else Console.WriteLine("El número es cero");
	}
}
