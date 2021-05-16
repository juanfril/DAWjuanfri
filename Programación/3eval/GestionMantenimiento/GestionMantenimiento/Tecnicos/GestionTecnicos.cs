using GestionMantenimiento.Tecnicos;
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
    /// Formulario para gestionar a los técnicos del sistema.
    /// </summary>
    public partial class GestionTecnicos : Form
    {
        private List<Tecnico> tecnicos;
        private AnyadirTecnico anyadirTecnico;
        /// <summary>
        /// Constructor de formulario que inicializa una lista de técnicos
        /// cargada desde un fichero, el formulario para añadir un técnico y
        /// establece el origen de la tabla a esa lista
        /// </summary>
        public GestionTecnicos()
        {
            InitializeComponent();
            tecnicos = new List<Tecnico>();
            tecnicos = GestionFicherosTecnicos.CargarTecnicos(tecnicos);
            dgwTecnicos.DataSource = tecnicos;
            anyadirTecnico = new AnyadirTecnico();
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgwTecnicos.SelectedRows.Count != 1)
            {
                MessageBox.Show("Tiene que seleccionar una fila", "Aviso");
            }
            else
            {
                int posicion = dgwTecnicos.SelectedRows[0].Index;
                tecnicos.RemoveAt(posicion);

                RefrescarGrid(tecnicos);
                GestionFicherosTecnicos.GuardarTecnicos(tecnicos);
            }
        }
        private void tbnAnyadir_Click(object sender, EventArgs e)
        {
            anyadirTecnico.ShowDialog();

            if(!anyadirTecnico.GetNombre().Equals("") ||
                !anyadirTecnico.GetOficio().Equals(""))
            {
                Tecnico t = new Tecnico();
                t.Nombre = anyadirTecnico.GetNombre();
                t.Oficio = anyadirTecnico.GetOficio();
                t.Antiguedad = anyadirTecnico.GetAntiguedad();
                tecnicos.Add(t);

                RefrescarGrid(tecnicos);
                GestionFicherosTecnicos.GuardarTecnicos(tecnicos);
            }
        }

        private void RefrescarGrid(List<Tecnico> tecnicos)
        {
            dgwTecnicos.DataSource = typeof(Tecnico);
            dgwTecnicos.DataSource = tecnicos;
        }
    }
}