using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_27
{
    class Program
    {
        static void Main(string[] args)
        {
            //iki tam sayı al
            //birinciyi ikinciye böl
            //sonucu yaz
            
            try
            {
                Console.Write("Birinci Sayı: ");
                int say1 = Int32.Parse(Console.ReadLine());
                Console.Write("İkinci Sayı: ");
                int say2 = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Sonuc = " + say1 / say2);
            }
            catch(DivideByZeroException)
            {
                Console.WriteLine("Sayı Bölü Sıfır Hatası");
            }
            catch(FormatException)
            {
                Console.WriteLine("Bir Sayı girin");
            }
            catch(OverflowException)
            {
                Console.WriteLine("Max Limit Üstünde değer Girişi");
            }
            catch
            {
                Console.WriteLine("Hata");
            }
            finally
            {
                Console.WriteLine("Merhaba Dünya");
            }
        }
    }
}
