using System;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecurrenciaUnDominioReal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce numero: ");
            double n = double.Parse(Console.ReadLine());
            Console.WriteLine(suma(n));
            Console.Read();
        }
        public static double suma(double n)
        {
            if (n>2 && n- (int)n >0)           //Mayor a 2 y no entero
            {
                return suma(Math.Floor(n)) + 2;
            }            
            else if(n> 2 && n - (int)n ==0 && n %2==0)       //Mayor a 2, par y entero
            { 
                return suma(n-1) + suma(n-2);             
            }
            else if(n > 2 && n - (int)n == 0 && n % 2 > 0)   //Mayor a 2, entero e impar
                    
            { 
                return suma(n - 1) + suma(n / 2) + 1;

            }
            else { return 1; }
        }
            
    }
}
