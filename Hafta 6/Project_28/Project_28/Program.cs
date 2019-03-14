using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_28
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> jelly = new List<int>();
            bool Con = true;
            while(Con)
            {
                try
                {
                    jelly.Add(5);
                }
                catch(OutOfMemoryException)
                {
                    Console.WriteLine("Bellek Bitti!");
                    Con = false;
                }
            }
            Console.ReadKey();
        }
    }
}
