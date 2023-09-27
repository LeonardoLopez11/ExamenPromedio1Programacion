using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenPromedio1Programacion
{
    class Plantas
    {
        protected string Nombre;
        protected int TiempoVida;
        protected int CantidadProducto;
        protected float SemillaValor;
        protected float ProductoValor;
        private int CrecimientoPlanta;

        public Plantas(string nombre, int tiempoVida, int cantidadProducto, float semillaValor, float productoValor)
        {
            this.Nombre = nombre;
            this.TiempoVida = tiempoVida;
           this.CantidadProducto = cantidadProducto;
           this.SemillaValor = semillaValor;
            this.ProductoValor = productoValor;

        }

        public virtual void CosecharPlanta()
        {
            if(CrecimientoPlanta <= 1)
            {
                Console.WriteLine("Has cosechado la planta demasiado pronto, no has obtenido su producto");
            }
            else if (CrecimientoPlanta == 2)
            {
                Console.WriteLine("Has cosechado la planta antes de tiempo, pero has obtenido 1 producto");
            }
            else if (CrecimientoPlanta == 3)
            {
                Console.WriteLine("Has cosechado la planta en el mejor momento, has obtenido 3 producto");
            }
            else
            {

                Console.WriteLine("Has cosechado la planta demasiado tarde, tanto que sus productos se han podrido");
                    
            }
        }
        public override string ToString()
        {
            return "Nombre: " + Nombre + ", TiempoVida: " + TiempoVida + " Cantidad de Productos: " + CantidadProducto + " valor de la semilla: " + SemillaValor + "Valor del Producto" + ProductoValor;
        }

        public float GetCosecharPlanta()
        {
            return CrecimientoPlanta;
        }

    }
}
