
// Ejercicio 5.11.1 - Función "DibujarRecuadro" que muestre un recuadro del ancho y alto indicados, con el relleno indicado
// Tanto el alto como el carácter de relleno son opcionales, y tienen valores por defecto

using System;

public class Ejercicio_5_11_1
{
    // Función de dibujado. Alto por defecto = 3, relleno por defecto = '#'
    public static void DibujarRecuadro(int ancho, int alto = 3, char relleno = '#')
    {
        for (int i = 0; i < alto; i++)
        {
            for (int j = 0; j < ancho; j++)
            {
                Console.Write(relleno);
            }
            Console.WriteLine();
        }
    }

	
	public static void Main()
	{
        int ancho, alto;
        char relleno;
        
        // Pedimos los tres datos al usuario
		
		Console.WriteLine("Introduce ancho del recuadro");
		ancho = Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("Introduce alto del recuadro");
		alto = Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("Introduce relleno del recuadro");
		relleno = Convert.ToChar(Console.ReadLine());
		
        Console.WriteLine("Dibujando recuadro:");
        DibujarRecuadro(ancho, alto, relleno);
        
        
        // Ahora dibujamos otro recuadro con valores por defecto
        Console.WriteLine("Otro recuadro con valores por defecto y mismo ancho:");
        DibujarRecuadro(ancho);
        
        // Y ahora dibujamos otro recuadro nombrando los parámetros, lo que permite cambiar el orden
        Console.WriteLine("Mismo recuadro del usuario cambiando orden de parámetros:");
        DibujarRecuadro(alto: alto, relleno: relleno, ancho: ancho);        
	}
}
