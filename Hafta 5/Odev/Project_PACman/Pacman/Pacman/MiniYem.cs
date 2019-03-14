using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pacman
{
    class MiniYem
    {
        char dot = '°';
        public char type = '_';
        public int X;
        public int Y;
        public bool Exist = true;
        public void YemCiz()
        {
            if (Exist == true)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.SetCursorPosition(X, Y);
                Console.Write(dot);
                Console.ForegroundColor = ConsoleColor.Yellow;
            }
        }
    }
}