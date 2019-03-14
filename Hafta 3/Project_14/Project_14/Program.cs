using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_14
{
    class Program
    {
        static void Main(string[] args)
        {
            double AgirlilikOrt = 0.0;
            double KrediOrt = 0.0;
            int Not, Kredi;
           for(int Count = 1;Count <= 10; Count++)
            {
                Console.Write(Count + ". dersin Notunu Girin: ");
                Not = Int32.Parse(Console.ReadLine());
                Console.Write(Count+". dersin Kredisin Girin: ");
                Kredi = Int32.Parse(Console.ReadLine());
                AgirlilikOrt += (double)(Not * Kredi);
                KrediOrt += Kredi;
            }
            Console.WriteLine("Ağırlıklı Not Ortalamsı = "+(AgirlilikOrt / KrediOrt));
            Console.ReadKey();
        }
    }
}
