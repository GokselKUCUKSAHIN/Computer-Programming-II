using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Project_19
{
    //isim-soyisim-numara
    //telefonRehberi Kişiler
    //Rehberin max kapasitesi var
    //kişi ve numara bulma

    class Program
    {
        static void Main(string[] args)
        {
            TelefonReh defterim = new TelefonReh();
            defterim.kisiEkle("Ali", "Demir", "123");
            defterim.kisiEkle("Ahmet", "Güneş", "456");
            defterim.kisiEkle("Ayşe", "Deniz", "789");
            defterim.kisiEkle("Jelly", "Beanci", "147");
            defterim.Listele();
            Console.ReadKey();
        }

    }
}
