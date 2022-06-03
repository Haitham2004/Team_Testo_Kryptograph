using System;

using System.Collections.Generic;


namespace KryptographBibliothek
{

    public class AuslesenTabelle
    {

        public static Dictionary<string, double> Auslesen(string pfad)
        {

           


            Console.ForegroundColor = ConsoleColor.Cyan;


            string[] lines = System.IO.File.ReadAllLines(pfad);
            var Dictionary_Tabelle = new Dictionary<string, double>();



            foreach(string rows in lines)
            {

                string[] row_items = rows.Split('\t',' ','%');

                Dictionary_Tabelle.Add((row_items[0]), Convert.ToDouble(row_items[1]));

                //Console.WriteLine(row_items[0] + "und" + row_items[1]);


               
            }
            return Dictionary_Tabelle;
        }
    }
}
