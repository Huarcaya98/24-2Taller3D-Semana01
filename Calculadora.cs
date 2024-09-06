using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24_2Taller3D_Semana01
{
    internal class Calculadora
    {

        public void Excute()
        {

            float a, b, resul;
            string option, conf;
            bool continueFlag = true;

            while (continueFlag)
            {
                Console.WriteLine("Que operacion deseas realizar");
                Console.WriteLine("suma");
                Console.WriteLine("resta");
                Console.WriteLine("multiplicar");
                Console.WriteLine("dividir");
                option = Console.ReadLine();

                switch (option)
                {
                    case "suma":
                        Console.WriteLine("Ingrese el primer numero");
                        a = float.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese el segundo numero");
                        b = float.Parse(Console.ReadLine());
                        resul = a + b;
                        Console.WriteLine($"Resultado de {a} + {b} = {resul} ");
                        break;

                    case "resta":
                        Console.WriteLine("Ingrese el primer numero");
                        a = float.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese el segundo numero");
                        b = float.Parse(Console.ReadLine());
                        resul = a - b;
                        Console.WriteLine($"Resultado de {a} - {b} = {resul} ");
                        break;

                    case "multiplicar":
                        Console.WriteLine("Ingrese el primer numero");
                        a = float.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese el segundo numero");
                        b = float.Parse(Console.ReadLine());
                        resul = a * b;
                        Console.WriteLine($"Resultado de {a} * {b} = {resul} ");
                        break;

                    case "dividir":
                        Console.WriteLine("Ingrese el primer numero");
                        a = float.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese el segundo numero");
                        b = float.Parse(Console.ReadLine());
                        resul = a / b;
                        Console.WriteLine($"Resultado de {a} / {b} = {resul} ");
                        break;

                    default:
                        Console.WriteLine("Opción no válida");
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

            Console.WriteLine("Gracias por usar la calculadora!");
            Console.ReadKey();


        }
        
     }
        
           

 }

    

