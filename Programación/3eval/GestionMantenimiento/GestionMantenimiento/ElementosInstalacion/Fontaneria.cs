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
    class Fontaneria : MaquinaGeneral
    {
        /// <value>
        /// Representa el tipo de tuberías de la instalación
        /// </value>
        public string TipoTuberias { get; set; }
        /// <summary>
        /// Constructor hijo de MaquinaGeneral
        /// </summary>
        /// <param name="nombre">Nombre</param>
        /// <param name="ubicacion">Ubicación</param>
        /// <param name="tipoInstalacion">Tipo de instalación</param>
        /// <param name="tipoTuberias">Tipo de tuberías</param>
        public Fontaneria(string nombre, string ubicacion,
            string tipoInstalacion, string tipoTuberias)
            : base(nombre, ubicacion, tipoInstalacion)
        {
            TipoTuberias = tipoTuberias;
        }
        /// <summary>
        /// Método ToString hijo de MaquinaGeneral
        /// </summary>
        /// <returns>Cadena propiedades separada por ;</returns>
        public override string ToString()
        {
            return base.ToString() + ";" + TipoTuberias;
        }
    }
}
