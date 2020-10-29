using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSH1_Tag_03_Aufgabe_05
{
    class Program
    {
        static void Main(string[] args)
        {
            int gerade = 0;
            int ungerade = 0;
            int eingabe = 0;
            int artNummer = 0;
            bool check;

            for(int i = 0; i < 5; i++)
            {
                check = false;
                Console.WriteLine("Bitte Ziffer eingeben");
                Console.Write(">>> ");
                
                while (!(check = Int32.TryParse(Console.ReadKey().KeyChar.ToString(), out eingabe)))
                {
                    Console.WriteLine("\nEingabe keine Zahl!");
                    Console.Write("Neue Eingabe: ");
                }
                Console.WriteLine();

                if (eingabe % 2 == 0)
                    gerade += eingabe;
                else
                    ungerade += eingabe * 3;

                artNummer = (artNummer + eingabe) * 10;
            }

            int prüfziffer = (gerade + ungerade) % 10;
            artNummer += prüfziffer;

            Console.WriteLine($"\nDie Artnummer lautet: {artNummer}");
            Console.ReadKey();
        }
    }
}
