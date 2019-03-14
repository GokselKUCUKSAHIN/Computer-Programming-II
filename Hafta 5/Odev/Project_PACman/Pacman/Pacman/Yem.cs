using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pacman
{
    class Yem
    {
        //char Dot = '¤';
        char sqr = '■';
        public char type = '_';
        public int X;
        public int Y;
        public bool Exist = true;
        public void YemCiz()
        {
            if(Exist == true)
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.SetCursorPosition(X, Y);
                Console.Write(sqr);
                Console.ForegroundColor = ConsoleColor.Yellow;
            }
        }
    }
}