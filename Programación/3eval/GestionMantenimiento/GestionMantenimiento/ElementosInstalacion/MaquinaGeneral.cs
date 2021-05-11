using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionMantenimiento
{
    class MaquinaGeneral
    {
        protected int identificador = 0;
        protected string nombre;
        protected string ubicacion;
        protected string tipoInstalacion;
        protected byte periodicidad;

        public int Identificador { get; set; }
        public string Nombre { get; set; }
        public string Ubicacion { get; set; }
        public string TipoInstalacion { get; set; }
        public byte Periodicidad { get; set; }

        public MaquinaGeneral(string nombre, string ubicacion,
            string tipoInstalacion, byte periodicidad)
        {
            ++identificador;
            Nombre = nombre;
            Ubicacion = ubicacion;
            TipoInstalacion = tipoInstalacion;
            Periodicidad = periodicidad;
        }
        
        public override string ToString()
        {
            return Identificador + ";" +Nombre + ";" + Ubicacion + ";"
                + TipoInstalacion + ";" + Periodicidad;
        }
    }
}
