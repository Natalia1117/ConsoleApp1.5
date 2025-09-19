using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1._5
{
    internal class Program
    {
        static int Suma(int n)
        {
            if (n == 0) return 0;
            return n + Suma(n - 1);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce un número");
            try
            {
                int n = int.Parse(Console.ReadLine());
                if (n < 0)
                {
                    Console.WriteLine("El número debe ser no negativo.");
                }
                else
                {
                    int resultado = Suma(n);
                    Console.WriteLine($"La suma de {n} desde 1 es {resultado}");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("No es un número");
               
            }
           
            
        }
    }
}
