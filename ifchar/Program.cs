using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ifchar
{
    class Program
    {
        static void Main(string[] args)
        {
            //pedir el carcter
            Console.WriteLine("Ingresa un caracter");
            char c = (char)Console.Read();
            if (char.IsLetter(c))
            { 
                if (char.IsLower(c))
                {
                    Console.WriteLine("El caracter es letra minuscula");

                }
                else
                {
                    Console.WriteLine("El caracter es letra mayuscula");

                }

                }
            else
            {
                Console.WriteLine("El caracter es un numero");
            }
            Console.WriteLine("Presiona una tecla para continuar");
            Console.ReadKey();


            

        }
    }
}
