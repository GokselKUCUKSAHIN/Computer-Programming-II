using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Project_33
{
    class RandevuSistemi
    {
        string dosyaYolu = @"C:\ERU\Bilgisayar Programlama II\c#\Hafta 8\Project_33\Project_33\bin\Randevu.txt";

        public void RandevuEkle(Randevu r)
        {
            Hasta h = r.Kisi;
            StreamWriter yazmaNesnesi = new StreamWriter(dosyaYolu, true);
            string satir = h.TCKimlikNo + "~" + h.Adi + "~" + h.Soyadi + "~" + r.bolum + "~" + r.tarih + "~" + r.saat;
            yazmaNesnesi.WriteLine(satir);
            yazmaNesnesi.Close();
        }

        public bool BTSArama(Randevu r)
        {
            bool sonuc = false;
            try
            {
                StreamReader okumaNesnesi = new StreamReader(dosyaYolu);
                while(okumaNesnesi.EndOfStream == false)
                {
                    string satir = okumaNesnesi.ReadLine();
                    string[] parcalar = satir.Split('~');
                    if ((parcalar[3] == r.bolum) && (parcalar[4] == r.tarih) && (parcalar[5] == r.saat)) 
                    {
                        sonuc = true;
                    }
                }
                okumaNesnesi.Close();
                
            }
            catch
            {
                //Error Exception
            }
            return sonuc;
        }
        public string Listele()
        {
            StreamReader okumaNesnesi = new StreamReader(dosyaYolu);
            string icerik = okumaNesnesi.ReadToEnd();
            return icerik;
        }
    }
}