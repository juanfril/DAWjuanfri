
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
            Codigo = "aa00";
            Marca = "generica";
            Modelo = "standard";
            Precio = 0.00f;
        }

        public ProductoInformatico(string codigo, string marca, string modelo,
            float precio)
        {
            this.Codigo = codigo;
            this.Marca = marca;
            this.Modelo = modelo;
            this.Precio = precio;
        }
        public string Codigo { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public float Precio { get; set; }

        public override string ToString()
        {
            return " | Código producto: " + Codigo + " |Marca; " + Marca +
                " | Modelo: " + Modelo + " |Precio: " + Precio + "euros";
        }
    }
}
