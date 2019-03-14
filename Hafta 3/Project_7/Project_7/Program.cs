using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_7
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 4;
            int s1 = a + b;
            long s2 = a + b; //implicit dönüşüm bilinçsiz
            short s3 = (short)(a + b); //explicit dönüşüm bilinçli
            byte s4 = (byte)(a + b);
            Console.WriteLine(s4);
            double d5 = a + b;
            float f = a + b;
            string s5 = (a + b).ToString();
            double d6 = a / (double)b;
            Console.WriteLine(d6);
            int s7 = a++;//s7=a;a=a+1;
            Console.WriteLine("s7 = {0}, a = {1}", s7, a);
            int s8 = --b;//b=b-1;s8=b;
            Console.WriteLine("s8 = {0}, b = {1}", s8, b);
            a += 5; // a = a + 5;
            a -= 5; // a = a - 5;
            a *= 5; // a = a * 5;
            a /= 5; // a = a / 5;
            Console.WriteLine("a: {0}, b: {1}", a, b);
            bool s9 = (a < b) && !(a == b);    //false
            bool s10 = (a <= b) || !(b != a);//false
            bool c = true;
            bool s11 = !c == s10;
            Console.WriteLine(s11);

            bool d = false;
            bool s12 = c && d;
            bool s13 = c || d;
            bool s14 = !d; //! NOT
            int s15 = a & b;
            Console.WriteLine(s15);
            int s16 = a | b;
            Console.WriteLine(s16);
            int s17 = a << 3;
            Console.WriteLine(s17);
            int s18 = a >> 3;
            Console.WriteLine(s18);
            //tip değişken = (sart) ? değer1 : değer 2;
            /*
            if(sart)
                değişken = değer1;
            else
                değişken = değer2;*/
            string sonuc = (a > 50) ? "geçti" : "kaldi";
            Console.ReadKey();
        }
    }
}
