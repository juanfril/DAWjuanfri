using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionMantenimiento.GestionPreventivos
{
    /// <summary>
    /// Formulario para la visualización de preventivos realizados
    /// </summary>
    public partial class PreventivosRealizados : Form
    {
        private List<Preventivo> preventivos;
        /// <summary>
        /// Constructor que inicializa el formulario, una lista de preventivos
        /// cargados desde un fichero y el origen de los datos de la listView
        /// </summary>
        public PreventivosRealizados()
        {
            InitializeComponent();
            preventivos = new List<Preventivo>();
            preventivos = GestionFicherosPreventivos.CargarPreventivos(preventivos);
            lbVisor.DataSource = preventivos;
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
