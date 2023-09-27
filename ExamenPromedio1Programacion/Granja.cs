using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenPromedio1Programacion
{
    class Granja
    {
        private int PrecioExpansion;
        List<Animal> animales = new List<Animal>();
        List<Plantas> plantas = new List<Plantas>();
        

        public void ExpandirGranja()
        {
            PrecioExpansion = PrecioExpansion + 10;
            Console.WriteLine("Se ha completado la compra");
        }
    }
}
