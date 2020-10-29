using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSH1_Tag_03_Aufgabe_01
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] myStrings = { "5", "10", "734", null, "Palimpalim"};
            bool check = false;
            int i = 0;

            Random rnd = new Random();

            while (true)
            {
                if(!(check = Int32.TryParse(myStrings[rnd.Next(myStrings.Length)], out i)))
                {
                    Console.WriteLine("Keine Zahl :(");
                } else
                {
                    Console.WriteLine($"Jup ist eine Zahl: {i}");
                }
                
                if(Console.ReadKey().Key == ConsoleKey.Escape)
                {
                    break;
                }
            }
        }
    }
}
