using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionMantenimiento.ElementosInstalacion
{
    /// <summary>
    /// Clase para añadir elementos de la instalación
    /// </summary>
    public partial class anyadirElemento : Form
    {
        private string tipo;
        /// <summary>
        /// Constructor que inicializa el formulario
        /// </summary>
        public anyadirElemento()
        {
            InitializeComponent();
        }
        private void btnAnyadir_Click(object sender, EventArgs e)
        {
            if(tbNombre.Text.Equals("") || tbUbicacion.Text.Equals("") ||
                cbOficio.Text.Equals("Elegir un tipo") ||
                tbOpcion.Text.Equals(""))
            {
                MessageBox.Show("Tiene rellenar todo el formulario", "Aviso");
            }
            else
            {
                Close();
            }
        }
        /// <summary>
        /// Recoge los datos del campo nombre
        /// </summary>
        /// <returns>Una cadena con el nombre</returns>
        public string GetNombre()
        {
            return tbNombre.Text;
        }
        /// <summary>
        /// Recoge los datos del campo ubicación
        /// </summary>
        /// <returns>Una cadena con la ubicación</returns>
        public string GetUbicacion()
        {
            return tbUbicacion.Text;
        }
        /// <summary>
        /// Recoge los datos del campo oficio
        /// </summary>
        /// <returns>Una cadena con el oficio</returns>
        public string GetOficio()
        {
            if (cbOficio.Text.Equals("Elegir un tipo"))
                tipo = "";
            else
                tipo = cbOficio.SelectedItem.ToString();

            return tipo;
        }
        /// <summary>
        /// Recoge los datos del campo según el oficio
        /// </summary>
        /// <returns>Una cadena con el valor introducido</returns>
        public string GetOpcion()
        {
            return tbOpcion.Text;
        }
        //Cambia el texto del label según el oficio
        private void cbOficio_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbOficio.SelectedItem.ToString())
            {
                case "frigorista":
                    lbOpcion.Text = "Tipo Gas";
                    break;
                case "electricista":
                    lbOpcion.Text = "Instalación";
                    break;
                case "fontanero":
                    lbOpcion.Text = "Tipo tubería";
                    break;
            }
        }
    }
}
