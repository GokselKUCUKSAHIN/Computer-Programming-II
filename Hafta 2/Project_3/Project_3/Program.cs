using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Adınız: ");
            string ad = Console.ReadLine();
            Console.WriteLine("Merhaba " + ad);
            int sayi;
            Console.Write("Sayı Girin-> ");
            string girdi = Console.ReadLine();
            sayi = Int32.Parse(girdi);
            Console.WriteLine("Karesi: " + (sayi * sayi));
            Console.Write("İkini bir sayi girin: ");
            string girdi3 = Console.ReadLine();
            int sayi2 = Convert.ToInt32(girdi3);
            int toplam = sayi + sayi2;
            Console.WriteLine("{0} + {1} = {2}",sayi,sayi2,toplam);
            Console.WriteLine("sayi = {0},{0},{0}", sayi);
            Console.ReadKey();
        }
    }
}
