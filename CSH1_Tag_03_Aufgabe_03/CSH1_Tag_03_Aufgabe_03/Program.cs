using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSH1_Tag_03_Aufgabe_03
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "";
            int pass = 0;

            for(int i = 0; i < 5; i++)
            {
                Console.Write($"Zeichen Nr. {i+1} eingeben: ");
                s += Console.ReadKey().KeyChar;
                Console.WriteLine();
            }

            if (Int32.TryParse(s, out pass) && pass == 12345)
                Console.WriteLine("Tür wird geöffnet!");
            else
                Console.WriteLine("You shall not pass!!!");

            Console.ReadKey();
        }
    }
}
