using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Morse_v1
{
    class Morse
    {
        internal Dictionary<string, string> MorseTable = new Dictionary<string, string>();

        public Morse()
        {
            MorseTable.Add("alpha", ".-");
            MorseTable.Add("bravo", " - ...");
            MorseTable.Add("charlie", "-.-.");
            MorseTable.Add("delta", "-..");
            MorseTable.Add("echo", ".");
            MorseTable.Add("foxtrot", "..-.");
            MorseTable.Add("golf", "--.");
            MorseTable.Add("hotel", "....");
            MorseTable.Add("india", "..");
            MorseTable.Add("juliett", ".---");
            MorseTable.Add("kilo", "-.-");
            MorseTable.Add("lima", ".-..");
            MorseTable.Add("mike", "--");
            MorseTable.Add("november", "-.");
            MorseTable.Add("oscar", "---");
            MorseTable.Add("papa", ".--.");
            MorseTable.Add("quebec", "--.-");
            MorseTable.Add("romeo", ".-.");
            MorseTable.Add("sierra", "...");
            MorseTable.Add("tango", "-");
            MorseTable.Add("uniform", "..-");
            MorseTable.Add("victor", "...-");
            MorseTable.Add("whiskey", ".--");
            MorseTable.Add("x - ray", "-..-");
            MorseTable.Add("yankee", "-.--");
            MorseTable.Add("zulu", "--..");

            MorseTable.Add("0", "----");
            MorseTable.Add("1", ".----");
            MorseTable.Add("2", "..---");
            MorseTable.Add("3", "..--");
            MorseTable.Add("4", "....-");
            MorseTable.Add("5", ".....");
            MorseTable.Add("6", "-....");
            MorseTable.Add("7", "--...");
            MorseTable.Add("8", "---..");
            MorseTable.Add("9", "----.");
            MorseTable.Add("@", ".--.-.");
        }

        internal void Beep(string code)
        {
            for (int i = 0; i < code.Length; i++)
            {
                if (code[i] == '.')
                {
                    Console.Beep(440, 150);
                }
                if (code[i] == '-')
                    Console.Beep(440, 400);
            }
        }
        internal void DisplayTitle()
        {
            string title = "M O R S E      press * to quit";

            Console.ForegroundColor = ConsoleColor.Red;
            foreach (var character in title)
            {
                Console.Write('-');
            }
            Console.WriteLine("\r");
            Console.WriteLine(title);
            foreach (var character in title)
            {
                Console.Write('-');
            }
            Console.WriteLine("\r");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Morse m = new Morse();
            m.DisplayTitle();
            
            Console.ForegroundColor = ConsoleColor.Yellow;

            char c = ' ';
            while (c != '*')
            {
                c = Console.ReadKey().KeyChar;

                foreach (KeyValuePair<string, string> item in m.MorseTable)
                {
                    if (c == item.Key[0])
                    {
                        m.Beep(item.Value);
                    }
                }
            }
        }
    }
}
