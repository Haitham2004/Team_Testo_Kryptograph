using System;

namespace KryptographBibliothek
{
    public class ZeichenEntfernen
    {
        public static void Entfernen(string chiffre)
        {
            bool wiederholen = false;
            do
            {
                Console.WriteLine("Das ist Ihre aktuelle chiffre.\n");
                Console.WriteLine(chiffre);
                Console.WriteLine("\nACHTUNG!!\nGeben Sie ein, welche Zeichen von der Dechiffrierung ausgeschlossen werden sollen. Beispiel: Leerzeile, Komma usw.");
                Console.WriteLine("Ihr Zeichen eintippen, anschließend 'Enter' drücken, um Ihre Eingabe zu speichern.");
                string Eingabe = Console.ReadLine();
                Console.Clear();
                chiffre = chiffre.Replace(Eingabe.ToLower(), "");
                chiffre = chiffre.Replace(Eingabe.ToUpper(), "");
                Console.WriteLine(chiffre);

                Console.WriteLine("\n\nWenn Sie weitere Zeichen ausschließen wollen, tippen Sie 'Ja' ein. Wenn sie zum nächsten Verfahren gehen möchten, schreiben Sie 'Nein'.");
                string str_wiederholen = Console.ReadLine();
                switch (str_wiederholen)
                {
                    case "Ja":
                        Console.Clear();
                        wiederholen = true;
                        break;
                    default:
                        wiederholen = false;
                        break;
                }

            } while (wiederholen == true);
        }
    }
}
