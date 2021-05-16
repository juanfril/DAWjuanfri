using GestionMantenimiento.Tecnicos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionMantenimiento.GestionPreventivos
{
    /// <summary>
    /// Clase que representa los preventivos realizados
    /// </summary>
    class Preventivo
    {
        private string usuario;
        private string tecnico;
        private string nombreElemento;
        private DateTime realizado;
        /// <summary>
        /// Constructor que inicializa los campos
        /// </summary>
        /// <param name="usuario">Nombre del usuario que generó el preventivo</param>
        /// <param name="tecnico">Nombre del técnico que realizó el preventivo</param>
        /// <param name="nombreElemento">Nombre del elemento sobre el que se hizo el preventivo</param>
        public Preventivo(string usuario, string tecnico, string nombreElemento)
        {
            this.usuario = usuario;
            this.tecnico = tecnico;
            this.nombreElemento = nombreElemento;
            realizado = DateTime.Now;
        }
        /// <summary>
        /// Método ToString de preventivo
        /// </summary>
        /// <returns>Una cadena con los campos separados por ;</returns>
        public override string ToString()
        {
            return usuario + ";" + tecnico + ";" + nombreElemento +
                ";" + realizado.ToString("d");
        }
    }
}
