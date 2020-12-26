/*
 * Práctica Evaluable Tema 4
 * Ejercicio Unico
 * 
 * Programa para gestionar un array de alumnos, con capacidad para hasta 90 alumnos
 * 
*/

using System;

public class Alumnos
{
	struct tipoAlumno
	{
		public string nombre;
		public string apellidos;
		public string ciudad;
		public tipoFecha fechaNacimiento;
		public tipoNota nota;
	}

	struct tipoFecha
	{
		public byte dia;
		public byte mes;
		public ushort anyo;
	}

	struct tipoNota
	{
		public float[] practica;
		public float[] examen;
		public float final;
	}
        

	public static void Main()
	{
		const int MAXIMO = 90;		// Capacidad maxima del array de alumnos
		const int PRACTICAS = 6;	// Capacidad maxima del array de notas de practicas
		const int EXAMENES = 3;		// Capacidad maxima del array de notas de examenes
		
		tipoAlumno[] alumnos = new tipoAlumno[MAXIMO];

		// Elemento temporal para ordenar array principal
		tipoAlumno alumnoTemporal;

		int ocupados = 0;			// Numero alumnos almacenados
		string opcion;				// Para gestión elección del menú principal
		string texto; 				// Almacena texto introducido por teclado

		bool fecha_OK = false;		// Comprobación fecha introducida correctamente
		
		bool salir_OK = false;		// Para finalizar aplicación
		bool encontrado = false;	// Para la búsqueda de contactos por ciudad o año

		float notaAUX;				// Para el almacenar las notas de las evaluaciones

		do
		{
			encontrado = false;
			Console.Clear();		// Borra la pantalla

			Console.WriteLine("****************************");
			Console.WriteLine("**** Gestion de ALUMNOS ****");
			Console.WriteLine("****************************");
			Console.WriteLine();
			Console.WriteLine("1. Añadir alumno");
			Console.WriteLine("2. Borrar alumno");
			Console.WriteLine("3. Mostrar alumnos de una ciudad");
            Console.WriteLine("4. Mostrar alumnos nacidos en un año");
			Console.WriteLine("5. Ordenar alfabéticamente el array por apellido (ascendente)");
			Console.WriteLine("6. Ordenar el array por mayor nota final (descendente)");
			Console.WriteLine("7. Calcular porcentajes aprobados y suspensos");
			Console.WriteLine();
			Console.WriteLine("0. Salir del programa");
			Console.WriteLine();
			Console.Write("Escoja una opción (0-7): ");
			
			opcion = Console.ReadLine();
			
			Console.Clear();		// Borra la pantalla
                
			switch (opcion)
			{
				case "1":
					Console.WriteLine("1. Añadir alumno");
					Console.WriteLine("****************");
					Console.WriteLine();

					if (ocupados >= MAXIMO)
						Console.WriteLine("El array está lleno. No se pueden añadir más alumnos");
					else
					{
						Console.Write("Introduce el nombre y dos apellidos: ");
						texto = Console.ReadLine();

						// Control excepción: Nombre y Apellidos deben estar separados por " "
						try
						{				
							string[] nombreApellidos = texto.Split();
									
							alumnos[ocupados].nombre = nombreApellidos[0];
							alumnos[ocupados].apellidos = nombreApellidos[1] + " " + nombreApellidos[2];
						}
						catch (Exception)
						{
							Console.WriteLine("Formato de introducción de datos incorrecto");
						}
								
						Console.Write("Introduce la ciudad: ");
						alumnos[ocupados].ciudad = Console.ReadLine();
						
						do
						{
							Console.WriteLine();
							Console.WriteLine("El día de estar comprendido entre 1 y 31.");
							Console.WriteLine("El mes debe estar comprendido entre 1 y 12.");
							Console.WriteLine("El año debe estar comprendido entre 1900 y 2010.");
							Console.Write("Introduce la fecha de nacimiento (\"dd-mm-aaaa\"): ");
							texto = Console.ReadLine();

							// Control excepción: fecha debe estar separada por "-"
							try
							{												
								string[] diaMesAnyo = texto.Split('-');
														
								alumnos[ocupados].fechaNacimiento.dia = Convert.ToByte(diaMesAnyo[0]);
								alumnos[ocupados].fechaNacimiento.mes = Convert.ToByte(diaMesAnyo[1]);
								alumnos[ocupados].fechaNacimiento.anyo = Convert.ToUInt16(diaMesAnyo[2]);

								// Comprobación errores en introducción fecha
								if ((alumnos[ocupados].fechaNacimiento.dia <=31) && (alumnos[ocupados].fechaNacimiento.dia >0) 
									&& (alumnos[ocupados].fechaNacimiento.mes >0) && (alumnos[ocupados].fechaNacimiento.mes <=12)
									&& (alumnos[ocupados].fechaNacimiento.anyo >= 1900) &&  (alumnos[ocupados].fechaNacimiento.anyo <= 2010))
								{
									fecha_OK = true;
								}
								else
								{
									Console.WriteLine();
									Console.WriteLine("Fecha incorrecta. Introduce una fecha válida.");
									Console.WriteLine();
									fecha_OK = false;
								}
							}
							catch (Exception)
							{
								Console.WriteLine("Formato de introducción de datos incorrecto");
							}
						}
						while (fecha_OK == false);

						alumnos[ocupados].nota.practica = new float[PRACTICAS];
						alumnos[ocupados].nota.examen = new float[EXAMENES];

						// Control excepción: las "notas" deben ser tipo float
						try
						{				
							for (int i = 0; i < PRACTICAS; i++)
							{
								do
								{
									Console.Write($"Introduce nota de la práctica {i + 1}: ");
									alumnos[ocupados].nota.practica[i] = Convert.ToSingle(Console.ReadLine());
								}
								while (!(alumnos[ocupados].nota.practica[i] >= 0 && alumnos[ocupados].nota.practica[i] <= 10));
							}
							
							for (int i = 0; i < EXAMENES; i++)
							{
								do
								{
									Console.Write($"Introduce nota de examen {i + 1}: ");
									alumnos[ocupados].nota.examen[i] = Convert.ToInt32(Console.ReadLine());
								}
								while (!(alumnos[ocupados].nota.examen[i] >= 0 && alumnos[ocupados].nota.examen[i] <= 10));
							}

							// Calculo de la nota final
							notaAUX = 0.0f;
							notaAUX = (0.3f * ((alumnos[ocupados].nota.practica[0] + alumnos[ocupados].nota.practica[1]) * 0.5f) + 0.7f * alumnos[ocupados].nota.examen[0]);
							alumnos[ocupados].nota.final = 0.2f * notaAUX;

							notaAUX = (0.3f * ((alumnos[ocupados].nota.practica[2] + alumnos[ocupados].nota.practica[3]) * 0.5f) + 0.7f * alumnos[ocupados].nota.examen[1]);
							alumnos[ocupados].nota.final += 0.3f * notaAUX;

							notaAUX = (0.3f * ((alumnos[ocupados].nota.practica[4] + alumnos[ocupados].nota.practica[5]) * 0.5f) + 0.7f * alumnos[ocupados].nota.examen[2]);
							alumnos[ocupados].nota.final += 0.5f * notaAUX;
						}
						catch (Exception)
						{
							Console.WriteLine("Formato de introducción de datos incorrecto");
						}		
						ocupados++;
					}
					break;

				case "2":
					Console.WriteLine("2. Borrar alumno");
					Console.WriteLine("****************");
					Console.WriteLine();
					
					if (ocupados <= 0)
					{
						Console.WriteLine("No hay alumnos que borrar. El array esta vacio");
					}
					else
					{
						for (int i=0; i<ocupados; i++)		// Muestra toda la lista de contactos
						{
							Console.WriteLine("{0}-- {1} {2}", i+1, alumnos[i].nombre, alumnos[i].apellidos); 
							Console.WriteLine("Ciudad: {0}", alumnos[i].ciudad);
							Console.WriteLine("Fecha Nacimiento: {0}/{1}/{2}", alumnos[i].fechaNacimiento.dia, alumnos[i].fechaNacimiento.mes, alumnos[i].fechaNacimiento.anyo);
							Console.WriteLine("Nota final: {0}", alumnos[i].nota.final);
							Console.WriteLine(); 
						}	
						Console.Write("Elige la posición que quieres borrar...: ");
								
						// Control excepción: posicion borrable debe ser byte
						try
						{
							byte posicionBorrar = Convert.ToByte(Console.ReadLine());
							posicionBorrar -= 1;

							if (posicionBorrar < ocupados)
							{
								for (int i= posicionBorrar; i <ocupados -1; i++)
								{
									alumnos[i] = alumnos[i+1];
								}
								ocupados--;
							}
							else
							{
								Console.WriteLine();
								Console.WriteLine("Posición incorrecta.");
								Console.WriteLine("Escoge una posición entre 1 y {0}.", ocupados);
							}
						}
						catch (Exception)
						{
							Console.WriteLine();
							Console.WriteLine("Posición incorrecta.");
							Console.WriteLine("Escoge una posición entre 1 y {0}.", ocupados);
						}
					}
					break;

				case "3":
					Console.WriteLine("3. Mostrar alumnos de una ciudad");
					Console.WriteLine("********************************");
					Console.WriteLine();
					
					if (ocupados <= 0)
					{
						Console.WriteLine("No hay alumnos que mostrar. El array esta vacio");
					}
					else
					{
						Console.Write("Indica la ciudad de búsqueda: ");
						string buscarCiudad = Console.ReadLine();
							
						for (int i=0; i < ocupados; i++)
						{
							if (alumnos[i].ciudad.ToUpper().Contains(buscarCiudad.ToUpper()))
							{
								encontrado = true;
								Console.WriteLine(); 
								Console.WriteLine("{0}-- {1} {2}", i+1, alumnos[i].nombre, alumnos[i].apellidos); 
								Console.WriteLine("Ciudad: {0}", alumnos[i].ciudad);
								Console.WriteLine("Fecha Nacimiento: {0}/{1}/{2}", alumnos[i].fechaNacimiento.dia, alumnos[i].fechaNacimiento.mes, alumnos[i].fechaNacimiento.anyo);
								Console.WriteLine("Nota final: {0}", alumnos[i].nota.final);
							}
						}
						if (encontrado == false)
						{
							Console.WriteLine("\nBúsqueda sin resultados");
						}
					}
					break;

				case "4":
					Console.WriteLine("4. Mostrar alumnos nacidos en un año");
					Console.WriteLine("************************************");
					Console.WriteLine();

					if (ocupados <= 0)
					{
						Console.WriteLine("No hay alumnos que mostrar. El array esta vacio");
					}
					else
					{
						// Control excepción: año buscado debe ser entero positivo
						try
						{
							Console.Write("Indica el año de nacimiento buscado: ");
							ushort buscarAnyoNac = Convert.ToUInt16(Console.ReadLine());
								
							for (int i=0; i < ocupados; i++)
							{
								if (alumnos[i].fechaNacimiento.anyo == buscarAnyoNac)
								{
									encontrado = true;
									Console.WriteLine(); 
									Console.WriteLine("{0}-- {1} {2}", i+1, alumnos[i].nombre, alumnos[i].apellidos); 
									Console.WriteLine("Ciudad: {0}", alumnos[i].ciudad);
									Console.WriteLine("Fecha Nacimiento: {0}/{1}/{2}", alumnos[i].fechaNacimiento.dia, alumnos[i].fechaNacimiento.mes, alumnos[i].fechaNacimiento.anyo);
									Console.WriteLine("Nota final: {0}", alumnos[i].nota.final);
								}
							}
							if (encontrado == false)
							{
								Console.WriteLine("\nBúsqueda sin resultados");
							}
						}
						catch (Exception)
						{
							Console.WriteLine("\nAño incorrecto.");
							Console.WriteLine("El año debe estar comprendido entre 1900 y 2010.");
						}
					}
					break;

				case "5":
					Console.WriteLine("5. Ordenar alfabéticamente el array por apellido");
					Console.WriteLine("************************************************");
					Console.WriteLine();

					if (ocupados <= 0)
					{
						Console.WriteLine("No hay alumnos que ordenar. El array esta vacio");
					}
					else
					{
						for (int i=0; i < ocupados-1; i++)
						{
							for(int j=i+1; j< ocupados; j++)
							{
								if (String.Compare(alumnos[i].apellidos, alumnos[j].apellidos, true) > 0)
								{
									alumnoTemporal = alumnos[i]; 
									alumnos[i] = alumnos[j];
									alumnos[j] = alumnoTemporal;	
								}
							}
						}
						
						for (int i=0; i<ocupados; i++)
						{
								Console.WriteLine(); 
								Console.WriteLine("{0}-- {1} {2}", i+1, alumnos[i].nombre, alumnos[i].apellidos); 
								Console.WriteLine("Ciudad: {0}", alumnos[i].ciudad);
								Console.WriteLine("Fecha Nacimiento: {0}/{1}/{2}", alumnos[i].fechaNacimiento.dia, alumnos[i].fechaNacimiento.mes, alumnos[i].fechaNacimiento.anyo);
								Console.WriteLine("Nota final: {0}", alumnos[i].nota.final);
						}
					}
					break;

				case "6":
					Console.WriteLine("6. Ordenar el array por mayor nota final (descendente)");
					Console.WriteLine("******************************************************");
					Console.WriteLine();

					if (ocupados <= 0)
					{
						Console.WriteLine("No hay alumnos que ordenar. El array esta vacio");
					}
					else
					{
						for (int i=0; i < ocupados-1; i++)
						{
							for(int j=i+1; j< ocupados; j++)
							{
								if (alumnos[i].nota.final < alumnos[j].nota.final)
								{
									alumnoTemporal = alumnos[i]; 
									alumnos[i] = alumnos[j];
									alumnos[j] = alumnoTemporal;	
								}
							}
						}
						
						for (int i=0; i<ocupados; i++)
						{
								Console.WriteLine(); 
								Console.WriteLine("{0}-- {1} {2}", i+1, alumnos[i].nombre, alumnos[i].apellidos); 
								Console.WriteLine("Ciudad: {0}", alumnos[i].ciudad);
								Console.WriteLine("Fecha Nacimiento: {0}/{1}/{2}", alumnos[i].fechaNacimiento.dia, alumnos[i].fechaNacimiento.mes, alumnos[i].fechaNacimiento.anyo);
								Console.WriteLine("Nota final: {0}", alumnos[i].nota.final);
						}
					}
					break;

				case "7":
					Console.WriteLine("7. Calcular porcentajes aprobados y suspensos");
					Console.WriteLine("*********************************************");
					Console.WriteLine();

					if (ocupados <= 0)
					{
						Console.WriteLine("No hay porcentajes que calcular. El array esta vacio");
					}
					else
					{
						int[] aprobadosPractica = new int[PRACTICAS];
						int[] aprobadosExamen = new int[EXAMENES];
						int aprobadosFinal = 0;

						float porcenAprobados;
							
						for (int n = 0; n < ocupados; n++)
						{
							for (int i = 0; i < PRACTICAS; i++)
							{
								if (alumnos[n].nota.practica[i] >= 5) aprobadosPractica[i]++;
							}
							for (int i = 0; i < EXAMENES; i++)
							{
								if (alumnos[n].nota.examen[i] >= 5) aprobadosExamen[i]++;
							}
							if (alumnos[n].nota.final >= 5) aprobadosFinal++;
						}
						
						Console.WriteLine("Estadísticas");
						Console.WriteLine();

						for (int i = 0; i < PRACTICAS; i++)
						{
							porcenAprobados = aprobadosPractica[i] * 100 / ocupados;

							Console.WriteLine("Práctica {0}: Aprobados {1}% {2} alumnos -- Suspendidos {3}% {4} alumnos",
								i+1, porcenAprobados, aprobadosPractica[i],
								100-porcenAprobados, ocupados-aprobadosPractica[i]);
						}
						for (int i = 0; i < EXAMENES; i++)
						{
							porcenAprobados = aprobadosExamen[i] * 100 / ocupados;
							Console.WriteLine("Examen {0}: Aprobados {1}% {2} alumnos -- Suspendidos {3}% ({4} alumnos)",
								i+1, porcenAprobados, aprobadosExamen[i],
								100-porcenAprobados, ocupados-aprobadosExamen[i]);

						}
						porcenAprobados = aprobadosFinal * 100 / ocupados;
						Console.WriteLine("Nota Final: Aprobados {0}% ({1} de {2}) -- Suspendidos {3}% ({4} de {5})",
							porcenAprobados, aprobadosFinal, ocupados,
							100-porcenAprobados, ocupados-aprobadosFinal, ocupados);
					}
					break;

				case "0":
					Console.WriteLine("Gracias por utilizar la aplicacion");
					salir_OK = true;
					break;

				default:
					Console.WriteLine("Opcion incorrecta.");
					Console.WriteLine("Escoja la opcion adecuada.");
					break;	
			}
			Console.WriteLine("\nPulse una tecla para continuar... ");
			Console.ReadKey();
		}
		while (salir_OK == false);           
    }
}

