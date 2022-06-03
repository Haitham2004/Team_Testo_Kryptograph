using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace KryptographBibliothek
{
    public class AuslesenChiffre
    {
        public static string Auslesenchiffre(string d)
        {


            Console.WriteLine(d);

            StreamReader pfad = new StreamReader(d);
            string text = System.IO.File.ReadAllText(d);
           
            pfad.Close();
            return text;

            

        }


    }
}
