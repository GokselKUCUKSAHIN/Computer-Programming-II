using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_22
{
    class Program
    {
        static void Main(string[] args)
        {
            Deste Oyun = new Deste();
            Oyun.Olustur();
            Oyun.Karistir();
            //Oyun.Yazdir();
            Kart Oyuncu1Kart = Oyun.KartCek();
            Kart Oyuncu2Kart = Oyun.KartCek();
            Oyuncu1Kart.yaz();
            Oyuncu2Kart.yaz();
            if (Oyuncu1Kart.puani > Oyuncu2Kart.puani)
                Console.WriteLine("Oyuncu 1 Kazanır");
            else if (Oyuncu2Kart.puani > Oyuncu1Kart.puani)
                Console.WriteLine("Oyuncu 2 Kazanır");
            else
                Console.WriteLine("DRAW");
            Console.ReadKey();
        }
    }


    class Deste
    {
        Kart[] kartlar = new Kart[52];
        int CekilenKartSayisi = 0;
        public void Olustur()
        {
            string[] Turler = new string[4] { "Maca", "Sinek", "Karo", "Kupa" };
            string[] Sayilar = new string[13] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K" };
            int k = 0;
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 13; j++)
                {
                    kartlar[k] = new Kart();
                    kartlar[k].turu = Turler[i];
                    kartlar[k].sayisi = Sayilar[j];
                    kartlar[k].puani = j + 1;
                    k++;
                }
            }
        }
        public void Yazdir()
        {
            for (int i = 0; i < 52; i++)
            {
                kartlar[i].yaz();
            }
        }
        public void Karistir()
        {
            Random r = new Random();
            for (int i = 0; i < 52; i++)
            {
                int rastgeleindis = r.Next(0, 52);
                Kart temp = kartlar[rastgeleindis];
                kartlar[rastgeleindis] = kartlar[i];
                kartlar[i] = temp;
            }
        }
        public Kart KartCek()
        {
            return kartlar[CekilenKartSayisi++];
        }
    }
    class Kart
    {
        public string turu;
        public string sayisi;
        public int puani;


        public void yaz()
        {
            Console.WriteLine("{0}-{1}", turu, sayisi);
        }
    }
}
