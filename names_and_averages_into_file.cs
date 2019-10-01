using System;
using System.IO;

namespace names_and_averages_into_file
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
            return this.name + '\n' + this.average;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            string name = "";
            double average = 0;
            StreamWriter s = new StreamWriter("names.txt");
            do
            {
                Console.WriteLine("Enter student's name");
                name = Console.ReadLine();
                if (name != "exit")
                {
                    Console.WriteLine("Average: ");
                    average = Convert.ToDouble(Console.ReadLine());
                    s.WriteLine(new Student(name, average).ToString());
                }

            } while (name != "exit");
            s.Close();
            
            Console.ReadLine();
        }
    }
}
