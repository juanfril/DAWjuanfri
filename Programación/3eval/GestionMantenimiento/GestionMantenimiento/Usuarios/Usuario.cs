using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionMantenimiento
{
    class Usuario
    {
        //private string nombre;
        //private string contraseña;

        public string Nombre { get; set; }
        public string Contraseña { get; set; }

        public override string ToString()
        {
            return Nombre + ";" + Contraseña;
        }
    }
}
