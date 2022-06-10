using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Text;

namespace KryptographBibliothek{
    public class ZeichenErsetzen
    {

        public static string Ersetze_zeichen(string chiffre, Dictionary<string, double> Tabelle_Chiffre, Dictionary<string, double> tabelle_zeichen)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("------------------------------------------------------------------------------------\n" +
                              "                              >>> Schlüssel <<<\n" +
                              "------------------------------------------------------------------------------------\n\n");
          
            chiffre = chiffre.ToUpper();


            tabelle_zeichen = tabelle_zeichen.OrderByDescending(u=>u.Value).ToDictionary(z=>z.Key,y=>y.Value);

            Tabelle_Chiffre = Tabelle_Chiffre.OrderByDescending(u=>u.Value).ToDictionary(z=>z.Key,y=>y.Value);

           StringBuilder ch=new StringBuilder(chiffre);


            int index = 0;

            for (int i = 0; i < chiffre.Length; i++)
            {
                for (int j = 0; j < Tabelle_Chiffre.Count;j++)
                {
                    if (Tabelle_Chiffre.Keys.ElementAt(j) == chiffre[i].ToString())
                    {
                        index = j;

                        ch[i] = tabelle_zeichen.Keys.ElementAt(index).ToCharArray()[0];

                    }



                }
            }

            return ch.ToString();
        }
    }
}