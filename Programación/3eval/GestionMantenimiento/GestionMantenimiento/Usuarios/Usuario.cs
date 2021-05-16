using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionMantenimiento
{
    /// <summary>
    /// Clase que representa los usuarios
    /// </summary>
    class Usuario
    {
        /// <value>
        /// Propiedad Nombre corresponde al nombre de usuario
        /// </value>
        public string Nombre { get; set; }
        /// <value>
        /// Propiedad Contraseña corresponde a la contraseña de usuario
        /// </value>
        public string Contraseña { get; set; }
        /// <summary>
        /// Método ToString del objeto usuario
        /// </summary>
        /// <returns>Una cadena con el nombre y la contraseña separada por ;</returns>
        public override string ToString()
        {
            return Nombre + ";" + Contraseña;
        }
    }
}
