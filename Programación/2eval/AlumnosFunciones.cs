using System;

namespace AlumnosFunciones
{
    class AlumnosFunciones
    {
        struct alumno
        {
            public string nombre;
            public string apellidos;
            public int dni;
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
                Console.WriteLine(" 8. Mostrar gráfica");
                Console.WriteLine(" 0. Salir del programa");
            }
            catch (Exception errorEncontrado)
            {
                Console.WriteLine("Ha habido un error: {0}",
                    errorEncontrado.Message);
            }
            return Convert.ToByte(Console.ReadLine());
        }
        static void AvisoFin()
        {
            Console.WriteLine("Fin del programa");
        }

        static void AnyadirAlumnos(alumno[] alumnos, ref byte cantidad)
        {
            const byte MAXIMO = 200;
            const int PRACTICAS = 6;
            const int EXAMENES = 3;
            string nombreProvisional;
            string fechaProvisional;
            bool correcto = false;

            if (cantidad < MAXIMO)
            {
                correcto = false;

                while (!correcto)
                {
                    try
                    {
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

                correcto = false;

                while (!correcto)
                {                    
                    Console.WriteLine("Introduzca DNI sin letra");
                    if(int.TryParse(Console.ReadLine(), out alumnos[cantidad].dni))
                    {
                        if(alumnos[cantidad].dni < 100000000 && alumnos[cantidad].dni > 9999999)
                        {
                            if(!ComprobarDni(alumnos, cantidad))
                                correcto = true;
                            else
                                Console.WriteLine("DNI ya existente");
                        }
                    }
                    
                    else
                        Console.WriteLine("Debe ser un número de DNI válido");
                    
                }

                Console.WriteLine("Ciudad");
                alumnos[cantidad].ciudad = Console.ReadLine();

                correcto = false;

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
                            Console.WriteLine("Fecha incorrecta, introduce fecha válida");
                        }
                    }
                    catch (Exception errorEncontrado)
                    {
                        Console.WriteLine("Ha habido un error {0}",
                            errorEncontrado);
                    }
                }
                while (!correcto);

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
                    cantidad++;
                }
                catch(Exception errorEncontrado)
                {
                    Console.WriteLine("Ha habido un error {0}", errorEncontrado);
                }
            }
            else
            {
                Console.WriteLine("No quedan espacios disponibles" +
                    "({0} máximo)", MAXIMO);
            }
        }
        static bool ComprobarDni(alumno[] alumnos, byte cantidad)
        {
            bool existe = false;

            if (cantidad == 0)
                return false;
            else
            {
                for (int i = cantidad; i > 0; i--)
                {
                    for (int j = 0; j < cantidad - 1; j++)
                    {
                        if (alumnos[j].dni == alumnos[i].dni)
                            existe = true;
                        else
                            existe = false;
                    }
                }
                if (existe)
                    return true;
                else
                    return false;
            }
        }

        static void CalcularFinales(alumno[] alumnos, byte cantidad)
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

            for (int i = 0; i < cantidad; i++)
            {
                Console.WriteLine("{0}. {1} {2}", i + 1, alumnos[i].nombre,
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
            if (BorrarAuxAlumnos(alumnos, ref cantidad, aluBorrar))
                Console.WriteLine("Se ha borrado el alumno solicitado");
            else
                Console.WriteLine("No se ha podido borrar el alumnos solicitado");
        }

        static bool BorrarAuxAlumnos(alumno[] alumnos, ref byte cantidad, byte aluBorrar)
        {
            if (aluBorrar < cantidad)
            {
                for (int i = aluBorrar - 1; i < cantidad - 1; i++)
                {
                    alumnos[i] = alumnos[i + 1];
                }
                cantidad--;
                return true;
            }
            else
            {
                Console.WriteLine("Número de alumno incorrecto");
                return false;
            }
        }

        static void Main()
        {
            const byte MAXIMO = 200;

            alumno[] alumnos = new alumno[MAXIMO];
            alumno[] alumnosProvisional = new alumno[MAXIMO];
            byte opcion = 9;
            byte cantidad = 0;          //Es la variable que controla los datos
            bool encontradoCuidad;
            bool encontradoAnyo;
            byte contadorAprobados = 0;
            float porcentaje;
            ushort anyoBus = 0;
            string busquedaCiudad = "";

            do
            {
                //Opciones();
                opcion = Opciones();

                switch (opcion)
                {
                    case 0:
                        AvisoFin(); break;

                    case 1:
                        AnyadirAlumnos(alumnos, ref cantidad); break;

                    case 2:
                        BorrarAlumnos(alumnos, ref cantidad); break;

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
                        if (encontradoCuidad == false)
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
                            if (alumnos[i].notasParciales.practicas[0] >= 5)
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
                            if (alumnos[i].notasParciales.practicas[1] >= 5)
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
                            if (alumnos[i].notasParciales.practicas[2] >= 5)
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
                            if (alumnos[i].notasParciales.practicas[3] >= 5)
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
                            if (alumnos[i].notasParciales.practicas[4] >= 5)
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
                            if (alumnos[i].notasParciales.practicas[5] >= 5)
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
                            if (alumnos[i].notasParciales.examenes[0] >= 5)
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
                            if (alumnos[i].notasParciales.examenes[1] >= 5)
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
                            if (alumnos[i].notasParciales.examenes[2] >= 5)
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
