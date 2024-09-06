using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24_2Taller3D_Semana01
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string option , conf;
            bool continueFlag = true;

            while(continueFlag)
            {
                Console.WriteLine("Que operacion deseas realizar");
                Console.WriteLine(" edad");
                Console.WriteLine(" calculadora ");
                Console.WriteLine(" geometrica");
                option = Console.ReadLine();

                switch (option)
                {
                    case "edad":
                        Menu menu = new Menu();
                        menu.Execute();
                        break;

                    case "calculadora":
                        Calculadora calculadora = new Calculadora();
                        calculadora.Excute();

                        break;

                    case "geometrica":
                        break;



                }


                Console.WriteLine("Deseas realizar otra operacion? (si/no)");
                conf = Console.ReadLine();

                if (conf == "no")
                {
                    continueFlag = false;
                }
                else if (conf == "si")
                {
                    continueFlag = true;
                }
                else
                {
                    Console.WriteLine("Entrada no válida. Saliendo del programa.");
                    continueFlag = false;
                }
            }

            Console.WriteLine("Gracias por usar el programa!");
            Console.ReadKey();
        }


    
            

            




        }
    }

