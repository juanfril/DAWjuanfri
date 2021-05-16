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
    /// Formulario para la edición de usuarios
    /// </summary>
    public partial class GestionUsuarios : Form
    {
        
        private List<Usuario> usuarios;
        private AñadirUsuario anyadirUsuario;
        /// <summary>
        /// Constructor de la clase <c>GestionUsuarios</c>, inicializa
        /// una lista de usuarios, el origen de los datos de la tabla y 
        /// el formulario para añadir un usuario nuevo
        /// </summary>
        public GestionUsuarios()
        {
            InitializeComponent();
            usuarios = new List<Usuario>();
            usuarios = GestionFicherosUsuario.CargarUsuarios(usuarios);
            dgwUsuarios.DataSource = usuarios;
            anyadirUsuario = new AñadirUsuario();
        }
        /// <summary>
        /// Añade funcionalidad al botón atrás del formulario
        /// </summary>
        /// <param name="sender">Objeto sobre el evento</param>
        /// <param name="e">Evento</param>
        private void btnAtras_Click(object sender, EventArgs e)
        {
            Close();
        }
        /// <summary>
        /// Borra un usuario seleccionado y actualiza el fichero
        /// de eliminar
        /// </summary>
        /// <param name="sender">Objeto sobre el evento</param>
        /// <param name="e">Evento</param>
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
                GestionFicherosUsuario.GuardarUsuarios(usuarios);
            }
        }
        /// <summary>
        /// Añade un usuario a la lista de usuarios y lo guarda en un fichero
        /// </summary>
        /// <param name="sender">Objeto del evento</param>
        /// <param name="e">Evento</param>
        private void tbnAnyadir_Click(object sender, EventArgs e)
        {
            anyadirUsuario.ShowDialog();
            if(!anyadirUsuario.GetNombre().Equals("") ||
                !anyadirUsuario.GetContraseña().Equals(""))
            {
                Usuario u = new Usuario();
                u.Nombre = anyadirUsuario.GetNombre();
                u.Contraseña = anyadirUsuario.GetContraseña();
                usuarios.Add(u);

                RefrescarGrid(usuarios);
                GestionFicherosUsuario.GuardarUsuarios(usuarios);
            }
        }
        /// <summary>
        /// Funcionalidad para refrescar la tabla después de un cambio
        /// </summary>
        /// <param name="usuarios">Lista de usuarios</param>
        private void RefrescarGrid(List<Usuario> usuarios)
        {
            dgwUsuarios.DataSource = typeof(Usuario);
            dgwUsuarios.DataSource = usuarios;
        }
        /// <summary>
        /// Permite modificar celdas individualmente y actualiza el fichero
        /// </summary>
        /// <param name="sender">Objeto sobre el evento</param>
        /// <param name="e">evento</param>
        private void dgwUsuarios_CellEndEdit(object sender,
            DataGridViewCellEventArgs e)
        {
            int posicion = dgwUsuarios.CurrentRow.Index;

            usuarios[posicion].Nombre = 
                (string)dgwUsuarios.Rows[posicion].Cells[0].Value;
            usuarios[posicion].Contraseña = 
                (string)dgwUsuarios.Rows[posicion].Cells[1].Value;

            GestionFicherosUsuario.GuardarUsuarios(usuarios);
        }
    }
}