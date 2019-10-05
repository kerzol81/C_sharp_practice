using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace names_until_exit2
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            List<string> names = new List<string>();

            Console.WriteLine("Enter names! \t\t enter \"exit\" to stop");
            do
            {
                Console.Write("> ");
                name = Console.ReadLine();
                if (name != "exit")
                {
                    names.Add(name);
                }

            } while (name != "exit");
            File.AppendAllLines("names.txt", names, Encoding.UTF8);       
        }
    }
}
