using System;
using Figgle;
namespace KryptographBibliothek
{
    public class Menue
    {
        public static void Meneu()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Clear();
            bool Exit = false;
            Console.WriteLine(FiggleFonts.Slant.Render("Cracked MH"), "\n");
            Console.WriteLine("Drücken sie eine beliebige Taste um fortzufahren");
            bool flag = false;
            do
            {
                (int, int) cPosBM = Console.GetCursorPosition();
                Console.WriteLine();
                Console.ReadKey();
                Console.Clear();
                Console.WriteLine
                    (FiggleFonts.Slant.Render("Kryptograph"));
                Console.Title = "BFTMultiTool";

                Console.WriteLine("------------------------------------------------------------------------------------\n" +
                                  "                              >>> Informatik <<<\n" +
                                  "------------------------------------------------------------------------------------\n\n");
                Console.WriteLine("Eingabe: exit\t\t->\tbeendet das Program");
                Console.WriteLine("\n\n Hier Können Sie Verschlüssene Texte entschlüssen");
        
                Console.WriteLine("Bitte geben Sie den Pfad der Chiffre an.:\n");
                Console.Write("Eingabe:");
                

                string dateipfad = Console.ReadLine();
                switch (dateipfad)
                {
                    case "exit":
                        Exit = true;
                        break;
                    default:
                        flag = Pfadprüfer(dateipfad);
                        if (flag)
                        {

                        }

                        break;

                        KonsolenExtrasBibliothek.ClearCurrent.ClearCurrentConsoleLine(cPosBM.Item1, cPosBM.Item2);

                }

            } while (!flag);
            if (Exit)
                Environment.Exit(0);
            }
        public static bool Pfadprüfer(string pfad)
        {
             pfad = "C:\\Files\\file.txt";
            bool result = File.Exists(pfad);
            if (result == true)
            {
                Console.WriteLine("File Found");
            }
            else
            {
                Console.WriteLine("File Not Found");
            }
        }
           





        }
    }
}
