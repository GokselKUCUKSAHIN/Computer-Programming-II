using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace Project_24
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList dinamikDizi = new ArrayList(20);
            dinamikDizi.Add("ali");
            dinamikDizi.Add(2);
            dinamikDizi.Add(7.62);
            dinamikDizi.Add(5.56f);
            dinamikDizi.Add('C');
            dinamikDizi.Add(true);

            Kitap kitapNesnesi = new Kitap();
            dinamikDizi.Add(kitapNesnesi);

            ArrayList dinamikDizi2 = new ArrayList();
            Console.WriteLine("Başlangic count: {0}, kapasite: {1}",dinamikDizi2.Count,dinamikDizi2.Capacity);
            int sayi = 0;
            do
            {
                try
                {
                    sayi = int.Parse(Console.ReadLine());
                    dinamikDizi2.Add(sayi);
                }
                catch { }
                Console.WriteLine("Count: {0}, kapasite: {1}", dinamikDizi2.Count, dinamikDizi2.Capacity);
            }
            while (sayi != -1);

            Console.WriteLine();//

            for (int i = 0; i < dinamikDizi2.Count; i++)
            {
                //DinamikDizi2[i] 
                Console.WriteLine(dinamikDizi2[i]);
            }

            Console.WriteLine("Sort Sonrası");//
            dinamikDizi2.Sort();
            foreach (int a in dinamikDizi2)
                Console.WriteLine(a);

            
            Console.WriteLine("Insert Sonrası");//
            dinamikDizi2.Insert(3, 120);
            foreach (int a in dinamikDizi2)
                Console.WriteLine(a);

            dinamikDizi2.Remove(120);
            dinamikDizi2.RemoveAt(0);

            int aranan = 5;
            int Findis = dinamikDizi2.IndexOf(aranan);
            int Lindis = dinamikDizi2.LastIndexOf(aranan);
            int Bindis = dinamikDizi2.BinarySearch(aranan);

            dinamikDizi2.AddRange(dinamikDizi);
        }


        class Kitap
        {
            public string kitapAdi = "MERHABA";
            public void IsimChange()
            {
                kitapAdi = "Dünya";
            }
        }
    }
}