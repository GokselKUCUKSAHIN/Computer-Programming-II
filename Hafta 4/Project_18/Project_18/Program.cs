using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_18
{
    class Program
    {
        static void Main(string[] args)
        {
            const int DiziBoyutu = 5;
            string[] isimler = new string[DiziBoyutu] {"Ali","Ayşe","Fatma","Hayriye","Ahmet" };
            //Console.WriteLine(isimler[0]);
            string[] telefonNum = new string[DiziBoyutu] { "123-456", "#123", "+90352", "567", "987-987" };
            //
            //tip "isim"[] = new tip["boyut"]{}; 
            //

            //App
            //aranın isimi alınız
            //numarayı ver

            string[] Numaralar = new string[] { "0535-511-75-03","0506-209-27-38","0544-722-72-13","0551-556-46-66","1700 44 53"};
            string[] Kisiler = new string[] { "Göksel", "Mehmet", "Emine", "Arda","Jelly"};
            bool varMi = false;
            Console.Write("Kimi Aramak istiyorsunuz?: ");
            string s1 = Console.ReadLine();
            for (int i = 0; (i < Kisiler.Length) && (varMi==false); i++)
            {
                if (s1 == Kisiler[i])
                {
                    Console.WriteLine(Numaralar[i]);
                    varMi = true;
                }
            }
            if (varMi == false)
                Console.WriteLine("{0} kişisi bulunamadı", s1);
            Console.ReadKey();
        }
    }
}
