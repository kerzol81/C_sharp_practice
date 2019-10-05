using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace names_until_exit_oop_and_generic_list
{
    class Person
    {
        internal string name;

        public Person(string name)
        {
            this.name = name;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> students = new List<Person>();

            Console.WriteLine("Enter names!");
            string name = null;
            do
            {
                Console.Write("> ");
                name = Console.ReadLine();
                if (name != "exit")
                {
                    students.Add(new Person(name));
                }

            } while (name != "exit");

            foreach (var item in students)
            {
                File.WriteAllText("names.txt", item.name);
            }
        }
    }
}
