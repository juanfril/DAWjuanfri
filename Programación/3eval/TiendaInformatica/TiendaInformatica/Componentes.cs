
namespace TiendaInformatica
{
    class Componentes : ProductoInformatico
    {
        private string nombre, descripcion;

        public Componentes() : base()
        {
            Nombre = "ninguno";
            Descripcion = "Sin descripción";
        }

        public Componentes(string codigo, string marca, string modelo,
            float precio, string nombre, string descripcion) 
            : base(codigo, marca, modelo, precio)
        {
            
            this.Nombre = nombre;
            this.Descripcion = descripcion;
        }

        public string Nombre { get; set; }
        public string Descripcion { get; set; }

        public override string ToString()
        {
            return "- Nombre: " + Nombre + " |Descripción : " + Descripcion + base.ToString();
        }
    }
}
