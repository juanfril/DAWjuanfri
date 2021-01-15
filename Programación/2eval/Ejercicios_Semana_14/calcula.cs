
// Ejercicio 5.11.2 - Calculadora sencilla que recibe los operandos y el operador como parámetros (por ejemplo, 3 + 2, o 5 * 8

using System;

public class Ejercicio_5_11_2
{
	public static void Main(string[] args)
	{
		int n1, n2;
		string operador;
		
		if (args.Length != 3)
		{
			Console.WriteLine("Uso incorrecto. Debe poner calcula <num1> <operador> <num2>");
		} else {
			n1 = Convert.ToInt32(args[0]);
			n2 = Convert.ToInt32(args[2]);
			operador = args[1];
			switch (operador)
			{
				case "+":
					Console.WriteLine(n1+n2);
					break;
				case "-":
					Console.WriteLine(n1-n2);
					break;
				case "*":
					Console.WriteLine(n1*n2);
					break;
				case "/":
					Console.WriteLine(n1/n2);
					break;
				default: 
					Console.WriteLine("Operador desconocido");
					Environment.Exit(1);
					break;
			}
		}
	}
}
