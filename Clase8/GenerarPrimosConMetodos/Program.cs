using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenerarPrimosConMetodos
{
    internal class Program
    {
        static bool VerificarPrimo(int num)
        { 


                int divisible = 0;
                for (int n = 1; n <= num; n++) ;
                {
                if (num % n == 0)
                    divisible++;
                    {
                      
                    }
                   return divisible <=2;
   
            
               
            
            } 
            
             
        }
        static void Main(string[] args)
{
    Console.WriteLine("Solicitar desde y hasta");
    int desde = Convert.ToInt32(Console.ReadLine());
    int hasta = Convert.ToInt32(Console.ReadLine());

    for (int i = desde; i <= hasta; i++)
    {
        if (Program.VerificarPrimo(i) == true)
        {
            Console.WriteLine(("{0}"), i);
        }
        Console.ReadKey();
    }
}