using System;

namespace Polimorphism_Excercise
{
    internal class SQLConnection : DbConnection
    {
        string name = "sql connection";
        public SQLConnection(string connetcionString, TimeSpan timeOut)
            :base(connetcionString, timeOut)
        {
            
        }
        public override void Open()
        {
            Console.WriteLine($"{name} opening");
        }

        public override void Close()
        {
            Console.WriteLine($"{name} closing");
        }
    }
}
