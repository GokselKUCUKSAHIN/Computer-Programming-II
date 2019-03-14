using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev4
{
    class Kutuphane
    {
        const int MaxKapasite = 50; //max kitap sayısı
        public int KitapSayisi = 0; //Toplam Kitap sayısı
        public int eklenenKitap = 0; //eklenen kitap sayısı
        
        Kitap[] Kitaplik = new Kitap[MaxKapasite]; //Kitaplardan oluşan bir "Kitaplik" Dizisi
        public void KitapSil(int Sec)
        {
            Kitaplik[Sec - 1].SahipMi = false;
        }
        public void KitapAktifEt(int Sec)
        {
            Kitaplik[Sec - 1].SahipMi = true;
        }
        public void KitapEkle(string pAdi,string pYazari, string pISBN)
        {
            Kitap Tkitap = new Kitap();
            Tkitap.Adi = pAdi;
            Tkitap.ISBN = pISBN;
            Tkitap.Yazari = pYazari;
            Tkitap.SahipMi = true;
            Kitaplik[eklenenKitap] = Tkitap;
            eklenenKitap++;
            KitapSayisi++;
        }
        public void KitapEkle(string pAdi, string pYazari, string pISBN,bool pSahipMi)
        {
            Kitap Tkitap = new Kitap();
            Tkitap.Adi = pAdi;
            Tkitap.ISBN = pISBN;
            Tkitap.Yazari = pYazari;
            Tkitap.SahipMi = pSahipMi;
            Kitaplik[eklenenKitap] = Tkitap;
            eklenenKitap++;
            KitapSayisi++;
        }
        string Tyazdir;
        string Fyazdir;
        public string PrintOrder(int i)
        {
            if (Kitaplik[i].SahipMi == true)
            {
                Tyazdir = (i + 1) + " -) " + Kitaplik[i].Adi + "\t" + Kitaplik[i].Yazari + "\t" + Kitaplik[i].ISBN;
            }
            else
                Tyazdir = "Q";

            return Tyazdir;
        }
        public string PrintDisorder(int i)
        {
            if (Kitaplik[i].SahipMi == false)
            {
                Fyazdir = (i + 1) + " -) " + Kitaplik[i].Adi + "\t" + Kitaplik[i].Yazari + "\t" + Kitaplik[i].ISBN;
            }
            else
                Fyazdir = "Q";
            return Fyazdir;
        }
        public void PrintItAll()
        {
            for (int i = 0; i < KitapSayisi; i++)
            {
                Console.Write("{0}\t{1}\t{2}", Kitaplik[i].Adi, Kitaplik[i].Yazari, Kitaplik[i].ISBN);
                if (Kitaplik[i].SahipMi == true)
                    Console.Write("\t(Var)\n");
                else
                    Console.Write("\t(Yok)\n");
            }
        }
        public void DirectPrint()
        {
            for (int i = 0; i < KitapSayisi; i++)
            {
                if (Kitaplik[i].SahipMi == true)
                    Console.WriteLine("{0}\t{1}\t{2}", Kitaplik[i].Adi,  Kitaplik[i].Yazari, Kitaplik[i].ISBN);
            }
        }
    }
}
