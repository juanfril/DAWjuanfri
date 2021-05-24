using System;

namespace TiendaInformatica
{
    /*
     * Clase base (abstracta) para todo producto informático, que almacena la información general de los mismos
     */ 
    abstract class ProductoInformatico
    {
        protected string codigo;
        protected string marca;
        protected string modelo;
        protected float precio;

        public string Codigo
        {
            get
            {
                return codigo;
            }
            set
            {
                codigo = value;
            }
        }
        public string Marca
        {
            get
            {
                return marca;
            }
            set
            {
                marca = value;
            }
        }
        public string Modelo
        {
            get
            {
                return modelo;
            }
            set
            {
                modelo = value;
            }
        }
        public float Precio
        {
            get
            {
                return precio;
            }
            set
            {
                precio = value;
            }
        }

        public ProductoInformatico(string codigo, string marca, string modelo, float precio)
        {
            Codigo = codigo;
            Marca = marca;
            Modelo = modelo;
            Precio = precio;
        }
        public virtual void Mostrar()
        {
            Console.Write("Cód. " + Codigo + ": " + Marca + " | " + Modelo + " | " + Precio + " eur");
        }
    }
}
