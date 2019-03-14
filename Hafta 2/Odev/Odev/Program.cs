using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("1. Sayı: ");
            double sayi1 = Double.Parse(Console.ReadLine());
            Console.Write("2. Sayı: ");
            double sayi2 = Double.Parse(Console.ReadLine());
            Console.WriteLine("{0} Sayısı ile {1} Sayısının:\nToplamı = {2}\nFarkı = {3}\nÇarpımı = {4}\nBölümü = {5}",sayi1,sayi2,sayi1+sayi2,sayi1-sayi2,sayi1*sayi2,sayi1/sayi2);
            Console.ReadKey();
        }
    }
}
