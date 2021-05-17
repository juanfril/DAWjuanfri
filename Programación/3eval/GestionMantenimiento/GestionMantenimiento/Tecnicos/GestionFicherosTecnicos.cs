using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionMantenimiento.Tecnicos
{
    struct provisionalTecnico
    {
        public string nombre;
        public string oficio;
        public DateTime antiguedad;
    }
    class GestionFicherosTecnicos
    {
        public static List<Tecnico> CargarTecnicos(List<Tecnico> tecnicos)
        {
            string[] provisional = new string[2];
            string linea;
            provisionalTecnico tecnicoProvisional = new provisionalTecnico();
        
            if (!File.Exists("tecnicos.txt"))
            {
                return tecnicos;
            }

            try
            {
                StreamReader ficheroTecnicos = new StreamReader("tecnicos.txt");
                do
                {
                    linea = ficheroTecnicos.ReadLine();
                    if (linea != null)
                    {
                        provisional = linea.Split(';');
                        tecnicoProvisional.nombre = provisional[0];
                        tecnicoProvisional.oficio = provisional[1];
                        tecnicoProvisional.antiguedad = Convert.ToDateTime(provisional[2]);
                        Tecnico t = new Tecnico
                        {
                            Nombre = tecnicoProvisional.nombre,
                            Oficio = tecnicoProvisional.oficio,
                            Antiguedad = tecnicoProvisional.antiguedad
                        };
                        tecnicos.Add(t);
                    }
                } while (linea != null);
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
            return tecnicos;
        }
        public static void GuardarTecnicos(List<Tecnico> tecnicos)
        {
            try
            {
                StreamWriter fichero = new StreamWriter("tecnicos.txt");
                for (int i = 0; i < tecnicos.Count; i++)
                {
                    fichero.WriteLine(tecnicos[i]);
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
