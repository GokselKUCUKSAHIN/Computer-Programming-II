using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Project_15
{
    class Project_15
    {
        static void Main(string[] args)
        { 
            Random r = new Random();
            Console.Write("1. Oyuncunun ismini girin-> ");
            string sO1 = Console.ReadLine();
            Console.Write("2. Oyuncunun ismini girin-> ");
            string sO2 = Console.ReadLine();

            int Counter1 = 0, Counter2 = 0, Counter3 = 0;
            for (int i = 0; i < 50; i++) 
            {
                int zar1 = r.Next(1, 21); //1. oyuncu için zar atımı
                Thread.Sleep(15);
                int zar2 = r.Next(1, 21); //2. oyuncu için zar atımı 
                
                if (zar1 > zar2)
                    Counter1++;
                else if (zar2 > zar1)
                    Counter2++;
                else
                    Counter3++;
            }
            if(Counter1 > Counter2)
            {
                //oyuncu1 kazanır
                Console.WriteLine("{0}; {1}\'a {2} fark ile Kazandı!",sO1,Counter1,Counter2);
            }

            else if(Counter2 > Counter1)
            {
                //oyuncu 2 kazanır
                Console.WriteLine("{0}; {1}\'a {2} fark ile Kazandı!", sO1, Counter2, Counter1);
            }
            else
            {
                //Beraberlik
                Console.WriteLine("BERABERLİK! {0} kere {1} kazandı, {2} kere {3} kazandı.\nAyrıca {4} kere aynı sayı geldi",Counter1,sO1,Counter2,sO2,Counter3);
            }
            Console.ReadKey();
        }
    }
}
