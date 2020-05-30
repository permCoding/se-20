using System;

class Program
{
    static void Main(string[] args)
    {
        //int a = new Int32();
        System.Int32 a = -2; // int 00000010 - 11111110
        Object ob = new Object();
        ob = (byte)a; // 0 .. 255 - 00000000 - 11111111
        Console.WriteLine(ob.ToString());
        // теоретический вопрос про дополнит код числа и
        // про явное приведение к другому типу данных
        byte c = 254;
        Console.WriteLine(ob.Equals(c));
        ;
    }
}
