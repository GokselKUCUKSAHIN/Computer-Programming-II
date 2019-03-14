using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_17
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            int Sayi = r.Next(0, 101);
            int Tahmin;
            int deneme = 0;
            while(true)
            {
                Console.Write("Tahmin Gir-> ");
                Tahmin = Int32.Parse(Console.ReadLine());
                if((Tahmin > Sayi) && (Tahmin <= 100))
                {
                    Console.WriteLine("Tahmininizi Küçültün");
                    deneme++;
                }
                else if((Sayi > Tahmin) && (Sayi >= 0))
                {
                    Console.WriteLine("Tahmininizi Artırın");
                    deneme++;
                }
                else if(Tahmin > 100)
                {
                    Console.WriteLine("Tahmininiz Sayı Limitinin Üstünde!");
                }
                else if(Tahmin < 0)
                {
                    Console.WriteLine("Tahmininiz Sayı Limitinin Altında!");
                }
                else
                {
                    deneme++;
                    Console.WriteLine("TEBRİKLER! {0} Sayısını; {1} kere tahmin ederek buldunuz.",Sayi,deneme);
                    break;
                }
            }
            Console.ReadKey();
            
        }
    }
}
