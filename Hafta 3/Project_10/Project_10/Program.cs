using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_10
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 10;
            for(int sayac = 0; sayac < n;sayac ++)
            {
                Console.WriteLine(sayac + " .merhaba");
            }

            int sayac2 = 0;
            for(;sayac2 < n;)
            {
                Console.WriteLine(sayac2 + " .merhaba");
                sayac2++;
            }
            int sayac3 = 0;
            while(sayac3 < n)
            {
                Console.WriteLine(sayac3 + " .merhaba");
                sayac3++;
            }
            int sayac4 = 0;
            do
            {
                Console.WriteLine(sayac4 + " .merhaba");
                sayac4++;
            }
            while (sayac4 < n);

            Console.ReadKey();
        }
    }
}
