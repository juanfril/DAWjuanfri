using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionMantenimiento.Tecnicos
{
    class Tecnico
    {
        public string Nombre { get; set; }
        public string Oficio { get; set; }
        public DateTime Antiguedad { get; set; }

        public override string ToString()
        {
            return Nombre + ";" + Oficio + ";" + Antiguedad.Day + "/" +
                Antiguedad.Month + "/" + Antiguedad.Year;
        }
    }
}
