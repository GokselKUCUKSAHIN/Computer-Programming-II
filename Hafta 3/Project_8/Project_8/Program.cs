using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_8
{
    class Program
    {
        static void Main(string[] args)
        {
            int sensor;
            int KlimaDerecesi = 15;
        //  do
        //    {
                Console.Write("Derece: ");
                sensor = Int32.Parse(Console.ReadLine());
                if (sensor < -10)
                {
                    Console.WriteLine("Hava Çok Soğuk, klima 5 derece artti");
                    KlimaDerecesi += 5;
                }
                else if ((sensor >= -10) && (sensor <10))
                {
                    Console.WriteLine("Hava Soğuk, klima 2 derece artti");
                    KlimaDerecesi += 2;
                }
                else if((sensor >= 10) && (sensor < 20))
                {
                    Console.WriteLine("Hava Ilık, Derecede değişiklik yapılmadı"); 
                }
                else
                {
                    Console.WriteLine("Hava Sıcak, klima 2 derece azaltıldı");
                    KlimaDerecesi -= 2;
                }
            //}
          //  while (sensor != 76);
            switch(KlimaDerecesi)
            {
                case 15:
                    {
                        Console.WriteLine("Mavi LED yandı");
                        break;
                    }
                case 18:
                    {
                        Console.WriteLine("Yeşil LED yandı");
                        break;
                    }
                case 20:
                    {
                        Console.WriteLine("Kırmızı LED yandı");
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Sarı LED yandı");
                        break;
                    }
            }
            Console.ReadKey();
        }
    }
}
