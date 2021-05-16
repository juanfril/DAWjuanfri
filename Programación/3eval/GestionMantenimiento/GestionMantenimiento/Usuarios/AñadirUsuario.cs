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
    /// Formulario para introducir los datos de nuevos usuarios
    /// </summary>
    public partial class AñadirUsuario : Form
    {
        /// <summary>
        /// Constructor que inicializa el formulario
        /// </summary>
        public AñadirUsuario()
        {
            InitializeComponent();
        }
        private void btnAnyadir_Click(object sender, EventArgs e)
        {
            if (tbNombre.Text == "" || tbContraseña.Text == "")
                MessageBox.Show("Debe rellenar los campos");
            else
                this.Close();
        }
        /// <summary>
        /// Devuelve una cadena con el nombre
        /// </summary>
        /// <returns>string con la cadena introducida en el formulario</returns>
        public string GetNombre()
        {
            return tbNombre.Text;
        }
        /// <summary>
        /// Devuelve una cadena con la contraseña
        /// </summary>
        /// <returns>string con la cadena introducida en el formulario</returns>
        public string GetContraseña()
        {
            return tbContraseña.Text;
        }
    }
}
//TODO Cuando cierras desde la cruz, si hay algo escrito se crea el usuario