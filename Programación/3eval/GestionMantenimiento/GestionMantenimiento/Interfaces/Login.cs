using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionMantenimiento
{
    /// <summary>
    /// Formulario de inicio para loguearse en la aplicación
    /// </summary>
    public partial class Login : Form
    {
        private List<Usuario> usuarios;
        private InterfazAdministrador interfazAdministrador;
        private InterfazUsuario interfazUsuario;
        private bool encontrado;
        /// <summary>
        /// Constructor que inicializa el formulario, así como una lista de 
        /// usuarios cargada desde un fichero y los diferentes formularios 
        /// a los que se accede
        /// </summary>
        public Login()
        {
            InitializeComponent();
            interfazAdministrador = new InterfazAdministrador();
            usuarios = new List<Usuario>();
            usuarios = GestionFicherosUsuario.CargarUsuarios(usuarios);
            encontrado = false;
        }
        private void btnUsuario_Click(object sender, EventArgs e)
        {
            if (tbNombre.Text.Contains("admin") &&
                        tbContraseña.Text.Contains("admin"))
            {
                interfazAdministrador.ShowDialog();
                this.Refresh();
            }
            else
            {
                for (int i = 0; i < usuarios.Count ; i++)
                {
                    if (usuarios[i].Nombre.Equals(tbNombre.Text) && 
                            usuarios[i].Contraseña.Equals(tbContraseña.Text))
                    {
                        interfazUsuario = new InterfazUsuario(usuarios[i].Nombre);
                        encontrado = true;
                        interfazUsuario.ShowDialog();
                        this.Refresh();
                    }
                }
                if (!encontrado)
                    MessageBox.Show("No se encuentra el usuario o contraseña");
            }
        }
    }
}
