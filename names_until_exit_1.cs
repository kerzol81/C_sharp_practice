using System;
using System.Text;
using System.IO;

namespace names_until_exit
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            StreamWriter s = new StreamWriter("names.txt", true, Encoding.UTF8);
            Console.Write("Enter names: ");
            do
            {
                Console.Write("> ");
                name = Console.ReadLine();
                if (name != "exit")
                {
                    s.WriteLine(name, Environment.NewLine);
                }
            } while (name != "exit");
            s.Close();
            Console.ReadKey();
        }
    }
}
