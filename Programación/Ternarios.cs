Console.WriteLine ("Introduzca un número");
n1 = Convert.ToInt32 (Console.ReadLine());
Console.WriteLine ("Introduzca otro número");
n2 = Convert.ToInt32 (Console.ReadLine());

CantidadDePositivos = n1 && n2 > 0 ? 2 : (n1 || n2 > 0 : 1, 0);

Console.WriteLine ("El número de positivos es {0}", CantidadDePositivos);