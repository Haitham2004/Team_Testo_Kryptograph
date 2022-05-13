using System;
using Figgle;
using System.IO;
namespace KryptographBibliothek
{
    public class Menue
    {
        public static void Meneu()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Clear();
            bool Exit = false;
            Console.WriteLine(FiggleFonts.Slant.Render("Team Testo"), "\n");
            Console.WriteLine("Enter um zu benutzen");
            bool flag = false;
            do
            {
                (int, int) cPosBM = Console.GetCursorPosition();
                Console.WriteLine();
                Console.ReadKey();
                Console.Clear();
                Console.WriteLine
                    (FiggleFonts.Slant.Render("Kryptograph"));
                Console.Title = "kryptographie entschlüssen";

                Console.WriteLine("------------------------------------------------------------------------------------\n" +
                                  "                              >>> Willkommen <<<\n" +
                                  "------------------------------------------------------------------------------------\n\n");
                Console.WriteLine("Eingabe: exit\t\t->\tbeendet das Program");
                Console.WriteLine("\n\n Hier Können Sie Verschlüssene Texte entschlüssen");

                Console.WriteLine("Bitte geben Sie den Pfad der Chiffre an.:\n");
                Console.Write("Eingabe:");


                string dateipfad = Console.ReadLine();
                switch (dateipfad)
                {
                    case "exit":
                        Environment.Exit(0);
                        break;
                    default:
                        flag = Pfadpruefer(dateipfad);
                        if (flag)
                        {

                        }

                        break;

                        KonsolenExtrasBibliothek.ClearCurrent.ClearCurrentConsoleLine(cPosBM.Item1, cPosBM.Item2);

                }

            } while (!flag);
        }
           
        public static bool Pfadpruefer(string pfad)
        {
             
            bool result = File.Exists(pfad);
            if (result == true)
            {
                Console.WriteLine("File gefunden");
            }
            else
            {
                Console.WriteLine("File nicht gefunden");
            }
            return result;
        }
        public static string substitutionverfahren()
        {
            return substitutionverfahren;
        }

       




        }
    }

