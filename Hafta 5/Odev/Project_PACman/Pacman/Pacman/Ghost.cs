using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pacman
{
    class Ghost
    {
        public int X;
        public int Y;
        public int tX;
        public int tY;
        public ConsoleColor BColor;
        public ConsoleColor FColor;
        char Head = '§';

        public void Ciz()
        {
            Console.BackgroundColor = BColor;
            Console.ForegroundColor = FColor;
            Console.SetCursorPosition(X, Y);
            Console.Write(Head);
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Yellow;
        }
        public void Move(int X,int Y)
        {
            Console.SetCursorPosition(X, Y);
            Console.Write(" ");
        }
    }
}