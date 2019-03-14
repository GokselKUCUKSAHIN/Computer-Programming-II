using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_26
{
    class Ders
    {
        public byte Vize;
        public byte Final;
        public byte Kredi;
        public string Adi;

        public void yaz()
        {
            Console.WriteLine("{0} K:{1} V:{2} F:{3}",Adi,Kredi,Vize,Final);
        }
        public bool DersBul(string Search)
        {
            if (Adi == Search)
                return true;
            else
                return false;
        }
    }
}