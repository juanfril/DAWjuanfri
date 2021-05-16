using GestionMantenimiento.ElementosInstalacion;
using GestionMantenimiento.Tecnicos;
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
    /// Formulario para gestionar las máquinas de la instalación
    /// </summary>
    public partial class GestionMaquinas : Form
    {
        private List<Climatizacion> clima;
        private List<Electricidad> electricidad;
        private List<Fontaneria> fontaneria;
        private anyadirElemento anyadirElemento;
        /// <summary>
        /// Constructor que inicializa el formulario, así como las listas de
        /// los objetos de las máquinas, el origen de los datos de las 
        /// diferentes tablas y el acceso a añadir más elementos.
        /// </summary>
        public GestionMaquinas()
        {
            InitializeComponent();
            clima = new List<Climatizacion>();
            clima = GestionFicherosElementos.CargarClima(clima);
            electricidad = new List<Electricidad>();
            electricidad = GestionFicherosElementos.CargarElectricidad(electricidad);
            fontaneria = new List<Fontaneria>();
            fontaneria = GestionFicherosElementos.CargarFontaneria(fontaneria);
            dgwClimatizacion.DataSource = clima;
            dgwElectricidad.DataSource = electricidad;
            dgwFontaneria.DataSource = fontaneria;
            anyadirElemento = new anyadirElemento();
        }
        private void btnAtras_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void btnEliminarClima_Click(object sender, EventArgs e)
        {
            if (dgwClimatizacion.SelectedRows.Count != 1)
            {
                MessageBox.Show("Tiene que seleccionar una fila", "Aviso");
            }
            else
            {
                int posicion = dgwClimatizacion.SelectedRows[0].Index;
                clima.RemoveAt(posicion);

                RefrescarGridClima(clima);
                GestionFicherosElementos.GuardarClima(clima);
            }
        }
        private void btnEliminarElectricidad_Click(object sender, EventArgs e)
        {
            if (dgwElectricidad.SelectedRows.Count != 1)
            {
                MessageBox.Show("Tiene que seleccionar una fila", "Aviso");
            }
            else
            {
                int posicion = dgwElectricidad.SelectedRows[0].Index;
                electricidad.RemoveAt(posicion);

                RefrescarGridElectricidad(electricidad);
                GestionFicherosElementos.GuardarElectricidad(electricidad);
            }
        }
        private void btnEliminarFontaneria_Click(object sender, EventArgs e)
        {
            if (dgwFontaneria.SelectedRows.Count != 1)
            {
                MessageBox.Show("Tiene que seleccionar una fila", "Aviso");
            }
            else
            {
                int posicion = dgwFontaneria.SelectedRows[0].Index;
                fontaneria.RemoveAt(posicion);

                RefrescarGridFontaneria(fontaneria);
                GestionFicherosElementos.GuardarFontaneria(fontaneria);
            }
        }
        private void tbnAnyadir_Click(object sender, EventArgs e)
        {
            anyadirElemento.ShowDialog();
            switch (anyadirElemento.GetOficio())
            {
                case "frigorista":
                    Climatizacion c = new Climatizacion(
                                    anyadirElemento.GetNombre(),
                                    anyadirElemento.GetUbicacion(),
                                    anyadirElemento.GetOficio(),
                                    anyadirElemento.GetOpcion()
                                );
                    clima.Add(c);

                    RefrescarGridClima(clima);
                    GestionFicherosElementos.GuardarClima(clima);
                    break;
                case "electricista":
                    Electricidad ele = new Electricidad(
                                    anyadirElemento.GetNombre(),
                                    anyadirElemento.GetUbicacion(),
                                    anyadirElemento.GetOficio(),
                                    anyadirElemento.GetOpcion()
                                );
                    electricidad.Add(ele);

                    RefrescarGridElectricidad(electricidad);
                    GestionFicherosElementos.GuardarElectricidad(electricidad);
                    break;
                case "fontanero":
                    Fontaneria f = new Fontaneria(
                                    anyadirElemento.GetNombre(),
                                    anyadirElemento.GetUbicacion(),
                                    anyadirElemento.GetOficio(),
                                    anyadirElemento.GetOpcion()
                                );
                    fontaneria.Add(f);

                    RefrescarGridFontaneria(fontaneria);
                    GestionFicherosElementos.GuardarFontaneria(fontaneria);
                    break;
            }
        }
        private void RefrescarGridClima(List<Climatizacion> clima)
        {
            dgwClimatizacion.DataSource = typeof(Climatizacion);
            dgwClimatizacion.DataSource = clima;
        }
        private void RefrescarGridElectricidad(List<Electricidad> electricidad)
        {
            dgwClimatizacion.DataSource = typeof(Electricidad);
            dgwClimatizacion.DataSource = electricidad;
        }
        private void RefrescarGridFontaneria(List<Fontaneria> fontas)
        {
            dgwClimatizacion.DataSource = typeof(Fontaneria);
            dgwClimatizacion.DataSource = fontas;
        }

        
    }
}