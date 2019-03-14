using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Hafta_5
namespace Project_21
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ne sorusu?
            //Analiz-Tasarım
            //Her varlık Birer Kutu(Class)
            Draw();
            Console.ReadKey();
        }
        static void Draw()
        {
            Yem y = new Yem();
            Yilan Snake = new Yilan();
            y.Uret();
            ConsoleKeyInfo Key;
            while (true)
            {
                Console.SetCursorPosition(1, 22);
                Console.WriteLine("Score = " + Snake.Score);
                Key = Console.ReadKey();
                Snake.hareketEt(Key);
                Snake.Ciz();
                y.Ciz();
                if((y.x == Snake.X) && (y.y == Snake.Y))
                {
                    y.Uret();
                    Snake.Score++;
                    Snake.Ciz();
                }
                //System.Threading.Thread.Sleep(50);
            }
            
        }
    }


    class Yem
    {
        Random r = new Random();
        public int x;
        public int y;
        public void Uret()
        {
            x = r.Next(1, 41);
            y = r.Next(1, 21);
        }
        
        public void Ciz()
        {
            
            Console.SetCursorPosition(x, y);
            Console.Write("#");
            
        } 
          
    }    
    class Yilan
    {
        public int X = 4;
        public int Y = 4;
        public int Score = 0;
        public char head = '#';
        public void Ciz()
        {
            Console.Clear();
            Console.SetCursorPosition(X, Y);
            Console.Write(head);
        }
        public void hareketEt(ConsoleKeyInfo tus)
        {
            if(tus.Key == ConsoleKey.RightArrow)
            {
                head = '>';
                X++;

            }
            else if(tus.Key == ConsoleKey.LeftArrow)
            {
                head = '<';
                X--;
            }
            else if(tus.Key == ConsoleKey.UpArrow)
            {
                head = '^';
                Y--;
            }
            else if(tus.Key == ConsoleKey.DownArrow)
            {
                head = 'V';
                Y++;
            }
            if (X > 40)
            {
                X = 1;
            }
            else if (X < 1)
            {
                X = 40;
            }
            else if (Y > 20)
            {
                Y = 1;
            }
            else if (Y < 1)
            {
                Y = 20;
            }
        }
    }
}
