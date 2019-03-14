using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_20
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1 = Matematik.Topla("ali", "veli");
            Console.WriteLine(s1);
            int i = Matematik.faktoriyel(5);
            Console.WriteLine(i);
            Console.ReadKey();
        }
    }
}
