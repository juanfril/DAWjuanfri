using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionMantenimiento
{
    class Electricidad : MaquinaGeneral
    {
        protected string tipoCableado;

        public string TipoCableado { get; set; }

        public Electricidad(string nombre, string ubicacion,
            string tipoInstalacion, byte periodicidad, string tipoCableado)
            : base(nombre, ubicacion, tipoInstalacion, periodicidad)
        {
            TipoCableado = tipoCableado;
        }
        public override string ToString()
        {
            return base.ToString() + ";" + TipoCableado;
        }
    }
}
