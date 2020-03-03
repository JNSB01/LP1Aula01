using System;

namespace VariasStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "Hello world";
            string v2 = "Nova linha \n Unicode e \u1234";
            string v3 = @"Nova linha \n Unicode e \u1234";
            string v4 = "\"String entre \t aspas\"";
            string v5 = @"""String entre aspas""";
            Console.WriteLine(s);
            Console.WriteLine(v2);
            Console.WriteLine(v3);
            Console.WriteLine(v4);
            Console.WriteLine(v5);
        }
    }
}
