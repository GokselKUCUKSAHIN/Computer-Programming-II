using System;

namespace Proje2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Jelly";
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.Cyan;
            //Console.WindowHeight = 30;
            //Console.WindowWidth = 30;
            Console.Write("Hello Guys");
            //LEL
            Console.Beep(261, 500); //C4
            Console.Beep(261, 500); //C4
            Console.Beep(392, 500); //G4
            Console.Beep(392, 500); //G4
            Console.Beep(440, 500); //A4
            Console.Beep(440, 500); //A4
            Console.Beep(392, 800); //G4
            Console.Beep(349, 500); //F4
            Console.Beep(349, 500); //F4
            Console.Beep(329, 500); //E4
            Console.Beep(329, 500); //E4
            Console.Beep(293, 500); //D4
            Console.Beep(293, 500); //D4
            Console.Beep(261, 500); //C4
         
            Console.ReadKey();
        }
    }
}
