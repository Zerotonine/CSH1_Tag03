using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSH1_Tag_03_Aufgabe_00
{
    class Program
    {
        static int ZahlParsen()
        {
            string s = "";
            int i = 0;
            bool check = false;

            do
            {
                Console.Write("Bitte Zahl eingeben: ");
                s = Console.ReadLine();
                if(!(check = Int32.TryParse(s, out i)))
                {
                    Console.Clear();
                    Console.WriteLine("Keine Zahl eingegeben!");
                }
            } while (!check);

            return i;
        }
        static void Main(string[] args)
        {
            Console.WriteLine($"Die Zahl lautet: {ZahlParsen()}");
            Console.ReadKey();
        }
    }
}
