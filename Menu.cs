using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24_2Taller3D_Semana01
{
    internal class Menu
    {
        public void Execute()
        {
            string name;
            int age = 0;
            bool continueFlag;

            Console.WriteLine("Ingrese su nombre");
            name = Console.ReadLine();
            Console.WriteLine($"Hola {name}");

            continueFlag=true;
            while(continueFlag)
            {
                Console.WriteLine("Ingrese su edad");
                age = int.Parse(Console.ReadLine());
                Console.WriteLine($"Tienes {age}");

                if(age < 0)
                {
                    Console.WriteLine("No puedes tener edad negativo");
                }

                else if(age < 18)
                {
                    continueFlag=false;
                   Console.WriteLine("Eres menor de edad");
                }
                else
                {
                    continueFlag = false;
                   Console.WriteLine("Eres mayor de edad");
                }
            }

            

            
            Console.ReadKey();

        }

        

    }

}
