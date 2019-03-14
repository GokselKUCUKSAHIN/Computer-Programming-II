using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_23
{
    class Program
    {
        static void Main(string[] args)
        {
            //Array.Sort Düzensiz diziler için aralamalar 
            //Array.BinnarySearch Düzenli diziler için arama

            string[] ogrenciler = new string[5] { "Ali", "Ayşe", "Ahmet", "Mehmet", "Fatma" };
            string[] ogrenciler2 = { "Ali", "Ayşe", "Ahmet", "Mehmet", "Fatma" };
            string[] ogrenciler3 = new string[] { "Ali", "Mehmet", "Ahmet", "Mehmet", "Fatma" };

            Console.WriteLine("for i ile sistematik tarama");

            for (int i = 0; i < ogrenciler.Length; i++)
            {
                //ogrenciler[i] ile ne yapılmak isteniyorsa bu block içinde yapılabilir
                Console.WriteLine(ogrenciler[i]);
            }

            Console.WriteLine(); //\n

            Console.WriteLine("foreach ile sistematik tarama");
            foreach (string a in ogrenciler)
            {
                //her bir eleman sirayla a değişkenine aktarılır
                //a ile ne yapılmak isteniyotsa burada yapilir
                Console.WriteLine(a);
            }

            int indis = -1;
            string aranan = "Mehmet";
            for (int i = 0; (i < ogrenciler3.Length) && (indis == -1); i++)
            {
                if(ogrenciler[i] == aranan)
                {
                    indis = i;
                }
            }
            Console.WriteLine("For i ile indis = "+indis);
            Console.WriteLine(); //\n
            int Findis = Array.IndexOf(ogrenciler3, aranan);
            Console.WriteLine("İlk indis = "+Findis);
            int Lindis = Array.LastIndexOf(ogrenciler3, aranan);
            Console.WriteLine("Son indis = "+Lindis);

            Console.WriteLine();//\n
            Array.Sort(ogrenciler);
            Console.WriteLine("Sıralama sonrası");
            foreach(string a in ogrenciler)
                Console.WriteLine(a);

            int Bindis = Array.BinarySearch(ogrenciler, aranan);
            Console.WriteLine("Binary indis:" + Bindis);

            Array.Reverse(ogrenciler);
            Console.WriteLine("Reverse Sonrası");
            foreach (string a in ogrenciler)
            {
                Console.WriteLine(a);
            }
        }
    }
}
