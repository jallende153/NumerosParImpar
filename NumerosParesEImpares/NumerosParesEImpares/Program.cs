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
            int e;
            double d;
            //===============================================
            
            //===============================================
            // Ingresar el número y guardarlo en la variable n, 
            //realizar los cálculos para averiguar si el número ingresado es par o impar 
            Console.Write("Ingrese un número: ");
            n = Convert.ToInt32(Console.ReadLine());
            e = n / 2;
            d = (double)n / 2;
            if (d - e == 0)
                // muestra el mensaje en pantalla
                Console.WriteLine("El Número " + n + " es par");
            else
                Console.WriteLine("El Número " + n + " es impar");
            Console.ReadKey();
            //===============================================
        }
    }
}
