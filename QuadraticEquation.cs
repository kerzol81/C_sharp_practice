using System;

namespace QuadraticEquation_1
{
    class Equation
    {
        int a;
        int b;
        int c;
        double d;

        public int A { get => a;
            set {
                if (value > 0)
                {
                    a = value;
                }
                else
                {
                    a = 1;
                }
            }
        }
        public int B { get => b; set => b = value; }
        public int C { get => c; set => c = value; }

        public Equation(int a, int b, int c)
        {
            A = a;
            B = b;
            C = c;
            
        }
        public void Solve() {
            double x1;
            double x2;
            d = (B * B) - (4 * (a * c));
            if (d > 0)
            {
                Console.WriteLine("Discriminant is positive, there are 2 roots: ");
                x1 = ((B * -1) + Math.Sqrt(d)) / (2 * A);
                x2 = ((B * -1) - Math.Sqrt(d)) / (2 * A);
                Console.WriteLine(x1);
                Console.WriteLine(x2);
            }
            else if (d == 0)
            {
                Console.WriteLine("Discriminant is zero, there is only 1 root: ");
                x1 = ((B * -1) + Math.Sqrt(d)) / (2 * A);
                Console.WriteLine(x1);
            }
            else if (d < 0)
            {
                Console.WriteLine("Discriminant is negative, so no real roots");
            }
            Console.WriteLine("---------------------------------");
        }
    }
}
