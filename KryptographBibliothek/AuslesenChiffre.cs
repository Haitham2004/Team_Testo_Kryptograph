﻿using System;

namespace KryptographBibliothek
{
    public class AuslesenChiffre
    {
        public static void Auslesenchiffre()
        {

            string pfad = @"C:\Users\tobias.c11\source\repos\Team_Testo_Kryptograph\Chiffre.txt";


            string text = System.IO.File.ReadAllText(pfad);
            System.Console.WriteLine("Ausgabe von Chiffre.txt = \n {0}", text);


          


        }


    }
}
