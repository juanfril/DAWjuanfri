using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace AlumnosFunciones
{
    class GestionFichero
    {
        public static List<Alumno> CargarAlumnos(List<Alumno> alumnos)
        {
            string linea;
            List<string> provisional;
            if (!File.Exists("alumnos.txt"))
            {
                return alumnos;
            }

            try
            {
                StreamReader fichero = new StreamReader("alumnos.txt");
                do
                {
                    linea = fichero.ReadLine();
                    if(linea != null)
                    {
                        provisional = new List<string>(linea.Split(';'));
                        Alumno a = new Alumno(provisional[0], provisional[1],provisional[2], Convert.ToDateTime(provisional[3]),
                            Convert.ToSingle(provisional[4]), Convert.ToSingle(provisional[5]), Convert.ToSingle(provisional[6]),
                            Convert.ToSingle(provisional[7]), Convert.ToSingle(provisional[8]), Convert.ToSingle(provisional[9]),
                            Convert.ToSingle(provisional[10]), Convert.ToSingle(provisional[11]), Convert.ToSingle(provisional[12]),
                            Convert.ToSingle(provisional[13]));
                        alumnos.Add(a);
                    }
                } while (linea != null);
                fichero.Close();
            }
            catch (IOException)
            {
                Console.WriteLine("Error de lectura");
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
            }
            return alumnos;
        }
        public static void GuardarAlumnos(List<Alumno> alumnos)
        {
            try
            {
                StreamWriter fichero = new StreamWriter("alumnos.txt");
                foreach (Alumno alumno in alumnos)
                {
                    fichero.WriteLine(alumno);
                }
                fichero.Close();
            }
            catch (IOException)
            {
                Console.WriteLine("Error de lectura");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
    }
}
