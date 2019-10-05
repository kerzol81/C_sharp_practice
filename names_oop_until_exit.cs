using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace names_and_averages_1
{
    class Student
    {
        string name;
        double average;

        public Student(string name, double average)
        {
            this.name = name;
            this.average = average;
        }
        public override string ToString()
        {
            return this.name + Environment.NewLine + this.average;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter names, and averages!");
            string name = null;
            double average;
            StreamWriter s = new StreamWriter("names.txt", true, Encoding.UTF8);
            do
            {
                Console.Write("name: ");
                name = Console.ReadLine();
                if (name != "exit")
                {
                    Console.Write("average: ");
                    average = Convert.ToDouble(Console.ReadLine());
                    s.WriteLine(new Student(name, average).ToString());
                    s.Flush();
                }

            } while (name != "exit");
            s.Close();
        }
    }
}
