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
                Console.Write("Bitte Ziffer eingeben: ");
                
                while (!(check = Int32.TryParse(Console.ReadLine(), out eingabe)))
                {
                    if(!check)
                    {
                        Console.WriteLine("Eingabe keine Zahl!");
                        Console.Write("Neue Eingabe: ");
                    }
                }

                if (eingabe % 2 == 0)
                    gerade += eingabe;
                else
                    ungerade += eingabe * 3;

                artNummer = (artNummer + eingabe) * 10;

                if(i == 4)
                {
                    int prüfziffer = (gerade + ungerade) % 10;
                    artNummer += prüfziffer;
                }
            }

            Console.WriteLine($"Die Artnummer lautet: {artNummer}");
            Console.ReadKey();
        }
    }
}
