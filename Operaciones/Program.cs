using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operaciones
{
    class Program
    {
        static void Main(string[] args)
        {

            //declaracion de variables
            int num1, num2, resultado;
            string linea;
            //pedir numeros
            Console.WriteLine("ingresa el primer numero");
            linea = Console.ReadLine();
            num1 = int.Parse(linea);
            Console.WriteLine("ingresa el segundo numero");
            linea = Console.ReadLine();
            num2 = int.Parse(linea);

            //Operaciones Sum 
            resultado = num1 + num2; 
            Console.WriteLine("la suma es {0} : ", resultado); 

            //Operaciones Resta 
            resultado = num1 - num2;
            Console.WriteLine("la resta es {0} : ", resultado); 

            //Operaciones Multipliccion
            resultado = num1 * num2;
            Console.WriteLine("la multiplicacion es {0} : ", resultado);


            //Operaciones Division 
            resultado = num1 / num2;
            Console.WriteLine("la division es {0} : ", resultado);

            //Operaciones Div
            resultado = num1 % num2;
            Console.WriteLine("El residuo es {0} : ", resultado);
            Console.WriteLine("Presiona cualquier tecla");
            Console.ReadKey();

        }

    }
}
