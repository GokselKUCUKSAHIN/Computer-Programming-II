using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_11
{
    class Program
    {
        static void Main(string[] args)
        {
            int toplam = 0;
            for (int count = 0; count < 10; count++)
            {
                Console.Write("{0}. Sayıyı girin -> ",count+1);
                int Input = Int32.Parse(Console.ReadLine());
                toplam += Input;
            }
            Console.WriteLine("Toplam = " + toplam);
            Console.ReadKey();
        }
    }
}
