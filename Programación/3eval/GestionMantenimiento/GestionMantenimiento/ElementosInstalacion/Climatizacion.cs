using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionMantenimiento
{
    /// <summary>
    /// Clase hija de MaquinaGeneral
    /// </summary>
    class Climatizacion : MaquinaGeneral
    {
        /// <value>
        /// Representa el tipo de refrigerante que usa la máquina
        /// </value>
        public string TipoRefrigerante { get; set; }
        /// <summary>
        /// Constructor hijo de MaquinaGeneral
        /// </summary>
        /// <param name="nombre">Nombre</param>
        /// <param name="ubicacion">Ubicación</param>
        /// <param name="tipoInstalacion">Tipo de instalación</param>
        /// <param name="tipoRefrigerante">Tipo de refrigerante</param>
        public Climatizacion(string nombre, string ubicacion,
            string tipoInstalacion, string tipoRefrigerante)
            : base(nombre, ubicacion, tipoInstalacion)
        {
            TipoRefrigerante = tipoRefrigerante;
        }
        /// <summary>
        /// Método ToString hijo de MaquinaGeneral
        /// </summary>
        /// <returns>Cadena propiedades separada por ;</returns>
        public override string ToString()
        {
            return base.ToString() + ";" + TipoRefrigerante;
        }
    }
}
