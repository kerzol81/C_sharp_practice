using System;

namespace Polimorphism_Excercise
{
    internal class SQLConnection : Connection
    {
        public override void Open()
        {
            Console.WriteLine("sql connection opening");
        }

        public override void Close()
        {
            Console.WriteLine("sql connection closing");
        }
    }
}
