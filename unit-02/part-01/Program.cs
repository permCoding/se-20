using System;

class Program
{
    static void Main()
    {
        Int32 a = new Int32();
        a = 12;
        Object b = new Object();
        b = null;
        b = a;
        int c = (int)b;

        Console.WriteLine(a.GetType());
        Console.WriteLine(b.GetType());
        Console.WriteLine(c.GetType());

        Console.WriteLine($"c = {c}");

        Console.WriteLine(a.CompareTo(a));
        Console.WriteLine(12.Equals(a));

        Console.ReadLine();
    }
}
