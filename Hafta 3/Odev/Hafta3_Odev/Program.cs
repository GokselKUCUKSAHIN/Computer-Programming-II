using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hafta3_Odev
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> OgrName = new List<string>();
            double SinifOrt = 0.0;
            int[] OrtData = new int[10];
            string s1;
            int Not;
            for (int i=0;i<10;i++)
            {
                Console.Write("{0}. Öğrencinin Adı: ",i+1);
                s1 = Console.ReadLine();
                OgrName.Add(s1);
                Console.Write(s1 + " adlı Öğrencinin Notu: ");
                Not = Int32.Parse(Console.ReadLine());
                OrtData[i] = Not;
                SinifOrt += (double)Not;
            }
            SinifOrt = SinifOrt / 10.0;
            Console.WriteLine("Sınıf ortalaması = "+SinifOrt);
            for (int i = 0; i < 10; i++)
            {
                if(OrtData[i] > SinifOrt)
                    Console.WriteLine(OgrName[i] + " Geçti");
                else
                    Console.WriteLine(OgrName[i] + " Kaldı");
            }
            Console.ReadKey();
        }
    }
}
