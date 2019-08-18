using System;

namespace value_vs_reference
{

    class Program
    {
        static void Main(string[] args)
        {
            int x = 10;

            Change(x);

            Console.WriteLine(x);

            Console.ReadKey();
        }

        static void Change(int x)
        {
            x = 100;
        }
    }
}
