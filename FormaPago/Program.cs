using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormaPago
{
    class Program
    {
        static void Main(string[] args)
        {
            // Pedir precio del producto
            Console.WriteLine("Escriba el precio del producto");
            double precio = Convert.ToDouble(Console.ReadLine());

            //Forma de pago (Tarjeta o Efectivo) 
            Console.WriteLine("Escribe la forma de pago: tarjeta o efectivo");
            String formaPago = (Console.ReadLine()).ToLower();
            //Si es tarjeta, pedir numero de tarjeta
            if (formaPago.Equals("Tarjeta"))
            {
                Console.WriteLine("Introduce el numero de tarjeta");
                int numero_tarjeta = Convert.ToInt32(Console.ReadLine());
                //Imprimir msj "El producto se a pagado con precio 
                //Se ha pagado con el numero de cuenta: <numCuenta>
;                Console.WriteLine("El producto con precio " + precio " se ha pagado con el numero de cuenta " + numero_tarjeta);
            }
            else if (formaPago.Equals("Efectivo"))
            {
                //Si el pago es en efectivo imprimira el producto
                Console.WriteLine("El producto con precio" + precio + "Se ha pagado");
            }
            else
            {
                //Si elige diferente imprimir "No es metodo correcto de pago"
                Console.WriteLine("No es un metodo de pago correcto");
            }

            Console.WriteLine("Presion cualquier tecla");
            Console.ReadKey();

            

           
        }
    }
}
