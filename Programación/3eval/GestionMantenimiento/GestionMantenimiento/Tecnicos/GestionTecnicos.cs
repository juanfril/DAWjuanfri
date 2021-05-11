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
    public partial class GestionTecnicos : Form
    {
        List<Tecnico> tecnicos;
        AnyadirTecnico anyadirTecnico;
        public GestionTecnicos()
        {
            tecnicos = new List<Tecnico>();
            tecnicos = GestionFicheros.CargarUsuarios(tecnicos);
            InitializeComponent();
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
                GestionFicheros.GuardarTecnicos(tecnicos);
            }
        }
        private void tbnAnyadir_Click(object sender, EventArgs e)
        {
            anyadirTecnico.ShowDialog();
            Tecnico t = new Tecnico();
            t.Nombre = anyadirTecnico.GetNombre();
            t.Oficio = anyadirTecnico.GetOficio();
            t.Antiguedad = anyadirTecnico.GetAntiguedad();
            tecnicos.Add(t);

            RefrescarGrid(tecnicos);
            GestionFicheros.GuardarTecnicos(tecnicos);
        }

        private void RefrescarGrid(List<Tecnico> tecnicos)
        {
            dgwTecnicos.DataSource = typeof(Tecnico);
            dgwTecnicos.DataSource = tecnicos;
        }
    }
}