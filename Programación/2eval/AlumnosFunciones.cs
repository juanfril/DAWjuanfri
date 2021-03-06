﻿/*
Losa Márquez, Juan Fco.
Práctica Evaluable Tema 5
Ejercicio 1
Apartado 1.1 si
Apartado 1.2 si
Apartado 1.3 si
Apartado 1.4 si
Apartado 1.5 parcialmente
Apartado 1.6 si
Apartado 1.7 parcialmente
Apartado 1.8 si
Apartado 1.9 si
Apartado 1.10 parcialmente
 */

using System;

namespace AlumnosFunciones
{
    class AlumnosFunciones
    {
        struct alumno
        {
            public string nombre;
            public string apellidos;
            public string dni;
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
            public float[] practicas;
            public float[] examenes;
            public float notaFinal;
        }

        static byte Opciones()
        {
            byte opcion = 9;
            bool opcionValida;
            
            while(opcion > 8)
            {
                Console.Clear();
                Console.WriteLine();
                Console.WriteLine("Escoja una opción:");
                Console.WriteLine(" 1. Añadir alumno");
                Console.WriteLine(" 2. Borrar alumno");
                Console.WriteLine(" 3. Buscar alumnos por apellidos o DNI");
                Console.WriteLine(" 4. Mostrar alumnos por ciudad");
                Console.WriteLine(" 5. Ordenar listado por apellidos");
                Console.WriteLine(" 6. Ordenar listado por nota final");
                Console.WriteLine(" 7. Calcular porcentajes" +
                    " aprobados suspensos");
                Console.WriteLine(" 8. Mostrar gráfica");
                Console.WriteLine(" 0. Salir del programa");

                opcionValida = byte.TryParse(Console.ReadLine(), out opcion);

                if (opcion < 9 && opcionValida)
                    Console.WriteLine("Ha elegido la opcion {0}", opcion);
                else
                {
                    opcion = 9;
                    Console.WriteLine("Debe eligir un número válido de opción");
                    Pausa();
                }
            }
            
            return opcion;
        }
        static void AvisoFin()
        {
            Console.WriteLine("Fin del programa");
        }

        static void Pausa()
        {
            Console.WriteLine();
            Console.WriteLine("Presione una tecla para continuar");
            Console.ReadKey();
        }

        static void AnyadirAlumnos(alumno[] alumnos, ref byte cantidad,
            byte PRACTICAS, byte EXAMENES)
        {
            PedirNombre(alumnos, cantidad);

            PedirDni(alumnos, cantidad);

            Console.WriteLine("Ciudad");
            alumnos[cantidad].ciudad = Console.ReadLine();

            PedirFecha(alumnos, cantidad);

            PedirNotas(alumnos, cantidad, PRACTICAS, EXAMENES);
        }
        static void PedirNombre(alumno[]alumnos, byte cantidad)
        {
            bool correcto = false;
            string nombreProvisional;

            while (!correcto)
            {
                try
                {
                    Console.Clear();
                    Console.WriteLine("Nombre y apellidos del alumno: ");
                    nombreProvisional = Console.ReadLine();
                    string[] nombrePartido = nombreProvisional.Split();
                    alumnos[cantidad].nombre = nombrePartido[0];
                    alumnos[cantidad].apellidos =
                        nombrePartido[1] + " " + nombrePartido[2];

                    correcto = true;
                }
                catch (Exception errorEncontrado)
                {
                    Console.WriteLine("Ha habido un error: {0}",
                        errorEncontrado.Message);
                }
            }
        }
        static void PedirDni(alumno[] alumnos, byte cantidad)
        {
            bool correcto = false;

            while (!correcto)
            {
                Console.WriteLine("Introduzca DNI/NIE:");
                alumnos[cantidad].dni = Console.ReadLine();

                if (alumnos[cantidad].dni.Length == 9)
                {
                    if (ComprobarDni(alumnos, cantidad) == false)
                        correcto = true;
                    else
                        Console.WriteLine("DNI ya existente");
                }
                else
                    Console.WriteLine("El DNI/NIE debe tener 9 dígitos");
            }
        }
        static bool ComprobarDni(alumno[] alumnos, byte cantidad)
        {
            bool existe = false;

            if (cantidad != 0)
            {
                for (int i = cantidad; i > 0; i--)
                {
                    for (int j = 0; j < cantidad; j++)
                    {
                        if (i != j)
                        {
                            if (alumnos[j].dni.Equals(alumnos[i].dni))
                                existe = true;
                        }
                    }
                }
            }
            return existe;
        }

