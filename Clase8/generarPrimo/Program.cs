using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace generarPrimo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Ingrese un numero");
            string varText = (Console.ReadLine());
            int num = Convert.ToInt32(varText);
            #region contador divisibles;
            int divisible = 0;
            for (int n = 1; n <= num; n++) ;
            {
                if (num % n == 0)
                {
                    divisible++;

                }
            #endregion

                if (divisible <= 2)
                {
                    Console.WriteLine("El numero es primo");
                }
                else
                {
                    Console.WriteLine("El numero no es primo");

                }

            }
        }
    }
}
