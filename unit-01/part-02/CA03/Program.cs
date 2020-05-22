using System;
using MyDLL;

namespace CA03
{
    class Program
    {
        static void Main()
        {
            string line = "1234567890";

            MyDLL.Console.WriteLine(line, 10);

            System.Console.ReadLine();
        }
    }
}
