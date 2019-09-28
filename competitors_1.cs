using System;


namespace competitors_1
{
    class Competitor
    {
        public string name;
        int point;
        string id;

        public Competitor(string name, int point, string id)
        {
            this.name = name;
            this.point = point;
            this.id = id;
        }
        internal static void Arrange(Competitor[] competitors)
        {
            for (int i = competitors.Length; i > 0; i--)
            {
                for (int j = 0; j < i - 1; j++)
                {
                    if (competitors[j].point < competitors[j + 1].point)
                    {
                        Competitor temp = competitors[j];
                        competitors[j] = competitors[j + 1];
                        competitors[j + 1] = temp;
                    }
                }

            }

        }
        internal static void DisplayCompetitors(Competitor[] competitors)
        {
            foreach (Competitor item in competitors)
            {
                Console.WriteLine($"{item.name}\t{item.point}\t{item.id}");
            }
        }
        internal static void DisplayMenu()
        {
            Console.WriteLine("L - competitor listing");
            Console.WriteLine("D - first 3");
            Console.WriteLine("A - average");
            Console.WriteLine("K - exit");

        }
        internal static void First3(Competitor[] competitors) {
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"{competitors[i].name}\t{competitors[i].point}\t{competitors[i].id}");
            }
        }
        internal static void Average(Competitor[] competitors) {
           
            int total = 0;
            foreach (Competitor item in competitors)
            {
                total += item.point;

            }
            Console.WriteLine($"Average: {(total * 1.0 )/ competitors.Length}");
        }
    }

    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("How many comptetitor will be?");
            Competitor[] competitors = new Competitor[Convert.ToInt32(Console.ReadLine())];
            
            for (int i = 0; i < competitors.Length; i++)
            {
                Console.WriteLine($"Enter {i + 1} name:");
                string name = Console.ReadLine();
                Console.WriteLine($"Enter {name}'s point:");
                int point = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"Enter {name}'s ID:");
                string id = Console.ReadLine();

                competitors[i] = new Competitor(name, point, id);
            }
            Competitor.Arrange(competitors);
            
            char user_choice;
            do
            {
                Competitor.DisplayMenu();
                user_choice = Console.ReadKey().KeyChar;
                switch (user_choice)
                {
                    case 'l':
                        Competitor.DisplayCompetitors(competitors);
                        break;
                    case 'd':
                        Competitor.First3(competitors);
                        break;
                    case 'a':
                        Competitor.Average(competitors);
                        break;
                    default:
                        Console.WriteLine("only l, d, a, and k chars are allowed");
                        break;
                }

            } while (user_choice != 'K' || user_choice != 'k');


            Console.ReadKey();
        }
    }
}
