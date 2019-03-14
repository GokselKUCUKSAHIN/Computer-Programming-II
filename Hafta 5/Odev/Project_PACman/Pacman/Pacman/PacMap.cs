using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pacman
{
    class PacMap
    {
        public static void Map()
        {
            char Nokta = '°';
            //char Dot = '¤';
            char Duz = '║';
            char Yan = '═';
            char g1 = '╣';
            char g2 = '╠';
            char s1 = '╗';
            char s2 = '╔';
            char s3 = '╚';
            char s4 = '╝';
            char j1 = '╦';
            char j2 = '╩';
            //char T = '╬'; //Kullanılmadığı için Deaktif
            
            //
            //Köşeler
            //

            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(1, 20); // sol alt
            Console.Write(Nokta);
            Console.SetCursorPosition(1, 1); // sol üst
            Console.Write(Nokta);
            Console.SetCursorPosition(40, 20); //sağ alt
            Console.Write(Nokta);
            Console.SetCursorPosition(40, 1); // sağ üst
            Console.Write(Nokta);
            //
            //Borular
            //
            Console.ForegroundColor = ConsoleColor.Yellow;
            //Console.BackgroundColor = ConsoleColor.DarkBlue;
            //Sol üst
            Console.SetCursorPosition(3, 1);
            Console.Write(s2);
            Console.SetCursorPosition(3, 2);
            Console.Write(s4);
            Console.SetCursorPosition(2, 2);
            Console.Write(s2);

            //Sağ üst
            Console.SetCursorPosition(38, 1);
            Console.Write(s1);
            Console.SetCursorPosition(38, 2);
            Console.Write(s3);
            Console.SetCursorPosition(39, 2);
            Console.Write(s1);

            //Sol Alt
            Console.SetCursorPosition(2, 19);
            Console.Write(s3);
            Console.SetCursorPosition(3, 19);
            Console.Write(s1);
            Console.SetCursorPosition(3, 20);
            Console.Write(s3);

            //Sağ Alt
            Console.SetCursorPosition(39, 19);
            Console.Write(s4);
            Console.SetCursorPosition(38, 19);
            Console.Write(s2);
            Console.SetCursorPosition(38, 20);
            Console.Write(s4);

            //
            //Düz Borular
            //

            //Üst
            for (int i = 4; i <= 19; i++)
            {
                Console.SetCursorPosition(i, 1);
                Console.Write(Yan);
            }
            for (int i = 22; i <= 37; i++)
            {
                Console.SetCursorPosition(i, 1);
                Console.Write(Yan);
            }
            //Alt
            for (int i = 4; i <= 19; i++)
            {
                Console.SetCursorPosition(i, 20);
                Console.Write(Yan);
            }
            for (int i = 22; i <= 37; i++)
            {
                Console.SetCursorPosition(i, 20);
                Console.Write(Yan);
            }

            //
            //Dikkey Borular
            //
            for (int i = 3; i < 9; i++)
            {
                Console.SetCursorPosition(2, i);
                Console.Write(Duz);
                Console.SetCursorPosition(39, i);
                Console.Write(Duz);
            }
            for (int i = 13; i < 19; i++)
            {
                Console.SetCursorPosition(2, i);
                Console.Write(Duz);
                Console.SetCursorPosition(39, i);
                Console.Write(Duz);
            }

            //
            //Köşeler
            //
            Console.SetCursorPosition(2, 9);
            Console.Write(s3);
            Console.SetCursorPosition(2, 12);
            Console.Write(s2);
            Console.SetCursorPosition(39, 9);
            Console.Write(s4);
            Console.SetCursorPosition(39, 12);
            Console.Write(s1);
            //
            Console.SetCursorPosition(14, 9);
            Console.Write(s4);
            Console.SetCursorPosition(14, 12);
            Console.Write(s1);
            Console.SetCursorPosition(27, 9);
            Console.Write(s3);
            Console.SetCursorPosition(27, 12);
            Console.Write(s2);
            //
            Console.SetCursorPosition(14, 5);
            Console.Write(s1);
            Console.SetCursorPosition(14, 16);
            Console.Write(s4);
            Console.SetCursorPosition(27, 5);
            Console.Write(s2);
            Console.SetCursorPosition(27, 16);
            Console.Write(s3);
            //
            Console.SetCursorPosition(10, 5);//
            Console.Write(g2);

            Console.SetCursorPosition(10, 16);//
            Console.Write(g2);
            Console.SetCursorPosition(31, 5);//
            Console.Write(g1);
            Console.SetCursorPosition(31, 16);//
            Console.Write(g1);
            //
            
            Console.SetCursorPosition(10, 4);//
            Console.Write(s1);
            Console.SetCursorPosition(10, 6);//
            Console.Write(Duz);
            Console.SetCursorPosition(10, 7);//
            Console.Write(s4);
            Console.SetCursorPosition(10, 14);//
            Console.Write(s1);
            Console.SetCursorPosition(10, 17);//
            Console.Write(s4);
            Console.SetCursorPosition(10, 15);//
            Console.Write(Duz);
            Console.SetCursorPosition(31, 4);//
            Console.Write(s2);
            Console.SetCursorPosition(31, 7);//
            Console.Write(s3);
            Console.SetCursorPosition(31, 6);//
            Console.Write(Duz);
            Console.SetCursorPosition(31, 14);//
            Console.Write(s2);
            Console.SetCursorPosition(31, 17);//
            Console.Write(s3);
            Console.SetCursorPosition(31, 15);//
            Console.Write(Duz);
            //

            //
            //Orta Düzlükler
            //
            //Sol Orta
            for (int i = 3; i < 14; i++)
            {
                Console.SetCursorPosition(i, 9);
                Console.Write(Yan);
                Console.SetCursorPosition(i, 12);
                Console.Write(Yan);
            }
            //Sağ Orta
            for (int i = 28; i < 39; i++)
            {
                Console.SetCursorPosition(i, 9);
                Console.Write(Yan);
                Console.SetCursorPosition(i, 12);
                Console.Write(Yan);
            }
            //Üst Orta Dikey 
            for (int i = 6; i < 9; i++)
            {
                Console.SetCursorPosition(14, i);
                Console.Write(Duz);
                Console.SetCursorPosition(27, i);
                Console.Write(Duz);
            }
            //Alt Orta Dikey
            for (int i = 13; i < 16; i++)
            {
                Console.SetCursorPosition(14, i);
                Console.Write(Duz);
                Console.SetCursorPosition(27, i);
                Console.Write(Duz);
            }
            //Sol üst-alt
            for (int i = 7; i < 10; i++)
            {
                Console.SetCursorPosition(i, 4);
                Console.Write(Yan);
                Console.SetCursorPosition(i, 7);
                Console.Write(Yan);
                Console.SetCursorPosition(i, 14);
                Console.Write(Yan);
                Console.SetCursorPosition(i, 17);
                Console.Write(Yan);
            }
            //Sağ üst-alt
            for (int i = 32; i < 35; i++)
            {
                Console.SetCursorPosition(i, 4);
                Console.Write(Yan);
                Console.SetCursorPosition(i, 7);
                Console.Write(Yan);
                Console.SetCursorPosition(i, 14);
                Console.Write(Yan);
                Console.SetCursorPosition(i, 17);
                Console.Write(Yan);
            }
            //Sol Ara bağlantılar
            for (int i = 11; i < 14; i++)
            {
                Console.SetCursorPosition(i, 5);
                Console.Write(Yan);
                Console.SetCursorPosition(i, 16);
                Console.Write(Yan);
            }
            //Sağ Ara bağlantılar
            for (int i = 28; i < 31; i++)
            {
                Console.SetCursorPosition(i, 5);
                Console.Write(Yan);
                Console.SetCursorPosition(i, 16);
                Console.Write(Yan);
            }
            //
            //Orta Bölüm
            //
            Console.SetCursorPosition(20, 7);
            Console.Write(j1);
            Console.SetCursorPosition(21, 7);
            Console.Write(j1);
            Console.SetCursorPosition(20, 14);
            Console.Write(j2);
            Console.SetCursorPosition(21, 14);
            Console.Write(j2);
            //
            Console.SetCursorPosition(22, 7);
            Console.Write(Yan);
            Console.SetCursorPosition(19, 7);
            Console.Write(Yan);
            Console.SetCursorPosition(22, 14);
            Console.Write(Yan);
            Console.SetCursorPosition(19, 14);
            Console.Write(Yan);
            //
            Console.SetCursorPosition(18, 7);
            Console.Write(g2);
            Console.SetCursorPosition(23, 7);
            Console.Write(g1);
            Console.SetCursorPosition(18, 14);
            Console.Write(g2);
            Console.SetCursorPosition(23, 14);
            Console.Write(g1);
            //
            Console.SetCursorPosition(17, 7);
            Console.Write(Duz);
            Console.SetCursorPosition(24, 7);
            Console.Write(Duz);
            Console.SetCursorPosition(17, 14);
            Console.Write(Duz);
            Console.SetCursorPosition(24, 14);
            Console.Write(Duz);
            //
            //4. Kat
            //
            Console.SetCursorPosition(17, 6);
            Console.Write(s2);
            Console.SetCursorPosition(18, 6);
            Console.Write(s1);
            Console.SetCursorPosition(23, 6);
            Console.Write(s2);
            Console.SetCursorPosition(24, 6);
            Console.Write(s1);
            //
            //3. Kat
            //
            Console.SetCursorPosition(17, 8);
            Console.Write(s3);
            Console.SetCursorPosition(18, 8);
            Console.Write(s4);
            Console.SetCursorPosition(23, 8);
            Console.Write(s3);
            Console.SetCursorPosition(24, 8);
            Console.Write(s4);
            //
            //2. Kat
            //
            Console.SetCursorPosition(17, 13);
            Console.Write(s2);
            Console.SetCursorPosition(18, 13);
            Console.Write(s1);
            Console.SetCursorPosition(23, 13);
            Console.Write(s2);
            Console.SetCursorPosition(24, 13);
            Console.Write(s1);
            //
            //1. Kat
            //
            Console.SetCursorPosition(17, 15);
            Console.Write(s3);
            Console.SetCursorPosition(18, 15);
            Console.Write(s4);
            Console.SetCursorPosition(23, 15);
            Console.Write(s3);
            Console.SetCursorPosition(24, 15);
            Console.Write(s4);
            //
            //Ara bağlantı
            //
            for (int i = 8; i < 14; i++)
            {
                Console.SetCursorPosition(20, i);
                Console.Write(Duz);
                Console.SetCursorPosition(21, i);
                Console.Write(Duz);
            }
            //
            //Dik Çıkıntılar
            //

            //Alt
            Console.SetCursorPosition(20, 20);
            Console.Write(s4);
            Console.SetCursorPosition(21, 20);
            Console.Write(s3);

            //Üst
            Console.SetCursorPosition(20, 1);
            Console.Write(s1);
            Console.SetCursorPosition(21, 1);
            Console.Write(s2);

            //Üst Link
            for (int i = 2; i < 4; i++)
            {
                Console.SetCursorPosition(20, i);
                Console.Write(Duz);
                Console.SetCursorPosition(21, i);
                Console.Write(Duz);
            }

            //Alt Link
            for (int i = 18; i < 20; i++)
            {
                Console.SetCursorPosition(20, i);
                Console.Write(Duz);
                Console.SetCursorPosition(21, i);
                Console.Write(Duz);
            }

            //Üst Kapak
            Console.SetCursorPosition(20, 4);
            Console.Write(s3);
            Console.SetCursorPosition(21, 4);
            Console.Write(s4);

            //Alt Kapak
            Console.SetCursorPosition(20, 17);
            Console.Write(s2);
            Console.SetCursorPosition(21, 17);
            Console.Write(s1);
        }
    }
}