        static void PedirFecha(alumno[] alumnos, byte cantidad)
        {
            bool correcto = false;
            string fechaProvisional;

            do
            {
                Console.WriteLine();
                Console.WriteLine("El día debe estar entre 1 y 30");
                Console.WriteLine("El mes debe estar entre 1 y 12");
                Console.WriteLine("El año debe estar entre 1900 y 2010");
                Console.WriteLine("Introduce fecha de nacimiento" +
                    " (dd-mm-aaaa)");
                fechaProvisional = Console.ReadLine();

                try
                {
                    string[] fechaPartida =
                        fechaProvisional.Split('-');

                    alumnos[cantidad].fechaNacimiento.dia =
                        Convert.ToByte(fechaPartida[0]);
                    alumnos[cantidad].fechaNacimiento.mes =
                        Convert.ToByte(fechaPartida[1]);
                    alumnos[cantidad].fechaNacimiento.anyo =
                        Convert.ToUInt16(fechaPartida[2]);

                    if ((alumnos[cantidad].fechaNacimiento.dia <= 31 &&
                        alumnos[cantidad].fechaNacimiento.dia > 0) &&
                        (alumnos[cantidad].fechaNacimiento.mes <= 12 &&
                        alumnos[cantidad].fechaNacimiento.mes > 0) &&
                        (alumnos[cantidad].fechaNacimiento.anyo <= 2010 &&
                        alumnos[cantidad].fechaNacimiento.anyo >= 1900))
                    {
                        correcto = true;
                    }
                    else
                    {
                        Console.WriteLine();
                        Console.WriteLine("Fecha incorrecta, introduce " +
                            "fecha válida");
                    }
                }
                catch (Exception errorEncontrado)
                {
                    Console.WriteLine("Ha habido un error {0}",
                        errorEncontrado);
                }
            }
            while (!correcto);
        }
        
        static void PedirNotas(alumno[]alumnos, byte cantidad,
            byte PRACTICAS, byte EXAMENES)
        {
            alumnos[cantidad].notasParciales.practicas = new float[PRACTICAS];
            alumnos[cantidad].notasParciales.examenes = new float[EXAMENES];

            try
            {
                for (int i = 0; i < PRACTICAS; i++)
                {
                    do
                    {
                        Console.WriteLine("Nota práctica {0}", i + 1);
                        alumnos[cantidad].notasParciales.practicas[i] =
                            Convert.ToSingle(Console.ReadLine());
                    }
                    while (!(alumnos[cantidad].notasParciales.practicas[i] >= 0 &&
                    alumnos[cantidad].notasParciales.practicas[i] <= 10));
                }

                for (int i = 0; i < EXAMENES; i++)
                {
                    do
                    {
                        Console.WriteLine("Nota exámen {0}ª evalución", i + 1);
                        alumnos[cantidad].notasParciales.examenes[i] =
                        Convert.ToSingle(Console.ReadLine());
                    }
                    while (!(alumnos[cantidad].notasParciales.examenes[i] >= 0 &&
                        alumnos[cantidad].notasParciales.examenes[i] <= 10));
                }
                CalcularNotas(alumnos, cantidad);
                cantidad++;
                Console.WriteLine("Alumno añadido correctamente");
            }
            catch (Exception errorEncontrado)
            {
                Console.WriteLine("Ha habido un error {0}", errorEncontrado);
            }
        }
        static void CalcularNotas(alumno[] alumnos, byte cantidad)
        {
            float notaEva1;
            float notaEva2;
            float notaEva3;

            notaEva1 = ((30 * (alumnos[cantidad].notasParciales.practicas[0] +
                    alumnos[cantidad].notasParciales.practicas[1]) / 100) / 2) +
                    (70 * (alumnos[cantidad].notasParciales.examenes[0]) / 100);

            notaEva2 = ((30 * (alumnos[cantidad].notasParciales.practicas[2] +
                alumnos[cantidad].notasParciales.practicas[3]) / 100) / 2) +
                (70 * (alumnos[cantidad].notasParciales.examenes[1]) / 100);

            notaEva3 = ((30 * (alumnos[cantidad].notasParciales.practicas[4] +
                alumnos[cantidad].notasParciales.practicas[5]) / 100) / 2) +
                (70 * (alumnos[cantidad].notasParciales.examenes[2]) / 100);

            alumnos[cantidad].notasParciales.notaFinal =
                (20 * (notaEva1 / 100)) + (30 * (notaEva2 / 100)) +
                (50 * (notaEva3 / 100));
        }

