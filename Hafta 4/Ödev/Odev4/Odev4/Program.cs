using System;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.Write("\t\tProject_Null\n\n");
            Kutuphane Book = new Kutuphane();
            //
            //
            Book.KitapEkle("Kürk Mantolu Madonna", "Sabahattin Ali", "9782268061313");
            Book.KitapEkle("Küçük Prens", "Antoine de Saint-Exupéry", "9788995317471");
            Book.KitapEkle("Uçurtma Avcısı", "Halit Hüseyni", "9789867475657");
            Book.KitapEkle("Dönüşüm", "Franz Kafka", "9783458352419");
            Book.KitapEkle("Simyacı", "Paulo Coelho", "9788576653721");
            Book.KitapEkle("JELLY", "Beanci", "17004453",false);
            //Console.WriteLine("Kitabın Adı/\t\t\tKitabın ISBN/\t\t\tKitabın Yazarı");
            //
            //
            int Secim = 0;
            int Sil;
            string Input;
            string mAdi,mYazar,mIsbn;
            bool valid;
            do
            {
                Console.Clear();
                Console.Write("YAZILIMA HOŞ GELDİNİZ.\n\n" +
                    "1- Tüm Kitapları Göster\n" +
                    "2- Mevcut Kitapları Göster\n" +
                    //"3- Kitap Ödünç Al\n" +
                    //"4- Ödünç Alınmış Kitabı Ver\n" +
                    "3- Kitap Ekle\n" +
                    "4- Kitap Çıkar\n" +
                    "5- Hakkında\n" +
                    "6- Çıkış Yap!\n" +
                    "\nSeçim --> ");
                
                Input = Console.ReadLine();
                try
                {
                    Secim = Int32.Parse(Input);
                }
                catch
                {
                    //Console.WriteLine("Error C0DE: 0x03");
                    Secim = 0;
                }

                Console.Clear(); //Clear Screen
                //Console.WriteLine(Secim);
                switch (Secim)
                {
                    case 0:
                        {
                            Console.Write("Boş ya da Hatalı Giriş!!!\nDevam Etmek için bir tuşa basın: ");
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        }
                    case 1:
                        {
                            Book.PrintItAll();
                            Console.ReadKey();
                            break;
                        }
                    case 2:
                        {
                            Book.DirectPrint();
                            Console.ReadKey();
                            break;
                        }
                    case 3:
                        {
                            int sec = 0;
                            Console.Write("1-) Yeni Kitap Ekle\n2-) Var olan bir kitabı Ekle\nSec -> ");
                            try
                            {
                                sec = Int32.Parse(Console.ReadLine());
                            }
                            catch
                            {
                                Console.WriteLine("HATA");
                                Thread.Sleep(400);
                                break;
                            }
                            switch (sec)
                            {
                                case 1:
                                    {
                                        valid = true;
                                        Console.Write("Kitap Ekle\n\nKitabın Adı: ");
                                        mAdi = Console.ReadLine().ToString();
                                        if (mAdi == "")
                                        {
                                            Console.Write("İsim Girmediniz: ");
                                            mAdi = Console.ReadLine().ToString();
                                            if (mAdi == "")
                                            {
                                                valid = false;
                                            }
                                        }
                                        Console.Write("Kitabın Yazarı: ");
                                        mYazar = Console.ReadLine().ToString();
                                        if (mYazar == "" || valid != true)
                                        {
                                            Console.Write("Yazarı Girmediniz: ");
                                            mYazar = Console.ReadLine().ToString();
                                            if (mYazar == "")
                                            {
                                                valid = false;
                                            }
                                        }
                                        Console.Write("Kitabın ISBN numarası: ");
                                        mIsbn = Console.ReadLine().ToString();
                                        if (mIsbn == "" || valid != true)
                                        {
                                            Console.Write("ISBN Girmediniz: ");
                                            mIsbn = Console.ReadLine().ToString();
                                            if (mIsbn == "")
                                            {
                                                valid = false;
                                            }
                                        }
                                        if (valid == true)
                                        {
                                            Book.KitapEkle(mAdi, mYazar, mIsbn);
                                        }
                                        else
                                        {
                                            Console.WriteLine("\nBir Alan Boş olduğu için Kayıt edilmedi!");
                                            Thread.Sleep(600);
                                        }
                                        break;
                                    }
                                case 2:
                                    {
                                        Console.WriteLine("Var Olmayan Kitaplar:\n");
                                        string Temp;
                                        for (int i = 0; i < Book.KitapSayisi; i++)
                                        {
                                            Temp = Book.PrintDisorder(i);
                                            if (Temp != "Q")
                                                Console.WriteLine(Temp);
                                        }
                                        Console.Write("\nEklemek İstediğiniz Kitabın Numarasını Girin -> ");
                                        try
                                        {
                                            Sil = Int32.Parse(Console.ReadLine());
                                        }
                                        catch
                                        {
                                            Console.WriteLine("Tekrar deneyin Eğer Yanlış girerseniz işlem iptal olacak!");
                                            Console.Write("Numara -> ");
                                            try
                                            {
                                                Sil = Int32.Parse(Console.ReadLine());
                                            }
                                            catch
                                            {
                                                break;
                                            }
                                        }
                                        //Console.WriteLine(Sil);
                                        //
                                        // if Control
                                        //

                                        Book.KitapAktifEt(Sil);

                                        break;
                                    }
                                default:
                                    {
                                        Console.WriteLine("Geçersiz Giriş");
                                        Thread.Sleep(800);
                                        break;
                                    }
                            }
                            break;
                        }
                    case 4:
                        {
                            Console.WriteLine("Var Olan Kitaplar:\n");
                            string Temp;
                            for (int i = 0; i < Book.KitapSayisi; i++)
                            {
                                Temp = Book.PrintOrder(i);
                                if (Temp != "Q")
                                    Console.WriteLine(Temp);
                            }
                            Console.Write("\nSilmek İstediğiniz Kitabın Numarasını Girin -> ");
                            try
                            {
                                Sil = Int32.Parse(Console.ReadLine());
                            }
                            catch
                            {
                                Console.WriteLine("Tekrar deneyin Eğer Yanlış girerseniz işlem iptal olacak!");
                                Console.Write("Numara -> ");
                                try
                                {
                                    Sil = Int32.Parse(Console.ReadLine());
                                }
                                catch
                                {
                                    break;
                                }
                            }
                            //
                            // if Control
                            //
                            Book.KitapSil(Sil);
                            //Console.ReadKey();
                            break;
                        }
                    case 5:
                        {
                            Console.WriteLine("Bu Program, Programlama-II dersi için Göksel Küçükşahin Tarafından Yazılmıştır.");
                            Console.ReadKey();
                            break;
                        }
                    case 6:
                        {
                            Console.WriteLine("Çıkış Yapılıyor...");
                            Thread.Sleep(400);
                            break;
                        }
                    default:
                        {
                            Console.Write("Doğru Seçim Yapmadınız! Lüften Tekrar deneyiniz!");
                            Thread.Sleep(1000);
                            break;
                        }
                }
            }
            while (Secim != 6);
            //Console.ReadKey();
        }
    }
}