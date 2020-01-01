using System;

namespace Polimorphism_Excercise
{
    internal class OracleConnection : DbConnection
    {
        string name = "oracle connection";
        public OracleConnection(string connectionString, TimeSpan timeOut)
            :base(connectionString, timeOut)
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
