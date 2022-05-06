using System;

namespace KryptographBibliothek
{
    public class Menue
    {
        public static void Meneu()
        {
            string HauptAusw;
            bool Exit = false;
            bool Hmenue;
            do
            {
                (int, int) cPosBM = Console.GetCursorPosition();
                Console.WriteLine();

                Console.Title = "BFTMultiTool";

                Console.WriteLine("------------------------------------------------------------------------------------\n" +
                                  "                              >>> Informatik <<<\n" +
                                  "------------------------------------------------------------------------------------\n\n");
                Console.WriteLine("Eingabe: exit\t\t->\tbeendet das Program");
                Console.WriteLine("\n\n Hier Können Sie Verschlüssene Texte entschlüssen");
                Console.WriteLine("Eingabe: hauptmenü\t->\tzurück zum Hauptmenü");

                Hmenue = false;

                 
                Console.WriteLine("Wählen Sie eine der folgenden Themenbereiche:\n");
                Console.WriteLine("\t1 - Auslesen Chiffre\n");
                Console.WriteLine("\t2 - Auslesen Tabelle\n ");
                Console.WriteLine("\t3 - Zeichen Zaehlen\n");
                Console.WriteLine("\t4 - Zeichen Entfernen\n");
                Console.WriteLine("\t5 - Zeichen Ersetzen \n");
                Console.WriteLine("\t6 - Ergebnis Ausgabe\n");
                Console.Write("Eingabe:");
                HauptAusw = Console.ReadLine();

                switch (HauptAusw)
                {

                    case "1":
                        Console.Clear();
                        AuslesenChiffre();

                        break;

                    case "2":
                        Console.Clear();
                        Feauture10.Feature10Funcion1();

                        break;

                    case "3":
                        Console.Clear();
                        Feature11.Feature11Funcion1();

                        break;

                    case "4":
                        Console.Clear();
                        Feature20.Feature20Funcion1();

                        break;

                    case "5":
                        Console.Clear();
                        Feature21.Feature21Funcion1();

                        break;

                    case "hauptmenü":
                        Console.Clear();
                        Hmenue = true;
                        break;
                    case "exit":
                        Exit = true;
                        break;


                } while (!Exit);
        }
    }
}
