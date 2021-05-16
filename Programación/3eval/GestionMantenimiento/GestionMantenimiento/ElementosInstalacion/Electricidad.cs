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
    class Electricidad : MaquinaGeneral
    {
        /// <value>
        /// Representa el tipo de cableado que usa la instalación
        /// </value>
        public string TipoCableado { get; set; }
        /// <summary>
        /// Constructor hijo de MaquinaGeneral
        /// </summary>
        /// <param name="nombre">Nombre</param>
        /// <param name="ubicacion">Ubicación</param>
        /// <param name="tipoInstalacion">Tipo de instalación</param>
        /// <param name="tipoCableado">Tipo de cableado</param>
        public Electricidad(string nombre, string ubicacion,
            string tipoInstalacion, string tipoCableado)
            : base(nombre, ubicacion, tipoInstalacion)
        {
            TipoCableado = tipoCableado;
        }
        /// <summary>
        /// Método ToString padre del elemento
        /// </summary>
        /// <returns>Cadena propiedades separada por ;</returns>
        public override string ToString()
        {
            return base.ToString() + ";" + TipoCableado;
        }
    }
}
