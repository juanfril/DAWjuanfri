using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionMantenimiento
{
    class GestionFicheros
    {
        public static List<Usuario> CargarUsuarios(List<Usuario> usuarios)
        {
            string[] provisional = new string[1];
            if (!File.Exists("usuarios.txt"))
            {
                return usuarios;
            }

            try
            {
                StreamReader ficheroUsuarios = new StreamReader("usuarios.txt");
                int cantidad = File.ReadLines(@"usuarios.txt").Count();
                for (int i = 0; i < cantidad; i++)
                {
                    provisional = ficheroUsuarios.ReadLine().Split(';');
                    Usuario u = new Usuario();
                    u.Nombre = provisional[0];
                    u.Contraseña = provisional[1];
                    usuarios.Add(u);
                }
                ficheroUsuarios.Close();
            }
            catch (IOException)
            {
                MessageBox.Show("Error de lectura");
            }
            catch (Exception e)
            {
                MessageBox.Show("Error: " + e);
            }
            return usuarios;
        }
        public static void GuardarUsuarios(List<Usuario> usuarios)
        {
            try
            {
                StreamWriter fichero = new StreamWriter("usuarios.txt");
                for (int i = 0; i < usuarios.Count; i++)
                {
                    fichero.WriteLine(usuarios[i]);
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
