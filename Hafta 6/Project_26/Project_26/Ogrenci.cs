using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_26
{
    class Ogrenci
    {
        public string Adi;
        public string Soyadi;
        public int Numara;
        List<Ders> Dersleri = new List<Ders>();

        public void dersEkle(string dersAdi, byte kredi)
        {
            Ders d = new Ders();
            d.Adi = dersAdi;
            d.Kredi = kredi;
            Dersleri.Add(d);
        }
        public void notDokumu()
        {
            foreach (Ders a in Dersleri)
            {
                a.yaz();
            }
        }

        public void notGir(string dersAdi, byte vize, byte final)
        {
           
            bool OK = false;
            int i;
            for (i = 0; (i < Dersleri.Count) && (OK !=true) ; i++)
            {
                OK = Dersleri[i].DersBul(dersAdi);
            }
            if(OK == true)
            {
                Dersleri[i-1].Vize = vize;
                Dersleri[i-1].Final = final;
            }
            else
                Console.WriteLine("Aradığınız ders Bulunamadı.");
                

        }
        public double ganoHesapla()
        {
            double Pay = 0;
            double Payda = 0;
            for (int i = 0; i < Dersleri.Count; i++)
            {
                Pay += ((Dersleri[i].Vize * 0.4) + (Dersleri[i].Final * 0.6)) * Dersleri[i].Kredi;
                Payda += Dersleri[i].Kredi;
            }
            return (Pay/Payda);
        }
    }
}
