using System;
using System.Linq;
using System.Collections.Generic;

namespace KryptographBibliothek
{
    public class ZeichenZaehlen
    {
        //arad / Florian
        public static Dictionary<string, double> Zaehlen(string chiffre)
        {

            Dictionary<string, double> tabelle_wahrscheinlichkeiten =new();



             chiffre=chiffre.ToUpper();

            for (int i = 0; i < chiffre.Length;i ++)
            {
                double count = chiffre.Count(f => f == chiffre[i]);
               

               if (!tabelle_wahrscheinlichkeiten.ContainsKey(Char.ToString(chiffre[i])))

                {
                    tabelle_wahrscheinlichkeiten.Add(chiffre[i].ToString(), count / chiffre.Length);  

                }
                

            }

            //foreach(KeyValuePair<string,double> item in tabelle_wahrscheinlichkeiten)
            //{
               
            //   Console.WriteLine("buchstaben: {0}, warscheinlichkeit: {1}", item.Key, item.Value);

            //}



            return tabelle_wahrscheinlichkeiten;

            

        }
    }


}
