using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_13
{
    class Program
    {
        static void Main(string[] args)
        {
            double ClassOrt = 0.0;
            for (int i = 1; i <= 10; i++)
            {
                Console.Write(i + ". Öğrenciyinin Vizesini girin -> ");
                int Vize = Int32.Parse(Console.ReadLine());
                Console.Write(i + ". Öğrenciyinin Finalini girin -> ");
                int Final = Int32.Parse(Console.ReadLine());
                Console.WriteLine(i + ". Öğrencinin Ort: " + (double)(Vize * 0.4 + Final * 0.6));
                ClassOrt += (double)(Final + Vize) / 2.0;
            }
            Console.WriteLine("\n 10 Öğrencinin Ortalaması: " + ClassOrt / 10.0);
            Console.ReadKey();
        }
    }
}
