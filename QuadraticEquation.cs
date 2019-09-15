using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            
            d = (B * B) - (4 * (a * c));
            if (d > 0)
            {
                Console.WriteLine("D is positive:");
                double x1 = ((B * -1) + Math.Sqrt(d)) / (2 * A);
                double x2 = ((B * -1) - Math.Sqrt(d)) / (2 * A);
                Console.WriteLine(x1);
                Console.WriteLine(x2);
            }
            else if (d == 0)
            {
                Console.WriteLine("D is zero:");
                double x1 = ((B * -1) + Math.Sqrt(d)) / (2 * A);
                Console.WriteLine(x1);
            }
            else if (d < 0)
            {
                Console.WriteLine("D is negative, so no real roots");
            }
            Console.WriteLine("---------------------------------");
        }
    }
}
