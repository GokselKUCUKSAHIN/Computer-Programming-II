using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_26
{
    class Program
    {
        static void Main(string[] args)
        {
            Ogrenci o1 = new Ogrenci();
            o1.Numara = 1030522874;
            o1.Adi = "Göksel";
            o1.Soyadi = "Küçükşahin";
            o1.dersEkle("Programlama",4);
            o1.dersEkle("Matematik", 4);
            o1.dersEkle("Tarih", 2);
            o1.dersEkle("Fizik", 3);
            o1.dersEkle("Kimya", 2);
            Console.WriteLine("{0} = notlar", o1.Adi);
            o1.notGir("Fizik", 60, 30);
            o1.notGir("Programlama", 90, 60);
            o1.notGir("Matematik", 80, 45);
            o1.notGir("Tarih", 30, 70);
            o1.notGir("Kimya", 45, 70);
            o1.notDokumu();
            double Gano = o1.ganoHesapla();
            Console.WriteLine("Gano =" + Gano);
            /*
            Ogrenci o2 = new Ogrenci();
            o2.Numara = 1030526398;
            o2.Adi = "Ali";
            o2.Soyadi = "Demir";
            o2.dersEkle("AyrıkMat", 3);
            o2.dersEkle("Programlama-II", 4);
            Console.WriteLine("{0} = notlar", o2.Adi);
            o2.notDokumu();*/
        }
    }
}