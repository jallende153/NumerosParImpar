using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumerosParesEImpares
{
    class Program
    {
        static void Main(string[] args)
        {

            //===============================================
            // declaracion de varibles 
            int n;
            //===============================================
            
            //===============================================
            // Ingresar el número y guardarlo en la variable n, 
            //realizar los cálculos para averiguar si el número ingresado es par o impar 
            Console.Write("Ingrese un número: ");
            n = Convert.ToInt32(Console.ReadLine());
            if (Math.Pow(-1, n) == 1)
            {
                // muestra el mensaje en pantalla
                Console.WriteLine("El Número {0} es par", n);
            }
            else
            {
                Console.WriteLine("El Número {0} es impar", n);
            }
            Console.ReadKey();
            //===============================================
        }
    }
}
