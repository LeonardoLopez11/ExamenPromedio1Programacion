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
        Animal Cerdo = new Animal("CERDO", 500, 50, 10, 50);
        Animal Vaca = new Animal("VACA", 500, 100, 15, 10);

        public void ExpandirGranja()
        {
            PrecioExpansion = PrecioExpansion + 10;
            Console.WriteLine("Se ha completado la compra");
        }
    }
}
