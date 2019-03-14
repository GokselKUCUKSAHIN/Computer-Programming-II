using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace Pacman
{
    class Pacman
    {
        
        public int X = 3;
        public int Y = 11;
        public int tX = 18;
        public int tY = 10;
        public int Score = 0;
        //int[,] DuvarXY = new int[400,2];
        //© O C
        char[] head = new char[4] { 'C', '©', 'O', '©' };
        private int Kcount = 0;
        private char PAC;
        public void PacManCiz()
        {
            //Console.BackgroundColor = ConsoleColor.Black;
            
            if (Kcount == 0)
            {
                PAC = head[Kcount];
                Kcount++;
            }
            else if (Kcount == 1)
            {
                PAC = head[Kcount];
                Kcount++;
            }
            else if (Kcount == 2)
            {
                PAC = head[Kcount];
                Kcount++;
            }
            else if (Kcount == 3)
            {
                PAC = head[Kcount];
                Kcount = 0;
            }
            //Console.Clear();
            Console.SetCursorPosition(X, Y);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(PAC);
        }
        public void PacMove(ConsoleKeyInfo tus)
        {
            if (tus.Key == ConsoleKey.RightArrow)
            {
                if (Hit(X + 1, Y) == true)
                {
                    Console.SetCursorPosition(X, Y);
                    Console.Write(" ");
                    
                    X++;
                }
                else
                {
                    Console.SetCursorPosition(X, Y);
                    Console.Write(" ");
                    
                }
            }
            else if (tus.Key == ConsoleKey.LeftArrow)
            {
                
                if (Hit(X-1, Y) == true)
                {
                    Console.SetCursorPosition(X, Y);
                    Console.Write(" ");
                    X--;
                }
                else
                {
                    Console.SetCursorPosition(X, Y);
                    Console.Write(" ");
                    
                }

            }
            else if (tus.Key == ConsoleKey.UpArrow)
            {
                if (Hit(X, Y-1) == true)
                {
                    Console.SetCursorPosition(X, Y);
                    Console.Write(" ");
                    Y--;
                }
                else
                {
                    Console.SetCursorPosition(X, Y);
                    Console.Write(" ");
                    
                }

            }
            else if (tus.Key == ConsoleKey.DownArrow)
            {
                
                if (Hit(X, Y+1) == true)
                {
                    Console.SetCursorPosition(X, Y);
                    Console.Write(" ");
                    Y++;
                }
                else
                {
                    Console.SetCursorPosition(X, Y);
                    Console.Write(" ");
                    
                }

            }
            if (X > 40)
            {
                Console.SetCursorPosition(X, Y);
                Console.Write(" ");
                
                X = 40;
                
            }
            else if (X < 1)
            {
                Console.SetCursorPosition(X, Y);
                Console.Write(" ");
                
                X = 1;
                
            }
            else if (Y > 19)
            {
                Console.SetCursorPosition(X, Y);
                Console.Write(" ");
                Y = 19;
            }
            else if (Y < 2)
            {
                Console.SetCursorPosition(X, Y);
                Console.Write(" ");
                Y = 2;
            }
        }
        private void GoWhile(byte Pos)
        {
            int Speed = 1;

            if (Pos == 4)
            {
                if (Hit(X + 1, Y) == true)
                    X += Speed;
               
            }
            else if (Pos == 2)
            {
                if (Hit(X - 1, Y) == true)
                    X -= Speed;
                
            }
            else if (Pos == 3)
            {
                if (Hit(X, Y + 1) == true)
                    Y += Speed;
               
            }
            else if (Pos == 1)
            {
                if (Hit(X, Y - 1) == true)
                    Y -= Speed;

            }
        }
        public void PacMove(ConsoleKeyInfo tus,bool OK)
        {
            if (tus.Key == ConsoleKey.RightArrow)
            {
                GoWhile(4);
            }
            else if (tus.Key == ConsoleKey.LeftArrow)
            {

                GoWhile(2);
            }
            else if (tus.Key == ConsoleKey.UpArrow)
            {
                GoWhile(1);
            }
            else if (tus.Key == ConsoleKey.DownArrow)
            {

                GoWhile(3);
            }
            if (X > 40)
            {
                X = 40;
            }
            else if (X < 1)
            {
                X = 1;
            }
            else if (Y > 19)
            {
                Y = 19;
            }
            else if (Y < 2)
            {
                Y = 2;
            }
        }

        public bool Hit(int px, int py)
        {
            bool ret = true;
            //if (((px >= 19) && (px <= 22)) && ((py >= 6) && (py <= 15)))
            if ((px == 14) && (py == 9))
                ret = false;
            //
            //Köşeler
            //
            else if ((px == 3) && (py == 2))
                ret = false;
            else if ((px == 3) && (py == 19))
                ret = false;
            else if ((px == 38) && (py == 2))
                ret = false;
            else if ((px == 38) && (py == 19))
                ret = false;
            //
            //Sol üst
            //
            else if ((px == 13) && (py == 9))
                ret = false;
            else if ((px == 12) && (py == 9))
                ret = false;
            else if ((px == 11) && (py == 9))
                ret = false;
            else if ((px == 10) && (py == 9))
                ret = false;
            else if ((px == 9) && (py == 9))
                ret = false;
            else if ((px == 8) && (py == 9))
                ret = false;
            else if ((px == 7) && (py == 9))
                ret = false;
            else if ((px == 6) && (py == 9))
                ret = false;
            else if ((px == 5) && (py == 9))
                ret = false;
            else if ((px == 4) && (py == 9))
                ret = false;
            else if ((px == 3) && (py == 9))
                ret = false;
            else if ((px == 2) && (py == 9))
                ret = false;
            else if ((px == 1) && (py == 9))
                ret = false;
            else if ((px == 14) && (py == 8))
                ret = false;
            else if ((px == 14) && (py == 7))
                ret = false;
            else if ((px == 14) && (py == 6))
                ret = false;
            else if ((px == 14) && (py == 5))
                ret = false;
            else if ((px == 13) && (py == 5))
                ret = false;
            else if ((px == 12) && (py == 5))
                ret = false;
            else if ((px == 11) && (py == 5))
                ret = false;
            else if ((px == 10) && (py == 5))
                ret = false;
            else if ((px == 9) && (py == 4))
                ret = false;
            else if ((px == 8) && (py == 4))
                ret = false;
            else if ((px == 7) && (py == 4))
                ret = false;
            else if ((px == 10) && (py == 4))
                ret = false;
            else if ((px == 9) && (py == 7))
                ret = false;
            else if ((px == 8) && (py == 7))
                ret = false;
            else if ((px == 7) && (py == 7))
                ret = false;
            else if ((px == 10) && (py == 6))
                ret = false;
            else if ((px == 10) && (py == 7))
                ret = false;
            

           


            //sol üst kenar
            else if ((px == 2) && (py == 8))
                ret = false;
            else if ((px == 2) && (py == 7))
                ret = false;
            else if ((px == 2) && (py == 6))
                ret = false;
            else if ((px == 2) && (py == 5))
                ret = false;
            else if ((px == 2) && (py == 4))
                ret = false;
            else if ((px == 2) && (py == 3))
                ret = false;
            //
            //Sol alt
            //
            else if ((px == 2) && (py == 12))
                ret = false;
            else if ((px == 3) && (py == 12))
                ret = false;
            else if ((px == 4) && (py == 12))
                ret = false;
            else if ((px == 5) && (py == 12))
                ret = false;
            else if ((px == 6) && (py == 12))
                ret = false;
            else if ((px == 7) && (py == 12))
                ret = false;
            else if ((px == 8) && (py == 12))
                ret = false;
            else if ((px == 9) && (py == 12))
                ret = false;
            else if ((px == 10) && (py == 12))
                ret = false;
            else if ((px == 11) && (py == 12))
                ret = false;
            else if ((px == 12) && (py == 12))
                ret = false;
            else if ((px == 13) && (py == 12))
                ret = false;
            else if ((px == 14) && (py == 12))
                ret = false;
            else if ((px == 14) && (py == 13))
                ret = false;
            else if ((px == 14) && (py == 14))
                ret = false;
            else if ((px == 14) && (py == 15))
                ret = false;
            else if ((px == 14) && (py == 16))
                ret = false;
            else if ((px == 13) && (py == 16))
                ret = false;
            else if ((px == 12) && (py == 16))
                ret = false;
            else if ((px == 11) && (py == 16))
                ret = false;
            else if ((px == 10) && (py == 16))
                ret = false;
            else if ((px == 10) && (py == 15))//
                ret = false;
            else if ((px == 9) && (py == 17))
                ret = false;
            else if ((px == 9) && (py == 14))
                ret = false;
            else if ((px == 8) && (py == 14))
                ret = false;
            else if ((px == 7) && (py == 14))
                ret = false;
            else if ((px == 8) && (py == 17))
                ret = false;
            else if ((px == 7) && (py == 17))
                ret = false;
            else if ((px == 10) && (py == 17))
                ret = false;
            //Sol Alt Kenar
            else if ((px == 1) && (py == 12))
                ret = false;
            else if ((px == 2) && (py == 13))
                ret = false;
            else if ((px == 2) && (py == 14))
                ret = false;
            else if ((px == 2) && (py == 15))
                ret = false;
            else if ((px == 2) && (py == 16))
                ret = false;
            else if ((px == 2) && (py == 17))
                ret = false;
            else if ((px == 2) && (py == 18))
                ret = false;
            else if ((px == 2) && (py == 19))
                ret = false;
            //
            //Sağ üst
            //

            else if ((px == 27) && (py == 9))
                ret = false;
            else if ((px == 28) && (py == 9))
                ret = false;
            else if ((px == 29) && (py == 9))
                ret = false;
            else if ((px == 30) && (py == 9))
                ret = false;
            else if ((px == 31) && (py == 9))
                ret = false;
            else if ((px == 32) && (py == 9))
                ret = false;
            else if ((px == 33) && (py == 9))
                ret = false;
            else if ((px == 34) && (py == 9))
                ret = false;
            else if ((px == 35) && (py == 9))
                ret = false;
            else if ((px == 36) && (py == 9))
                ret = false;
            else if ((px == 37) && (py == 9))
                ret = false;
            else if ((px == 38) && (py == 9))
                ret = false;
            else if ((px == 39) && (py == 9))
                ret = false;
            else if ((px == 40) && (py == 9))
                ret = false;
            //
            else if ((px == 27) && (py == 8))
                ret = false;
            else if ((px == 27) && (py == 7))
                ret = false;
            else if ((px == 27) && (py == 6))
                ret = false;
            else if ((px == 27) && (py == 5))
                ret = false;
            else if ((px == 28) && (py == 5))
                ret = false;
            else if ((px == 29) && (py == 5))
                ret = false;
            else if ((px == 30) && (py == 5))
                ret = false;
            else if ((px == 31) && (py == 7))
                ret = false;
            else if ((px == 31) && (py == 6))
                ret = false;
            else if ((px == 31) && (py == 5))
                ret = false;
            else if ((px == 31) && (py == 4))
                ret = false;
            else if ((px == 32) && (py == 7))
                ret = false;
            else if ((px == 33) && (py == 7))
                ret = false;
            else if ((px == 34) && (py == 7))
                ret = false;
            else if ((px == 32) && (py == 4))
                ret = false;
            else if ((px == 33) && (py == 4))
                ret = false;
            else if ((px == 34) && (py == 4))
                ret = false;
            //Sağ üst kenar
            else if ((px == 39) && (py == 3))
                ret = false;
            else if ((px == 39) && (py == 4))
                ret = false;
            else if ((px == 39) && (py == 5))
                ret = false;
            else if ((px == 39) && (py == 6))
                ret = false;
            else if ((px == 39) && (py == 7))
                ret = false;
            else if ((px == 39) && (py == 8))
                ret = false;
            //
            //Sağ Alt
            //
            else if ((px == 27) && (py == 12))
                ret = false;
            else if ((px == 28) && (py == 12))
                ret = false;
            else if ((px == 29) && (py == 12))
                ret = false;
            else if ((px == 30) && (py == 12))
                ret = false;
            else if ((px == 31) && (py == 12))
                ret = false;
            else if ((px == 32) && (py == 12))
                ret = false;
            else if ((px == 33) && (py == 12))
                ret = false;
            else if ((px == 34) && (py == 12))
                ret = false;
            else if ((px == 35) && (py == 12))
                ret = false;
            else if ((px == 36) && (py == 12))
                ret = false;
            else if ((px == 37) && (py == 12))
                ret = false;
            else if ((px == 38) && (py == 12))
                ret = false;
            else if ((px == 39) && (py == 12))
                ret = false;
            else if ((px == 40) && (py == 12))
                ret = false;
            else if ((px == 27) && (py == 13))
                ret = false;
            else if ((px == 27) && (py == 14))
                ret = false;
            else if ((px == 27) && (py == 15))
                ret = false;
            else if ((px == 27) && (py == 16))
                ret = false;

            else if ((px == 28) && (py == 16))
                ret = false;
            else if ((px == 29) && (py == 16))
                ret = false;
            else if ((px == 30) && (py == 16))
                ret = false;
            else if ((px == 31) && (py == 16))
                ret = false;

            else if ((px == 31) && (py == 17))
                ret = false;
            else if ((px == 32) && (py == 17))
                ret = false;
            else if ((px == 33) && (py == 17))
                ret = false;
            else if ((px == 34) && (py == 17))
                ret = false;
            else if ((px == 31) && (py == 15))
                ret = false;
            else if ((px == 31) && (py == 14))
                ret = false;
            else if ((px == 32) && (py == 14))
                ret = false;
            else if ((px == 33) && (py == 14))
                ret = false;
            else if ((px == 34) && (py == 14))
                ret = false;
            
            //sol alt kenar
            else if ((px == 39) && (py == 13))
                ret = false;
            else if ((px == 39) && (py == 14))
                ret = false;
            else if ((px == 39) && (py == 15))
                ret = false;
            else if ((px == 39) && (py == 16))
                ret = false;
            else if ((px == 39) && (py == 17))
                ret = false;
            else if ((px == 39) && (py == 18))
                ret = false;
            else if ((px == 39) && (py == 19))
                ret = false;
            //
            //Üst Çıkıntı
            //
            else if ((px == 20) && (py == 2))
                ret = false;
            else if ((px == 20) && (py == 3))
                ret = false;
            else if ((px == 20) && (py == 4))
                ret = false;
            else if ((px == 21) && (py == 2))
                ret = false;
            else if ((px == 21) && (py == 3))
                ret = false;
            else if ((px == 21) && (py == 4))
                ret = false;
            //
            //Alt Çıkıntı
            //
            else if ((px == 20) && (py == 17))
                ret = false;
            else if ((px == 20) && (py == 18))
                ret = false;
            else if ((px == 20) && (py == 19))
                ret = false;
            else if ((px == 21) && (py == 17))
                ret = false;
            else if ((px == 21) && (py == 18))
                ret = false;
            else if ((px == 21) && (py == 19))
                ret = false;
            //
            //TELEPORT
            //
            else if (((px == 1) && (py == 10)) || ((px == 1) && (py == 11)))
            {
                Console.SetCursorPosition(X, Y);
                Console.Write(" ");
                X = 40;
                ret = false;
                
                
            }
            else if (((px == 40) && (py == 10)) || ((px == 40) && (py == 11)))
            {
                Console.SetCursorPosition(X, Y);
                Console.Write(" ");
                X = 1;
                ret = false;
                
            }
            //
            //Orta Bölüm
            //
            else if ((px == 17) && (py == 6))
                ret = false;
            else if ((px == 17) && (py == 7))
                ret = false;
            else if ((px == 17) && (py == 8))
                ret = false;
            else if ((px == 18) && (py == 6))
                ret = false;
            else if ((px == 18) && (py == 8))
                ret = false;
            else if ((px == 24) && (py == 6))
                ret = false;
            else if ((px == 24) && (py == 7))
                ret = false;
            else if ((px == 24) && (py == 8))
                ret = false;
            else if ((px == 23) && (py == 6))
                ret = false;
            else if ((px == 23) && (py == 8))
                ret = false;
            else if ((px == 19) && (py == 7))
                ret = false;
            else if ((px == 20) && (py == 7))
                ret = false;
            else if ((px == 21) && (py == 7))
                ret = false;
            else if ((px == 22) && (py == 7))
                ret = false;
            else if ((px == 20) && (py == 8))
                ret = false;
            else if ((px == 20) && (py == 9))
                ret = false;
            else if ((px == 20) && (py == 10))
                ret = false;
            else if ((px == 20) && (py == 11))
                ret = false;
            else if ((px == 20) && (py == 12))
                ret = false;
            else if ((px == 20) && (py == 13))
                ret = false;
            else if ((px == 21) && (py == 8))
                ret = false;
            else if ((px == 21) && (py == 9))
                ret = false;
            else if ((px == 21) && (py == 10))
                ret = false;
            else if ((px == 21) && (py == 11))
                ret = false;
            else if ((px == 21) && (py == 12))
                ret = false;
            else if ((px == 21) && (py == 13))
                ret = false;
            else if ((px == 19) && (py == 14))
                ret = false;
            else if ((px == 20) && (py == 14))
                ret = false;
            else if ((px == 21) && (py == 14))
                ret = false;
            else if ((px == 22) && (py == 14))
                ret = false;
            else if ((px == 17) && (py == 13))
                ret = false;
            else if ((px == 17) && (py == 14))
                ret = false;
            else if ((px == 17) && (py == 15))
                ret = false;
            else if ((px == 18) && (py == 13))
                ret = false;
            else if ((px == 18) && (py == 15))
                ret = false;
            else if ((px == 24) && (py == 13))
                ret = false;
            else if ((px == 24) && (py == 14))
                ret = false;
            else if ((px == 24) && (py == 15))
                ret = false;
            else if ((px == 23) && (py == 13))
                ret = false;
            else if ((px == 23) && (py == 15))
                ret = false;
            //
            //Legit WAY
            //
            else
                ret = true;
            return ret;
        }
        public void PrintScore()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.SetCursorPosition(0, 22);
            Console.Write("Score: " + Score);
        }
    }
}