using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSH1_Tag_03_Aufgabe_04
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int zZahl = rnd.Next(1, 100);
            int versuche = 1;
            int eingabe = 0;

            while (true)
            {
                Console.Write($"Versuch Nr.{versuche} - Bitte Zahl eingeben: ");
                if (!Int32.TryParse(Console.ReadLine(), out eingabe))
                    continue;

                if (eingabe > zZahl)
                    Console.WriteLine("Schätzung war zu hoch!");
                else if (eingabe < zZahl)
                    Console.WriteLine("Schätzung war zu niedrig!");
                else
                {
                    Console.WriteLine($"Glückwunsch du hast die Zahl erraten! \nBenötigte Versuche: {versuche}");
                    break;
                }

                versuche++;
            }
            Console.ReadKey();
        }
    }
}
