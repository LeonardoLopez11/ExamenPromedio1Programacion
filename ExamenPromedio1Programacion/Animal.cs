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
        protected float semillaValor;
        protected float productoValor;


        public Animal(string nombre, int tiempoVida, int cantidadProducto, float semillaValor, float productoValor)
        {
            this.Nombre = nombre;
            this.TiempoVida = tiempoVida;
            this.cantidadProducto = cantidadProducto;
            this.semillaValor = semillaValor;
            this.productoValor = productoValor;

        }
        public override string ToString()
        {
            return "Nombre: " + Nombre + ", TiempoVida: " + TiempoVida + " Cantidad de Productos: " + cantidadProducto + " valor de la semilla: " + semillaValor + "Valor del Producto" + productoValor;
        }
    }
}
