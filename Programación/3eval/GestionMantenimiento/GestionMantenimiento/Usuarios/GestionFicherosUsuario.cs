using GestionMantenimiento.Tecnicos;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace GestionMantenimiento
{
    /// <summary>
    /// Clase para guardar y cargar datos del fichero usuarios
    /// </summary>
    class GestionFicherosUsuario
    {
        /// <summary>
        /// Método para cargar los datos de los usuarios del sistema
        /// </summary>
        /// <param name="usuarios">Lista de usuarios</param>
        /// <returns>Lista de usuarios</returns>
        public static List<Usuario> CargarUsuarios(List<Usuario> usuarios)
        {
            string[] provisional = new string[1];
            string linea;
            if (!File.Exists("usuarios.txt"))
            {
                return usuarios;
            }

            try
            {
                StreamReader ficheroUsuarios = new StreamReader("usuarios.txt");
                do
                {
                    linea = ficheroUsuarios.ReadLine();
                    if (linea != null)
                    {
                        provisional = linea.Split(';');
                        Usuario u = new Usuario();
                        u.Nombre = provisional[0];
                        u.Contraseña = provisional[1];
                        usuarios.Add(u);
                    }
                } while (linea != null);
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
        /// <summary>
        /// Método para guardar los datos de los usuarios en el fichero
        /// </summary>
        /// <param name="usuarios">Lista de usuarios</param>
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
