using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int Vize,Final;
            Console.Write("Vize Notunuz?: ");
            Vize = Int32.Parse(Console.ReadLine());
            Console.Write("\nFinal Notunuz?: ");
            Final = Int32.Parse(Console.ReadLine());
            double ortalama = (Vize + Final) / 2.0;
            Console.WriteLine("Vize Notunuz: {0}, Final Notunuz: {1}, Ortalamanız = {2}", Vize, Final, ortalama);



            Console.ReadKey();
          
        }
    }
}
