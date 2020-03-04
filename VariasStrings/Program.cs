using System;

namespace VariasStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 4;
            string s = "Hello world";
            string v2 = "Nova linha \n Unicode e \u1234";
            string v3 = @"Nova linha \n Unicode e \u1234";
            string v4 = "\"String entre \t aspas\"";
            string v5 = @"""String entre aspas""";
            string x1 = "Quase tudo" + " feito";
            string x2 = "Correção mais do que " + a;
            string x3 = x1 + x2;
            string x4 = $"Eu tenho {a} exercícios feitos";
            string x5 = $"Eu tenho {a} exercícios feitos. {x2}";
            string x6 = String.Format("{0}. {1}",x5,x1);
            Console.WriteLine(@"Valor de a é {0}", a);

            Console.WriteLine(s);
            Console.WriteLine(v2);
            Console.WriteLine(v3);
            Console.WriteLine(v4);
            Console.WriteLine(v5);
            Console.WriteLine(x1);
            Console.WriteLine(x2);
            Console.WriteLine(x3);
            Console.WriteLine(x4);
            Console.WriteLine(x5);
            Console.WriteLine(x6);

        }
    }
}
