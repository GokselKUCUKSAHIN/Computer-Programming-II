using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_19
{
    class TelefonReh
    {
        //
        const int maxKapasite = 30;
        public int eklenenElemanSayisi = 0;

        Kisi[] Data = new Kisi[maxKapasite];


        //işlevler ve sorumluluklari
        //dişarıidan alınan isim,soyisim ve telefon bilgilerine erişim
        //sahip kişiyi kişiler topluluğuna eklemek
        //eklenmiş kişilerin dökümünü yapmak 

        public void kisiEkle(string pAdi, string pSoyadi, string pTel)
        {
            Kisi k1 = new Kisi();
            k1.isim = pAdi;
            k1.soyadi = pSoyadi;
            k1.telefon = pTel;
            Data[eklenenElemanSayisi] = k1;
            eklenenElemanSayisi++;

            /*
            kisiler[0].isim = pAdi;
            kisiler[0].soyadi = pSoyadi;
            kisiler[0].telefon = pTel;
            */
        }
        
        public void Listele()
        {
            for (int i = 0; i < eklenenElemanSayisi; i++)
            {
                Console.WriteLine("{0} {1} {2}",Data[i].isim,Data[i].soyadi,Data[i].telefon);
            }
        }
    }
}
