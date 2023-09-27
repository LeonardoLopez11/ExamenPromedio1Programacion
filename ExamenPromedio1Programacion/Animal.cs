using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenPromedio1Programacion
{
    class Animal
    {
        protected string Nombre;
        protected int TiempoVida;
        protected float cantidadProducto;
        protected float PrecioAnimal;
        protected float PrecioProductoFinal;

        public Animal(string nombre, int tiempoVida, float cantidadProducto, float precioAnimal, float precioProductoFinal)
        {
            Nombre = nombre;
            TiempoVida = tiempoVida;
            this.cantidadProducto = cantidadProducto;
            PrecioAnimal = precioAnimal;
            PrecioProductoFinal = precioProductoFinal;
        }

        public override string ToString()
        {
            return "Nombre: " + Nombre + ", TiempoVida: " + TiempoVida + " Cantidad de Productos: " + cantidadProducto + " Precio del Animal: " + PrecioAnimal + "Producto Final Precio" + PrecioProductoFinal;
        }
    }
}
