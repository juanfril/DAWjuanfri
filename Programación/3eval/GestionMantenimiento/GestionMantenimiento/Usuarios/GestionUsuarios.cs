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
    public partial class GestionUsuarios : Form
    {
        List<Usuario> usuarios;
        AñadirUsuario anyadirUsuario;
        public GestionUsuarios()
        {
            usuarios = new List<Usuario>();
            usuarios = GestionFicheros.CargarUsuarios(usuarios);
            InitializeComponent();
            dgwUsuarios.DataSource = usuarios;
            anyadirUsuario = new AñadirUsuario();
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if(dgwUsuarios.SelectedRows.Count != 1)
            {
                MessageBox.Show("Tiene que seleccionar una fila", "Aviso");
            }
            else
            {
                int posicion = dgwUsuarios.SelectedRows[0].Index;
                usuarios.RemoveAt(posicion);

                RefrescarGrid(usuarios);
                GestionFicheros.GuardarUsuarios(usuarios);
            }
        }
        private void tbnAnyadir_Click(object sender, EventArgs e)
        {
            anyadirUsuario.ShowDialog();
            Usuario u = new Usuario();
            u.Nombre = anyadirUsuario.GetNombre();
            u.Contraseña = anyadirUsuario.GetContraseña();
            usuarios.Add(u);

            RefrescarGrid(usuarios);
            GestionFicheros.GuardarUsuarios(usuarios);
        }

        private void RefrescarGrid(List<Usuario> usuarios)
        {
            dgwUsuarios.DataSource = typeof(Usuario);
            dgwUsuarios.DataSource = usuarios;
        }

        private void dgwUsuarios_CellEndEdit(object sender,
            DataGridViewCellEventArgs e)
        {
            int posicion = dgwUsuarios.CurrentRow.Index;

            usuarios[posicion].Nombre = 
                (string)dgwUsuarios.Rows[posicion].Cells[0].Value;
            usuarios[posicion].Contraseña = 
                (string)dgwUsuarios.Rows[posicion].Cells[1].Value;

            GestionFicheros.GuardarUsuarios(usuarios);
        }
    }
}