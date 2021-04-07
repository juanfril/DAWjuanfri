
namespace TiendaInformatica
{
    class Portatiles : ProductoInformatico
    {
        private float tamanyoPantalla;
        private int ram, discoDuro;

        public Portatiles() : base()
        {
            TamanyoPantalla = 0.00f;
            Ram = 0;
            DiscoDuro = 0;
        }
        public Portatiles(string codigo, string marca, string modelo,
            float precio, float tamanyoPantalla, int ram, int discoDuro)
            : base(codigo, marca, modelo, precio)
        {
            this.TamanyoPantalla = tamanyoPantalla;
            this.Ram = ram;
            this.DiscoDuro = discoDuro;
        }

        public float TamanyoPantalla { get; set; }
        public int Ram { get; set; }
        public int DiscoDuro { get; set; }

        public override string ToString()
        {
            return "- Tamaño de pantalla: " + TamanyoPantalla + " inch | Ram instalada: " +
                Ram + " GB | Disco duro: " + DiscoDuro + " GB" + base.ToString();
        }
    }
}
