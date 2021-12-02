using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4_1
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Console.Write("Ведите целое число: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)

                Console.WriteLine("Квадрат числа {0} равен {1}", i, i * i);
            Console.ReadKey();
                       
        }
    }
}
