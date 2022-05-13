using System;
using System.Linq;
using System.Collections.Generic;

namespace KryptographBibliothek
{
    public class ZeichenZaehlen
    {
        //arad / Florian
        public static void Zaehlen()
        {

            Dictionary<string, double> tabelle_wahrscheinlichkeiten =new();

            string chiffre = "Klyulbl";

             chiffre=chiffre.ToUpper();

            for (int i = 0; i < chiffre.Length;i ++)
            {
                int count = chiffre.Count(f => f == chiffre[i]);
                Console.WriteLine($"{chiffre[i]}\t{count}");

               if (tabelle_wahrscheinlichkeiten.ContainsKey(Char.ToString(chiffre[i])));

                {
                   tabelle_wahrscheinlichkeiten.Add  

                }
                



                Console.WriteLine(count);

            }
          
        
            Console.WriteLine(chiffre.Length);


            // kK 7/1144
            // l 152/1144
            // k 7/1144

        }
    }


}
