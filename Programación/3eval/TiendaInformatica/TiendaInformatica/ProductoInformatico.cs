
namespace TiendaInformatica
{
    abstract class ProductoInformatico
    {
        protected string codigo;
        protected string marca;
        protected string modelo;
        protected float precio;

        public ProductoInformatico()
        {
            codigo = "aa00";
            marca = "generica";
            modelo = "standard";
            precio = 0.00f;
        }
        public string Codigo { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public float Precio { get; set; }

        public override string ToString()
        {
            return "Código producto: " + Codigo + " |Marca; " + Marca +
                " | Modelo: " + Modelo + " |Precio: " + Precio;
        }
    }
}
