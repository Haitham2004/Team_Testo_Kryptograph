using System;
using System.Collections.Generic;
using System.Linq;

namespace KryptographBibliothek
{
    public class ZeichenErsetzen
    {
        public static void Ersetzen(string chiffre )

        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("------------------------------------------------------------------------------------\n" +
                             "                              >>> Schlüssel <<<\n" +
                             "------------------------------------------------------------------------------------\n\n");


            ///beise Dictionarys sortieren


            Dictionary<string, double> tabelle_zeichen_deutsch = new Dictionary<string, double>();      //Deutsch

            Dictionary<string, double> tabelle_zeichen_englisch = new Dictionary<string, double>();     //Englsich

            Dictionary<string, double> tabelle_zeichen_chiffre = new Dictionary<string, double>();      //Chiffre

            var sortedDict_chiffre = from entry in tabelle_zeichen_chiffre orderby entry.Value ascending select entry;
            var sortedDict_deutsch = from entry in tabelle_zeichen_deutsch orderby entry.Value ascending select entry;

            //tabelle_zeichen_chiffre = tabelle_zeichen_chiffre.OrderBy(x => x.Value).ToDictionary(x => x.Key, x => x.Value);




            for (int i =0; i< tabelle_zeichen_chiffre.Count; i++)
            {

                chiffre.Replace(sortedDict_chiffre.ElementAt(sortedDict_chiffre.Count() - i - 1).Key, sortedDict_deutsch.ElementAt(sortedDict_deutsch.Count() - i - 1).Key);

                Console.WriteLine(chiffre);
            }                                                                                // Sortiert Value  
        }
    }
}