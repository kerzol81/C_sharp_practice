using System;

namespace Polimorphism_Excercise
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = new SQLConnection("sql_test", new TimeSpan(1, 1, 1));

            s.Open();
            s.Close();

            var d = new OracleConnection("oracle_test", new TimeSpan(1, 2, 1));

            d.Open();
            d.Close();       

            Console.ReadKey();
            
        }
    }
}
