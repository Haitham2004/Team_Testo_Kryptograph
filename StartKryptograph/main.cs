using System;

namespace StartKryptograph
{
    class main
    {
        static void Main(string[] args)
        {
            string pfad = @"C:\Users\tobias.c11\source\repos\Team_Testo_Kryptograph\Chiffre.txt";

            pfad = KryptographBibliothek.AuslesenChiffre.Auslesenchiffre(pfad);
            Console.WriteLine("Text von Chiffre in Main übertragen: \n {0}",pfad);
            
        }
    }
}
