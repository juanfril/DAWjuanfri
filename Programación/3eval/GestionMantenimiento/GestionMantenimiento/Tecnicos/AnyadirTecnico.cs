using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionMantenimiento.Tecnicos
{
    /// <summary>
    /// Formulario para añadir técnicos al sistema.
    /// </summary>
    public partial class AnyadirTecnico : Form
    {
        private string oficio;
        /// <summary>
        /// Constructor que inicializa los componentes del formulario.
        /// </summary>
        public AnyadirTecnico()
        {
            InitializeComponent();
        }
        private void btnAnyadir_Click(object sender, EventArgs e)
        {
            if (tbNombre.Text == "" || cbOficio.Text.Equals("Elegir un oficio"))
            {
                MessageBox.Show("Debe rellenar todos los campos");
            }
            else
            {
                MessageBox.Show("Añadido correctamente");
                this.Refresh();
                this.Close();
            }
        }
        /// <summary>
        /// Recoge el nombre del técnico
        /// </summary>
        /// <returns>Cadena con el nombre del técnico</returns>
        public string GetNombre()
        {
            return tbNombre.Text == null ? "" : tbNombre.Text;
        }
        /// <summary>
        /// Recoge el oficio del técnico. Si no hay nada seleccionado
        /// devuelve cadena vacía.
        /// </summary>
        /// <returns>Cadena con el oficio del técnico</returns>
        public string GetOficio()
        {
            if(cbOficio.Text.Equals("Elegir un oficio"))
            {
                oficio = "";
            }
            else
            {
                oficio = cbOficio.SelectedItem.ToString();
            }
            return oficio;
        }
        /// <summary>
        /// Recoge la fecha de entrada en la empresa del técnico
        /// </summary>
        /// <returns>La fecha en formato DateTime</returns>
        public DateTime GetAntiguedad()
        {
            return mcAntiguedad.SelectionStart;
        }
    }
}
