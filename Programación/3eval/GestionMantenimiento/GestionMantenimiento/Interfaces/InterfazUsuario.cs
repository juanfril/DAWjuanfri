using System;
using GestionMantenimiento.Tecnicos;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GestionMantenimiento.ElementosInstalacion;
using GestionMantenimiento.GestionPreventivos;

namespace GestionMantenimiento
{
    /// <summary>
    /// Formulario donde los usuarios pueden cerrar preventivos.
    /// </summary>
    public partial class InterfazUsuario : Form
    {
        private List<Tecnico> tecnicos;
        private List<Climatizacion> climas;
        private List<Electricidad> electricidad;
        private List<Fontaneria> fontaneria;
        private Preventivo preventivo;
        /// <summary>
        /// Constructor que inicializa el formulario, así como las listas de
        /// los diferentes objetos necesarios y las opciones del textBox.
        /// </summary>
        /// <param name="usuarioAceptado">Usuario por el cuál se accede</param>
        public InterfazUsuario(string usuarioAceptado)
        {
            InitializeComponent();
            tecnicos = new List<Tecnico>();
            climas = new List<Climatizacion>();
            electricidad = new List<Electricidad>();
            fontaneria = new List<Fontaneria>();
            tecnicos = GestionFicherosTecnicos.CargarTecnicos(tecnicos);
            climas = GestionFicherosElementos.CargarClima(climas);
            electricidad = GestionFicherosElementos.CargarElectricidad(electricidad);
            fontaneria = GestionFicherosElementos.CargarFontaneria(fontaneria);
            this.Text = usuarioAceptado;
            foreach (Tecnico t in tecnicos)
            {
                cbTecnicos.Items.Add(t.Nombre);
            }
        }
        private void btnAtrás_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //Cambia el formulario según qué técnico esté seleccionado
        private void cbTecnicos_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbAdvertencia.Visible = false;
            for (int i = 0; i < tecnicos.Count; i++)
            {
                if (tecnicos[i].Nombre.Contains(cbTecnicos.SelectedItem.ToString()))
                {
                    switch (tecnicos[i].Oficio)
                    {
                        case "frigorista":
                            dgwPeventivos.DataSource = climas;
                            break;
                        case "electricista":
                            dgwPeventivos.DataSource = electricidad;
                            break;
                        case "fontanero":
                            dgwPeventivos.DataSource = fontaneria;
                            break;
                    }
                }
            }
        }
        //Este método guarda el preventivo que se realiza en un fichero
        //y lo oculta en la tabla.
        private void btnRealizar_Click(object sender, EventArgs e)
        {
            if (dgwPeventivos.SelectedRows.Count != 1)
            {
                MessageBox.Show("Tiene que seleccionar una fila", "Aviso");
            }
            else
            {
                int posicion = dgwPeventivos.SelectedRows[0].Index;
                string elemento = dgwPeventivos.SelectedRows[0].Cells[1].Value.ToString();
                preventivo = new Preventivo(
                        this.Text, cbTecnicos.SelectedItem.ToString(),
                        elemento
                    );
                GestionFicherosPreventivos.GuardarPreventivo(preventivo);
                this.dgwPeventivos.CurrentCell = null;
                this.dgwPeventivos.Rows[posicion].Visible = false;
                MessageBox.Show("Preventivo cerrado", "Información");
            }
        }
    }
}
