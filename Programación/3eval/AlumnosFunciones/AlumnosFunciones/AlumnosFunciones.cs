/*
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
using System.Collections.Generic;

namespace AlumnosFunciones
{
    class AlumnosFunciones
    {
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

        static void AnyadirAlumnos(List<Alumno> alumnos)
        {
            Alumno alumno = new Alumno();

            PedirNombre(alumno);

            PedirDni(alumnos, alumno);

            Console.WriteLine("Ciudad");
            alumno.Ciudad = Console.ReadLine();

            PedirFecha(alumno);

            PedirNotas(alumno);

            alumnos.Add(alumno);

            GestionFichero.GuardarAlumnos(alumnos);
        }
        static void PedirNombre(Alumno alumno)
        {
            bool correcto = false;

            while (!correcto)
            {
                try
                {
                    Console.Clear();
                    Console.WriteLine("Nombre y apellidos del alumno: ");
                    alumno.NombreApellido = Console.ReadLine();
                    correcto = true;
                }
                catch (Exception errorEncontrado)
                {
                    Console.WriteLine("Ha habido un error: {0}",
                        errorEncontrado.Message);
                }
            }
        }
        static void PedirDni(List<Alumno> alumnos, Alumno alumno)
        {
            bool correcto = false;

            while (!correcto)
            {
                Console.WriteLine("Introduzca DNI/NIE:");
                alumno.Dni = Console.ReadLine();

                if (alumno.Dni.Length == 9)
                {
                    if (!ComprobarDni(alumnos, alumno))
                        correcto = true;
                    else
                        Console.WriteLine("DNI ya existente");
                }
                else
                    Console.WriteLine("El DNI/NIE debe tener 9 dígitos");
            }
        }
        static bool ComprobarDni(List<Alumno> alumnos, Alumno alumno)
        {
            bool existe = false;

            if (alumnos.Count != 0)
            {
                foreach (Alumno al in alumnos)
                {
                    if (al.Dni.Equals(alumno.Dni))
                        existe = true;
                }
            }
            return existe;
        }

        static void PedirFecha(Alumno alumno)
        {
            bool correcto = false;
            do
            {
                Console.WriteLine();
                Console.WriteLine("El día debe estar entre 1 y 30");
                Console.WriteLine("El mes debe estar entre 1 y 12");
                Console.WriteLine("El año debe estar entre 1900 y 2010");
                Console.WriteLine("Introduce fecha de nacimiento" +
                    " (dd/mm/aaaa)");

                try
                {
                    alumno.FechaNacimiento = Convert.ToDateTime(Console.ReadLine());
                    correcto = true;
                }
                catch (Exception errorEncontrado)
                {
                    Console.WriteLine("Ha habido un error {0}",
                        errorEncontrado);
                    Console.WriteLine();
                    Console.WriteLine("Fecha incorrecta, introduce " +
                        "fecha válida");
                }
            }
            while (!correcto);
        }
        
        static void PedirNotas(Alumno alumno)
        {
            float[] practicas = new float[5];
            float[] examenes = new float[2];

            try
            {
                for (int i = 0; i < 6; i++)
                {
                    do
                    {
                        Console.WriteLine("Nota práctica {0}", i + 1);
                        practicas[i] = Convert.ToSingle(Console.ReadLine());
                    }
                    while (practicas[i] <= 0 && practicas[i] >= 10);
                }

                for (int i = 0; i < 3; i++)
                {
                    do
                    {
                        Console.WriteLine("Nota exámen {0}ª evalución", i + 1);
                        examenes[i] = Convert.ToSingle(Console.ReadLine());
                    }
                    while (examenes[i] >= 0 && examenes[i] <= 10);
                }
                alumno.CalcularNotas();
                Console.WriteLine("Alumno añadido correctamente");
            }
            catch (Exception errorEncontrado)
            {
                Console.WriteLine("Ha habido un error {0}", errorEncontrado);
            }
            alumno.SetParcial1(practicas[0]);
            alumno.SetParcial2(practicas[1]);
            alumno.SetParcial3(practicas[2]);
            alumno.SetParcial4(practicas[3]);
            alumno.SetParcial5(practicas[4]);
            alumno.SetParcial6(practicas[5]);
            alumno.SetExamen1(examenes[0]);
            alumno.SetExamen2(examenes[1]);
            alumno.SetExamen3(examenes[2]);
            alumno.CalcularNotas();
        }

        static void BorrarAlumnos(List<Alumno> alumnos)
        {
            byte aluBorrar = 0;

            if (alumnos.Count > 0)
            {
                MostrarAlumnos(alumnos);
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
                if (BorrarAuxAlumnos(alumnos, aluBorrar))
                    Console.WriteLine("Se ha borrado el alumno solicitado");
                else
                    Console.WriteLine("No se ha podido borrar" +
                        " el alumnos solicitado");
            }
            else
                Console.WriteLine("No existen alumnos que borrar");
        }
        static bool BorrarAuxAlumnos(List<Alumno> alumnos, byte aluBorrar)
        {
            bool borrado;

            if (aluBorrar - 1 < alumnos.Count)
            {
                alumnos.RemoveAt(aluBorrar - 1);
                borrado = true;
                GestionFichero.GuardarAlumnos(alumnos);
            }
            else
                borrado = false;

            return borrado;
        }
        static void MostrarAlumnos(List<Alumno> alumnos)
        {
            Console.Clear();
            for (int i = 0; i < alumnos.Count; i++)
            {
                Console.WriteLine("{0}. {1}. Nota final = {2}",
                    i + 1, alumnos[i].NombreApellido, alumnos[i].GetNotaFinal());
            }
            Console.WriteLine();
        }

        /*static void OrdenarAlumno(List<Alumno> alumnos, byte criterio)
        {
            List<Alumno> alumnosProvisional = new List<Alumno>();

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
        }*/

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
            List<Alumno> alumnos = new List<Alumno>();
            alumnos = GestionFichero.CargarAlumnos(alumnos);
            byte opcion = 9;
            
            do
            {
                opcion = Opciones();
                Pausa();

                switch (opcion)
                {
                    case 0:
                        AvisoFin(); break;

                    case 1:
                        AnyadirAlumnos(alumnos);
                        Pausa();
                        break;

                    case 2:
                        BorrarAlumnos(alumnos);
                        Pausa();
                        break;

                    case 3:
                        BuscarAlumnos(alumnos);
                        Pausa();
                        break;

                    case 4:
                        OrdenarAlumno(alumnos);
                        MostrarAlumnos(alumnos);
                        Pausa();
                        break;

                    case 5:
                        OrdenarAlumno(alumnos);
                        MostrarAlumnos(alumnos);
                        Pausa();
                        
                        break;

                    case 6:
                        OrdenarAlumno(alumnos);
                        MostrarAlumnos(alumnos);
                        Pausa();
                        break;

                    case 7:
                        CalcularPorcentajes(alumnos);
                        Pausa();
                        break;

                    case 8:
                        MostrarGrafica(alumnos);
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
