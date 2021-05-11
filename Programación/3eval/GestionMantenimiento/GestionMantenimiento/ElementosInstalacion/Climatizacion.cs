using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionMantenimiento
{
    class Climatizacion : MaquinaGeneral
    {
        protected string tipoRefrigerante;

        public string TipoRefrigerante { get; set; }

        public Climatizacion(string nombre, string ubicacion,
            string tipoInstalacion, byte periodicidad ,string tipoRefrigerante)
            : base(nombre, ubicacion, tipoInstalacion, periodicidad)
        {
            TipoRefrigerante = tipoRefrigerante;
        }
        public override string ToString()
        {
            return base.ToString() + ";" + TipoRefrigerante;
        }
    }
}
