using System;
using System.Collections.Generic;

namespace övning_5._9
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> namnLista = new List<string>();

            Console.WriteLine("Välkommen till namninsamlaren!");
            Console.WriteLine("Skriv in så många namn som du vill (max 1000). Skriv 'klar' när du är klar.");

            while (namnLista.Count < 1000)
            {
                Console.Write("Skriv in ett namn: ");
                string namn = Console.ReadLine();

                if (namn.ToLower() == "klar")
                {
                    break;
                }

                namnLista.Add(namn);
            }

            Console.Write("Skriv in ett namn för att räkna dess förekomst i listan: ");
            string sökNamn = Console.ReadLine();

            int förekomster = RäknaFörekomster(namnLista, sökNamn);
            Console.WriteLine($"Namnet '{sökNamn}' förekommer {förekomster} gånger i listan.");
        }

        static int RäknaFörekomster(List<string> lista, string namn)
        {
            int antal = 0;
            foreach (string n in lista)
            {
                if (n.Equals(namn, StringComparison.OrdinalIgnoreCase))
                {
                    antal++;
                }
            }
            return antal;
        }
    }
}
