/*
Losa Márquez, Juan Fco.
Practica Evaluable Tema 4
Ejercicio 1
Apartado 1.1 si
Apartado 1.2 si
Apartado 1.3 si
Apartado 1.4 si
Apartado 1.5 si
Apartado 1.6 si
Apartado 1.7 si
Apartado 1.8 si
Apartado 1.9 si
Apartado 1.10 si
Apartado 1.11 si
*/

using System;

namespace Alumno
{
    class Program
    {
        struct alumno
        {
            public string nombre;
            public string apellidos;
            public string ciudad;
            public fecha fechaNacimiento;
            public notas notasParciales;
        }
        struct fecha
        {
            public byte dia;
            public byte mes;
            public ushort anyo;
        }
        struct notas
        {
            public float practica1;
            public float practica2;
            public float practica3;
            public float practica4;
            public float practica5;
            public float practica6;
            public float examen1;
            public float examen2;
            public float examen3;
            public float notaFinal;
        }

        static void Main(string[] args)
        {
            const byte MAXIMO = 90;
            alumno[] alumnos = new alumno[MAXIMO];
            alumno[] alumnosProvisional = new alumno[MAXIMO];
            byte opcion = 9;
            byte cantidad = 0;          //Es la variable que controla los datos
            string nombreProvisional;  
            string fechaProvisional;   
            bool diaCorrecto = false;   
            bool mesCorrecto = false;   //Estos 3 booleanos los utilizo
            bool anyoCorrecto = false;  //para controlar la fecha correcta
            float notaEva1;
            float notaEva2;
            float notaEva3;
            byte aluBorrar = 0;
            bool encontradoCuidad;
            bool encontradoAnyo;
            byte contadorAprobados = 0;
            float porcentaje;
            ushort anyoBus = 0;
            string busquedaCiudad = "";

            do
            {
                try
                {
                    Console.WriteLine();
                    Console.WriteLine("Escoja una opción:");
                    Console.WriteLine(" 1. Añadir alumno");
                    Console.WriteLine(" 2. Borrar alumno");
                    Console.WriteLine(" 3. Mostrar alumnos por ciudad");
                    Console.WriteLine(" 4. Mostrar alumnos nacidos" +
                        " en un año concreto");
                    Console.WriteLine(" 5. Ordenar listado por apellidos");
                    Console.WriteLine(" 6. Ordenar listado por nota final");
                    Console.WriteLine(" 7. Calcular porcentajes" +
                        " aprobados suspensos");
                    Console.WriteLine(" 0. Salir del programa");
                    opcion = Convert.ToByte(Console.ReadLine());
                }
                catch (Exception errorEncontrado)
                {
                    Console.WriteLine("Ha habido un error: {0}",
                        errorEncontrado.Message);
                }
                
                switch (opcion)
                {
                    case 0:
                        Console.WriteLine("Fin del programa");
                        break;

                    case 1:
                        if(cantidad < MAXIMO)
                        {
                            try
                            {
                                Console.WriteLine("Nombre y apellidos del alumno: ");
                                nombreProvisional = Console.ReadLine();
                                string[] nombrePartido = nombreProvisional.Split();
                                alumnos[cantidad].nombre = nombrePartido[0];
                                alumnos[cantidad].apellidos =
                                    nombrePartido[1] + " " + nombrePartido[2];

                                Console.WriteLine("Ciudad");
                                alumnos[cantidad].ciudad = Console.ReadLine();

                                do
                                {
                                    diaCorrecto = false;
                                    mesCorrecto = false;
                                    anyoCorrecto = false;

                                    Console.WriteLine("Fecha de nacimiento" +
                                        " (dd-mm-aaaa)");
                                    fechaProvisional = Console.ReadLine();
                                    string[] fechaPartida =
                                        fechaProvisional.Split('-');
                                    byte diaProvisional = 
                                        Convert.ToByte(fechaPartida[0]);
                                    byte mesProvisional = 
                                        Convert.ToByte(fechaPartida[1]);
                                    ushort anyoProvisional = 
                                        Convert.ToUInt16(fechaPartida[2]);

                                    if (diaProvisional >= 1 && diaProvisional <= 31)
                                    {
                                        alumnos[cantidad].fechaNacimiento.dia =
                                            diaProvisional;
                                        diaCorrecto = true;
                                    }
                                    else if (diaProvisional > 31)
                                    {
                                        Console.WriteLine("Día demasiado alto");
                                    }
                                    else
                                    {
                                        Console.WriteLine("Día demasiado bajo");
                                    }
                                    if (mesProvisional >= 1 && mesProvisional <= 12)
                                    {
                                        alumnos[cantidad].fechaNacimiento.mes =
                                            mesProvisional;
                                        mesCorrecto = true;
                                    }
                                    else if (mesProvisional > 12)
                                    {
                                        Console.WriteLine("Mes demasiado alto");
                                    }
                                    else
                                    {
                                        Console.WriteLine("Mes demasiado bajo");
                                    }
                                    if (anyoProvisional >= 1900 &&
                                        anyoProvisional <= 2010)
                                    {
                                        alumnos[cantidad].fechaNacimiento.anyo =
                                            anyoProvisional;
                                        anyoCorrecto = true;
                                    }
                                    else if (anyoProvisional > 12)
                                    {
                                        Console.WriteLine("Año demasiado alto");
                                    }
                                    else
                                    {
                                        Console.WriteLine("Año demasiado bajo");
                                    }
                                } while (diaCorrecto == false ||
                                            mesCorrecto == false ||
                                            anyoCorrecto == false);

                                Console.WriteLine("Nota práctica 1");
                                alumnos[cantidad].notasParciales.practica1 =
                                    Convert.ToSingle(Console.ReadLine());
                                Console.WriteLine("Nota práctica 2");
                                alumnos[cantidad].notasParciales.practica2 =
                                    Convert.ToSingle(Console.ReadLine());
                                Console.WriteLine("Nota práctica 3");
                                alumnos[cantidad].notasParciales.practica3 =
                                    Convert.ToSingle(Console.ReadLine());
                                Console.WriteLine("Nota práctica 4");
                                alumnos[cantidad].notasParciales.practica4 =
                                    Convert.ToSingle(Console.ReadLine());
                                Console.WriteLine("Nota práctica 5");
                                alumnos[cantidad].notasParciales.practica5 =
                                    Convert.ToSingle(Console.ReadLine());
                                Console.WriteLine("Nota práctica 6");
                                alumnos[cantidad].notasParciales.practica6 =
                                    Convert.ToSingle(Console.ReadLine());
                                Console.WriteLine("Nota exámen 1ª evalución");
                                alumnos[cantidad].notasParciales.examen1 =
                                    Convert.ToSingle(Console.ReadLine());
                                Console.WriteLine("Nota exámen 2ª evalución");
                                alumnos[cantidad].notasParciales.examen2 =
                                    Convert.ToSingle(Console.ReadLine());
                                Console.WriteLine("Nota exámen 3ª evalución");
                                alumnos[cantidad].notasParciales.examen3 =
                                    Convert.ToSingle(Console.ReadLine());
                            }
                            catch (Exception errorEncontrado)
                            {
                                Console.WriteLine("Ha habido un error: {0}",
                                    errorEncontrado.Message);
                                break;
                            }

                            notaEva1 =((30 * (alumnos[cantidad].notasParciales.practica1 +
                                alumnos[cantidad].notasParciales.practica2) / 100) / 2) +
                                (70 * (alumnos[cantidad].notasParciales.examen1) / 100);

                            notaEva2 = ((30 * (alumnos[cantidad].notasParciales.practica3 +
                                alumnos[cantidad].notasParciales.practica4) / 100) / 2) +
                                (70 * (alumnos[cantidad].notasParciales.examen2) / 100);

                            notaEva3 = ((30 * (alumnos[cantidad].notasParciales.practica5 +
                                alumnos[cantidad].notasParciales.practica6) / 100) / 2) +
                                (70 * (alumnos[cantidad].notasParciales.examen3) / 100);                        

                            alumnos[cantidad].notasParciales.notaFinal =
                                (20 * (notaEva1 / 100)) + (30 * (notaEva2 / 100)) +
                                (50 * (notaEva3 / 100));
                            cantidad++;
                        }
                        else
                        {
                            Console.WriteLine("No quedan espacios disponibles" +
                                "({0} máximo)", MAXIMO);
                        }                        
                        break;

                    case 2:
                        for (int i = 0; i < cantidad; i++)
                        {
                            Console.WriteLine("{0}. {1} {2}", i+1, alumnos[i].nombre, 
                                alumnos[i].apellidos);
                        }
                        Console.WriteLine();
                        try
                        {
                            Console.WriteLine("¿Número de alumno a borrar?");
                            aluBorrar = Convert.ToByte(Console.ReadLine());
                        }
                        catch (Exception errorEncontrado)
                        {
                            Console.WriteLine("Ha habido un error: {0}",
                                errorEncontrado.Message);
                        }
                        if (aluBorrar < cantidad)
                        {
                            for (int i = aluBorrar - 1; i < cantidad - 1; i++)
                            {
                                alumnos[i] = alumnos[i + 1];
                            }
                            cantidad--;
                        }
                        else
                        {
                            Console.WriteLine("Número de alumno incorrecto");
                        }
                        break;

                    case 3:
                        encontradoCuidad = false;
                        Console.WriteLine();
                        try
                        {
                            Console.WriteLine("Indique ciudad a buscar");
                            busquedaCiudad = Console.ReadLine().ToUpper();
                        }
                        catch (Exception errorEncontrado)
                        {
                            Console.WriteLine("Ha habido un error: {0}",
                                errorEncontrado.Message);
                        }
                        for (int i = 0; i < cantidad; i++)
                        {
                            if (alumnos[i].ciudad.ToUpper().Contains(busquedaCiudad))
                            {
                                Console.WriteLine("{0}. {1} {2}. {3}", i + 1, alumnos[i].nombre,
                                alumnos[i].apellidos, alumnos[i].ciudad);
                                encontradoCuidad = true;
                            }
                        }
                        if(encontradoCuidad == false)
                        {
                            Console.WriteLine();
                            Console.WriteLine("No se encontraron coincidencias");
                        }
                        break;

                    case 4:
                        encontradoAnyo = false;
                        Console.WriteLine();
                        try
                        {
                            Console.WriteLine("Indique año a buscar");
                            anyoBus = Convert.ToUInt16(Console.ReadLine());
                        }
                        catch (Exception errorEncontrado)
                        {
                            Console.WriteLine("Ha habido un error: {0}",
                                errorEncontrado.Message);
                        }
                        for (int i = 0; i < cantidad; i++)
                        {
                            if (alumnos[i].fechaNacimiento.anyo == anyoBus)
                            {
                                Console.WriteLine("{0}. {1} {2}. {3}",
                                    i + 1, alumnos[i].nombre,
                                    alumnos[i].apellidos,
                                    alumnos[i].fechaNacimiento.anyo);
                                encontradoAnyo = true;
                            }
                        }
                        if (encontradoAnyo == false)
                        {
                            Console.WriteLine();
                            Console.WriteLine("No se encontraron coincidencias");
                        }
                        break;

                    case 5:
                        for (int i = 0; i < cantidad -1; i++)
                        {
                            for (int j = i+1; j < cantidad; j++)
                            {
                                if (alumnos[i].apellidos.ToUpper()
                                    .CompareTo(alumnos[j].apellidos.ToUpper()) > 0)
                                {
                                    alumnosProvisional[i] = alumnos[i];
                                    alumnos[i] = alumnos[j];
                                    alumnos[j] = alumnosProvisional[i];
                                }
                            }
                        }
                        for (int i = 0; i < cantidad; i++)
                        {
                            Console.WriteLine("{0}. {1}, {2}", i + 1, alumnos[i].apellidos,
                                alumnos[i].nombre);
                        }
                        break;

                    case 6:
                        for (int i = 0; i < cantidad - 1; i++)
                        {
                            for (int j = i + 1; j < cantidad; j++)
                            {
                                if (alumnos[i].notasParciales.notaFinal <
                                    alumnos[j].notasParciales.notaFinal)
                                {
                                    alumnosProvisional[i] = alumnos[i];
                                    alumnos[i] = alumnos[j];
                                    alumnos[j] = alumnosProvisional[i];
                                }
                            }
                        }
                        for (int i = 0; i < cantidad; i++)
                        {
                            Console.WriteLine("{0}. {1} {2}.Nota final = {3}",
                                i + 1, alumnos[i].nombre, alumnos[i].apellidos,
                                alumnos[i].notasParciales.notaFinal);
                        }
                        break;

                    case 7:
                        for (int i = 0; i < cantidad; i++)
                        {
                            if (alumnos[i].notasParciales.practica1 >= 5)
                            {
                                contadorAprobados++;
                            }
                        }
                        porcentaje = (contadorAprobados * 100) / cantidad;
                        Console.WriteLine("El porcentaje de aprobados de la" +
                            " práctica 1 es del {0}%, de {1} alumnos", porcentaje, cantidad);

                        contadorAprobados = 0;
                        for (int i = 0; i < cantidad; i++)
                        {
                            if (alumnos[i].notasParciales.practica2 >= 5)
                            {
                                contadorAprobados++;
                            }
                        }
                        porcentaje = (contadorAprobados * 100) / cantidad;
                        Console.WriteLine("El porcentaje de aprobados de la" +
                            " práctica 2 es del {0}%, de {1} alumnos", porcentaje, cantidad);

                        contadorAprobados = 0;
                        for (int i = 0; i < cantidad; i++)
                        {
                            if (alumnos[i].notasParciales.practica3 >= 5)
                            {
                                contadorAprobados++;
                            }
                        }
                        porcentaje = (contadorAprobados * 100) / cantidad;
                        Console.WriteLine("El porcentaje de aprobados de la" +
                            " práctica 3 es del {0}%, de {1} alumnos", porcentaje, cantidad);

                        contadorAprobados = 0;
                        for (int i = 0; i < cantidad; i++)
                        {
                            if (alumnos[i].notasParciales.practica4 >= 5)
                            {
                                contadorAprobados++;
                            }
                        }
                        porcentaje = (contadorAprobados * 100) / cantidad;
                        Console.WriteLine("El porcentaje de aprobados de la" +
                            " práctica 4 es del {0}%, de {1} alumnos", porcentaje, cantidad);

                        contadorAprobados = 0;
                        for (int i = 0; i < cantidad; i++)
                        {
                            if (alumnos[i].notasParciales.practica5 >= 5)
                            {
                                contadorAprobados++;
                            }
                        }
                        porcentaje = (contadorAprobados * 100) / cantidad;
                        Console.WriteLine("El porcentaje de aprobados de la" +
                            " práctica 5 es del {0}%, de {1} alumnos", porcentaje, cantidad);

                        contadorAprobados = 0;
                        for (int i = 0; i < cantidad; i++)
                        {
                            if (alumnos[i].notasParciales.practica6 >= 5)
                            {
                                contadorAprobados++;
                            }
                        }
                        porcentaje = (contadorAprobados * 100) / cantidad;
                        Console.WriteLine("El porcentaje de aprobados de la" +
                            " práctica 6 es del {0}%, de {1} alumnos", porcentaje, cantidad);

                        contadorAprobados = 0;
                        for (int i = 0; i < cantidad; i++)
                        {
                            if (alumnos[i].notasParciales.examen1 >= 5)
                            {
                                contadorAprobados++;
                            }
                        }
                        porcentaje = (contadorAprobados * 100) / cantidad;
                        Console.WriteLine("El porcentaje de aprobados del exámen" +
                           "de la 1ª evaluación es del {0}%, de {1} alumnos",
                           porcentaje, cantidad);

                        contadorAprobados = 0;
                        for (int i = 0; i < cantidad; i++)
                        {
                            if (alumnos[i].notasParciales.examen2 >= 5)
                            {
                                contadorAprobados++;
                            }
                        }
                        porcentaje = (contadorAprobados * 100) / cantidad;
                        Console.WriteLine("El porcentaje de aprobados del exámen" +
                           "de la 2ª evaluación es del {0}%, de {1} alumnos",
                           porcentaje, cantidad);

                        contadorAprobados = 0;
                        for (int i = 0; i < cantidad; i++)
                        {
                            if (alumnos[i].notasParciales.examen3 >= 5)
                            {
                                contadorAprobados++;
                            }
                        }
                        porcentaje = (contadorAprobados * 100) / cantidad;
                        Console.WriteLine("El porcentaje de aprobados del exámen" +
                           "de la 3ª evaluación es del {0}%, de {1} alumnos",
                           porcentaje, cantidad);

                        contadorAprobados = 0;
                        for (int i = 0; i < cantidad; i++)
                        {
                            if (alumnos[i].notasParciales.notaFinal >= 5)
                            {
                                contadorAprobados++;
                            }
                        }
                        porcentaje = (contadorAprobados * 100) / cantidad;
                        Console.WriteLine("El porcentaje de aprobados a final" +
                           "de curso es del {0}%, de {1} alumnos", porcentaje, cantidad);
                        break;

                    default:
                        Console.WriteLine("Opción desconocida");
                        break;
                }
                Console.WriteLine();
            }
            while (opcion != 0);

        }
    }
}
