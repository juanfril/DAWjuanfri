using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionMantenimiento.Tecnicos
{
    /// <summary>
    /// Clase que representa los técnicos
    /// </summary>
    class Tecnico
    {
        /// <value>
        /// Propiedad Nombre corresponde al nombre del técnico
        /// </value>
        public string Nombre { get; set; }
        /// <value>
        /// Propiedad Oficio corresponde al oficio del técnico
        /// </value>
        public string Oficio { get; set; }
        /// <value>
        /// Propiedad Antiguedad corresponde a la antiguedad del técnico
        /// en la empresa
        /// </value>
        public DateTime Antiguedad { get; set; }
        /// <summary>
        /// Método ToString de Técnico
        /// </summary>
        /// <returns>Una cadena con las propiedad de técnico separada por ;</returns>
        public override string ToString()
        {
            return Nombre + ";" + Oficio + ";" + Antiguedad.ToString("d");
        }
    }
}
