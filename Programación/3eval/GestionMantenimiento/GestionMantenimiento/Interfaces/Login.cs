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
    public partial class Login : Form
    {
        List<Usuario> usuarios;
        InterfazAdministrador interfazAdministrador;
        public Login()
        {
            InitializeComponent();
            interfazAdministrador = new InterfazAdministrador();
            usuarios = new List<Usuario>();
            usuarios = GestionFicheros.CargarUsuarios(usuarios);
        }

        private void btnUsuario_Click(object sender, EventArgs e)
        {
            if (tbNombre.Text.Contains("admin") &&
                        tbContraseña.Text.Contains("admin"))
            {
                interfazAdministrador.ShowDialog();
                //Close();
            }
            else
            {
                for (int i = 0; i < usuarios.Count; i++)
                {
                    if (usuarios[i].Nombre.Equals(tbNombre.Text) && 
                            usuarios[i].Contraseña.Equals(tbContraseña.Text))
                    {
                        MessageBox.Show("Usuario aceptado", "Aviso");
                    }
                    else
                    {
                        MessageBox.Show("El usuario o la contraseña no son correctos",
                            "Aviso");
                    }
                }
            }
        }
    }
}
