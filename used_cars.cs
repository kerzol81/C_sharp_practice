using System;
using System.Collections.Generic;
using System.Linq;

namespace Cars_1
{
    class Car
    {
        string plate;
        byte state;

        public Car(string plate, byte state)
        {
            Plate = plate;
            State = state;
        }

        public string Plate
        {
            get => plate;
            set {
                if (!String.IsNullOrEmpty(value))
                {
                    plate = value;
                }
                else
                {
                    plate = "-------";
                }
            }
        }
        public byte State
        {
            get => state;
            set {
                if (0 < value && value < 101)
                {
                    state = value;
                }
                else
                {
                    state = 1;
                }
            }
        }

        public static void PrintWorst(List<Car> cars)
        {
            Car worst = cars[0];
            for (int i = 0; i < cars.Count(); i++)
            {
                if (cars[i].state < worst.state)
                {
                    worst = cars[i];
                }
            }
            Console.WriteLine($"{worst.plate} is in the worst condition");
        }


    }
    class Program
    {
        static void Main(string[] args)
        {

            List<Car> cars = new List<Car>();

            Console.WriteLine("Enter cars data: \t\tpress enter to escape filling");
            string plate = " ";
            byte state;
            do
            {
                Console.Write("Plate: \t\tAAA123");
                plate = Console.ReadLine();
                if (plate != "")
                {
                    Console.Write("State: \t\t0..100");
                    state = Byte.Parse(Console.ReadLine());
                    Car new_car = new Car(plate, state);
                    cars.Add(new_car);
                }
            } while (plate != "" );

            Car.PrintWorst(cars);
            Console.ReadLine();
            
        }
    }
}
