using System;

namespace value_vs_reference
{
    class Cat
    {
        public int age;
        public int lifes;
        public Cat()
        {
            this.age = 1;
            this.lifes = 1;
        }
        internal void Display()
        {
            Console.WriteLine("Cat's data:");
            Console.WriteLine($"age: {this.age}");
            Console.WriteLine($"lives: {this.lifes}\n");
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Cat c = new Cat();
            Cat d = c;

            ChangeLife(c);

            c.Display();
            d.Display();

            Console.ReadKey();
        }

        static void ChangeLife(Cat c)
        {
            c.lifes = 7;
        }
    }
}
