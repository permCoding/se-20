using System;

namespace MyDLL
{
    public class Console
    {
        public static void WriteLine(string line, int count)
        {
            Random rnd = new Random();
            char smb = line[rnd.Next(line.Length)];
            
            System.Console.WriteLine(
                new String(smb, count)
            );
        }
    }
}
