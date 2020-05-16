using System;

namespace CA04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.Clear();
            Console.ForegroundColor = (ConsoleColor)14;

            Console.WriteLine("#");
            
            while(true) 
            {
                ConsoleKeyInfo ckInfo = Console.ReadKey(true);
                Console.WriteLine((int)ckInfo.KeyChar);
                if (ckInfo.Key == ConsoleKey.Escape)
                    break;
            }
            //Console.ReadLine();
        }
    }
}
