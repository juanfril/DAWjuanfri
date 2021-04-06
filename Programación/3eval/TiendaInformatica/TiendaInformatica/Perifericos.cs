
namespace TiendaInformatica
{
    class Perifericos : ProductoInformatico
    {
        private string nombre, conexion;

        public Perifericos() :base()
        {
            Nombre = "ninguno";
            Conexion = "indefinida";
        }

        public Perifericos(string codigo, string marca, string modelo,
            float precio, string nombre, string conexion)
            : base(codigo, marca, modelo, precio)
        {
            this.Nombre = nombre;
            this.Conexion = conexion;
        }

        public string Nombre { get; set; }
        public string Conexion { get; set; }

        public override string ToString()
        {
            return "- Nombre: " + Nombre + " |Conexión: " + Conexion + base.ToString();
        }
    }
}
