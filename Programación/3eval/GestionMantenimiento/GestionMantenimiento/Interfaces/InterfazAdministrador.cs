using GestionMantenimiento.GestionPreventivos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionMantenimiento
{
    /// <summary>
    /// Formulario que representa las opciones del administrador
    /// </summary>
    public partial class InterfazAdministrador : Form
    {
        private GestionUsuarios gestionUsuarios;
        private GestionTecnicos gestionTecnicos;
        private GestionMaquinas gestionMaquinas;
        private PreventivosRealizados preventivosRealizados;
        /// <summary>
        /// Constructor que inicializa el formulario, así como los diferentes
        /// formularios a los cuáles se accede
        /// </summary>
        public InterfazAdministrador()
        {
            InitializeComponent();
            gestionUsuarios = new GestionUsuarios();
            gestionTecnicos = new GestionTecnicos();
            gestionMaquinas = new GestionMaquinas();
            preventivosRealizados = new PreventivosRealizados();
        }
        private void msCerrarSesion_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            gestionUsuarios.ShowDialog();
        }
        private void btnTecnicos_Click(object sender, EventArgs e)
        {
            gestionTecnicos.ShowDialog();
        }
        private void btnMaquinas_Click(object sender, EventArgs e)
        {
            gestionMaquinas.ShowDialog();
        }
        private void btnVisualizar_Click(object sender, EventArgs e)
        {
            preventivosRealizados.ShowDialog();
        }
    }
}
