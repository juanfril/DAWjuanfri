using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionMantenimiento.Tecnicos
{
    public partial class AnyadirTecnico : Form
    {
        public AnyadirTecnico()
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
        public string GetOficio()
        {
            return cbOficio.SelectedItem.ToString();
        }
        public DateTime GetAntiguedad()
        {
            return mcAntiguedad.SelectionStart;
        }
    }
}
