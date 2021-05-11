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
    public partial class InterfazAdministrador : Form
    {
        GestionUsuarios gestionUsuarios;
        public InterfazAdministrador()
        {
            InitializeComponent();
            gestionUsuarios = new GestionUsuarios();
        }

        private void msCerrarSesion_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            gestionUsuarios.ShowDialog();
        }
    }
}
