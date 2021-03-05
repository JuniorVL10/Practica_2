using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Burger
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declarar Variables
            int cantidadburger, cantidadpapas, cantidadbebidas;
            double total;
            string linea;
            const double precioburger = 45;
            const double preciopapas = 15;
            const double preciobebida = 20;

            //Datos en cosola
            Console.WriteLine("ingresa cantidad de burger");
            linea = Console.ReadLine();
            cantidadburger = int.Parse(linea);
            //papas
            Console.WriteLine("ingresa cantidad de papas");
            linea = Console.ReadLine();
            cantidadpapas = int.Parse(linea);
            //bebidas
            Console.WriteLine("ingresa cantidad de bebidas");
            linea = Console.ReadLine();
            cantidadbebidas = int.Parse(linea);
            //Calcular precio
            total = (cantidadburger * precioburger) + (cantidadpapas * preciopapas) + (cantidadbebidas * preciobebida);
            Console.WriteLine("total a pagar es: " + total);
            Console.WriteLine("Presiona cualquier tecla");
            Console.ReadKey();






        }
    }
}
