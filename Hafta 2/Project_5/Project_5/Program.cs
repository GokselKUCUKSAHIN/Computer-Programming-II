using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("1. Sayıyı girin -> ");
            double sayi1 = Double.Parse(Console.ReadLine());
            Console.Write("2. Sayıyı girin -> ");
            double sayi2 = Double.Parse(Console.ReadLine());
            Console.WriteLine("{0} ile {1}\'nin farkı = {2}\'dir.", sayi1, sayi2, sayi1 - sayi2);
            Console.ReadKey();

        }
    }
}
