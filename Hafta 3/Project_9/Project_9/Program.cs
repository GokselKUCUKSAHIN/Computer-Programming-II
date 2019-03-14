using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_9
{
    class Program
    {
        static void Main(string[] args)
        {
            //not al
            //not 50den büyükse geçti
            //değilse kaldi yazsin

            Console.Write("Not: ");
            int Not = Int32.Parse(Console.ReadLine());
            if((Not >= 50) && (Not <= 100))
            {
                Console.WriteLine("Geçti");
            }
            else if((Not <50) && (Not >=0))
            {
                Console.WriteLine("Kaldı");
            }
            else
            {
                Console.WriteLine("Geçersiz aralık!\n");
            }
            //
            //Program 1
            //


            if ((Not <= 100) && (Not >= 85))
                Console.WriteLine("AA");
            else if ((Not < 85) && (Not >= 75))
                Console.WriteLine("BA");
            else if ((Not < 75) && (Not >= 65))
                Console.WriteLine("BB");
            else if ((Not < 65) && (Not >= 57))
                Console.WriteLine("CB");
            else if ((Not < 57) && (Not >= 50))
                Console.WriteLine("CC");
            else if ((Not > 100) || (Not < 0))
            {
                if (Not > 100)
                    Console.WriteLine("100 den büyük değer giremezsiniz");
                else
                    Console.WriteLine(" dan küçük değer giremezsiniz");
            }
            else
                Console.WriteLine("Kaldınız");
            Console.ReadKey();
        }
    }
}
