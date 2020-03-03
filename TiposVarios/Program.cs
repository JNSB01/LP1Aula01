using System;

namespace TiposVarios
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 3;
            uint r = 4U;
            byte y = 6;
            long h = 0x10;
            char cps = '\u00A9';
            char n = '\x000A';

            Console.WriteLine($"{i}, {r}, {y}, {h}");
            Console.WriteLine($"{cps}, {n}{cps}");
        }
    }
}
