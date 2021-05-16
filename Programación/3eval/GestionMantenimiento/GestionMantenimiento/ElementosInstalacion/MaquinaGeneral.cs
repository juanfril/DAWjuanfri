using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GestionMantenimiento
{
    /// <summary>
    /// Super clase de los elementos de la instalación
    /// </summary>
    class MaquinaGeneral
    {
        //Creí que necesitaría un id; pero al final no lo usé
        //public static int contador;
        //public int Identificador { get; private set; }
        /// <value>
        /// Representa el nombre del elemento
        /// </value>
        public string Nombre { get; set; }
        /// <value>
        /// Representa la ubicación del elemento
        /// </value>
        public string Ubicacion { get; set; }
        /// <value>
        /// Representa el tipo de instalación del elemento.
        /// </value>
        public string TipoInstalacion { get; set; }
        /// <summary>
        /// Constructor padre del objeto
        /// </summary>
        /// <param name="nombre">Nombre del elemento</param>
        /// <param name="ubicacion">Ubicación del elemento</param>
        /// <param name="tipoInstalacion">Tipo de instalación del elemento</param>
        public MaquinaGeneral(string nombre, string ubicacion,
            string tipoInstalacion)
        {
            //Identificador = Interlocked.Increment(ref contador);
            Nombre = nombre;
            Ubicacion = ubicacion;
            TipoInstalacion = tipoInstalacion;
        }
        /// <summary>
        /// Método ToString padre del elemento
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return Nombre + ";" + Ubicacion + ";" + TipoInstalacion;
        }
    }
}
