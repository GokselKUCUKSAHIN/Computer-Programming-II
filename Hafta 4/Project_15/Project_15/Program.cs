using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_15
{
    class Project_15
    {
        static void Main(string[] args)
        {
            //oyuncu için isim 
            Random r = new Random();
            Console.Write("1. Oyuncunun ismini girin-> ");
            string sO1 = Console.ReadLine();
            Console.Write("2. Oyuncunun ismini girin-> ");
            string sO2 = Console.ReadLine();

            int zar1 = r.Next(1, 7); //1. oyuncu için zar atımı
            int zar2 = r.Next(1, 7); //2. oyuncu için zar atımı 

            if (zar1 > zar2)
                Console.WriteLine(sO1 + " KAZANDI");
            else if (zar2 > zar1)
                Console.WriteLine(sO2 + " KAZANDI");
            else
                Console.WriteLine("BERABERLİK!");
            Console.ReadKey();
        }
    }
}
