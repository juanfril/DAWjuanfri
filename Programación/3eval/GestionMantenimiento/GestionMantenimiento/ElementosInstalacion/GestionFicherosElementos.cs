using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionMantenimiento.ElementosInstalacion
{
    class GestionFicherosElementos
    {
        public static List<Climatizacion> CargarClima(List<Climatizacion> climas)
        {
            string[] provisional = new string[3];
            if (!File.Exists("climas.txt"))
            {
                return climas;
            }

            try
            {
                StreamReader ficheroMaquinas = new StreamReader("climas.txt");
                int cantidad = File.ReadLines(@"climas.txt").Count();
                for (int i = 0; i < cantidad; i++)
                {
                    provisional = ficheroMaquinas.ReadLine().Split(';');
                    Climatizacion c = new Climatizacion(
                                    provisional[0], provisional[1],
                                    provisional[2], provisional[3]
                                );
                    climas.Add(c);
                }
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
        public static List<Electricidad> CargarElectricidad(List<Electricidad> electricos)
        {
            string[] provisional = new string[3];
            if (!File.Exists("electricidad.txt"))
            {
                return electricos;
            }

            try
            {
                StreamReader ficheroMaquinas = new StreamReader("electricidad.txt");
                int cantidad = File.ReadLines(@"electricidad.txt").Count();
                for (int i = 0; i < cantidad; i++)
                {
                    provisional = ficheroMaquinas.ReadLine().Split(';');
                    Electricidad e = new Electricidad(
                                    provisional[0], provisional[1],
                                    provisional[2], provisional[3]
                                );
                    electricos.Add(e);
                }
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
        public static List<Fontaneria> CargarFontaneria(List<Fontaneria> fontas)
        {
            string[] provisional = new string[3];
            if (!File.Exists("fontaneria.txt"))
            {
                return fontas;
            }

            try
            {
                StreamReader ficheroMaquinas = new StreamReader("fontaneria.txt");
                int cantidad = File.ReadLines(@"fontaneria.txt").Count();
                for (int i = 0; i < cantidad; i++)
                {
                    provisional = ficheroMaquinas.ReadLine().Split(';');
                    Fontaneria f = new Fontaneria(
                                    provisional[0], provisional[1],
                                    provisional[2], provisional[3]
                                );
                    fontas.Add(f);
                }
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
