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
    public partial class AñadirUsuario : Form
    {
        public AñadirUsuario()
        {
            InitializeComponent();
        }

        private void btnAnyadir_Click(object sender, EventArgs e)
        {
            Close();
        }

        public string GetNombre()
        {
            return tbNombre.Text;
        }
        public string GetContraseña()
        {
            return tbContraseña.Text;
        }
    }
}
