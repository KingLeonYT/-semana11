using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ConsoleApp1
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese una cantidad de elementos: ");
            int n = int.Parse(Console.ReadLine());
            int[] numeros = new int[n];
            Random rnd = new Random();
            for (int i = 0; i < n; i++)
            {
                numeros[i] = rnd.Next(10, 99 + 1);
            }
            string todos=string.Join(",", numeros);
            Console.WriteLine($"Numeros { todos}");
        }
    }
}
