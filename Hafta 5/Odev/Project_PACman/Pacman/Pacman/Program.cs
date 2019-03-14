using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Media;

namespace Pacman
{
    class Program
    {
        static void Main()
        {

            //İmleci Görünmez yapmak için
            Console.CursorVisible = false;

            //
            //Sound Effects
            //
            
            SoundPlayer Walk = new SoundPlayer();
            Walk.SoundLocation = Environment.CurrentDirectory + "\\SFX/Walk.wav";
            SoundPlayer Gover = new SoundPlayer();
            Gover.SoundLocation = Environment.CurrentDirectory + "\\SFX/GameOver.wav";
            SoundPlayer Victory = new SoundPlayer();
            Victory.SoundLocation = Environment.CurrentDirectory + "\\SFX/Victory.wav";

            //
            //LOADING
            //

            Loading();
            //
            //Mega Yem
            //
            Yem[] Yemlik = new Yem[6];
            int[,] Konum = new int[6, 2] { { 9, 5 }, { 9, 16 }, { 32, 5 }, { 32, 16 }, { 19, 2 }, { 22, 19 } };
            for (int i = 0; i < 6; i++)
            {
                Yem k1 = new Yem();
                k1.X = Konum[i,0];
                k1.Y = Konum[i, 1];
                Yemlik[i] = k1;
            }
            //
            //Mini Yem
            //
            MiniYem[] Puan = new MiniYem[22];
            int[,] Local = new int[22, 2] { { 11, 4 }, { 11, 6 }, { 30, 4 }, { 30, 6 }, { 19, 8 }, { 22, 8 }, { 11, 15 }, { 11, 17 }, { 30, 15 }, { 30, 17 }, { 19, 13 }, { 22, 13 }, { 3, 8 }, { 38, 8 }, { 3, 13 }, { 38, 13 }, { 18, 3 }, { 23, 18 }, { 4, 5 }, { 4, 16 }, { 37, 5 }, { 37, 16 } };
            //{18,3},{23,18},{4,5},{4,16},{37,5},{37,16}

            Pacman CLU = new Pacman();
            for (int i = 0; i < 22; i++)
            {
                MiniYem k2 = new MiniYem();
                k2.X = Local[i, 0];
                k2.Y = Local[i, 1];
                Puan[i] = k2;
            }

            //
            //Green Ghost Object
            //
            Ghost Enemy = new Ghost();
            Enemy.X = 15;
            Enemy.Y = 18;
            Enemy.BColor = ConsoleColor.Green;
            Enemy.FColor = ConsoleColor.DarkMagenta;
            int AdımX = 15;
            int AdımY = 18;
            byte flag = 0;

            //
            //Red Ghost Object
            //
            Ghost Jelly = new Ghost();
            Jelly.X = 15;
            Jelly.Y = 18;
            Jelly.BColor = ConsoleColor.Red;
            Jelly.FColor = ConsoleColor.Gray;
            int StepX = 26;
            int StepY = 3;
            byte Bayrak = 0;

            bool Game = true;
            ConsoleKeyInfo Key = Console.ReadKey();
            
            bool isKeyPressed = false;
            Console.Clear();
            //Menu.Stop();
            DrawFrame();
            PacMap.Map();
            //bool Game = false;
            Walk.PlayLooping();
            while (Game)
            {

                //PacMap.Map();
                //Key = Console.ReadKey();

                CLU.PacMove(Key);
                if (Console.KeyAvailable)
                {
                    Key = Console.ReadKey();
                    isKeyPressed = true;
                }
                else
                    isKeyPressed = false;
                CLU.PacMove(Key, isKeyPressed);
                CLU.PacManCiz();
                
                //
                //Green Ghost
                //
                Enemy.tX = Enemy.X;
                Enemy.tY = Enemy.Y;
                Enemy.X = AdımX;
                Enemy.Y = AdımY;

                if (((Enemy.X == CLU.X) && (Enemy.Y == CLU.Y)) || ((Enemy.tX == CLU.X) && (Enemy.tY == CLU.X)) || ((Enemy.X == CLU.tX) && (Enemy.X == CLU.tY)) || ((Enemy.tX == CLU.tX) && (Enemy.tY == CLU.tY))) 
                {
                    Gover.Play();
                    Game = false;
                    
                }
                Enemy.Ciz();
                Enemy.Move(Enemy.tX,Enemy.tY);

                if (flag == 0)
                {
                    AdımY--;
                    AdımX = 15;
                    if (AdımY <=3 )
                        flag = 1;
                } 
                else if(flag == 1)
                {
                    AdımY = 3;
                    AdımX--;
                    if (AdımX <= 7)
                        flag = 2;
                }
                else if(flag == 2)
                {
                    AdımY = 3;
                    AdımX++;
                    if (AdımX >= 15)
                        flag = 3;
                }
                else if(flag ==3)
                {
                    AdımY++;
                    AdımX = 15;
                    if (AdımY >= 18)
                        flag = 0;
                }
                //


                //
                //Red Ghost
                //
                Jelly.tX = Jelly.X;
                Jelly.tY = Jelly.Y;
                Jelly.X = StepX;
                Jelly.Y = StepY;

                if ((Jelly.X == CLU.X) && (Jelly.Y == CLU.Y))
                {
                    Gover.Play();
                    Game = false;
                    
                }
                Jelly.Ciz();
                Jelly.Move(Jelly.tX, Jelly.tY);

                if (Bayrak == 0)
                {
                    StepY++;
                    StepX = 26;
                    if (StepY >= 18)
                        Bayrak = 1;
                }
                else if (Bayrak == 1)
                {
                    StepY = 18;
                    StepX++;
                    if (StepX >= 34)
                        Bayrak = 2;
                }
                else if (Bayrak == 2)
                {
                    StepY = 18;
                    StepX--;
                    if (StepX <= 26)
                        Bayrak = 3;
                }
                else if (Bayrak == 3)
                {
                    StepY--;
                    StepX = 26;
                    if (StepY <= 3)
                        Bayrak = 0;
                }
                //

                //PacMap
                PacMap.Map();
                for (int i = 0; i < 6; i++)
                {
                    Yemlik[i].YemCiz();
                    if(((Yemlik[i].X == CLU.X) && (Yemlik[i].Y == CLU.Y)) && (Yemlik[i].Exist == true))
                    {
                        Yemlik[i].Exist = false;
                        CLU.PacManCiz();
                        CLU.Score+= 20;
                        //Walk.Play();
                    }
                }
                //
                for (int i = 0; i < 22; i++)
                {
                    Puan[i].YemCiz();
                    if (((Puan[i].X == CLU.X) && (Puan[i].Y == CLU.Y)) && (Puan[i].Exist == true))
                    {
                        Puan[i].Exist = false;
                        CLU.PacManCiz();
                        CLU.Score += 5;
                        //Walk.Play();
                    }
                }
                //
                //DrawFrame
                DrawFrame();
                //Thread.Sleep(20);
                CLU.PrintScore();
                //
                //Score Limit
                //
                if (CLU.Score >= 230)
                {
                    Walk.Stop();
                    Victory.Play();
                    Game = false;
                }
                Thread.Sleep(100);
            }
            
            if (CLU.Score < 230)
                GameOver(CLU.Score);
            else
                GameWon(CLU.Score);
            bool ReGame = Replay();
            if (ReGame == true)
                Main();
            else
                Environment.Exit(0);
        }
        static void DrawFrame()
        {
            char Kare = '■';
            char Cubuk = '█';
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            for (int i = 1; i < 21; i++)
            {
                Console.SetCursorPosition(0, i);
                Console.Write(Cubuk);
                Console.SetCursorPosition(41, i);
                Console.Write(Cubuk);
            }
            for (int i = 0; i < 42; i++)
            {
                Console.SetCursorPosition(i, 0);
                Console.Write(Kare);
                Console.SetCursorPosition(i, 21);
                Console.Write(Kare);
            }
        }
        static void Loading()
        {
            SoundPlayer Menu = new SoundPlayer();
            Menu.SoundLocation = Environment.CurrentDirectory + "\\SFX/Menu.wav";
            Menu.PlayLooping();
            char Load = '░';
            DrawFrame();
            Console.SetCursorPosition(14, 9);
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Yükleniyor...");
            Console.SetCursorPosition(13,10);
            for (int i = 14; i < 29; i++)
            {
                Console.Write(Load);
                Thread.Sleep(75);
            }
            Nyan();
            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(11, 12);
            Console.Write("Bir Ok tuşana Basın.");
            
            
            //Console.Clear();
            //Console.ReadKey();
        }
        static void GameOver(int Revard)
        {
            Console.Clear();
            DrawFrame();
            Console.SetCursorPosition(15, 9);
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("GAME OVER");
            Console.SetCursorPosition(10, 11);
            Console.Write(Revard + " Puan Kazandınız");
            Thread.Sleep(2000);  
        }
        static void GameWon(int Revard)
        {
            Console.Clear();
            DrawFrame();
            Console.SetCursorPosition(15, 9);
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("YOU  WON!");
            Console.SetCursorPosition(10, 11);
            Console.Write(Revard + " Puan Kazandınız");
            Thread.Sleep(6500);
        }
        static bool Replay()
        {
            Console.Clear();
            DrawFrame();
            char Kare = '■';
            char Cubuk = '█';

            //
            //Sol Buton
            //
            Console.ForegroundColor = ConsoleColor.Cyan;
            for (int i = 5; i < 17; i++)
            {
                
                Console.SetCursorPosition(i, 8);
                Console.Write(Kare);
                Console.SetCursorPosition(i, 13);
                Console.Write(Kare);
            }
            for (int i = 9; i < 13; i++)
            {
                Console.SetCursorPosition(5,i);
                Console.Write(Cubuk);
                Console.SetCursorPosition(16, i);
                Console.Write(Cubuk);
            }

            //
            //Sağ Buton
            //
            Console.ForegroundColor = ConsoleColor.Magenta;
            for (int i = 25; i < 37; i++)
            {
                Console.SetCursorPosition(i, 8);
                Console.Write(Kare);
                Console.SetCursorPosition(i, 13);
                Console.Write(Kare);
            }
            for (int i = 9; i < 13; i++)
            {
                Console.SetCursorPosition(25, i);
                Console.Write(Cubuk);
                Console.SetCursorPosition(36, i);
                Console.Write(Cubuk);
            }
            //
            //Oklar
            //
            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(8, 11);
            Console.Write("<----");

            Console.SetCursorPosition(29, 11);
            Console.Write("---->");
            Console.SetCursorPosition(6, 16);
            Console.Write("Yeniden Oynamak için Sol OKa");
            Console.SetCursorPosition(6, 17);
            Console.Write("Oyundan Çıkmak Sağ OKa Basın");

            while(true)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                ConsoleKeyInfo Secim = Console.ReadKey();
                if (Secim.Key == ConsoleKey.LeftArrow)
                {
                    Console.Clear();
                    return true;
                }
                else if (Secim.Key == ConsoleKey.RightArrow)
                    return false;
            }
        }
        static void Nyan()
        {
            char Cubuk = '█';


            for (int j = 0; j < 4; j++)
            {
                if (j == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                }
                else if (j == 1)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                }
                else if (j == 2)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                else if (j == 3)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                }

