using System;

namespace value_vs_reference
{
    class Cup
    {
        public bool filled = false;

    }

    class Program
    {
        static void Main(string[] args)
        {
            Cup c = new Cup();

            Fill(c);

            Console.WriteLine(c.filled);

            Console.ReadKey();
        }

        static void Fill(Cup c) {
            c.filled = true;
        }
       
    }
}
