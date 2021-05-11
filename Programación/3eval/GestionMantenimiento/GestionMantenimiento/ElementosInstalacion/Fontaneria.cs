using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionMantenimiento
{
    class Fontaneria : MaquinaGeneral
    {
        protected string tipoTuberias;

        public string TipoTuberias { get; set; }

        public Fontaneria(string nombre, string ubicacion,
            string tipoInstalacion, byte periodicidad, string tipoTuberias)
            : base(nombre, ubicacion, tipoInstalacion, periodicidad)
        {
            TipoTuberias = tipoTuberias;
        }
        public override string ToString()
        {
            return base.ToString() + ";" + TipoTuberias;
        }
    }
}