        static void BorrarAlumnos(alumno[] alumnos, ref byte cantidad)
        {
            byte aluBorrar = 0;

            if (alumnos.Length > 0)
            {
                MostrarAlumnos(alumnos, cantidad);
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
                if (BorrarAuxAlumnos(alumnos, ref cantidad, aluBorrar))
                    Console.WriteLine("Se ha borrado el alumno solicitado");
                else
                    Console.WriteLine("No se ha podido borrar" +
                        " el alumnos solicitado");
            }
            else
                Console.WriteLine("No existen alumnos que borrar");
        }
        static bool BorrarAuxAlumnos(alumno[] alumnos, ref byte cantidad,
            byte aluBorrar)
        {
            bool borrado;

            if (aluBorrar - 1 < cantidad)
            {
                for (int i = aluBorrar - 1; i < cantidad - 1; i++)
                {
                    alumnos[i] = alumnos[i + 1];
                }
                cantidad--;
                borrado = true;
            }
            else
                borrado = false;

            return borrado;
        }
        static void MostrarAlumnos(alumno[] alumnos, byte cantidad)
        {
            Console.Clear();
            for (int i = 0; i < cantidad; i++)
            {
                Console.WriteLine("{0}. {1} {2}. Nota final = {3}",
                    i + 1, alumnos[i].nombre, alumnos[i].apellidos,
                    alumnos[i].notasParciales.notaFinal);
            }
            Console.WriteLine();
        }

