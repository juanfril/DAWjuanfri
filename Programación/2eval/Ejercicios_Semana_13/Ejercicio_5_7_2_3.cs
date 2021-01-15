// Ejercicio 5.7.2.3 - Función MaxMinArray que calcula el máximo y mínimo de un array de reales de doble precisión y los devuelve por parámetros por referencia

using System;

public class Ejercicio_5_7_2_3
{
	// Función MaxMinArray
	public static void MaxMinArray(double[] datos, ref double mayor, ref double menor)                   
	{
		//inicializo los valores con el primer valor del array
		mayor=datos[0];
		menor=datos[0];
		for (int i=1; i<datos.Length; i++)
		{
			if (datos[i]>mayor) mayor=datos[i];
			else if (datos[i]<menor) menor=datos[i];
		}
	}	
		
	
	// Programa principal
	public static void Main()
	{
		double[] datos;
		int longitud;
		double mayor=0;
		double menor=0;
		Console.Write("Escriba la longitud del array: ");
		longitud= Convert.ToInt32(Console.ReadLine());
		datos=new double[longitud];
		for(int i=0;i<longitud;i++)
		{
			Console.Write("introduzca el número {0}: ",i);
			datos[i]=Convert.ToDouble(Console.ReadLine());
		}
		MaxMinArray(datos,ref mayor,ref menor);
		Console.WriteLine("El valor mayor es {0}, y el menor es {1}",mayor,menor);
		
	}
}
