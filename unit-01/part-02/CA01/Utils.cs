using S = System;

namespace CA01
{
    class Console
    {
        public static void WriteLine(string str)
        {
            S.Console.WriteLine("==============\n" + str);
        }
    }
}

namespace Utils
{
    class Console
    {
        public static void WriteLine(string str)
        {
            System.Console.WriteLine("_________\n" + str);
        }
    }
}
