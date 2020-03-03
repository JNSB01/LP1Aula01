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
            decimal d = 1.1245m;
            float f = 2.43f;
            double dec = 5.0e-10;
            bool t = true;
            bool fal = 3<1;

            Console.WriteLine($"{i}, {r}, {y}, {h}");
            Console.WriteLine($"{cps}, {n}{cps}");
            Console.WriteLine($"{d}, {f}, {dec}");
            Console.WriteLine($"{t}, {fal}");
        }
    }
}
