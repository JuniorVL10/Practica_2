using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejersicio_String2
{
    class Program
    {
        static void Main(string[] args)
        {

            String Nombre;
            string LineaEdad;
            int edad;
            Console.WriteLine("Pedir Nombre");
            Nombre = Console.ReadLine();
            Console.WriteLine("Escribe la edad");
            LineaEdad = Console.ReadLine();
            edad = Convert.ToInt32(LineaEdad);
            Console.WriteLine("Tu nombre es:  " + Nombre + "y tiene" + edad + "años");
            Console.WriteLine("Presiona una tecla");
            Console.ReadKey();



        }
    }
}
