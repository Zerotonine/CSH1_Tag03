using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSH1_Tag_03_Aufgabe__02
{
    class Program
    {
        static void Main(string[] args)
        {
            bool check = false;
            double d = 0.0;

            while(true)
            {
                Console.Write("Bitte Double eingeben: ");
                check = Double.TryParse(Console.ReadLine(), out d);
                if (!check)
                    Console.WriteLine($"Parsen ist nicht geglückt! - Wert: {d}");
                else
                    Console.WriteLine($"Parsen ist geglückt :) - Wert: {d}");

                if (Console.ReadKey().Key == ConsoleKey.Escape)
                    break;
            }
        }
    }
}
