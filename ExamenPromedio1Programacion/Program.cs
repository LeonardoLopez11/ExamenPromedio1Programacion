﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenPromedio1Programacion
{
    class Program
    {
        private List<Animal> todosanimales = new List<Animal>();
        private List<Plantas> todasplantas = new List<Plantas>();
        




        static void Main(string[] args)
        {
            Granja granja = new Granja();
            granja.ExpandirGranja();

            List<Animal> todosanimales = new List<Animal>();
            List<Plantas> todasplantas = new List<Plantas>();
            List<Animal> animales = new List<Animal>();
            List<Plantas> plantas = new List<Plantas>();
            Animal Cerdo = new Animal("Cerdo", 50, 500, 10, 100);
            Animal Vaca = new Animal("Vaca", 50, 300, 20, 200);
            Plantas Girasol = new Plantas("Giraso", 10, 100, 500, 200);
            Plantas Girasol2 = new Plantas("Giraso2", 20, 1100, 700, 700);
            todosanimales.Add(Cerdo);
            todosanimales.Add(Vaca);
            todasplantas.Add(Girasol);
            todasplantas.Add(Girasol2);
            



            bool continueFlag = true;
            while (continueFlag)
            {
                Console.WriteLine("Introducir el dinero que quieres tener");
                
                float dinero = float.Parse(Console.ReadLine());


                Console.WriteLine("1. Expandir Granja");
                Console.WriteLine("2. Comprar Animales");
                Console.WriteLine("3. Comprar Plantas");
                Console.WriteLine("4. Pasar turno");
                Console.WriteLine("5. Ver productos");
                Console.WriteLine("6. Ver mis plantas");
                Console.WriteLine("7. Ver mis animales");
                string option = Console.ReadLine();
                switch (option)
                {
                    case "1":
                        {
                            dinero = dinero - granja.GetPrecioExpansion();
                            granja.ExpandirGranja();
                            Console.WriteLine("Has expandido la granja");
                            

                            break;
                        }
                    case "2":
                        {
                            foreach (var objetos in todosanimales)
                            {
                                Console.WriteLine(objetos.ToString());
                                Console.WriteLine("Nombre del animal que quieres comprar");
                                string option2 = Console.ReadLine();
                                switch (option2)
                                {
                                    case "Cerdo":
                                        {
                                            animales.Add(Cerdo);
                                            break;
                                        }
                                    case "Vaca":
                                        {
                                            animales.Add(Vaca);
                                            break;
                                        }
                                }
                            }


                            break;
                        }
                    case "3":
                        {
                            foreach (var objetos in todasplantas)
                            {
                                Console.WriteLine(objetos.ToString());
                                Console.WriteLine("Nombre de la planta que quieres comprar");
                                string option3 = Console.ReadLine();
                                switch (option3)
                                {
                                    case "Girasol":
                                        {
                                            plantas.Add(Girasol);
                                            break;
                                        }
                                    case "Girasol1":
                                        {
                                            plantas.Add(Girasol2);
                                            break;
                                        }
                                }
                            }

                            break;
                        }
                       
                            case "4":
                        {

                            break;

                        }
                    case "5":
                        {

                            break;

                        }
                    case "6":
                        {
                            break;

                        }
                    case "7":
                        {
                            break;

                        }
                    
                        {

                        }





                }




            }



        }
    }
}