        static void OrdenarAlumno(alumno[] alumnos, byte cantidad,
            byte criterio)
        {
            alumno[] alumnosProvisional = new alumno[cantidad];

            switch (criterio)
            {
                case 1:
                    for (int i = 0; i < cantidad - 1; i++)
                    {
                        for (int j = i + 1; j < cantidad; j++)
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
                    break;

                case 2:
                    for (int i = 0; i < cantidad - 1; i++)
                    {
                        for (int j = i + 1; j < cantidad; j++)
                        {
                            if (alumnos[i].dni.CompareTo(alumnos[j].dni) > 0)
                            {
                                alumnosProvisional[i] = alumnos[i];
                                alumnos[i] = alumnos[j];
                                alumnos[j] = alumnosProvisional[i];
                            }
                        }
                    }
                    break;

                case 3: // Hay que poner el orden descendente
                    for (int i = 0; i < cantidad - 1; i++)
                    {
                        for (int j = i + 1; j < cantidad; j++)
                        {
                            if (alumnos[i].ciudad.ToUpper()
                                .CompareTo(alumnos[j].ciudad.ToUpper()) < 0)
                            {
                                alumnosProvisional[i] = alumnos[i];
                                alumnos[i] = alumnos[j];
                                alumnos[j] = alumnosProvisional[i];
                            }
                        }
                    }
                    break;
                case 4:
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
                    break;
            }
        }

        static void BuscarAlumnos(alumno[] alumnos, byte cantidad)
        {
            string busquedaApellido = "";
            string busquedaDni;
            bool encontrado = false;
            bool correcto;
            byte criterio;

            do
            {
                Console.WriteLine();
                Console.WriteLine("**Introduzca criterio de busqueda**");
                Console.WriteLine(" 1. Por apellido");
                Console.WriteLine(" 2. Por DNI");

                correcto = byte.TryParse(Console.ReadLine(), out criterio);
                if (!correcto)
                    Console.WriteLine("Debe introducir un valor válido");
            }
            while (!correcto);

            if (criterio == 2)
            {
                do
                {
                    Console.WriteLine();
                    Console.WriteLine("Introduzca DNI a  buscar");
                    busquedaDni = Console.ReadLine();

                    if (busquedaDni.Length != 9)
                        Console.WriteLine("El DNI/NIF debe tener 9 dígitos");
                    else
                        correcto = true;
                }
                while (!correcto);

                OrdenarAlumno(alumnos, cantidad, criterio);

                for (int i = 0; i < cantidad; i++)
                {
                    if(alumnos[i].dni.Equals(busquedaDni))
                    {
                        Console.WriteLine("{0}. {1} {2}. {3}. {4}", i +1,
                            alumnos[i].nombre, alumnos[i].apellidos,
                            alumnos[i].ciudad, alumnos[i].dni);
                        encontrado = true;
                    }
                }
                if (encontrado == false)
                {
                    Console.WriteLine();
                    Console.WriteLine("No se encontraron coincidencias");
                }
            }
            else
            {
                Console.WriteLine("Introduzca apellido");
                busquedaApellido = Console.ReadLine().ToUpper();

                OrdenarAlumno(alumnos, cantidad, criterio);

                for (int i = 0; i < cantidad; i++)
                {
                    if (alumnos[i].apellidos.ToUpper().Equals(busquedaApellido))
                    {
                        Console.WriteLine("{0}. {1} {2}. {3}. {4}", i + 1,
                            alumnos[i].nombre, alumnos[i].apellidos,
                            alumnos[i].ciudad, alumnos[i].dni);
                        encontrado = true;
                    }
                }
                if (encontrado == false)
                {
                    Console.WriteLine();
                    Console.WriteLine("No se encontraron coincidencias");
                }
            }
        }

        //no sé cómo se emplea
        static int BusquedaRecursiva(alumno[] alumnos, int cantidad,
            string textoBuscar)
        {
            if (cantidad == 0)
                return -1;
            else if (alumnos[cantidad].apellidos.Equals(textoBuscar) ||
                alumnos[cantidad].dni.Equals(textoBuscar))
                return cantidad;
            else
                return BusquedaRecursiva(alumnos, cantidad - 1, textoBuscar);
        }

        static void CalcularPorcentajes(alumno[] alumnos, byte cantidad,
            byte PRACTICAS, byte EXAMENES)
        {
            byte contadorAprobados = 0;
            float porcentaje;

            for (int i = 0; i < PRACTICAS; i++)
            {
                contadorAprobados = 0;

                for (int j = 0; j < cantidad; j++)
                {
                    if (alumnos[j].notasParciales.practicas[i] >= 5)
                        contadorAprobados++;
                }
                porcentaje = (contadorAprobados * 100) / cantidad;
                Console.WriteLine("El porcentaje de aprobados de la" +
                    " práctica {0} es del {1}%, de {2} alumnos", i + 1,
                    porcentaje, cantidad);
            }
            
            for (int i = 0; i < EXAMENES; i++)
            {
                contadorAprobados = 0;

                for (int j = 0; j < cantidad; j++)
                {
                    if (alumnos[j].notasParciales.examenes[i] >= 5)
                        contadorAprobados++;
                }
                porcentaje = (contadorAprobados * 100) / cantidad;
                Console.WriteLine("El porcentaje de aprobados del exámen" +
                   "de la {0}ª evaluación es del {1}%, de {2} alumnos", i + 1,
                   porcentaje, cantidad);
            }
        }

        static void MostrarGrafica(alumno[] alumnos, float cantidad)
        {
            string[,] porcentajeNotaFinal = new string[20,2];
            float contadorAprobados = 0;
            float auxiliarNumeroAsteriscos = 0.2f;
            byte resultadoAprobados;
            byte numeroAsteriscosAprobados;
            byte numeroAsteriscosSuspensos;

            for (int i = 0; i < cantidad; i++)
            {
                if (alumnos[i].notasParciales.notaFinal >= 5)
                    contadorAprobados++;
            }
            resultadoAprobados = Convert.ToByte((contadorAprobados / cantidad) * 100);
            numeroAsteriscosAprobados = 
                Convert.ToByte(resultadoAprobados * auxiliarNumeroAsteriscos);
            numeroAsteriscosSuspensos = 
                Convert.ToByte(20 - numeroAsteriscosAprobados);

            for (int i = 0; i < numeroAsteriscosAprobados; i++)
            {
                porcentajeNotaFinal[i, 0] = "*";
            }
            for (int i = 0; i < numeroAsteriscosSuspensos; i++)
            {
                porcentajeNotaFinal[i, 1] = "*";
            }
            PintarGrafica();
            
            for (int i = 15; numeroAsteriscosAprobados > 0; i--)
            {
                Console.SetCursorPosition(7, i);
                Console.Write(porcentajeNotaFinal[numeroAsteriscosAprobados -1, 0]);
                numeroAsteriscosAprobados--;
            }
            for (int i = 15; numeroAsteriscosSuspensos > 0; i--)
            {
                Console.SetCursorPosition(15 , i);
                Console.Write(porcentajeNotaFinal[numeroAsteriscosSuspensos -1, 1]);
                numeroAsteriscosSuspensos--;
            }
        }       
        static void PintarGrafica()
        {
            byte porcentajeGrafica = 70;
            Console.Clear();

            for (int i = 2; i < 19; i++)
            {
                if (i == 2)
                {
                    Console.SetCursorPosition(0, i);
                    Console.Write("%");
                }
                else if (i > 2 && i < 16)
                {
                    Console.SetCursorPosition(0, i);
                    Console.Write((porcentajeGrafica) + "|");
                    porcentajeGrafica -= 5;
                }
                else if (i == 16)
                {
                    Console.SetCursorPosition(0, i);
                    Console.Write((porcentajeGrafica) + " |");
                }
                else if (i == 17)
                {
                    Console.SetCursorPosition(3, i - 1);
                    Console.Write("_ _ _ _ _ _ _ _ _");
                }
                else
                {
                    Console.SetCursorPosition(5, i - 1);
                    Console.WriteLine("APTO    SUSP");
                }
            }
        }
        static void Main()
        {
            const byte MAXIMO = 200;
            const int PRACTICAS = 6;
            const int EXAMENES = 3;
            alumno[] alumnos = new alumno[MAXIMO];
            alumno[] alumnosProvisional = new alumno[MAXIMO];
            byte opcion = 9;
            byte cantidad = 0;
            
            do
            {
                opcion = Opciones();
                Pausa();

                switch (opcion)
                {
                    case 0:
                        AvisoFin(); break;

                    case 1:
                        if(cantidad < MAXIMO)
                            AnyadirAlumnos(alumnos, ref cantidad, PRACTICAS,
                                EXAMENES);
                        else
                            Console.WriteLine("No quedan espacios disponibles" +
                                "({0} máximo)", MAXIMO);
                        Pausa();
                        break;

                    case 2:
                        BorrarAlumnos(alumnos, ref cantidad);
                        Pausa();
                        break;

                    case 3:
                        BuscarAlumnos(alumnos, cantidad);
                        Pausa();
                        break;

                    case 4:
                        OrdenarAlumno(alumnos, cantidad, 3);
                        MostrarAlumnos(alumnos, cantidad);
                        Pausa();
                        break;

                    case 5:
                        OrdenarAlumno(alumnos, cantidad, 1);
                        MostrarAlumnos(alumnos, cantidad);
                        Pausa();
                        
                        break;

                    case 6:
                        OrdenarAlumno(alumnos, cantidad, 4);
                        MostrarAlumnos(alumnos, cantidad);
                        Pausa();
                        break;

                    case 7:
                        CalcularPorcentajes(alumnos, cantidad, PRACTICAS,
                            EXAMENES);
                        Pausa();
                        break;

                    case 8:
                        MostrarGrafica(alumnos, cantidad);
                        Console.SetCursorPosition(1, 21);
                        Pausa();
                        break;

                    default:
                        Console.WriteLine("Opción desconocida");
                        Pausa();
                        break;
                }
                Console.WriteLine();
            }
            while (opcion != 0);

        }
    }
}
