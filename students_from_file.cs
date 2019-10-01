using System;
using System.IO;
using System.Collections.Generic;

namespace names_01
{
    class Student
    {
        internal string name;
        internal double average;

        public Student(string name, double average)
        {
            this.name = name;
            this.average = average;
        }

        public static void ClassAverage(List<Student> students)
        {
            double total = 0;
            foreach (Student s in students)
            {
                total += s.average;
            }
            Console.WriteLine($"Class average: {Math.Round(total / students.Count, 4)}");
        }
        
        public static void Best(List<Student> students)
        {
            Student best = students[0];
            foreach (Student item in students)
            {
                if (item.average > best.average)
                {
                    best = item;
                }
            }
            Console.WriteLine($"The best student is {best.name}");
        }
        internal static void Worst(List<Student> students) 
        {
            Student worst = students[0];
            foreach (Student item in students)
            {
                if (item.average < worst.average)
                {
                    worst = item;
                }
            }
            Console.WriteLine($"The worst student is {worst.name}");
        }

    }
    class Program
    {
        static void Main(string[] args)
        {

            List<Student> students = new List<Student>();

            StreamReader s = new StreamReader("names.txt");

            for (int i = 0; i < File.ReadAllLines("names.txt").Length / 2; i++)
            {
                students.Add(new Student(s.ReadLine(), Convert.ToDouble(s.ReadLine())));
            }
            
            Student.ClassAverage(students);
            Student.Best(students);
            Student.Worst(students);

            Console.ReadKey();
        }
    }
}
