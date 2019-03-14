using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_12
{
    class Program
    {
        static void Main(string[] args)
        {
            int Input = 0, toplam = 0;
            do
            {
                toplam += Input;
                Console.Write("Sayi girin: ");
                Input = Int32.Parse(Console.ReadLine());
            }
            while (Input != -1);
            Console.WriteLine("Toplam = " + toplam);
            Console.ReadKey();
        }
        
    }
}
