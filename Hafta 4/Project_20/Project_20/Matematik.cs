using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_20
{
    class Matematik
    {
        public static int Topla(int i, int j)
        {
            return i + j;
        }
        public static string Topla(string s1, string s2)
        {
            return s1 + " " + s2;
        }
        public static string Topla(int i, string s1)
        {
            return i.ToString() + " " + s1;
        }
        public static int faktoriyel(int sayi)
        {
            int f = 1;
            for (int i = 2; i <= sayi; i++)
                f *= i;
            return f;
        }
    }
}
