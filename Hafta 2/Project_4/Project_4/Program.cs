using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = new int();
            int b = a;
            int c = 5;
            double d = 3.12;
            Console.WriteLine("int türü kapladığı alan " + sizeof(int) + " byte");
            Console.WriteLine("long  türü kapladığı alan " + sizeof(long) + " byte");
            Console.WriteLine("double türü kapladığı alan " + sizeof(double) + " byte");
            Console.WriteLine("char türü kapladığı alan " + sizeof(char) + " byte");
            Console.WriteLine("short türü kapladığı alan " + sizeof(short) + " byte");
            int a1 = (int) d; //bilinçli tür dönüşümü, explicit casting
            double d2 = c; // bilinçsiz tür dönüşümü,implicit casting
            Console.ReadKey();

        }
    }
}
