using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionMantenimiento.ElementosInstalacion
{
    /// <summary>
    /// Clase para guardar y cargar los datos de los diferentes elementos desde un fichero
    /// </summary>
    class GestionFicherosElementos
    {
        /// <summary>
        /// Método para cargar datos sobre una lista
        /// </summary>
        /// <param name="climas">Lista donde cargar los datos</param>
        /// <returns>Lista con los datos cargados</returns>
        public static List<Climatizacion> CargarClima(List<Climatizacion> climas)
        {
            string[] provisional = new string[3];
            string linea;
            if (!File.Exists("climas.txt"))
            {
                return climas;
            }

            try
            {
                StreamReader ficheroMaquinas = new StreamReader("climas.txt");
                do
                {
                    linea = ficheroMaquinas.ReadLine();
                    if (linea != null)
                    {
                        provisional = linea.Split(';');
                        Climatizacion c = new Climatizacion(
                                        provisional[0], provisional[1],
                                        provisional[2], provisional[3]
                                    );
                        climas.Add(c);

                    }
                } while (linea != null);
                ficheroMaquinas.Close();
            }
            catch (IOException)
            {
                MessageBox.Show("Error de lectura");
            }
            catch (Exception e)
            {
                MessageBox.Show("Error: " + e);
            }
            return climas;
        }
        /// <summary>
        /// Guarda una lista en el fichero preventivos
        /// </summary>
        /// <param name="fontas">Lista a guardar en el fichero</param>
        public static void GuardarClima(List<Climatizacion> climas)
        {
            try
            {
                StreamWriter fichero = new StreamWriter("climas.txt");
                for (int i = 0; i < climas.Count; i++)
                {
                    fichero.WriteLine(climas[i]);
                }
                fichero.Close();
            }
            catch (IOException)
            {
                Console.WriteLine("Error de escritura");
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
            }
        }
        /// <summary>
        /// Método para cargar datos sobre una lista
        /// </summary>
        /// <param name="climas">Lista donde cargar los datos</param>
        /// <returns>Lista con los datos cargados</returns>
        public static List<Electricidad> CargarElectricidad(List<Electricidad> electricos)
        {
            string[] provisional = new string[3];
            string linea;
            if (!File.Exists("electricidad.txt"))
            {
                return electricos;
            }

            try
            {
                StreamReader ficheroMaquinas = new StreamReader("electricidad.txt");
                do
                {
                    linea = ficheroMaquinas.ReadLine();
                    if (linea != null)
                    {
                        provisional = linea.Split(';');
                        Electricidad e = new Electricidad(
                                        provisional[0], provisional[1],
                                        provisional[2], provisional[3]
                                    );
                        electricos.Add(e);
                    }
                } while (linea != null);
                ficheroMaquinas.Close();
            }
            catch (IOException)
            {
                MessageBox.Show("Error de lectura");
            }
            catch (Exception e)
            {
                MessageBox.Show("Error: " + e);
            }
            return electricos;
        }
        /// <summary>
        /// Guarda una lista en el fichero preventivos
        /// </summary>
        /// <param name="fontas">Lista a guardar en el fichero</param>
        public static void GuardarElectricidad(List<Electricidad> electricos)
        {
            try
            {
                StreamWriter fichero = new StreamWriter("electricidad.txt");
                for (int i = 0; i < electricos.Count; i++)
                {
                    fichero.WriteLine(electricos[i]);
                }
                fichero.Close();
            }
            catch (IOException)
            {
                Console.WriteLine("Error de escritura");
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
            }
        }
        /// <summary>
        /// Método para cargar datos sobre una lista
        /// </summary>
        /// <param name="climas">Lista donde cargar los datos</param>
        /// <returns>Lista con los datos cargados</returns>
        public static List<Fontaneria> CargarFontaneria(List<Fontaneria> fontas)
        {
            string[] provisional = new string[3];
            string linea;
            if (!File.Exists("fontaneria.txt"))
            {
                return fontas;
            }

            try
            {
                StreamReader ficheroMaquinas = new StreamReader("fontaneria.txt");
                do
                {
                    linea = ficheroMaquinas.ReadLine();
                    if (linea != null)
                    {
                        provisional = linea.Split(';');
                        Fontaneria f = new Fontaneria(
                                        provisional[0], provisional[1],
                                        provisional[2], provisional[3]
                                    );
                        fontas.Add(f);
                    }
                } while (linea != null);
                ficheroMaquinas.Close();
            }
            catch (IOException)
            {
                MessageBox.Show("Error de lectura");
            }
            catch (Exception e)
            {
                MessageBox.Show("Error: " + e);
            }
            return fontas;
        }
        /// <summary>
        /// Guarda una lista en el fichero preventivos
        /// </summary>
        /// <param name="fontas">Lista a guardar en el fichero</param>
        public static void GuardarFontaneria(List<Fontaneria> fontas)
        {
            try
            {
                StreamWriter fichero = new StreamWriter("fontaneria.txt");
                for (int i = 0; i < fontas.Count; i++)
                {
                    fichero.WriteLine(fontas[i]);
                }
                fichero.Close();
            }
            catch (IOException)
            {
                Console.WriteLine("Error de escritura");
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
            }
        }
    }
}