                for (int i = 1; i <= 40; i++)
                {
                    Console.SetCursorPosition(i, 1);
                    Console.Write(Cubuk);
                    Console.SetCursorPosition(i, 20);
                    Console.Write(Cubuk);
                }
                for (int i = 2; i <= 19; i++)
                {
                    Console.SetCursorPosition(1, i);
                    Console.Write(Cubuk);
                    Console.SetCursorPosition(40, i);
                    Console.Write(Cubuk);
                }

                if ((j + 1) % 4 == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                }
                else if ((j + 1) % 4 == 1)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                }
                else if ((j + 1) % 4 == 2)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                else if ((j + 1) % 4 == 3)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                }

                for (int i = 2; i <= 39; i++)
                {
                    Console.SetCursorPosition(i, 2);
                    Console.Write(Cubuk);
                    Console.SetCursorPosition(i, 19);
                    Console.Write(Cubuk);
                }
                for (int i = 3; i <= 18; i++)
                {
                    Console.SetCursorPosition(2, i);
                    Console.Write(Cubuk);
                    Console.SetCursorPosition(39, i);
                    Console.Write(Cubuk);
                }

                if ((j + 1) % 4 == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                }
                else if ((j + 2) % 4 == 1)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                }
                else if ((j + 2) % 4 == 2)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                else if ((j + 2) % 4 == 3)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                }

                for (int i = 3; i <= 38; i++)
                {
                    Console.SetCursorPosition(i, 3);
                    Console.Write(Cubuk);
                    Console.SetCursorPosition(i, 18);
                    Console.Write(Cubuk);
                }
                for (int i = 4; i <= 17; i++)
                {
                    Console.SetCursorPosition(3, i);
                    Console.Write(Cubuk);
                    Console.SetCursorPosition(38, i);
                    Console.Write(Cubuk);
                }

                if ((j + 3) % 4 == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                }
                else if ((j + 3) % 4 == 1)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                }
                else if ((j + 3) % 4 == 2)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                else if ((j + 3) % 4 == 3)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                }

                for (int i = 4; i <= 37; i++)
                {
                    Console.SetCursorPosition(i, 4);
                    Console.Write(Cubuk);
                    Console.SetCursorPosition(i, 17);
                    Console.Write(Cubuk);
                }
                for (int i = 5; i <= 16; i++)
                {
                    Console.SetCursorPosition(4, i);
                    Console.Write(Cubuk);
                    Console.SetCursorPosition(37, i);
                    Console.Write(Cubuk);
                }
                Thread.Sleep(100);
            }
        }
    }
}