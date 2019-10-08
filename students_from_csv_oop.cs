using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace StudentsFromCSV_2
{
    class Student
    {
        internal string Name { get; private set; }
        internal double Average { get; private set; }
        internal string ID { get; private set; }

        public Student(string name, double average, string iD)
        {
            Name = name;
            Average = average;
            ID = iD;
        }
    }
    class ClassRoom
    {
        internal double class_average;
        internal List<Student> students = new List<Student>();
        internal void AddStudent(Student new_student)
        {
            students.Add(new_student);
        }
        internal void GetClassAverage()
        {
            double total = 0;
            foreach (var item in students)
            {
                total += item.Average;
            }
            class_average = total / students.Count;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader s = new StreamReader("students.txt", Encoding.UTF8);
            ClassRoom c = new ClassRoom();
            for (int i = 0; i < File.ReadAllLines("students.txt").Length; i++)
            {
                string[] chunks = s.ReadLine().Split(';');
                string name = chunks[0];
                double average = Convert.ToDouble(chunks[1]);
                string id = chunks[1];

                c.AddStudent(new Student(name, average, id));
                Console.WriteLine(c.class_average);
            }
        }
    }
}

