using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionMantenimiento.GestionPreventivos
{
    /// <summary>
    /// Clase para guardar un cargar datos de preventivos
    /// </summary>
    class GestionFicherosPreventivos
    {
        /// <summary>
        /// Carga los preventivos desde un fichero.
        /// </summary>
        /// <param name="preventivos">Una lista de preventivos</param>
        /// <returns>Una lista de preventivos</returns>
        public static List<Preventivo> CargarPreventivos(List<Preventivo> preventivos)
        {
            string[] provisional = new string[2];
        
            if (!File.Exists("preventivos.txt"))
            {
                return preventivos;
            }

            try
            {
                StreamReader ficheroTecnicos = new StreamReader("preventivos.txt");
                int cantidad = File.ReadLines(@"preventivos.txt").Count();
                for (int i = 0; i < cantidad; i++)
                {
                    provisional = ficheroTecnicos.ReadLine().Split(';');
                    Preventivo p = new Preventivo(
                            provisional[0], provisional[1],
                            provisional[2]
                        );
                    
                    preventivos.Add(p);
                }
                ficheroTecnicos.Close();
            }
            catch (IOException)
            {
                MessageBox.Show("Error de lectura");
            }
            catch (Exception e)
            {
                MessageBox.Show("Error: " + e);
            }
            return preventivos;
        }
        /// <summary>
        /// Guarda preventivos cerrados individualmente sin sobreescribir.
        /// </summary>
        /// <param name="preventivo"></param>
        public static void GuardarPreventivo(Preventivo preventivo)
        {
            try
            {
                StreamWriter fichero = File.AppendText("preventivos.txt");
                fichero.WriteLine(preventivo);
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
