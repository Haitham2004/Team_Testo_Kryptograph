using System;
using System.Collections.Generic;

namespace StartKryptograph
{
    class main
    {
        static void Main(string[] args)
        {

            Dictionary<string, double> tabelle_zeichen = new Dictionary<string, double>();
            string chiffre = "Klyulbl";

            tabelle_zeichen=KryptographBibliothek.ZeichenZaehlen.Zaehlen(chiffre);

            Console.ReadKey();
        }
    }
}
